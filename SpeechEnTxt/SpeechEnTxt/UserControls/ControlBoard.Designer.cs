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
            this.ToolTipInfor = new System.Windows.Forms.ToolTip(this.components);
            this.lnkPath = new System.Windows.Forms.LinkLabel();
            this.rbtnWord = new System.Windows.Forms.RadioButton();
            this.rbtnLine = new System.Windows.Forms.RadioButton();
            this.grpReadMethod = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpPauseType = new System.Windows.Forms.GroupBox();
            this.cmbPauseType = new System.Windows.Forms.ComboBox();
            this.txtPauseTimes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            this.grpReadMethod.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpPauseType.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
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
            this.cmbVoices.Location = new System.Drawing.Point(60, 6);
            this.cmbVoices.Name = "cmbVoices";
            this.cmbVoices.Size = new System.Drawing.Size(437, 21);
            this.cmbVoices.TabIndex = 1;
            // 
            // cbkRead
            // 
            this.cbkRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbkRead.AutoSize = true;
            this.cbkRead.Checked = true;
            this.cbkRead.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbkRead.Location = new System.Drawing.Point(514, 8);
            this.cbkRead.Name = "cbkRead";
            this.cbkRead.Size = new System.Drawing.Size(52, 17);
            this.cbkRead.TabIndex = 2;
            this.cbkRead.Text = "Read";
            this.cbkRead.UseVisualStyleBackColor = true;
            // 
            // cbkRecord
            // 
            this.cbkRecord.AutoSize = true;
            this.cbkRecord.Location = new System.Drawing.Point(18, 96);
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
            this.label2.Location = new System.Drawing.Point(14, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Speed:";
            // 
            // tbSpeed
            // 
            this.tbSpeed.LargeChange = 2;
            this.tbSpeed.Location = new System.Drawing.Point(69, 39);
            this.tbSpeed.Minimum = -10;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(147, 45);
            this.tbSpeed.TabIndex = 5;
            this.tbSpeed.Scroll += new System.EventHandler(this.tbSpeedAndVolume_Scroll);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Volume:";
            // 
            // tbVolume
            // 
            this.tbVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbVolume.LargeChange = 10;
            this.tbVolume.Location = new System.Drawing.Point(346, 39);
            this.tbVolume.Maximum = 100;
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(162, 45);
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
            this.lbVolume.Location = new System.Drawing.Point(522, 39);
            this.lbVolume.Name = "lbVolume";
            this.lbVolume.Padding = new System.Windows.Forms.Padding(5);
            this.lbVolume.Size = new System.Drawing.Size(43, 26);
            this.lbVolume.TabIndex = 9;
            this.lbVolume.Text = "Vol";
            this.lbVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSpeed
            // 
            this.lblSpeed.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblSpeed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSpeed.Location = new System.Drawing.Point(230, 39);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Padding = new System.Windows.Forms.Padding(5);
            this.lblSpeed.Size = new System.Drawing.Size(43, 26);
            this.lblSpeed.TabIndex = 10;
            this.lblSpeed.Text = "Sp";
            this.lblSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRead
            // 
            this.btnRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRead.Location = new System.Drawing.Point(14, 179);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 11;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnPause
            // 
            this.btnPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPause.Location = new System.Drawing.Point(104, 179);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 12;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStop.Location = new System.Drawing.Point(194, 179);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 13;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // ToolTipInfor
            // 
            this.ToolTipInfor.ToolTipTitle = "tips:";
            // 
            // lnkPath
            // 
            this.lnkPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lnkPath.Enabled = false;
            this.lnkPath.Location = new System.Drawing.Point(79, 91);
            this.lnkPath.Name = "lnkPath";
            this.lnkPath.Size = new System.Drawing.Size(487, 23);
            this.lnkPath.TabIndex = 16;
            this.lnkPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTipInfor.SetToolTip(this.lnkPath, "The path of Saved File ");
            this.lnkPath.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPath_LinkClicked);
            // 
            // rbtnWord
            // 
            this.rbtnWord.AutoSize = true;
            this.rbtnWord.Location = new System.Drawing.Point(76, 30);
            this.rbtnWord.Name = "rbtnWord";
            this.rbtnWord.Size = new System.Drawing.Size(51, 17);
            this.rbtnWord.TabIndex = 17;
            this.rbtnWord.Text = "Word";
            this.rbtnWord.UseVisualStyleBackColor = true;
            // 
            // rbtnLine
            // 
            this.rbtnLine.AutoSize = true;
            this.rbtnLine.Checked = true;
            this.rbtnLine.Location = new System.Drawing.Point(8, 30);
            this.rbtnLine.Name = "rbtnLine";
            this.rbtnLine.Size = new System.Drawing.Size(45, 17);
            this.rbtnLine.TabIndex = 18;
            this.rbtnLine.TabStop = true;
            this.rbtnLine.Text = "Line";
            this.rbtnLine.UseVisualStyleBackColor = true;
            // 
            // grpReadMethod
            // 
            this.grpReadMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpReadMethod.Controls.Add(this.rbtnLine);
            this.grpReadMethod.Controls.Add(this.rbtnWord);
            this.grpReadMethod.Location = new System.Drawing.Point(284, 123);
            this.grpReadMethod.Name = "grpReadMethod";
            this.grpReadMethod.Size = new System.Drawing.Size(134, 79);
            this.grpReadMethod.TabIndex = 19;
            this.grpReadMethod.TabStop = false;
            this.grpReadMethod.Text = "Read Text By:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpPauseType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.grpReadMethod);
            this.panel1.Controls.Add(this.cmbVoices);
            this.panel1.Controls.Add(this.lnkPath);
            this.panel1.Controls.Add(this.cbkRead);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.cbkRecord);
            this.panel1.Controls.Add(this.btnPause);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnRead);
            this.panel1.Controls.Add(this.tbSpeed);
            this.panel1.Controls.Add(this.lblSpeed);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbVolume);
            this.panel1.Controls.Add(this.tbVolume);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 216);
            this.panel1.TabIndex = 20;
            // 
            // grpPauseType
            // 
            this.grpPauseType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPauseType.Controls.Add(this.label4);
            this.grpPauseType.Controls.Add(this.txtPauseTimes);
            this.grpPauseType.Controls.Add(this.cmbPauseType);
            this.grpPauseType.Location = new System.Drawing.Point(426, 123);
            this.grpPauseType.Name = "grpPauseType";
            this.grpPauseType.Size = new System.Drawing.Size(140, 79);
            this.grpPauseType.TabIndex = 20;
            this.grpPauseType.TabStop = false;
            this.grpPauseType.Text = "Pause Type:";
            // 
            // cmbPauseType
            // 
            this.cmbPauseType.BackColor = System.Drawing.SystemColors.Window;
            this.cmbPauseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPauseType.FormattingEnabled = true;
            this.cmbPauseType.Location = new System.Drawing.Point(6, 21);
            this.cmbPauseType.Name = "cmbPauseType";
            this.cmbPauseType.Size = new System.Drawing.Size(128, 21);
            this.cmbPauseType.TabIndex = 0;
            // 
            // txtPauseTimes
            // 
            this.txtPauseTimes.Location = new System.Drawing.Point(81, 52);
            this.txtPauseTimes.Name = "txtPauseTimes";
            this.txtPauseTimes.Size = new System.Drawing.Size(53, 20);
            this.txtPauseTimes.TabIndex = 1;
            this.txtPauseTimes.Text = "0";
            this.txtPauseTimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Pause Times:";
            // 
            // ControlBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Name = "ControlBoard";
            this.Size = new System.Drawing.Size(584, 216);
            this.Load += new System.EventHandler(this.ControlBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            this.grpReadMethod.ResumeLayout(false);
            this.grpReadMethod.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpPauseType.ResumeLayout(false);
            this.grpPauseType.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ToolTip ToolTipInfor;
        private System.Windows.Forms.LinkLabel lnkPath;
        private System.Windows.Forms.RadioButton rbtnWord;
        private System.Windows.Forms.RadioButton rbtnLine;
        private System.Windows.Forms.GroupBox grpReadMethod;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpPauseType;
        private System.Windows.Forms.ComboBox cmbPauseType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPauseTimes;
    }
}
