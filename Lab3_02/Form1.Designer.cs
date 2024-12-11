namespace Lab3_02
{
    partial class Soanvanban
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Soanvanban));
            this.rtbVanBan = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TipHethong = new System.Windows.Forms.ToolStripMenuItem();
            this.tipCreateVB = new System.Windows.Forms.ToolStripMenuItem();
            this.TipDinhDang = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tipFont = new System.Windows.Forms.ToolStripComboBox();
            this.tipSize = new System.Windows.Forms.ToolStripComboBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnOpenFile = new System.Windows.Forms.ToolStripButton();
            this.btnSaveFile = new System.Windows.Forms.ToolStripButton();
            this.btnBold = new System.Windows.Forms.ToolStripButton();
            this.btnItalicized = new System.Windows.Forms.ToolStripButton();
            this.btnUnderline = new System.Windows.Forms.ToolStripButton();
            this.tipMoFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tipSave = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbVanBan
            // 
            this.rtbVanBan.Location = new System.Drawing.Point(12, 64);
            this.rtbVanBan.Name = "rtbVanBan";
            this.rtbVanBan.Size = new System.Drawing.Size(776, 374);
            this.rtbVanBan.TabIndex = 0;
            this.rtbVanBan.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TipHethong,
            this.TipDinhDang});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TipHethong
            // 
            this.TipHethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipCreateVB,
            this.tipMoFile,
            this.tipSave,
            this.thoátToolStripMenuItem});
            this.TipHethong.Name = "TipHethong";
            this.TipHethong.Size = new System.Drawing.Size(72, 20);
            this.TipHethong.Text = "Hệ Thống";
            // 
            // tipCreateVB
            // 
            this.tipCreateVB.Name = "tipCreateVB";
            this.tipCreateVB.Size = new System.Drawing.Size(241, 22);
            this.tipCreateVB.Text = "Tạo văn bản mới        Ctrl+N";
            this.tipCreateVB.Click += new System.EventHandler(this.tipCreateVB_Click);
            // 
            // TipDinhDang
            // 
            this.TipDinhDang.Name = "TipDinhDang";
            this.TipDinhDang.Size = new System.Drawing.Size(74, 20);
            this.TipDinhDang.Text = "Định dạng";
            this.TipDinhDang.Click += new System.EventHandler(this.TipDinhDang_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.RoyalBlue;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpenFile,
            this.btnSaveFile,
            this.tipFont,
            this.tipSize,
            this.btnBold,
            this.btnItalicized,
            this.btnUnderline});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tipFont
            // 
            this.tipFont.Name = "tipFont";
            this.tipFont.Size = new System.Drawing.Size(121, 25);
            // 
            // tipSize
            // 
            this.tipSize.Name = "tipSize";
            this.tipSize.Size = new System.Drawing.Size(121, 25);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFile.Image")));
            this.btnOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(23, 22);
            this.btnOpenFile.Text = "OpenFile";
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveFile.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveFile.Image")));
            this.btnSaveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(23, 22);
            this.btnSaveFile.Text = "SaveFile";
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnBold
            // 
            this.btnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBold.Image = ((System.Drawing.Image)(resources.GetObject("btnBold.Image")));
            this.btnBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(23, 22);
            this.btnBold.Text = "Bold";
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnItalicized
            // 
            this.btnItalicized.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnItalicized.Image = ((System.Drawing.Image)(resources.GetObject("btnItalicized.Image")));
            this.btnItalicized.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnItalicized.Name = "btnItalicized";
            this.btnItalicized.Size = new System.Drawing.Size(23, 22);
            this.btnItalicized.Text = "Italicized";
            this.btnItalicized.Click += new System.EventHandler(this.btnItalicized_Click);
            // 
            // btnUnderline
            // 
            this.btnUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUnderline.Image = ((System.Drawing.Image)(resources.GetObject("btnUnderline.Image")));
            this.btnUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(23, 22);
            this.btnUnderline.Text = "Underline";
            this.btnUnderline.Click += new System.EventHandler(this.btnUnderline_Click);
            // 
            // tipMoFile
            // 
            this.tipMoFile.Image = global::Lab3_02.Properties.Resources._2;
            this.tipMoFile.Name = "tipMoFile";
            this.tipMoFile.Size = new System.Drawing.Size(241, 22);
            this.tipMoFile.Text = "Mở tập tin";
            this.tipMoFile.Click += new System.EventHandler(this.tipMoFile_Click);
            // 
            // tipSave
            // 
            this.tipSave.Image = global::Lab3_02.Properties.Resources._4;
            this.tipSave.Name = "tipSave";
            this.tipSave.Size = new System.Drawing.Size(241, 22);
            this.tipSave.Text = "Lưu nội dung văn bản      Ctrl+S";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Image = global::Lab3_02.Properties.Resources._8;
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // Soanvanban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.rtbVanBan);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Soanvanban";
            this.Text = "Lab3_02";
            this.Load += new System.EventHandler(this.Soanvanban_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbVanBan;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TipHethong;
        private System.Windows.Forms.ToolStripMenuItem tipCreateVB;
        private System.Windows.Forms.ToolStripMenuItem tipMoFile;
        private System.Windows.Forms.ToolStripMenuItem tipSave;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnOpenFile;
        private System.Windows.Forms.ToolStripButton btnSaveFile;
        private System.Windows.Forms.ToolStripComboBox tipFont;
        private System.Windows.Forms.ToolStripMenuItem TipDinhDang;
        private System.Windows.Forms.ToolStripComboBox tipSize;
        private System.Windows.Forms.ToolStripButton btnBold;
        private System.Windows.Forms.ToolStripButton btnItalicized;
        private System.Windows.Forms.ToolStripButton btnUnderline;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

