using System;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Xilium.CefGlue.WindowsForms;
using Telerik.WinControls.UI;
namespace Anomolacaris {
    public partial class frmBrowser : Telerik.WinControls.UI.RadForm {
        private readonly string _mainTitle;
        private IniFile settings;
        private string homePage;
        public frmBrowser() {
            try {
                settings = new IniFile(Application.StartupPath + @"\settings.ini");
                InitializeComponent();
                _mainTitle = Text;
                homePage = settings.Read("Settings", "Homepage", "http://www.google.com/");
                NewTab(homePage);
                //radPageView1.MouseUp += radPageView1_MouseUp;
                txtUrl.KeyPress += txtUrl_KeyPress;
                this.Resize += frmBrowser_Resize;
                this.FormClosing += frmBrowser_FormClosing;
                this.Width = settings.ReadInt("Settings", "Width", this.Width);
                this.Height = settings.ReadInt("Settings", "Height", this.Height);
                this.Left = settings.ReadInt("Settings", "Left", this.Left);
                this.Top = settings.ReadInt("Settings", "Left", this.Top);
            } catch (Exception ex) {
                throw ex;
            }
        }
        private void mnuNewTab_Click(object sender, EventArgs e) {
            try {
                NewTab(homePage);
            } catch (Exception ex) {
                throw ex;
            }
        }
        private void frmBrowser_Resize(object sender, EventArgs e) {
            try {
                txtUrl.MinSize = new Size(this.Size.Width - 230, 0);
            } catch (Exception ex) {
                throw ex;
            }
        }
        private void frmBrowser_FormClosing(object sender, FormClosingEventArgs e) {
            try {
                settings.Write("Settings", "Width", this.Width.ToString());
                settings.Write("Settings", "Height", this.Height.ToString());
                settings.Write("Settings", "Left", this.Left.ToString());
                settings.Write("Settings", "Top", this.Top.ToString());
            } catch (Exception ex) {
                throw ex;
            }
        }
        private CefWebBrowser GetActiveBrowser() {
            try {
                if (radPageView1.Pages.Count > 0) {
                    foreach (var ctl in radPageView1.SelectedPage.Controls) {
                        if (ctl is CefWebBrowser) {
                            var browser = (CefWebBrowser)ctl;
                            return browser;
                        }
                    }
                }
                return null;
            } catch (Exception ex) {
                throw ex;
            }
        }
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e) {
            try {
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
            } catch (Exception ex) {
                throw ex;
            }
        }
        private void goAddressAction(object sender, EventArgs e) {
            try {
                var ctl = GetActiveBrowser();
                if (ctl != null) {
                    ctl.Browser.GetMainFrame().LoadUrl(txtUrl.Text);
                }
            } catch (Exception ex) {
                throw ex;
            }
        }
        private void NewTab(string startUrl) {
            try {
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
                        //radStatusStrip1.Text = e.Value; // DO NOT DELETE
                    }));
                };
                page.Controls.Add(browser);
                radPageView1.Pages.Add(page);
                radPageView1.SelectedPage = page;
            } catch (Exception ex) {
                throw ex;
            }
        }
        private void addressTextBox_KeyDown(object sender, KeyEventArgs e) {
            try {
                if (e.KeyCode == Keys.Enter) goAddressAction(sender, EventArgs.Empty);
            } catch (Exception ex) {
                throw ex;
            }
        }
        private void txtUrl_KeyPress(object sender, KeyPressEventArgs e) {
            try {
                if (e.KeyChar == 13) {
                    if (GetActiveBrowser() != null) {
                        GetActiveBrowser().Browser.GetMainFrame().LoadUrl(txtUrl.Text);
                    }
                    e.Handled = true;
                }
            } catch (Exception ex) {
                throw ex;
            }
        }
        private void mnuExit_Click(object sender, EventArgs e) {
            try {
                Application.Exit();
            } catch (Exception ex) {
                throw ex;
            }
        }
        private void cmdBack_Click(object sender, EventArgs e) {
            try {
                if (GetActiveBrowser() != null) {
                    if (GetActiveBrowser().Browser.CanGoBack) {
                        GetActiveBrowser().Browser.GoBack();
                    }
                }
            } catch (Exception ex) {
                throw ex;
            }
        }
        private void cmdForward_Click(object sender, EventArgs e) {
            try {
                if (GetActiveBrowser() != null) {
                    if (GetActiveBrowser().Browser.CanGoForward) {
                        GetActiveBrowser().Browser.GoForward();
                    }
                }
            } catch (Exception ex) {
                throw ex;
            }
        }
        private void cmdNewTab_Click(object sender, EventArgs e) {
            try {
                NewTab(homePage);
            } catch (Exception ex) {
                throw ex;
            }
        }
        private void cmdStop_Click(object sender, EventArgs e) {
            try {
                if (GetActiveBrowser() != null) {
                    GetActiveBrowser().Browser.StopLoad();
                }
            } catch (Exception ex) {
                throw ex;
            }
        }
        private void cmdGo_Click(object sender, EventArgs e) {
            try {
                if (!string.IsNullOrEmpty(txtUrl.Text)) {
                    if (GetActiveBrowser() != null) {
                        GetActiveBrowser().Browser.GetMainFrame().LoadUrl(txtUrl.Text);
                    }
                }
            } catch (Exception ex) {
                throw ex;
            }
        }
        private void mnuAbout_Click(object sender, EventArgs e) {
            try {
                frmAbout a = new frmAbout();
                a.Show();
            } catch (Exception ex) {
                throw ex;
            }
        }
        private void mnuSettings_Click(object sender, EventArgs e) {
            try {
                var settings = new frmSettings();
                settings.Show();
            } catch (Exception ex) {
                throw ex;
            }
        }
    }
}