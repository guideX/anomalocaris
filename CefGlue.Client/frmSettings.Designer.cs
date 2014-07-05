namespace Anomolacaris
{
    partial class frmSettings
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
            this.lblHomepage = new Telerik.WinControls.UI.RadLabel();
            this.cmdOK = new Telerik.WinControls.UI.RadButton();
            this.cmdCancel = new Telerik.WinControls.UI.RadButton();
            this.txtHomepage = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lblHomepage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHomepage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHomepage
            // 
            this.lblHomepage.Location = new System.Drawing.Point(12, 12);
            this.lblHomepage.Name = "lblHomepage";
            this.lblHomepage.Size = new System.Drawing.Size(64, 18);
            this.lblHomepage.TabIndex = 0;
            this.lblHomepage.Text = "Homepage:";
            this.lblHomepage.ThemeName = "Office2010Black";
            // 
            // cmdOK
            // 
            this.cmdOK.Location = new System.Drawing.Point(222, 201);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(73, 24);
            this.cmdOK.TabIndex = 1;
            this.cmdOK.Text = "OK";
            this.cmdOK.ThemeName = "Office2010Black";
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(301, 201);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(73, 24);
            this.cmdCancel.TabIndex = 2;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.ThemeName = "Office2010Black";
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // txtHomepage
            // 
            this.txtHomepage.Location = new System.Drawing.Point(116, 12);
            this.txtHomepage.Name = "txtHomepage";
            this.txtHomepage.Size = new System.Drawing.Size(258, 20);
            this.txtHomepage.TabIndex = 3;
            this.txtHomepage.TabStop = false;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 237);
            this.Controls.Add(this.txtHomepage);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.lblHomepage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmSettings";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Anomolocaris - Settings";
            this.ThemeName = "Office2010Black";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lblHomepage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHomepage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel lblHomepage;
        private Telerik.WinControls.UI.RadButton cmdOK;
        private Telerik.WinControls.UI.RadButton cmdCancel;
        private Telerik.WinControls.UI.RadTextBox txtHomepage;
    }
}
