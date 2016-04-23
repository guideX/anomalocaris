namespace Anomolacaris
{
    partial class frmBrowser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBrowser));
            this.office2010BlackTheme1 = new Telerik.WinControls.Themes.Office2010BlackTheme();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.mnuSettings = new Telerik.WinControls.UI.RadMenuItem();
            this.mnuExit = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem5 = new Telerik.WinControls.UI.RadMenuItem();
            this.mnuAbout = new Telerik.WinControls.UI.RadMenuItem();
            this.radCommandBar1 = new Telerik.WinControls.UI.RadCommandBar();
            this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.cmdBack = new Telerik.WinControls.UI.CommandBarButton();
            this.cmdForward = new Telerik.WinControls.UI.CommandBarButton();
            this.cmdNewTab = new Telerik.WinControls.UI.CommandBarButton();
            this.cmdStop = new Telerik.WinControls.UI.CommandBarButton();
            this.txtUrl = new Telerik.WinControls.UI.CommandBarTextBox();
            this.cmdGo = new Telerik.WinControls.UI.CommandBarButton();
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.mnuPopup = new Telerik.WinControls.UI.RadContextMenu(this.components);
            this.mnuNewTab = new Telerik.WinControls.UI.RadMenuItem();
            this.mnuCloseTab = new Telerik.WinControls.UI.RadMenuItem();
            this.office2010BlueTheme1 = new Telerik.WinControls.Themes.Office2010BlueTheme();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.AccessibleDescription = "&File";
            this.radMenuItem1.AccessibleName = "&File";
            this.radMenuItem1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.mnuSettings,
            this.mnuExit});
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "&File";
            this.radMenuItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // mnuSettings
            // 
            this.mnuSettings.AccessibleDescription = "&Settings";
            this.mnuSettings.AccessibleName = "&Settings";
            this.mnuSettings.Name = "mnuSettings";
            this.mnuSettings.Text = "&Settings";
            this.mnuSettings.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.mnuSettings.Click += new System.EventHandler(this.mnuSettings_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.AccessibleDescription = "&Exit";
            this.mnuExit.AccessibleName = "&Exit";
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Text = "&Exit";
            this.mnuExit.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // radMenuItem5
            // 
            this.radMenuItem5.AccessibleDescription = "&Help";
            this.radMenuItem5.AccessibleName = "&Help";
            this.radMenuItem5.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.mnuAbout});
            this.radMenuItem5.Name = "radMenuItem5";
            this.radMenuItem5.Text = "&Help";
            this.radMenuItem5.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // mnuAbout
            // 
            this.mnuAbout.AccessibleDescription = "About";
            this.mnuAbout.AccessibleName = "About";
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Text = "About";
            this.mnuAbout.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // radCommandBar1
            // 
            this.radCommandBar1.AutoSize = true;
            this.radCommandBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radCommandBar1.Location = new System.Drawing.Point(0, 21);
            this.radCommandBar1.Name = "radCommandBar1";
            this.radCommandBar1.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement1});
            this.radCommandBar1.Size = new System.Drawing.Size(721, 42);
            this.radCommandBar1.TabIndex = 1;
            this.radCommandBar1.Text = "radCommandBar1";
            this.radCommandBar1.ThemeName = "Office2010Black";
            // 
            // commandBarRowElement1
            // 
            this.commandBarRowElement1.DisplayName = null;
            this.commandBarRowElement1.MinSize = new System.Drawing.Size(25, 25);
            this.commandBarRowElement1.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.commandBarStripElement1});
            // 
            // commandBarStripElement1
            // 
            this.commandBarStripElement1.DisplayName = "commandBarStripElement1";
            this.commandBarStripElement1.FloatingForm = null;
            this.commandBarStripElement1.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.cmdBack,
            this.cmdForward,
            this.cmdNewTab,
            this.cmdStop,
            this.txtUrl,
            this.cmdGo});
            this.commandBarStripElement1.Name = "commandBarStripElement1";
            this.commandBarStripElement1.StretchHorizontally = true;
            this.commandBarStripElement1.Text = "";
            // 
            // cmdBack
            // 
            this.cmdBack.AccessibleDescription = "cmdBack";
            this.cmdBack.AccessibleName = "cmdBack";
            this.cmdBack.DisplayName = "commandBarButton1";
            this.cmdBack.Image = global::Anomolacaris.Properties.Resources.back;
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Text = "&Back";
            this.cmdBack.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.cmdBack.VisibleInOverflowMenu = true;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // cmdForward
            // 
            this.cmdForward.AccessibleDescription = "commandBarButton1";
            this.cmdForward.AccessibleName = "commandBarButton1";
            this.cmdForward.DisplayName = "commandBarButton1";
            this.cmdForward.Image = global::Anomolacaris.Properties.Resources._for;
            this.cmdForward.Name = "cmdForward";
            this.cmdForward.Text = "commandBarButton1";
            this.cmdForward.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.cmdForward.VisibleInOverflowMenu = true;
            this.cmdForward.Click += new System.EventHandler(this.cmdForward_Click);
            // 
            // cmdNewTab
            // 
            this.cmdNewTab.AccessibleDescription = "New Tab";
            this.cmdNewTab.AccessibleName = "New Tab";
            this.cmdNewTab.DisplayName = "commandBarButton1";
            this.cmdNewTab.Image = global::Anomolacaris.Properties.Resources.tab;
            this.cmdNewTab.Name = "cmdNewTab";
            this.cmdNewTab.Text = "New Tab";
            this.cmdNewTab.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.cmdNewTab.VisibleInOverflowMenu = true;
            this.cmdNewTab.Click += new System.EventHandler(this.cmdNewTab_Click);
            // 
            // cmdStop
            // 
            this.cmdStop.AccessibleDescription = "commandBarButton1";
            this.cmdStop.AccessibleName = "commandBarButton1";
            this.cmdStop.DisplayName = "commandBarButton1";
            this.cmdStop.Image = global::Anomolacaris.Properties.Resources.stop;
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Text = "commandBarButton1";
            this.cmdStop.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.cmdStop.VisibleInOverflowMenu = true;
            this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.DisplayName = "commandBarTextBox1";
            this.txtUrl.MinSize = new System.Drawing.Size(250, 0);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Text = "";
            this.txtUrl.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.txtUrl.VisibleInOverflowMenu = true;
            // 
            // cmdGo
            // 
            this.cmdGo.AccessibleDescription = "commandBarButton1";
            this.cmdGo.AccessibleName = "commandBarButton1";
            this.cmdGo.DisplayName = "commandBarButton1";
            this.cmdGo.Image = global::Anomolacaris.Properties.Resources.go;
            this.cmdGo.Name = "cmdGo";
            this.cmdGo.Text = "commandBarButton1";
            this.cmdGo.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.cmdGo.VisibleInOverflowMenu = true;
            this.cmdGo.Click += new System.EventHandler(this.cmdGo_Click);
            // 
            // radPageView1
            // 
            this.radPageView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPageView1.Location = new System.Drawing.Point(0, 63);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.Size = new System.Drawing.Size(721, 378);
            this.radPageView1.TabIndex = 2;
            this.radPageView1.Text = "radPageView1";
            this.radPageView1.ThemeName = "Office2010Black";
            this.radPageView1.SelectedPageChanged += new System.EventHandler(this.radPageView1_SelectedPageChanged);
            // 
            // mnuPopup
            // 
            this.mnuPopup.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.mnuNewTab,
            this.mnuCloseTab});
            this.mnuPopup.ThemeName = "Office2010Blue";
            // 
            // mnuNewTab
            // 
            this.mnuNewTab.AccessibleDescription = "radMenuItem6";
            this.mnuNewTab.AccessibleName = "radMenuItem6";
            this.mnuNewTab.Name = "mnuNewTab";
            this.mnuNewTab.Text = "&New Tab";
            this.mnuNewTab.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // mnuCloseTab
            // 
            this.mnuCloseTab.AccessibleDescription = "Close Tab";
            this.mnuCloseTab.AccessibleName = "Close Tab";
            this.mnuCloseTab.Name = "mnuCloseTab";
            this.mnuCloseTab.Text = "Close Tab";
            this.mnuCloseTab.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1,
            this.radMenuItem5});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(721, 21);
            this.radMenu1.TabIndex = 0;
            this.radMenu1.Text = "radMenu1";
            this.radMenu1.ThemeName = "Office2010Black";
            // 
            // frmBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 441);
            this.Controls.Add(this.radPageView1);
            this.Controls.Add(this.radCommandBar1);
            this.Controls.Add(this.radMenu1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBrowser";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Anomolocaris";
            this.ThemeName = "Office2010Black";
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;
        private Telerik.WinControls.UI.RadCommandBar radCommandBar1;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1;
        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem mnuExit;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem5;
        private Telerik.WinControls.UI.RadMenuItem mnuAbout;
        private Telerik.WinControls.UI.CommandBarButton cmdBack;
        private Telerik.WinControls.UI.CommandBarButton cmdForward;
        private Telerik.WinControls.UI.CommandBarButton cmdNewTab;
        private Telerik.WinControls.UI.CommandBarButton cmdStop;
        private Telerik.WinControls.UI.CommandBarTextBox txtUrl;
        private Telerik.WinControls.UI.CommandBarButton cmdGo;
        private Telerik.WinControls.UI.RadContextMenu mnuPopup;
        private Telerik.WinControls.Themes.Office2010BlueTheme office2010BlueTheme1;
        private Telerik.WinControls.UI.RadMenuItem mnuNewTab;
        private Telerik.WinControls.UI.RadMenuItem mnuCloseTab;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem mnuSettings;
    }
}
