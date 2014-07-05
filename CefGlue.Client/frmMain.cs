using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
namespace Anomolacaris {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Text;
    using System.Windows.Forms;
    using Xilium.CefGlue.WindowsForms;
    using Telerik.WinControls.UI;
    public partial class frmMain : Telerik.WinControls.UI.RadForm {
        private readonly string _mainTitle;
        public frmMain() {
            InitializeComponent();
            _mainTitle = Text;
            NewTab("http://www.google.com");
            txtUrl.KeyPress += txtUrl_KeyPress;
            this.Resize += frmMain_Resize;
        }
        private void frmMain_Resize(object sender, EventArgs e) {
            txtUrl.MinSize = new Size(this.Size.Width - 220, 0);
        }
        private CefWebBrowser GetActiveBrowser() {
            if (radPageView1.Pages.Count > 0) {
                foreach (var ctl in radPageView1.SelectedPage.Controls) {
                    if (ctl is CefWebBrowser) {
                        var browser = (CefWebBrowser)ctl;
                        return browser;
                    }
                }
            }
            return null;
        }
        void tabControl_SelectedIndexChanged(object sender, EventArgs e) {
            if (radPageView1.Pages.Count > 0) {
                foreach (var ctl in radPageView1.SelectedPage.Controls) {
                    if (ctl is CefWebBrowser) {
                        var browser = (CefWebBrowser)ctl;
                        Text = browser.Title + " - " + _mainTitle;
                        break;
                    }
                }
            } else {
                Text = _mainTitle;
            }
        }
        private void tabControl_MouseUp(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                for (int i = 0; i < radPageView1.Pages.Count; i++) {
                    Rectangle r = radPageView1.Pages[i].DisplayRectangle;
                    if (r.Contains(e.Location)) {
                        closeTabContextMenuItem.Tag = radPageView1.Pages[i];
                        tabContextMenu.LostFocus += (s, ev) => { tabContextMenu.Hide(); };
                        tabContextMenu.ChangeUICues += (s, ev) => { tabContextMenu.Hide(); };
                        tabContextMenu.Show(radPageView1, e.Location);
                    }
                }
            }
        }
        private void newTabAction(object sender, EventArgs e) {
            NewTab("http://www.google.com");
        }
        private void goAddressAction(object sender, EventArgs e) {
            var ctl = GetActiveBrowser();
            if (ctl != null) {
                ctl.Browser.GetMainFrame().LoadUrl(txtUrl.Text);
            }
        }
        private void NewTab(string startUrl) {
            var page = new RadPageViewPage();
            page.Text = "New Tab";
            page.Padding = new Padding(0, 0, 0, 0);
            var browser = new CefWebBrowser();
            browser.StartUrl = startUrl;
            browser.Dock = DockStyle.Fill;
            browser.TitleChanged += (s, e) => {
                BeginInvoke(new Action(() => {
                    var title = browser.Title;
                    if (radPageView1.SelectedPage == page) {
                        Text = browser.Title + " - " + _mainTitle;
                    }
                    page.ToolTipText = title;
                    if (title.Length > 18) {
                        title = title.Substring(0, 18) + "...";
                    }
                    page.Text = title;
                }));
            };
            browser.AddressChanged += (s, e) => {
                BeginInvoke(new Action(() => {
                    txtUrl.Text = browser.Address;
                }));
            };
            browser.StatusMessage += (s, e) => {
                BeginInvoke(new Action(() => {
                    statusLabel.Text = e.Value;
                }));
            };
            page.Controls.Add(browser);
            radPageView1.Pages.Add(page);
            radPageView1.SelectedPage = page;
        }
        private void closeTabAction(object sender, EventArgs e) {
            var s = (ToolStripMenuItem)sender;
            var page = s.Tag as TabPage;
            if (page != null) {
                page.Dispose();
                page = null;
            }
        }
        private void addressTextBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) goAddressAction(sender, EventArgs.Empty);
        }
        private void cmdBack_Click(object sender, EventArgs e) {
            if (GetActiveBrowser() != null) {
                if (GetActiveBrowser().Browser.CanGoBack) {
                    GetActiveBrowser().Browser.GoBack();
                }
            }
        }
        private void cmdForward_Click(object sender, EventArgs e) {
            if (GetActiveBrowser() != null) {
                if (GetActiveBrowser().Browser.CanGoForward) {
                    GetActiveBrowser().Browser.GoForward();
                }
            }
        }
        private void cmdStop_Click(object sender, EventArgs e) {
            if (GetActiveBrowser() != null) {
                GetActiveBrowser().Browser.StopLoad();
            }
        }
        private void txtUrl_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) {
                if (GetActiveBrowser() != null) {
                    GetActiveBrowser().Browser.GetMainFrame().LoadUrl(txtUrl.Text);
                }
                e.Handled = true;
            }
        }
        private void txtUrl_Click(object sender, EventArgs e) {
            //txtUrl.SelectionStart = 0;
            //txtUrl.SelectionLength = txtUrl.Text.Length;
        }
        private void cmdNewTab_Click(object sender, EventArgs e) {
            NewTab("http://www.google.com");
        }
        private void rcmdBack_Click(object sender, EventArgs e) {
            if (GetActiveBrowser() != null) {
                if (GetActiveBrowser().Browser.CanGoBack) {
                    GetActiveBrowser().Browser.GoBack();
                }
            }
        }
        /*
        private void rcmdForward_Click(object sender, EventArgs e) {
            if (GetActiveBrowser() != null) {
                if (GetActiveBrowser().Browser.CanGoForward) {
                    GetActiveBrowser().Browser.GoForward();
                }
            }
        }
         */
        private void rcmdNewTab_Click(object sender, EventArgs e) {
            NewTab("http://www.google.com");
        }
        private void cmdGo_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(txtUrl.Text)) {
                if (GetActiveBrowser() != null) {
                    GetActiveBrowser().Browser.GetMainFrame().LoadUrl(txtUrl.Text);
                }
            }
        }
        private void mnuExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}