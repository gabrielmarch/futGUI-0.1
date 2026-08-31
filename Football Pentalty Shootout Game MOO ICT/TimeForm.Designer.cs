namespace Football_Pentalty_Shootout_Game_MOO_ICT
{
    partial class TimeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeForm));
            logofut = new PictureBox();
            label_escolhertime = new Label();
            escolher_timeBR = new PictureBox();
            escolher_timeAR = new PictureBox();
            Botao_voltarMenu = new Button();
            Botao_confirmarTime = new Button();
            ((System.ComponentModel.ISupportInitialize)logofut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)escolher_timeBR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)escolher_timeAR).BeginInit();
            SuspendLayout();
            // 
            // logofut
            // 
            logofut.BackColor = Color.Transparent;
            logofut.Image = (Image)resources.GetObject("logofut.Image");
            logofut.Location = new Point(276, 12);
            logofut.Name = "logofut";
            logofut.Size = new Size(358, 334);
            logofut.SizeMode = PictureBoxSizeMode.CenterImage;
            logofut.TabIndex = 1;
            logofut.TabStop = false;
            // 
            // label_escolhertime
            // 
            label_escolhertime.AutoSize = true;
            label_escolhertime.BackColor = Color.Transparent;
            label_escolhertime.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_escolhertime.ForeColor = Color.Black;
            label_escolhertime.Location = new Point(281, 366);
            label_escolhertime.Name = "label_escolhertime";
            label_escolhertime.Size = new Size(353, 38);
            label_escolhertime.TabIndex = 2;
            label_escolhertime.Text = "ESCOLHA UM TIME";
            // 
            // escolher_timeBR
            // 
            escolher_timeBR.BackColor = Color.Transparent;
            escolher_timeBR.Image = Properties.Resources.logobrasil1;
            escolher_timeBR.Location = new Point(242, 430);
            escolher_timeBR.Name = "escolher_timeBR";
            escolher_timeBR.Size = new Size(147, 155);
            escolher_timeBR.SizeMode = PictureBoxSizeMode.Zoom;
            escolher_timeBR.TabIndex = 3;
            escolher_timeBR.TabStop = false;
            escolher_timeBR.Click += escolher_timeBR_Click;
            // 
            // escolher_timeAR
            // 
            escolher_timeAR.BackColor = Color.Transparent;
            escolher_timeAR.Image = Properties.Resources.logoargentina;
            escolher_timeAR.Location = new Point(533, 430);
            escolher_timeAR.Name = "escolher_timeAR";
            escolher_timeAR.Size = new Size(147, 155);
            escolher_timeAR.SizeMode = PictureBoxSizeMode.Zoom;
            escolher_timeAR.TabIndex = 4;
            escolher_timeAR.TabStop = false;
            escolher_timeAR.Click += escolher_timeAR_Click;
            // 
            // Botao_voltarMenu
            // 
            Botao_voltarMenu.Cursor = Cursors.PanNW;
            Botao_voltarMenu.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Botao_voltarMenu.Location = new Point(98, 590);
            Botao_voltarMenu.Name = "Botao_voltarMenu";
            Botao_voltarMenu.Size = new Size(86, 30);
            Botao_voltarMenu.TabIndex = 5;
            Botao_voltarMenu.Text = "Voltar";
            Botao_voltarMenu.UseVisualStyleBackColor = true;
            Botao_voltarMenu.Click += Botao_voltarMenu_Click;
            // 
            // Botao_confirmarTime
            // 
            Botao_confirmarTime.Cursor = Cursors.PanNW;
            Botao_confirmarTime.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Botao_confirmarTime.Location = new Point(708, 590);
            Botao_confirmarTime.Name = "Botao_confirmarTime";
            Botao_confirmarTime.Size = new Size(105, 30);
            Botao_confirmarTime.TabIndex = 6;
            Botao_confirmarTime.Text = "Confirmar";
            Botao_confirmarTime.UseVisualStyleBackColor = true;
            Botao_confirmarTime.Visible = false;
            Botao_confirmarTime.Click += Botao_confirmarTime_Click;
            // 
            // TimeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(899, 678);
            Controls.Add(Botao_confirmarTime);
            Controls.Add(Botao_voltarMenu);
            Controls.Add(escolher_timeAR);
            Controls.Add(escolher_timeBR);
            Controls.Add(label_escolhertime);
            Controls.Add(logofut);
            Name = "TimeForm";
            Text = "TimeForm";
            ((System.ComponentModel.ISupportInitialize)logofut).EndInit();
            ((System.ComponentModel.ISupportInitialize)escolher_timeBR).EndInit();
            ((System.ComponentModel.ISupportInitialize)escolher_timeAR).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logofut;
        private Label label_escolhertime;
        private PictureBox escolher_timeBR;
        private PictureBox escolher_timeAR;
        private Button Botao_voltarMenu;
        private Button Botao_confirmarTime;
    }
}