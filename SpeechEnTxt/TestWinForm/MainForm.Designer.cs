
namespace TestWinForm
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
            this.wbBrwser = new System.Windows.Forms.WebBrowser();
            this.btnFuncTest1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wbBrwser
            // 
            this.wbBrwser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wbBrwser.Location = new System.Drawing.Point(12, 12);
            this.wbBrwser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrwser.Name = "wbBrwser";
            this.wbBrwser.Size = new System.Drawing.Size(776, 276);
            this.wbBrwser.TabIndex = 0;
            // 
            // btnFuncTest1
            // 
            this.btnFuncTest1.Location = new System.Drawing.Point(12, 303);
            this.btnFuncTest1.Name = "btnFuncTest1";
            this.btnFuncTest1.Size = new System.Drawing.Size(75, 23);
            this.btnFuncTest1.TabIndex = 1;
            this.btnFuncTest1.Text = "test";
            this.btnFuncTest1.UseVisualStyleBackColor = true;
            this.btnFuncTest1.Click += new System.EventHandler(this.btnFuncTest1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFuncTest1);
            this.Controls.Add(this.wbBrwser);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbBrwser;
        private System.Windows.Forms.Button btnFuncTest1;
    }
}

