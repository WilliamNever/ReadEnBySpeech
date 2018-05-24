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
            this.tpFile = new System.Windows.Forms.TabPage();
            this.txtInfors = new System.Windows.Forms.TextBox();
            this.tabReadContents.SuspendLayout();
            this.tpWords.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabReadContents
            // 
            this.tabReadContents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabReadContents.Controls.Add(this.tpWords);
            this.tabReadContents.Controls.Add(this.tpFile);
            this.tabReadContents.Location = new System.Drawing.Point(0, 0);
            this.tabReadContents.Name = "tabReadContents";
            this.tabReadContents.SelectedIndex = 0;
            this.tabReadContents.Size = new System.Drawing.Size(450, 250);
            this.tabReadContents.TabIndex = 2;
            // 
            // tpWords
            // 
            this.tpWords.Controls.Add(this.txtInfors);
            this.tpWords.Location = new System.Drawing.Point(4, 22);
            this.tpWords.Name = "tpWords";
            this.tpWords.Padding = new System.Windows.Forms.Padding(3);
            this.tpWords.Size = new System.Drawing.Size(442, 224);
            this.tpWords.TabIndex = 0;
            this.tpWords.Text = "ReadWords";
            this.tpWords.UseVisualStyleBackColor = true;
            // 
            // tpFile
            // 
            this.tpFile.Location = new System.Drawing.Point(4, 22);
            this.tpFile.Name = "tpFile";
            this.tpFile.Padding = new System.Windows.Forms.Padding(3);
            this.tpFile.Size = new System.Drawing.Size(502, 176);
            this.tpFile.TabIndex = 1;
            this.tpFile.Text = "ReadFile";
            this.tpFile.UseVisualStyleBackColor = true;
            // 
            // txtInfors
            // 
            this.txtInfors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInfors.Location = new System.Drawing.Point(3, 3);
            this.txtInfors.Multiline = true;
            this.txtInfors.Name = "txtInfors";
            this.txtInfors.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInfors.Size = new System.Drawing.Size(436, 218);
            this.txtInfors.TabIndex = 0;
            // 
            // ReadContents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabReadContents);
            this.Name = "ReadContents";
            this.Size = new System.Drawing.Size(450, 250);
            this.tabReadContents.ResumeLayout(false);
            this.tpWords.ResumeLayout(false);
            this.tpWords.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabReadContents;
        private System.Windows.Forms.TabPage tpWords;
        private System.Windows.Forms.TabPage tpFile;
        private System.Windows.Forms.TextBox txtInfors;
    }
}
