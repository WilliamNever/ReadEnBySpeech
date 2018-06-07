namespace SpeechEnTxt.UserControls
{
    partial class ReadContents
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabReadContents = new System.Windows.Forms.TabControl();
            this.tpWords = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtInfors = new System.Windows.Forms.TextBox();
            this.tpFile = new System.Windows.Forms.TabPage();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.tabReadContents.SuspendLayout();
            this.tpWords.SuspendLayout();
            this.tpFile.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabReadContents
            // 
            this.tabReadContents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabReadContents.Controls.Add(this.tpWords);
            this.tabReadContents.Controls.Add(this.tpFile);
            this.tabReadContents.Location = new System.Drawing.Point(3, 3);
            this.tabReadContents.Name = "tabReadContents";
            this.tabReadContents.SelectedIndex = 0;
            this.tabReadContents.Size = new System.Drawing.Size(444, 244);
            this.tabReadContents.TabIndex = 2;
            // 
            // tpWords
            // 
            this.tpWords.Controls.Add(this.btnHelp);
            this.tpWords.Controls.Add(this.btnClear);
            this.tpWords.Controls.Add(this.txtInfors);
            this.tpWords.Location = new System.Drawing.Point(4, 22);
            this.tpWords.Name = "tpWords";
            this.tpWords.Padding = new System.Windows.Forms.Padding(3);
            this.tpWords.Size = new System.Drawing.Size(436, 218);
            this.tpWords.TabIndex = 0;
            this.tpWords.Text = "ReadWords";
            this.tpWords.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.Location = new System.Drawing.Point(3, 189);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtInfors
            // 
            this.txtInfors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInfors.Location = new System.Drawing.Point(3, 3);
            this.txtInfors.Multiline = true;
            this.txtInfors.Name = "txtInfors";
            this.txtInfors.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInfors.Size = new System.Drawing.Size(430, 180);
            this.txtInfors.TabIndex = 0;
            // 
            // tpFile
            // 
            this.tpFile.Controls.Add(this.btnBrowse);
            this.tpFile.Controls.Add(this.txtFilePath);
            this.tpFile.Controls.Add(this.label1);
            this.tpFile.Location = new System.Drawing.Point(4, 22);
            this.tpFile.Name = "tpFile";
            this.tpFile.Padding = new System.Windows.Forms.Padding(3);
            this.tpFile.Size = new System.Drawing.Size(436, 218);
            this.tpFile.TabIndex = 1;
            this.tpFile.Text = "ReadFile";
            this.tpFile.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(352, 5);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Pick File";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilePath.BackColor = System.Drawing.SystemColors.Window;
            this.txtFilePath.Location = new System.Drawing.Point(39, 7);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(306, 20);
            this.txtFilePath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabReadContents);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 250);
            this.panel1.TabIndex = 3;
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelp.Location = new System.Drawing.Point(358, 189);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 2;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // ReadContents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ReadContents";
            this.Size = new System.Drawing.Size(450, 250);
            this.tabReadContents.ResumeLayout(false);
            this.tpWords.ResumeLayout(false);
            this.tpWords.PerformLayout();
            this.tpFile.ResumeLayout(false);
            this.tpFile.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabReadContents;
        private System.Windows.Forms.TabPage tpWords;
        private System.Windows.Forms.TabPage tpFile;
        private System.Windows.Forms.TextBox txtInfors;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnHelp;
    }
}
