namespace Football_Pentalty_Shootout_Game_MOO_ICT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblScore = new Label();
            lblMissed = new Label();
            left = new PictureBox();
            right = new PictureBox();
            topLeft = new PictureBox();
            top = new PictureBox();
            topRight = new PictureBox();
            goalKeeper = new PictureBox();
            football = new PictureBox();
            KeeperTimer = new System.Windows.Forms.Timer(components);
            BallTimer = new System.Windows.Forms.Timer(components);
            Box_seuTime = new PictureBox();
            Label_time = new Label();
            checkPenalt1 = new PictureBox();
            checkPenalt2 = new PictureBox();
            checkPenalt3 = new PictureBox();
            checkPenalt4 = new PictureBox();
            checkPenalt5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)left).BeginInit();
            ((System.ComponentModel.ISupportInitialize)right).BeginInit();
            ((System.ComponentModel.ISupportInitialize)topLeft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)top).BeginInit();
            ((System.ComponentModel.ISupportInitialize)topRight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)goalKeeper).BeginInit();
            ((System.ComponentModel.ISupportInitialize)football).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Box_seuTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)checkPenalt1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)checkPenalt2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)checkPenalt3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)checkPenalt4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)checkPenalt5).BeginInit();
            SuspendLayout();
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.BackColor = Color.Transparent;
            lblScore.Font = new Font("Bahnschrift SemiBold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScore.ForeColor = Color.White;
            lblScore.Location = new Point(12, 81);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(104, 35);
            lblScore.TabIndex = 0;
            lblScore.Text = "Gols: 0";
            lblScore.Visible = false;
            // 
            // lblMissed
            // 
            lblMissed.AutoSize = true;
            lblMissed.BackColor = Color.Transparent;
            lblMissed.Font = new Font("Bahnschrift SemiBold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMissed.ForeColor = Color.White;
            lblMissed.Location = new Point(12, 116);
            lblMissed.Name = "lblMissed";
            lblMissed.Size = new Size(118, 35);
            lblMissed.TabIndex = 1;
            lblMissed.Text = "Erros: 0";
            lblMissed.Visible = false;
            // 
            // left
            // 
            left.BackColor = Color.Transparent;
            left.Cursor = Cursors.Cross;
            left.Image = Properties.Resources.target;
            left.Location = new Point(201, 238);
            left.Name = "left";
            left.Size = new Size(40, 40);
            left.SizeMode = PictureBoxSizeMode.StretchImage;
            left.TabIndex = 2;
            left.TabStop = false;
            left.Tag = "left";
            left.Click += SetGoalTargetEvent;
            // 
            // right
            // 
            right.BackColor = Color.Transparent;
            right.Cursor = Cursors.Cross;
            right.Image = Properties.Resources.target;
            right.Location = new Point(675, 238);
            right.Name = "right";
            right.Size = new Size(40, 40);
            right.SizeMode = PictureBoxSizeMode.StretchImage;
            right.TabIndex = 3;
            right.TabStop = false;
            right.Tag = "right";
            right.Click += SetGoalTargetEvent;
            // 
            // topLeft
            // 
            topLeft.BackColor = Color.Transparent;
            topLeft.Cursor = Cursors.Cross;
            topLeft.Image = Properties.Resources.target;
            topLeft.Location = new Point(201, 78);
            topLeft.Name = "topLeft";
            topLeft.Size = new Size(40, 40);
            topLeft.SizeMode = PictureBoxSizeMode.StretchImage;
            topLeft.TabIndex = 4;
            topLeft.TabStop = false;
            topLeft.Tag = "topLeft";
            topLeft.Click += SetGoalTargetEvent;
            // 
            // top
            // 
            top.BackColor = Color.Transparent;
            top.Cursor = Cursors.Cross;
            top.Image = Properties.Resources.target;
            top.Location = new Point(437, 76);
            top.Name = "top";
            top.Size = new Size(40, 40);
            top.SizeMode = PictureBoxSizeMode.StretchImage;
            top.TabIndex = 5;
            top.TabStop = false;
            top.Tag = "top";
            top.Click += SetGoalTargetEvent;
            // 
            // topRight
            // 
            topRight.BackColor = Color.Transparent;
            topRight.Cursor = Cursors.Cross;
            topRight.Image = Properties.Resources.target;
            topRight.Location = new Point(675, 76);
            topRight.Name = "topRight";
            topRight.Size = new Size(40, 40);
            topRight.SizeMode = PictureBoxSizeMode.StretchImage;
            topRight.TabIndex = 6;
            topRight.TabStop = false;
            topRight.Tag = "topRight";
            topRight.Click += SetGoalTargetEvent;
            // 
            // goalKeeper
            // 
            goalKeeper.BackColor = Color.Transparent;
            goalKeeper.Image = Properties.Resources.stand_small;
            goalKeeper.Location = new Point(414, 169);
            goalKeeper.Name = "goalKeeper";
            goalKeeper.Size = new Size(82, 126);
            goalKeeper.SizeMode = PictureBoxSizeMode.AutoSize;
            goalKeeper.TabIndex = 7;
            goalKeeper.TabStop = false;
            // 
            // football
            // 
            football.BackColor = Color.Transparent;
            football.Image = Properties.Resources.football;
            football.Location = new Point(430, 500);
            football.Name = "football";
            football.Size = new Size(50, 51);
            football.SizeMode = PictureBoxSizeMode.AutoSize;
            football.TabIndex = 8;
            football.TabStop = false;
            // 
            // KeeperTimer
            // 
            KeeperTimer.Interval = 20;
            KeeperTimer.Tick += KeeperTimerEvent;
            // 
            // BallTimer
            // 
            BallTimer.Interval = 20;
            BallTimer.Tick += BallTimerEvent;
            // 
            // Box_seuTime
            // 
            Box_seuTime.BackColor = Color.Transparent;
            Box_seuTime.Location = new Point(3, 619);
            Box_seuTime.Name = "Box_seuTime";
            Box_seuTime.Size = new Size(62, 56);
            Box_seuTime.SizeMode = PictureBoxSizeMode.Zoom;
            Box_seuTime.TabIndex = 9;
            Box_seuTime.TabStop = false;
            // 
            // Label_time
            // 
            Label_time.AutoSize = true;
            Label_time.BackColor = Color.Transparent;
            Label_time.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_time.Location = new Point(71, 640);
            Label_time.Name = "Label_time";
            Label_time.Size = new Size(0, 18);
            Label_time.TabIndex = 10;
            // 
            // checkPenalt1
            // 
            checkPenalt1.BackColor = Color.Transparent;
            checkPenalt1.Image = Properties.Resources.football;
            checkPenalt1.Location = new Point(12, 12);
            checkPenalt1.Name = "checkPenalt1";
            checkPenalt1.Size = new Size(50, 50);
            checkPenalt1.SizeMode = PictureBoxSizeMode.Zoom;
            checkPenalt1.TabIndex = 11;
            checkPenalt1.TabStop = false;
            // 
            // checkPenalt2
            // 
            checkPenalt2.BackColor = Color.Transparent;
            checkPenalt2.Image = Properties.Resources.football;
            checkPenalt2.Location = new Point(71, 12);
            checkPenalt2.Name = "checkPenalt2";
            checkPenalt2.Size = new Size(50, 50);
            checkPenalt2.SizeMode = PictureBoxSizeMode.Zoom;
            checkPenalt2.TabIndex = 12;
            checkPenalt2.TabStop = false;
            // 
            // checkPenalt3
            // 
            checkPenalt3.BackColor = Color.Transparent;
            checkPenalt3.Image = Properties.Resources.football;
            checkPenalt3.Location = new Point(127, 12);
            checkPenalt3.Name = "checkPenalt3";
            checkPenalt3.Size = new Size(50, 50);
            checkPenalt3.SizeMode = PictureBoxSizeMode.Zoom;
            checkPenalt3.TabIndex = 13;
            checkPenalt3.TabStop = false;
            // 
            // checkPenalt4
            // 
            checkPenalt4.BackColor = Color.Transparent;
            checkPenalt4.Image = Properties.Resources.football;
            checkPenalt4.Location = new Point(183, 12);
            checkPenalt4.Name = "checkPenalt4";
            checkPenalt4.Size = new Size(50, 50);
            checkPenalt4.SizeMode = PictureBoxSizeMode.Zoom;
            checkPenalt4.TabIndex = 14;
            checkPenalt4.TabStop = false;
            // 
            // checkPenalt5
            // 
            checkPenalt5.BackColor = Color.Transparent;
            checkPenalt5.Image = Properties.Resources.football;
            checkPenalt5.Location = new Point(239, 12);
            checkPenalt5.Name = "checkPenalt5";
            checkPenalt5.Size = new Size(50, 50);
            checkPenalt5.SizeMode = PictureBoxSizeMode.Zoom;
            checkPenalt5.TabIndex = 15;
            checkPenalt5.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(899, 678);
            Controls.Add(checkPenalt5);
            Controls.Add(checkPenalt4);
            Controls.Add(checkPenalt3);
            Controls.Add(checkPenalt2);
            Controls.Add(checkPenalt1);
            Controls.Add(Label_time);
            Controls.Add(Box_seuTime);
            Controls.Add(football);
            Controls.Add(goalKeeper);
            Controls.Add(topRight);
            Controls.Add(top);
            Controls.Add(topLeft);
            Controls.Add(right);
            Controls.Add(left);
            Controls.Add(lblMissed);
            Controls.Add(lblScore);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Football Penalty Shootout Game MOOICT";
            ((System.ComponentModel.ISupportInitialize)left).EndInit();
            ((System.ComponentModel.ISupportInitialize)right).EndInit();
            ((System.ComponentModel.ISupportInitialize)topLeft).EndInit();
            ((System.ComponentModel.ISupportInitialize)top).EndInit();
            ((System.ComponentModel.ISupportInitialize)topRight).EndInit();
            ((System.ComponentModel.ISupportInitialize)goalKeeper).EndInit();
            ((System.ComponentModel.ISupportInitialize)football).EndInit();
            ((System.ComponentModel.ISupportInitialize)Box_seuTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)checkPenalt1).EndInit();
            ((System.ComponentModel.ISupportInitialize)checkPenalt2).EndInit();
            ((System.ComponentModel.ISupportInitialize)checkPenalt3).EndInit();
            ((System.ComponentModel.ISupportInitialize)checkPenalt4).EndInit();
            ((System.ComponentModel.ISupportInitialize)checkPenalt5).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label lblScore;
        private Label lblMissed;
        private PictureBox left;
        private PictureBox right;
        private PictureBox topLeft;
        private PictureBox top;
        private PictureBox topRight;
        private PictureBox goalKeeper;
        private PictureBox football;
        private System.Windows.Forms.Timer KeeperTimer;
        private System.Windows.Forms.Timer BallTimer;
        private PictureBox Box_seuTime;
        private Label Label_time;
        private PictureBox checkPenalt1;
        private PictureBox checkPenalt2;
        private PictureBox checkPenalt3;
        private PictureBox checkPenalt4;
        private PictureBox checkPenalt5;
    }
}