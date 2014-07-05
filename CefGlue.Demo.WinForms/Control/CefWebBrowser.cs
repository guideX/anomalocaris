namespace Xilium.CefGlue.Demo {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;
    using Xilium.CefGlue.Demo.Browser;
    using WebBrowser = Xilium.CefGlue.Demo.Browser.WebBrowser;
    public sealed class CefWebBrowser : Control {
        private bool _handleCreated;
        private WebBrowser _core;
        private IntPtr _browserWindowHandle;
        public CefWebBrowser() {
            SetStyle(
                ControlStyles.ContainerControl
                | ControlStyles.ResizeRedraw
                | ControlStyles.FixedWidth
                | ControlStyles.FixedHeight
                | ControlStyles.StandardClick
                | ControlStyles.UserMouse
                | ControlStyles.SupportsTransparentBackColor
                | ControlStyles.StandardDoubleClick
                | ControlStyles.OptimizedDoubleBuffer
                | ControlStyles.CacheText
                | ControlStyles.EnableNotifyMessage
                | ControlStyles.DoubleBuffer
                | ControlStyles.OptimizedDoubleBuffer
                | ControlStyles.UseTextForAccessibility
                | ControlStyles.Opaque,
                false);
            SetStyle(
                ControlStyles.UserPaint
                | ControlStyles.AllPaintingInWmPaint
                | ControlStyles.Selectable,
                true);
            var settings = new CefBrowserSettings();
            _core = new WebBrowser(this, settings, "about:blank");
            _core.Created += new EventHandler(BrowserCreated);
        }
        public string StartUrl {
            get { return _core.StartUrl; }
            set { _core.StartUrl = value; }
        }
        public WebBrowser WebBrowser { get { return _core; } }
        protected override void OnHandleCreated(EventArgs e) {
            base.OnHandleCreated(e);
            if (DesignMode) {
            } else {
                var windowInfo = CefWindowInfo.Create();
                windowInfo.SetAsChild(Handle, new CefRectangle { X = 0, Y = 0, Width = Width, Height = Height });

                _core.Create(windowInfo);
            }
            _handleCreated = true;
        }
        protected override void Dispose(bool disposing) {
            if (_core != null) {
                var browser = _core.CefBrowser;
                var host = browser.GetHost();
                host.CloseBrowser();
                host.ParentWindowWillClose();
                host.Dispose();
                browser.Dispose();
                browser = null;
                _browserWindowHandle = IntPtr.Zero;
            }
            base.Dispose(disposing);
        }
        internal void BrowserCreated(object sender, EventArgs e) {
            // _browser = browser;
            _browserWindowHandle = _core.CefBrowser.GetHost().GetWindowHandle();
            ResizeWindow(_browserWindowHandle, Width, Height);
        }
        protected override void OnResize(EventArgs e) {
            base.OnResize(e);
            var form = TopLevelControl as Form;
            if (form != null && form.WindowState != FormWindowState.Minimized) {
                ResizeWindow(_browserWindowHandle, Width, Height);
            }
        }
        private static void ResizeWindow(IntPtr handle, int width, int height) {
            if (handle != IntPtr.Zero) {
                NativeMethods.SetWindowPos(handle, IntPtr.Zero,
                    0, 0, width, height,
                    SetWindowPosFlags.NoMove | SetWindowPosFlags.NoZOrder
                    );
            }
        }
    }
}