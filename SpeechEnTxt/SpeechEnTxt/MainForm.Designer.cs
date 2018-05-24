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
            this.SuspendLayout();
            // 
            // CtrBoard
            // 
            this.CtrBoard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CtrBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CtrBoard.Location = new System.Drawing.Point(12, 211);
            this.CtrBoard.Name = "CtrBoard";
            this.CtrBoard.Size = new System.Drawing.Size(510, 189);
            this.CtrBoard.TabIndex = 0;
            // 
            // rcReadingContents
            // 
            this.rcReadingContents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rcReadingContents.Location = new System.Drawing.Point(12, 12);
            this.rcReadingContents.Name = "rcReadingContents";
            this.rcReadingContents.Size = new System.Drawing.Size(512, 193);
            this.rcReadingContents.TabIndex = 1;
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 412);
            this.Controls.Add(this.rcReadingContents);
            this.Controls.Add(this.CtrBoard);
            this.Name = "frmMainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ControlBoard CtrBoard;
        private UserControls.ReadContents rcReadingContents;
    }
}

