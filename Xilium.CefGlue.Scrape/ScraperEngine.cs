using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xilium.CefGlue.Scrape
{
    public class Scraper
    {
        public void Shutdown()
        {
            CefRuntime.Shutdown();
        }
        public string Scrape(string url)
        {
            CefRuntime.Load();
            var cefMainArgs = new CefMainArgs(new string[0]);
            var cefApp = new DemoCefApp();
            if (CefRuntime.ExecuteProcess(cefMainArgs, cefApp) != -1)
            {
                CefRuntime.Shutdown();
                return "";
            }
            var cefSettings = new CefSettings
            {
                SingleProcess = false,
                MultiThreadedMessageLoop = true
            };
            CefRuntime.Initialize(cefMainArgs, cefSettings, cefApp);
            CefWindowInfo cefWindowInfo = CefWindowInfo.Create();
            cefWindowInfo.SetAsOffScreen(IntPtr.Zero);
            var cefBrowserSettings = new CefBrowserSettings();
            var cefClient = new DemoCefClient(640, 480);
            CefBrowserHost.CreateBrowser(cefWindowInfo, cefClient, cefBrowserSettings, url);
            //Console.WriteLine("Press a key at any time to end the program.");
            //Console.ReadKey();
            return "";
        }
    }
    internal class DemoCefApp : CefApp
    {
    }
    internal class DemoCefClient : CefClient
    {
        private readonly DemoCefLoadHandler _loadHandler;
        private readonly DemoCefRenderHandler _renderHandler;
        public DemoCefClient(int windowWidth, int windowHeight)
        {
            _renderHandler = new DemoCefRenderHandler(windowWidth, windowHeight);
            _loadHandler = new DemoCefLoadHandler();
        }
        protected override CefRenderHandler GetRenderHandler()
        {
            return _renderHandler;
        }
        protected override CefLoadHandler GetLoadHandler()
        {
            return _loadHandler;
        }
    }
    internal class DemoCefLoadHandler : CefLoadHandler
    {
        protected override void OnLoadStart(CefBrowser browser, CefFrame frame)
        {
            if (frame.IsMain)
            {
                Console.WriteLine("START: {0}", browser.GetMainFrame().Url);
            }
        }
        protected override void OnLoadEnd(CefBrowser browser, CefFrame frame, int httpStatusCode)
        {
            if (frame.IsMain)
            {
                Console.WriteLine("END: {0}, {1}", browser.GetMainFrame().Url, httpStatusCode);
            }
        }
    }
    internal class DemoCefRenderHandler : CefRenderHandler
    {
        private readonly int _windowHeight;
        private readonly int _windowWidth;
        public DemoCefRenderHandler(int windowWidth, int windowHeight)
        {
            _windowWidth = windowWidth;
            _windowHeight = windowHeight;
        }
        protected override bool GetRootScreenRect(CefBrowser browser, ref CefRectangle rect)
        {
            return GetViewRect(browser, ref rect);
        }
        protected override bool GetScreenPoint(CefBrowser browser, int viewX, int viewY, ref int screenX, ref int screenY)
        {
            screenX = viewX;
            screenY = viewY;
            return true;
        }
        protected override bool GetViewRect(CefBrowser browser, ref CefRectangle rect)
        {
            rect.X = 0;
            rect.Y = 0;
            rect.Width = _windowWidth;
            rect.Height = _windowHeight;
            return true;
        }
        protected override bool GetScreenInfo(CefBrowser browser, CefScreenInfo screenInfo)
        {
            return false;
        }
        protected override void OnPopupSize(CefBrowser browser, CefRectangle rect)
        {
        }
        protected override void OnPaint(CefBrowser browser, CefPaintElementType type, CefRectangle[] dirtyRects, IntPtr buffer, int width, int height)
        {
            var bitmap = new Bitmap(width, height, width * 4, PixelFormat.Format32bppRgb, buffer);
            bitmap.Save("LastOnPaint.png", ImageFormat.Png);
        }
        protected override void OnCursorChange(CefBrowser browser, IntPtr cursorHandle)
        {
        }
        protected override void OnScrollOffsetChanged(CefBrowser browser)
        {
        }
    }
    

}
