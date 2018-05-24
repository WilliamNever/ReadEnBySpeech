namespace SpeechEnTxt.UserControls
{
    partial class ControlBoard
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbVoices = new System.Windows.Forms.ComboBox();
            this.cbkRead = new System.Windows.Forms.CheckBox();
            this.cbkRecord = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.tbVolume = new System.Windows.Forms.TrackBar();
            this.lbVolume = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ToolTipInfor = new System.Windows.Forms.ToolTip(this.components);
            this.lnkPath = new System.Windows.Forms.LinkLabel();
            this.txtInterval = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voices:";
            // 
            // cmbVoices
            // 
            this.cmbVoices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbVoices.BackColor = System.Drawing.SystemColors.Window;
            this.cmbVoices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoices.FormattingEnabled = true;
            this.cmbVoices.Location = new System.Drawing.Point(58, 6);
            this.cmbVoices.Name = "cmbVoices";
            this.cmbVoices.Size = new System.Drawing.Size(361, 21);
            this.cmbVoices.TabIndex = 1;
            // 
            // cbkRead
            // 
            this.cbkRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbkRead.AutoSize = true;
            this.cbkRead.Checked = true;
            this.cbkRead.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbkRead.Location = new System.Drawing.Point(436, 8);
            this.cbkRead.Name = "cbkRead";
            this.cbkRead.Size = new System.Drawing.Size(52, 17);
            this.cbkRead.TabIndex = 2;
            this.cbkRead.Text = "Read";
            this.cbkRead.UseVisualStyleBackColor = true;
            // 
            // cbkRecord
            // 
            this.cbkRecord.AutoSize = true;
            this.cbkRecord.Location = new System.Drawing.Point(16, 131);
            this.cbkRecord.Name = "cbkRecord";
            this.cbkRecord.Size = new System.Drawing.Size(61, 17);
            this.cbkRecord.TabIndex = 3;
            this.cbkRecord.Text = "Record";
            this.cbkRecord.UseVisualStyleBackColor = true;
            this.cbkRecord.CheckedChanged += new System.EventHandler(this.cbkRecord_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Speed:";
            // 
            // tbSpeed
            // 
            this.tbSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSpeed.LargeChange = 2;
            this.tbSpeed.Location = new System.Drawing.Point(58, 39);
            this.tbSpeed.Minimum = -10;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(386, 45);
            this.tbSpeed.TabIndex = 5;
            this.tbSpeed.Scroll += new System.EventHandler(this.tbSpeedAndVolume_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Volume:";
            // 
            // tbVolume
            // 
            this.tbVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbVolume.LargeChange = 10;
            this.tbVolume.Location = new System.Drawing.Point(58, 83);
            this.tbVolume.Maximum = 100;
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(386, 45);
            this.tbVolume.TabIndex = 7;
            this.tbVolume.TickFrequency = 10;
            this.tbVolume.Value = 60;
            this.tbVolume.Scroll += new System.EventHandler(this.tbSpeedAndVolume_Scroll);
            // 
            // lbVolume
            // 
            this.lbVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbVolume.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lbVolume.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbVolume.Location = new System.Drawing.Point(445, 81);
            this.lbVolume.Name = "lbVolume";
            this.lbVolume.Padding = new System.Windows.Forms.Padding(5);
            this.lbVolume.Size = new System.Drawing.Size(43, 26);
            this.lbVolume.TabIndex = 9;
            this.lbVolume.Text = "Vol";
            this.lbVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSpeed
            // 
            this.lblSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpeed.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblSpeed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSpeed.Location = new System.Drawing.Point(445, 36);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Padding = new System.Windows.Forms.Padding(5);
            this.lblSpeed.Size = new System.Drawing.Size(43, 26);
            this.lblSpeed.TabIndex = 10;
            this.lblSpeed.Text = "Sp";
            this.lblSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(12, 158);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 11;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(107, 158);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 12;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(202, 158);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 13;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 14;
            this.label4.Tag = "";
            this.label4.Text = "Word Interval:";
            this.ToolTipInfor.SetToolTip(this.label4, "Millisecond=(1/1000)Second");
            // 
            // ToolTipInfor
            // 
            this.ToolTipInfor.ToolTipTitle = "tips:";
            // 
            // lnkPath
            // 
            this.lnkPath.Enabled = false;
            this.lnkPath.Location = new System.Drawing.Point(77, 126);
            this.lnkPath.Name = "lnkPath";
            this.lnkPath.Size = new System.Drawing.Size(411, 23);
            this.lnkPath.TabIndex = 16;
            this.lnkPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTipInfor.SetToolTip(this.lnkPath, "The path of Saved File ");
            this.lnkPath.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPath_LinkClicked);
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(415, 159);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(73, 20);
            this.txtInterval.TabIndex = 17;
            this.txtInterval.Text = "0";
            this.txtInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToolTipInfor.SetToolTip(this.txtInterval, "Millisecond=(1/1000)Second");
            // 
            // ControlBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txtInterval);
            this.Controls.Add(this.lnkPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lbVolume);
            this.Controls.Add(this.tbVolume);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbkRecord);
            this.Controls.Add(this.cbkRead);
            this.Controls.Add(this.cmbVoices);
            this.Controls.Add(this.label1);
            this.Name = "ControlBoard";
            this.Size = new System.Drawing.Size(500, 191);
            this.Load += new System.EventHandler(this.ControlBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbVoices;
        private System.Windows.Forms.CheckBox cbkRead;
        private System.Windows.Forms.CheckBox cbkRecord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tbSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tbVolume;
        private System.Windows.Forms.Label lbVolume;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip ToolTipInfor;
        private System.Windows.Forms.LinkLabel lnkPath;
        private System.Windows.Forms.TextBox txtInterval;
    }
}
