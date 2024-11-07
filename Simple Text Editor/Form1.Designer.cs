namespace Simple_Text_Editor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Mainmenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnnOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNew = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveas = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findReplaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btncolor = new System.Windows.Forms.ToolStripMenuItem();
            this.darkThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBold = new System.Windows.Forms.ToolStripMenuItem();
            this.btnitalic = new System.Windows.Forms.ToolStripMenuItem();
            this.btnunderline = new System.Windows.Forms.ToolStripMenuItem();
            this.btnnormal = new System.Windows.Forms.ToolStripMenuItem();
            this.tbMainControl = new System.Windows.Forms.TabControl();
            this.Mainmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mainmenu
            // 
            this.Mainmenu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Mainmenu.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mainmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.preferenceToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.Mainmenu.Location = new System.Drawing.Point(0, 0);
            this.Mainmenu.Name = "Mainmenu";
            this.Mainmenu.Size = new System.Drawing.Size(1632, 33);
            this.Mainmenu.TabIndex = 0;
            this.Mainmenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnnOpen,
            this.btnNew,
            this.btnSave,
            this.btnSaveas,
            this.btnClose,
            this.btnExit});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(60, 29);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // btnnOpen
            // 
            this.btnnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnnOpen.Image")));
            this.btnnOpen.Name = "btnnOpen";
            this.btnnOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.btnnOpen.Size = new System.Drawing.Size(271, 30);
            this.btnnOpen.Text = "&Open";
            this.btnnOpen.Click += new System.EventHandler(this.btnnOpen_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.Name = "btnNew";
            this.btnNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.btnNew.Size = new System.Drawing.Size(271, 30);
            this.btnNew.Text = "&New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Name = "btnSave";
            this.btnSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.btnSave.Size = new System.Drawing.Size(271, 30);
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveas
            // 
            this.btnSaveas.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveas.Image")));
            this.btnSaveas.Name = "btnSaveas";
            this.btnSaveas.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.btnSaveas.Size = new System.Drawing.Size(271, 30);
            this.btnSaveas.Text = "Sa&ve as";
            this.btnSaveas.Click += new System.EventHandler(this.btnSaveas_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Name = "btnClose";
            this.btnClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.btnClose.Size = new System.Drawing.Size(271, 30);
            this.btnClose.Text = "&Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Name = "btnExit";
            this.btnExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.btnExit.Size = new System.Drawing.Size(271, 30);
            this.btnExit.Text = "E&xit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findReplaceToolStripMenuItem});
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // findReplaceToolStripMenuItem
            // 
            this.findReplaceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("findReplaceToolStripMenuItem.Image")));
            this.findReplaceToolStripMenuItem.Name = "findReplaceToolStripMenuItem";
            this.findReplaceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.findReplaceToolStripMenuItem.Size = new System.Drawing.Size(288, 30);
            this.findReplaceToolStripMenuItem.Text = "Find Replace";
            this.findReplaceToolStripMenuItem.Click += new System.EventHandler(this.findReplaceToolStripMenuItem_Click);
            // 
            // preferenceToolStripMenuItem
            // 
            this.preferenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btncolor});
            this.preferenceToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preferenceToolStripMenuItem.Name = "preferenceToolStripMenuItem";
            this.preferenceToolStripMenuItem.Size = new System.Drawing.Size(125, 29);
            this.preferenceToolStripMenuItem.Text = "&Preference";
            // 
            // btncolor
            // 
            this.btncolor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkThemeToolStripMenuItem,
            this.lightThemeToolStripMenuItem});
            this.btncolor.Image = ((System.Drawing.Image)(resources.GetObject("btncolor.Image")));
            this.btncolor.Name = "btncolor";
            this.btncolor.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.btncolor.Size = new System.Drawing.Size(217, 30);
            this.btncolor.Text = "Theme";
            // 
            // darkThemeToolStripMenuItem
            // 
            this.darkThemeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("darkThemeToolStripMenuItem.Image")));
            this.darkThemeToolStripMenuItem.Name = "darkThemeToolStripMenuItem";
            this.darkThemeToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.darkThemeToolStripMenuItem.Text = "Dark Theme";
            this.darkThemeToolStripMenuItem.Click += new System.EventHandler(this.darkThemeToolStripMenuItem_Click);
            // 
            // lightThemeToolStripMenuItem
            // 
            this.lightThemeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lightThemeToolStripMenuItem.Image")));
            this.lightThemeToolStripMenuItem.Name = "lightThemeToolStripMenuItem";
            this.lightThemeToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.lightThemeToolStripMenuItem.Text = "Light Theme";
            this.lightThemeToolStripMenuItem.Click += new System.EventHandler(this.lightThemeToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBold,
            this.btnitalic,
            this.btnunderline,
            this.btnnormal});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(119, 29);
            this.fontToolStripMenuItem.Text = "Font Style";
            // 
            // btnBold
            // 
            this.btnBold.Image = ((System.Drawing.Image)(resources.GetObject("btnBold.Image")));
            this.btnBold.Name = "btnBold";
            this.btnBold.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.btnBold.Size = new System.Drawing.Size(246, 30);
            this.btnBold.Text = "Bold";
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnitalic
            // 
            this.btnitalic.Image = ((System.Drawing.Image)(resources.GetObject("btnitalic.Image")));
            this.btnitalic.Name = "btnitalic";
            this.btnitalic.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.btnitalic.Size = new System.Drawing.Size(246, 30);
            this.btnitalic.Text = "Italic";
            this.btnitalic.Click += new System.EventHandler(this.btnitalic_Click);
            // 
            // btnunderline
            // 
            this.btnunderline.Image = ((System.Drawing.Image)(resources.GetObject("btnunderline.Image")));
            this.btnunderline.Name = "btnunderline";
            this.btnunderline.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.U)));
            this.btnunderline.Size = new System.Drawing.Size(246, 30);
            this.btnunderline.Text = "Underline";
            this.btnunderline.Click += new System.EventHandler(this.btnunderline_Click);
            // 
            // btnnormal
            // 
            this.btnnormal.Image = ((System.Drawing.Image)(resources.GetObject("btnnormal.Image")));
            this.btnnormal.Name = "btnnormal";
            this.btnnormal.Size = new System.Drawing.Size(246, 30);
            this.btnnormal.Text = "Normal";
            this.btnnormal.Click += new System.EventHandler(this.btnnormal_Click);
            // 
            // tbMainControl
            // 
            this.tbMainControl.Location = new System.Drawing.Point(0, 31);
            this.tbMainControl.Name = "tbMainControl";
            this.tbMainControl.SelectedIndex = 0;
            this.tbMainControl.Size = new System.Drawing.Size(1540, 810);
            this.tbMainControl.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1632, 1053);
            this.Controls.Add(this.tbMainControl);
            this.Controls.Add(this.Mainmenu);
            this.MainMenuStrip = this.Mainmenu;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reference";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Mainmenu.ResumeLayout(false);
            this.Mainmenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Mainmenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnnOpen;
        private System.Windows.Forms.ToolStripMenuItem btnNew;
        private System.Windows.Forms.ToolStripMenuItem btnSave;
        private System.Windows.Forms.ToolStripMenuItem btnSaveas;
        private System.Windows.Forms.ToolStripMenuItem btnClose;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btncolor;
        private System.Windows.Forms.TabControl tbMainControl;
        private System.Windows.Forms.ToolStripMenuItem findReplaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkThemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightThemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnBold;
        private System.Windows.Forms.ToolStripMenuItem btnitalic;
        private System.Windows.Forms.ToolStripMenuItem btnunderline;
        private System.Windows.Forms.ToolStripMenuItem btnnormal;
    }
}

