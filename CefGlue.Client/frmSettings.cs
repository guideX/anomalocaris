using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
namespace Anomolacaris {
    public partial class frmSettings : Telerik.WinControls.UI.RadForm {
        public frmSettings() {
            InitializeComponent();
        }
        private IniFile settings;
        private void frmSettings_Load(object sender, EventArgs e) {
            try {
                settings = new IniFile(Application.StartupPath + @"\settings.ini");
                this.txtHomepage.Text = settings.Read("Settings", "Homepage", "http://www.google.com/");
            } catch (Exception ex) {
                throw ex;
            }
        }
        private void cmdCancel_Click(object sender, EventArgs e) {
            try {
                this.Close();
            } catch (Exception ex) {
                throw ex;
            }
        }
        private void cmdOK_Click(object sender, EventArgs e) {
            try {
                settings.Write("Settings", "Homepage", txtHomepage.Text);
                this.Close();
            } catch (Exception ex) {
                throw ex;
            }
        }
    }
}