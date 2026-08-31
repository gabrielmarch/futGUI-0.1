namespace Football_Pentalty_Shootout_Game_MOO_ICT
{
    partial class FormResultado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResultado));
            logofut = new PictureBox();
            label1 = new Label();
            Box_seuTime = new PictureBox();
            lblMissed = new Label();
            lblScore = new Label();
            button_JogarDnv = new Button();
            button_VoltarMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)logofut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Box_seuTime).BeginInit();
            SuspendLayout();
            // 
            // logofut
            // 
            logofut.BackColor = Color.Transparent;
            logofut.Image = (Image)resources.GetObject("logofut.Image");
            logofut.Location = new Point(329, 44);
            logofut.Name = "logofut";
            logofut.Size = new Size(252, 235);
            logofut.SizeMode = PictureBoxSizeMode.Zoom;
            logofut.TabIndex = 1;
            logofut.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bahnschrift", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(347, 291);
            label1.Name = "label1";
            label1.Size = new Size(222, 42);
            label1.TabIndex = 2;
            label1.Text = "FIM DE JOGO";
            // 
            // Box_seuTime
            // 
            Box_seuTime.BackColor = Color.Transparent;
            Box_seuTime.Location = new Point(424, 348);
            Box_seuTime.Name = "Box_seuTime";
            Box_seuTime.Size = new Size(62, 56);
            Box_seuTime.SizeMode = PictureBoxSizeMode.Zoom;
            Box_seuTime.TabIndex = 10;
            Box_seuTime.TabStop = false;
            // 
            // lblMissed
            // 
            lblMissed.AutoSize = true;
            lblMissed.BackColor = Color.Transparent;
            lblMissed.Font = new Font("Bahnschrift SemiBold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMissed.ForeColor = Color.White;
            lblMissed.Location = new Point(396, 451);
            lblMissed.Name = "lblMissed";
            lblMissed.Size = new Size(118, 35);
            lblMissed.TabIndex = 12;
            lblMissed.Text = "Erros: 0";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.BackColor = Color.Transparent;
            lblScore.Font = new Font("Bahnschrift SemiBold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScore.ForeColor = Color.White;
            lblScore.Location = new Point(396, 416);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(104, 35);
            lblScore.TabIndex = 11;
            lblScore.Text = "Gols: 0";
            // 
            // button_JogarDnv
            // 
            button_JogarDnv.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_JogarDnv.Location = new Point(360, 499);
            button_JogarDnv.Name = "button_JogarDnv";
            button_JogarDnv.Size = new Size(191, 38);
            button_JogarDnv.TabIndex = 13;
            button_JogarDnv.Text = "JOGAR NOVAMENTE";
            button_JogarDnv.UseVisualStyleBackColor = true;
            button_JogarDnv.Click += button_JogarDnv_Click;
            // 
            // button_VoltarMenu
            // 
            button_VoltarMenu.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_VoltarMenu.Location = new Point(360, 561);
            button_VoltarMenu.Name = "button_VoltarMenu";
            button_VoltarMenu.Size = new Size(191, 38);
            button_VoltarMenu.TabIndex = 14;
            button_VoltarMenu.Text = "VOLTAR AO MENU";
            button_VoltarMenu.UseVisualStyleBackColor = true;
            button_VoltarMenu.Click += button_VoltarMenu_Click;
            // 
            // FormResultado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(899, 678);
            Controls.Add(button_VoltarMenu);
            Controls.Add(button_JogarDnv);
            Controls.Add(lblMissed);
            Controls.Add(lblScore);
            Controls.Add(Box_seuTime);
            Controls.Add(label1);
            Controls.Add(logofut);
            Name = "FormResultado";
            Text = "FormResultado";
            ((System.ComponentModel.ISupportInitialize)logofut).EndInit();
            ((System.ComponentModel.ISupportInitialize)Box_seuTime).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logofut;
        private Label label1;
        private PictureBox Box_seuTime;
        private Label lblMissed;
        private Label lblScore;
        private Button button_JogarDnv;
        private Button button_VoltarMenu;
    }
}