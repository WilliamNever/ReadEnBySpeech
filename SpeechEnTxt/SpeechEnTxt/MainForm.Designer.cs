namespace SpeechEnTxt
{
    partial class frmMainForm
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
            this.CtrBoard = new SpeechEnTxt.UserControls.ControlBoard();
            this.rcReadingContents = new SpeechEnTxt.UserControls.ReadContents();
            this.stbar = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.stbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // CtrBoard
            // 
            this.CtrBoard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CtrBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CtrBoard.Location = new System.Drawing.Point(12, 242);
            this.CtrBoard.Name = "CtrBoard";
            this.CtrBoard.Size = new System.Drawing.Size(580, 226);
            this.CtrBoard.TabIndex = 0;
            // 
            // rcReadingContents
            // 
            this.rcReadingContents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rcReadingContents.Location = new System.Drawing.Point(12, 5);
            this.rcReadingContents.Name = "rcReadingContents";
            this.rcReadingContents.Size = new System.Drawing.Size(580, 231);
            this.rcReadingContents.TabIndex = 1;
            // 
            // stbar
            // 
            this.stbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.stbar.Location = new System.Drawing.Point(0, 484);
            this.stbar.Name = "stbar";
            this.stbar.Size = new System.Drawing.Size(604, 22);
            this.stbar.TabIndex = 2;
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 17);
            this.lblStatus.Text = "Welcome!";
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 506);
            this.Controls.Add(this.stbar);
            this.Controls.Add(this.rcReadingContents);
            this.Controls.Add(this.CtrBoard);
            this.MinimumSize = new System.Drawing.Size(620, 545);
            this.Name = "frmMainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainForm_FormClosing);
            this.stbar.ResumeLayout(false);
            this.stbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.ControlBoard CtrBoard;
        private UserControls.ReadContents rcReadingContents;
        private System.Windows.Forms.StatusStrip stbar;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}

