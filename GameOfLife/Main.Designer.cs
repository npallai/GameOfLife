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
            this.nextGenTimer = new System.Windows.Forms.Timer(this.components);
            this.lblAge = new System.Windows.Forms.Label();
            this.lblTimerInterval = new System.Windows.Forms.Label();
            this.mTbxInterval = new System.Windows.Forms.MaskedTextBox();
            this.picBxMain = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // nextGenTimer
            // 
            this.nextGenTimer.Interval = 50;
            this.nextGenTimer.Tick += new System.EventHandler(this.NextGenTimer_Tick);
            // 
            // lblAge
            // 
            this.lblAge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(12, 456);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(38, 13);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "Age: 0";
            // 
            // lblTimerInterval
            // 
            this.lblTimerInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimerInterval.AutoSize = true;
            this.lblTimerInterval.Location = new System.Drawing.Point(669, 456);
            this.lblTimerInterval.Name = "lblTimerInterval";
            this.lblTimerInterval.Size = new System.Drawing.Size(71, 13);
            this.lblTimerInterval.TabIndex = 5;
            this.lblTimerInterval.Text = "Timer Interval";
            // 
            // mTbxInterval
            // 
            this.mTbxInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mTbxInterval.HidePromptOnLeave = true;
            this.mTbxInterval.Location = new System.Drawing.Point(746, 453);
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
            this.picBxMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picBxMain_MouseClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Click Surface to Start and Stop";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Arrow Keys to Move";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 485);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mTbxInterval);
            this.Controls.Add(this.lblTimerInterval);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.picBxMain);
            this.KeyPreview = true;
            this.Name = "Main";
            this.Text = "Game Of Life";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picBxMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer nextGenTimer;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblTimerInterval;
        private System.Windows.Forms.MaskedTextBox mTbxInterval;
        private System.Windows.Forms.PictureBox picBxMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

