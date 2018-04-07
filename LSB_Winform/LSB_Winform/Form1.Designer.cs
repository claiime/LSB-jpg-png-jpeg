namespace LSB_Winform
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
            this.tab_menu = new System.Windows.Forms.TabControl();
            this.tabHidden = new System.Windows.Forms.TabPage();
            this.btnCleartext = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.picboxAfter = new System.Windows.Forms.PictureBox();
            this.textHide = new System.Windows.Forms.TextBox();
            this.btnFile = new System.Windows.Forms.Button();
            this.picboxBefore = new System.Windows.Forms.PictureBox();
            this.tabExtract = new System.Windows.Forms.TabPage();
            this.btnFile2 = new System.Windows.Forms.Button();
            this.textExtract = new System.Windows.Forms.TextBox();
            this.btnExtract = new System.Windows.Forms.Button();
            this.picboxExtract = new System.Windows.Forms.PictureBox();
            this.tab_menu.SuspendLayout();
            this.tabHidden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAfter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxBefore)).BeginInit();
            this.tabExtract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxExtract)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_menu
            // 
            this.tab_menu.Controls.Add(this.tabHidden);
            this.tab_menu.Controls.Add(this.tabExtract);
            this.tab_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_menu.Location = new System.Drawing.Point(-1, 0);
            this.tab_menu.Name = "tab_menu";
            this.tab_menu.SelectedIndex = 0;
            this.tab_menu.Size = new System.Drawing.Size(524, 451);
            this.tab_menu.TabIndex = 0;
            // 
            // tabHidden
            // 
            this.tabHidden.BackColor = System.Drawing.Color.Lavender;
            this.tabHidden.Controls.Add(this.btnCleartext);
            this.tabHidden.Controls.Add(this.btnSave);
            this.tabHidden.Controls.Add(this.btnHide);
            this.tabHidden.Controls.Add(this.picboxAfter);
            this.tabHidden.Controls.Add(this.textHide);
            this.tabHidden.Controls.Add(this.btnFile);
            this.tabHidden.Controls.Add(this.picboxBefore);
            this.tabHidden.Location = new System.Drawing.Point(4, 22);
            this.tabHidden.Name = "tabHidden";
            this.tabHidden.Padding = new System.Windows.Forms.Padding(3);
            this.tabHidden.Size = new System.Drawing.Size(516, 425);
            this.tabHidden.TabIndex = 0;
            this.tabHidden.Text = "Hidden";
            // 
            // btnCleartext
            // 
            this.btnCleartext.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCleartext.Location = new System.Drawing.Point(373, 276);
            this.btnCleartext.Name = "btnCleartext";
            this.btnCleartext.Size = new System.Drawing.Size(101, 50);
            this.btnCleartext.TabIndex = 7;
            this.btnCleartext.Text = "Clear text";
            this.btnCleartext.UseVisualStyleBackColor = true;
            this.btnCleartext.Click += new System.EventHandler(this.btnCleartext_Click);
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(373, 344);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 50);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnHide
            // 
            this.btnHide.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHide.Location = new System.Drawing.Point(144, 344);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(101, 50);
            this.btnHide.TabIndex = 4;
            this.btnHide.Text = "Hide text";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // picboxAfter
            // 
            this.picboxAfter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picboxAfter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picboxAfter.Location = new System.Drawing.Point(262, 31);
            this.picboxAfter.Name = "picboxAfter";
            this.picboxAfter.Size = new System.Drawing.Size(221, 179);
            this.picboxAfter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxAfter.TabIndex = 3;
            this.picboxAfter.TabStop = false;
            this.picboxAfter.Paint += new System.Windows.Forms.PaintEventHandler(this.picboxAfter_Paint);
            // 
            // textHide
            // 
            this.textHide.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textHide.Location = new System.Drawing.Point(24, 276);
            this.textHide.Multiline = true;
            this.textHide.Name = "textHide";
            this.textHide.Size = new System.Drawing.Size(325, 53);
            this.textHide.TabIndex = 2;
            this.textHide.Text = "Text will be hidden ...";
            // 
            // btnFile
            // 
            this.btnFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFile.Location = new System.Drawing.Point(24, 344);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(89, 50);
            this.btnFile.TabIndex = 1;
            this.btnFile.Text = "Load Image";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // picboxBefore
            // 
            this.picboxBefore.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picboxBefore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picboxBefore.Location = new System.Drawing.Point(24, 31);
            this.picboxBefore.Name = "picboxBefore";
            this.picboxBefore.Size = new System.Drawing.Size(221, 179);
            this.picboxBefore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxBefore.TabIndex = 0;
            this.picboxBefore.TabStop = false;
            this.picboxBefore.Click += new System.EventHandler(this.picboxBefore_Click);
            this.picboxBefore.Paint += new System.Windows.Forms.PaintEventHandler(this.picboxBefore_Paint);
            // 
            // tabExtract
            // 
            this.tabExtract.BackColor = System.Drawing.Color.Lavender;
            this.tabExtract.Controls.Add(this.btnFile2);
            this.tabExtract.Controls.Add(this.textExtract);
            this.tabExtract.Controls.Add(this.btnExtract);
            this.tabExtract.Controls.Add(this.picboxExtract);
            this.tabExtract.Location = new System.Drawing.Point(4, 22);
            this.tabExtract.Name = "tabExtract";
            this.tabExtract.Padding = new System.Windows.Forms.Padding(3);
            this.tabExtract.Size = new System.Drawing.Size(516, 425);
            this.tabExtract.TabIndex = 1;
            this.tabExtract.Text = "Extract";
            // 
            // btnFile2
            // 
            this.btnFile2.Location = new System.Drawing.Point(80, 233);
            this.btnFile2.Name = "btnFile2";
            this.btnFile2.Size = new System.Drawing.Size(119, 34);
            this.btnFile2.TabIndex = 3;
            this.btnFile2.Text = "Load image";
            this.btnFile2.UseVisualStyleBackColor = true;
            this.btnFile2.Click += new System.EventHandler(this.btnFile2_Click);
            // 
            // textExtract
            // 
            this.textExtract.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textExtract.Enabled = false;
            this.textExtract.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textExtract.Location = new System.Drawing.Point(80, 303);
            this.textExtract.Multiline = true;
            this.textExtract.Name = "textExtract";
            this.textExtract.Size = new System.Drawing.Size(320, 71);
            this.textExtract.TabIndex = 2;
            this.textExtract.Text = "Text export..";
            // 
            // btnExtract
            // 
            this.btnExtract.Location = new System.Drawing.Point(218, 233);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(182, 34);
            this.btnExtract.TabIndex = 1;
            this.btnExtract.Text = "Extract";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // picboxExtract
            // 
            this.picboxExtract.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picboxExtract.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picboxExtract.Location = new System.Drawing.Point(80, 15);
            this.picboxExtract.Name = "picboxExtract";
            this.picboxExtract.Size = new System.Drawing.Size(320, 204);
            this.picboxExtract.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxExtract.TabIndex = 0;
            this.picboxExtract.TabStop = false;
            this.picboxExtract.Click += new System.EventHandler(this.picboxExtract_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 448);
            this.Controls.Add(this.tab_menu);
            this.Name = "Form1";
            this.Text = "LSPApp -N14DCAT082";
            this.tab_menu.ResumeLayout(false);
            this.tabHidden.ResumeLayout(false);
            this.tabHidden.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAfter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxBefore)).EndInit();
            this.tabExtract.ResumeLayout(false);
            this.tabExtract.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxExtract)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_menu;
        private System.Windows.Forms.TabPage tabHidden;
        private System.Windows.Forms.TabPage tabExtract;
        private System.Windows.Forms.Button btnCleartext;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.PictureBox picboxAfter;
        private System.Windows.Forms.TextBox textHide;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.PictureBox picboxBefore;
        private System.Windows.Forms.TextBox textExtract;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.PictureBox picboxExtract;
        private System.Windows.Forms.Button btnFile2;
    }
}

