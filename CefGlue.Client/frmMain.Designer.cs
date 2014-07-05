namespace Anomolacaris
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tabContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newTabContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeTabContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.radCommandBar22 = new Telerik.WinControls.UI.RadCommandBar();
            this.mnuRoot = new Telerik.WinControls.UI.RadMenu();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.mnuExit = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem4 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem5 = new Telerik.WinControls.UI.RadMenuItem();
            this.mnuAbout = new Telerik.WinControls.UI.RadMenuItem();
            this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.rcmdBack = new Telerik.WinControls.UI.CommandBarButton();
            this.rcmdForward = new Telerik.WinControls.UI.CommandBarButton();
            this.rcmdNewTab = new Telerik.WinControls.UI.CommandBarButton();
            this.rcmdStop = new Telerik.WinControls.UI.CommandBarButton();
            this.txtUrl = new Telerik.WinControls.UI.CommandBarTextBox();
            this.cmdGo = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarRowElement2 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.statusStrip.SuspendLayout();
            this.tabContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar22)).BeginInit();
            this.radCommandBar22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mnuRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 434);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(736, 22);
            this.statusStrip.TabIndex = 7;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tabContextMenu
            // 
            this.tabContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTabContextMenuItem,
            this.closeTabContextMenuItem});
            this.tabContextMenu.Name = "tabContextMenu";
            this.tabContextMenu.Size = new System.Drawing.Size(124, 48);
            // 
            // newTabContextMenuItem
            // 
            this.newTabContextMenuItem.Name = "newTabContextMenuItem";
            this.newTabContextMenuItem.Size = new System.Drawing.Size(123, 22);
            this.newTabContextMenuItem.Text = "New tab";
            // 
            // closeTabContextMenuItem
            // 
            this.closeTabContextMenuItem.Name = "closeTabContextMenuItem";
            this.closeTabContextMenuItem.Size = new System.Drawing.Size(123, 22);
            this.closeTabContextMenuItem.Text = "Close tab";
            // 
            // menuStrip
            // 
            this.menuStrip.Location = new System.Drawing.Point(0, 49);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(736, 24);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Visible = false;
            // 
            // radCommandBar22
            // 
            this.radCommandBar22.AutoSize = true;
            this.radCommandBar22.Controls.Add(this.mnuRoot);
            this.radCommandBar22.Dock = System.Windows.Forms.DockStyle.Top;
            this.radCommandBar22.Location = new System.Drawing.Point(0, 0);
            this.radCommandBar22.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.radCommandBar22.Name = "radCommandBar22";
            this.radCommandBar22.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement1,
            this.commandBarRowElement2});
            this.radCommandBar22.Size = new System.Drawing.Size(736, 70);
            this.radCommandBar22.TabIndex = 11;
            this.radCommandBar22.Text = "radCommandBar1";
            // 
            // mnuRoot
            // 
            this.mnuRoot.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1,
            this.radMenuItem2,
            this.radMenuItem3,
            this.radMenuItem4,
            this.radMenuItem5});
            this.mnuRoot.Location = new System.Drawing.Point(0, 0);
            this.mnuRoot.Name = "mnuRoot";
            this.mnuRoot.Size = new System.Drawing.Size(736, 20);
            this.mnuRoot.TabIndex = 1;
            this.mnuRoot.Text = "radMenu1";
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.AccessibleDescription = "&File";
            this.radMenuItem1.AccessibleName = "&File";
            this.radMenuItem1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.mnuExit});
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "&File";
            this.radMenuItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
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
            // radMenuItem2
            // 
            this.radMenuItem2.AccessibleDescription = "&Edit";
            this.radMenuItem2.AccessibleName = "&Edit";
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "&Edit";
            this.radMenuItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenuItem3
            // 
            this.radMenuItem3.AccessibleDescription = "&Favorites";
            this.radMenuItem3.AccessibleName = "&Favorites";
            this.radMenuItem3.Name = "radMenuItem3";
            this.radMenuItem3.Text = "&Favorites";
            this.radMenuItem3.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenuItem4
            // 
            this.radMenuItem4.AccessibleDescription = "&Tool";
            this.radMenuItem4.AccessibleName = "&Tool";
            this.radMenuItem4.Name = "radMenuItem4";
            this.radMenuItem4.Text = "&Tool";
            this.radMenuItem4.Visibility = Telerik.WinControls.ElementVisibility.Visible;
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
            this.mnuAbout.AccessibleDescription = "&About";
            this.mnuAbout.AccessibleName = "&About";
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Text = "&About";
            this.mnuAbout.Visibility = Telerik.WinControls.ElementVisibility.Visible;
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
            this.commandBarStripElement1.BorderDrawMode = Telerik.WinControls.BorderDrawModes.HorizontalOverVertical;
            this.commandBarStripElement1.BorderLeftShadowColor = System.Drawing.Color.Empty;
            this.commandBarStripElement1.DisplayName = "commandBarStripElement1";
            this.commandBarStripElement1.FloatingForm = null;
            this.commandBarStripElement1.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.rcmdBack,
            this.rcmdForward,
            this.rcmdNewTab,
            this.rcmdStop,
            this.txtUrl,
            this.cmdGo});
            this.commandBarStripElement1.MaxSize = new System.Drawing.Size(1200, 0);
            this.commandBarStripElement1.Name = "commandBarStripElement1";
            this.commandBarStripElement1.StretchHorizontally = true;
            this.commandBarStripElement1.Text = "";
            // 
            // rcmdBack
            // 
            this.rcmdBack.AccessibleDescription = "commandBarButton1";
            this.rcmdBack.AccessibleName = "commandBarButton1";
            this.rcmdBack.DisplayName = "commandBarButton1";
            this.rcmdBack.Image = global::Anomolacaris.Properties.Resources.back;
            this.rcmdBack.Name = "rcmdBack";
            this.rcmdBack.Text = "commandBarButton1";
            this.rcmdBack.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.rcmdBack.VisibleInOverflowMenu = true;
            this.rcmdBack.Click += new System.EventHandler(this.rcmdBack_Click);
            // 
            // rcmdForward
            // 
            this.rcmdForward.AccessibleDescription = "commandBarButton1";
            this.rcmdForward.AccessibleName = "commandBarButton1";
            this.rcmdForward.DisplayName = "commandBarButton1";
            this.rcmdForward.Image = global::Anomolacaris.Properties.Resources._for;
            this.rcmdForward.Name = "rcmdForward";
            this.rcmdForward.Text = "commandBarButton1";
            this.rcmdForward.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.rcmdForward.VisibleInOverflowMenu = true;
            this.rcmdForward.Click += new System.EventHandler(this.rcmdForward_Click);
            // 
            // rcmdNewTab
            // 
            this.rcmdNewTab.AccessibleDescription = "New Tab";
            this.rcmdNewTab.AccessibleName = "New Tab";
            this.rcmdNewTab.DisplayName = "commandBarButton1";
            this.rcmdNewTab.Image = global::Anomolacaris.Properties.Resources.tab;
            this.rcmdNewTab.Name = "rcmdNewTab";
            this.rcmdNewTab.Text = "New Tab";
            this.rcmdNewTab.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.rcmdNewTab.VisibleInOverflowMenu = true;
            this.rcmdNewTab.Click += new System.EventHandler(this.rcmdNewTab_Click);
            // 
            // rcmdStop
            // 
            this.rcmdStop.AccessibleDescription = "commandBarButton1";
            this.rcmdStop.AccessibleName = "commandBarButton1";
            this.rcmdStop.DisplayName = "commandBarButton1";
            this.rcmdStop.Image = global::Anomolacaris.Properties.Resources.stop;
            this.rcmdStop.Name = "rcmdStop";
            this.rcmdStop.Text = "commandBarButton1";
            this.rcmdStop.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.rcmdStop.VisibleInOverflowMenu = true;
            // 
            // txtUrl
            // 
            this.txtUrl.DisplayName = "Url";
            this.txtUrl.MaxSize = new System.Drawing.Size(1200, 0);
            this.txtUrl.MinSize = new System.Drawing.Size(200, 0);
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
            // commandBarRowElement2
            // 
            this.commandBarRowElement2.DisplayName = null;
            this.commandBarRowElement2.MinSize = new System.Drawing.Size(25, 25);
            // 
            // radPageView1
            // 
            this.radPageView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPageView1.Location = new System.Drawing.Point(0, 70);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.Size = new System.Drawing.Size(736, 364);
            this.radPageView1.TabIndex = 12;
            this.radPageView1.Text = "radPageView1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 456);
            this.Controls.Add(this.tabContextMenu);
            this.Controls.Add(this.radPageView1);
            this.Controls.Add(this.radCommandBar22);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Anomolacaris";
            this.ThemeName = "ControlDefault";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar22)).EndInit();
            this.radCommandBar22.ResumeLayout(false);
            this.radCommandBar22.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mnuRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ContextMenuStrip tabContextMenu;
        private System.Windows.Forms.ToolStripMenuItem newTabContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeTabContextMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private Telerik.WinControls.UI.RadCommandBar radCommandBar22;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1;
        private Telerik.WinControls.UI.CommandBarButton rcmdBack;
        private Telerik.WinControls.UI.CommandBarButton rcmdForward;
        private Telerik.WinControls.UI.CommandBarButton rcmdNewTab;
        private Telerik.WinControls.UI.CommandBarButton rcmdStop;
        private Telerik.WinControls.UI.CommandBarTextBox txtUrl;
        private Telerik.WinControls.UI.CommandBarButton cmdGo;
        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadMenu mnuRoot;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem4;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem5;
        private Telerik.WinControls.UI.RadMenuItem mnuExit;
        private Telerik.WinControls.UI.RadMenuItem mnuAbout;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement2;

    }
}
