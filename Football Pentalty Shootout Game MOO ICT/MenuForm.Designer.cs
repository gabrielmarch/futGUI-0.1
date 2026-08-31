namespace Football_Pentalty_Shootout_Game_MOO_ICT
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            logofut = new PictureBox();
            Botao_jogar = new Button();
            Botao_sair = new Button();
            ((System.ComponentModel.ISupportInitialize)logofut).BeginInit();
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
            logofut.TabIndex = 0;
            logofut.TabStop = false;
            // 
            // Botao_jogar
            // 
            Botao_jogar.Cursor = Cursors.PanNW;
            Botao_jogar.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Botao_jogar.Location = new Point(347, 435);
            Botao_jogar.Name = "Botao_jogar";
            Botao_jogar.Size = new Size(198, 61);
            Botao_jogar.TabIndex = 1;
            Botao_jogar.Text = "JOGAR";
            Botao_jogar.UseVisualStyleBackColor = true;
            Botao_jogar.Click += Botao_jogar_Click;
            // 
            // Botao_sair
            // 
            Botao_sair.Cursor = Cursors.PanNW;
            Botao_sair.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Botao_sair.Location = new Point(347, 532);
            Botao_sair.Name = "Botao_sair";
            Botao_sair.Size = new Size(198, 61);
            Botao_sair.TabIndex = 2;
            Botao_sair.Text = "SAIR";
            Botao_sair.UseVisualStyleBackColor = true;
            Botao_sair.Click += Botao_sair_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(899, 678);
            Controls.Add(Botao_sair);
            Controls.Add(Botao_jogar);
            Controls.Add(logofut);
            Name = "MenuForm";
            Text = "MenuForm";
            ((System.ComponentModel.ISupportInitialize)logofut).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox logofut;
        private Button Botao_jogar;
        private Button Botao_sair;
    }
}