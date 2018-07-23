namespace GameOfLife
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.picBxMain = new System.Windows.Forms.PictureBox();
            this.nextGenTimer = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblTimerInterval = new System.Windows.Forms.Label();
            this.mTbxInterval = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(630, 450);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // picBxMain
            // 
            this.picBxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBxMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBxMain.Location = new System.Drawing.Point(12, 12);
            this.picBxMain.Name = "picBxMain";
            this.picBxMain.Size = new System.Drawing.Size(775, 432);
            this.picBxMain.TabIndex = 1;
            this.picBxMain.TabStop = false;
            // 
            // nextGenTimer
            // 
            this.nextGenTimer.Interval = 50;
            this.nextGenTimer.Tick += new System.EventHandler(this.NextGenTImer_Tick);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(712, 450);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.Btn_Stop_Click);
            // 
            // lblAge
            // 
            this.lblAge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(12, 450);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(38, 13);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "Age: 0";
            // 
            // lblTimerInterval
            // 
            this.lblTimerInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimerInterval.AutoSize = true;
            this.lblTimerInterval.Location = new System.Drawing.Point(506, 455);
            this.lblTimerInterval.Name = "lblTimerInterval";
            this.lblTimerInterval.Size = new System.Drawing.Size(71, 13);
            this.lblTimerInterval.TabIndex = 5;
            this.lblTimerInterval.Text = "Timer Interval";
            // 
            // mTbxInterval
            // 
            this.mTbxInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mTbxInterval.HidePromptOnLeave = true;
            this.mTbxInterval.Location = new System.Drawing.Point(583, 452);
            this.mTbxInterval.Mask = "0000";
            this.mTbxInterval.Name = "mTbxInterval";
            this.mTbxInterval.PromptChar = '-';
            this.mTbxInterval.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mTbxInterval.Size = new System.Drawing.Size(41, 20);
            this.mTbxInterval.TabIndex = 6;
            this.mTbxInterval.Text = "200";
            this.mTbxInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mTbxInterval.ValidatingType = typeof(int);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 485);
            this.Controls.Add(this.mTbxInterval);
            this.Controls.Add(this.lblTimerInterval);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.picBxMain);
            this.Controls.Add(this.btnStart);
            this.Name = "Main";
            this.Text = "Game Of Life";
            ((System.ComponentModel.ISupportInitialize)(this.picBxMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox picBxMain;
        private System.Windows.Forms.Timer nextGenTimer;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblTimerInterval;
        private System.Windows.Forms.MaskedTextBox mTbxInterval;
    }
}

