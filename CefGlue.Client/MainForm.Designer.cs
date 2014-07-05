namespace Xilium.CefGlue.Client
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newTabContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeTabContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtUrl = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdNewTab = new System.Windows.Forms.ToolStripButton();
            this.cmdBack = new System.Windows.Forms.ToolStripButton();
            this.cmdForward = new System.Windows.Forms.ToolStripButton();
            this.cmdRefresh = new System.Windows.Forms.ToolStripButton();
            this.cmdStop = new System.Windows.Forms.ToolStripButton();
            this.cmdGo = new System.Windows.Forms.ToolStripButton();
            this.statusStrip.SuspendLayout();
            this.tabContextMenu.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Location = new System.Drawing.Point(0, 24);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(764, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Visible = false;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 440);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(764, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 49);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.ShowToolTips = true;
            this.tabControl.Size = new System.Drawing.Size(764, 391);
            this.tabControl.TabIndex = 3;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            this.tabControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tabControl_MouseUp);
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
            this.newTabContextMenuItem.Click += new System.EventHandler(this.newTabAction);
            // 
            // closeTabContextMenuItem
            // 
            this.closeTabContextMenuItem.Name = "closeTabContextMenuItem";
            this.closeTabContextMenuItem.Size = new System.Drawing.Size(123, 22);
            this.closeTabContextMenuItem.Text = "Close tab";
            this.closeTabContextMenuItem.Click += new System.EventHandler(this.closeTabAction);
            // 
            // txtUrl
            // 
            this.txtUrl.BackColor = System.Drawing.Color.White;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(400, 25);
            this.txtUrl.Click += new System.EventHandler(this.txtUrl_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.White;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdNewTab,
            this.cmdBack,
            this.cmdForward,
            this.cmdRefresh,
            this.cmdStop,
            this.cmdGo,
            this.txtUrl});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(764, 25);
            this.toolStrip.TabIndex = 4;
            this.toolStrip.Text = "toolStrip1";
            this.toolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip_ItemClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.favoritesToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(764, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // favoritesToolStripMenuItem
            // 
            this.favoritesToolStripMenuItem.Name = "favoritesToolStripMenuItem";
            this.favoritesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.favoritesToolStripMenuItem.Text = "&Favorites";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // cmdNewTab
            // 
            this.cmdNewTab.Image = global::Anomolacaris.Properties.Resources.tab;
            this.cmdNewTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdNewTab.Name = "cmdNewTab";
            this.cmdNewTab.Size = new System.Drawing.Size(74, 22);
            this.cmdNewTab.Text = "New Tab";
            this.cmdNewTab.Click += new System.EventHandler(this.cmdNewTab_Click);
            // 
            // cmdBack
            // 
            this.cmdBack.ForeColor = System.Drawing.Color.Black;
            this.cmdBack.Image = global::Anomolacaris.Properties.Resources.back;
            this.cmdBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(52, 22);
            this.cmdBack.Text = "&Back";
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // cmdForward
            // 
            this.cmdForward.ForeColor = System.Drawing.Color.Black;
            this.cmdForward.Image = global::Anomolacaris.Properties.Resources._for;
            this.cmdForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdForward.Name = "cmdForward";
            this.cmdForward.Size = new System.Drawing.Size(70, 22);
            this.cmdForward.Text = "&Forward";
            this.cmdForward.Click += new System.EventHandler(this.cmdForward_Click);
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cmdRefresh.ForeColor = System.Drawing.Color.Black;
            this.cmdRefresh.Image = ((System.Drawing.Image)(resources.GetObject("cmdRefresh.Image")));
            this.cmdRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new System.Drawing.Size(50, 22);
            this.cmdRefresh.Text = "Refresh";
            // 
            // cmdStop
            // 
            this.cmdStop.ForeColor = System.Drawing.Color.Black;
            this.cmdStop.Image = global::Anomolacaris.Properties.Resources.stop;
            this.cmdStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(51, 22);
            this.cmdStop.Text = "&Stop";
            this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
            // 
            // cmdGo
            // 
            this.cmdGo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmdGo.ForeColor = System.Drawing.Color.Black;
            this.cmdGo.Image = global::Anomolacaris.Properties.Resources.go;
            this.cmdGo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdGo.Name = "cmdGo";
            this.cmdGo.Size = new System.Drawing.Size(42, 22);
            this.cmdGo.Text = "&Go";
            this.cmdGo.Click += new System.EventHandler(this.cmdGo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 462);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Anomolacaris";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabContextMenu.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ContextMenuStrip tabContextMenu;
        private System.Windows.Forms.ToolStripMenuItem newTabContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeTabContextMenuItem;
        private ToolStripSpringTextBox addressTextBox;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripButton cmdForward;
        private System.Windows.Forms.ToolStripButton cmdStop;
        private System.Windows.Forms.ToolStripTextBox txtUrl;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton cmdGo;
        private System.Windows.Forms.ToolStripButton cmdBack;
        private System.Windows.Forms.ToolStripButton cmdRefresh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton cmdNewTab;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;

    }
}