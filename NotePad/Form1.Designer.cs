
namespace NotePad
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripFont = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.txbWindow = new System.Windows.Forms.TextBox();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SaveFileAsDialog = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.menuStripAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripNew,
            this.menuStripOpen,
            this.menuStripSave,
            this.menuStripSaveAs,
            this.menuStripExit});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.newToolStripMenuItem.Text = "File";
            // 
            // menuStripNew
            // 
            this.menuStripNew.Name = "menuStripNew";
            this.menuStripNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuStripNew.Size = new System.Drawing.Size(184, 22);
            this.menuStripNew.Text = "New";
            this.menuStripNew.Click += new System.EventHandler(this.ClickNew);
            // 
            // menuStripOpen
            // 
            this.menuStripOpen.Name = "menuStripOpen";
            this.menuStripOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuStripOpen.Size = new System.Drawing.Size(184, 22);
            this.menuStripOpen.Text = "Open";
            this.menuStripOpen.Click += new System.EventHandler(this.ClickOpen);
            // 
            // menuStripSave
            // 
            this.menuStripSave.Name = "menuStripSave";
            this.menuStripSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuStripSave.Size = new System.Drawing.Size(184, 22);
            this.menuStripSave.Text = "Save";
            this.menuStripSave.Click += new System.EventHandler(this.ClickSave);
            // 
            // menuStripSaveAs
            // 
            this.menuStripSaveAs.Name = "menuStripSaveAs";
            this.menuStripSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.menuStripSaveAs.Size = new System.Drawing.Size(184, 22);
            this.menuStripSaveAs.Text = "Save as";
            this.menuStripSaveAs.Click += new System.EventHandler(this.ClickSaveAs);
            // 
            // menuStripExit
            // 
            this.menuStripExit.Name = "menuStripExit";
            this.menuStripExit.Size = new System.Drawing.Size(184, 22);
            this.menuStripExit.Text = "Exit";
            this.menuStripExit.Click += new System.EventHandler(this.ClickExit);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripFont});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // menuStripFont
            // 
            this.menuStripFont.Name = "menuStripFont";
            this.menuStripFont.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F)));
            this.menuStripFont.Size = new System.Drawing.Size(170, 22);
            this.menuStripFont.Text = "Font";
            this.menuStripFont.Click += new System.EventHandler(this.ClickFont);
            // 
            // menuStripAbout
            // 
            this.menuStripAbout.Name = "menuStripAbout";
            this.menuStripAbout.Size = new System.Drawing.Size(52, 20);
            this.menuStripAbout.Text = "About";
            this.menuStripAbout.Click += new System.EventHandler(this.ClickAbout);
            // 
            // txbWindow
            // 
            this.txbWindow.Location = new System.Drawing.Point(0, 27);
            this.txbWindow.Multiline = true;
            this.txbWindow.Name = "txbWindow";
            this.txbWindow.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbWindow.Size = new System.Drawing.Size(800, 421);
            this.txbWindow.TabIndex = 1;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            this.OpenFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.Filter = "Text files (*.txt)|*.txt";
            // 
            // SaveFileAsDialog
            // 
            this.SaveFileAsDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbWindow);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuStripNew;
        private System.Windows.Forms.ToolStripMenuItem menuStripOpen;
        private System.Windows.Forms.ToolStripMenuItem menuStripSave;
        private System.Windows.Forms.ToolStripMenuItem menuStripSaveAs;
        private System.Windows.Forms.ToolStripMenuItem menuStripExit;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuStripFont;
        private System.Windows.Forms.ToolStripMenuItem menuStripAbout;
        private System.Windows.Forms.TextBox txbWindow;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileAsDialog;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

