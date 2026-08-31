using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Football_Pentalty_Shootout_Game_MOO_ICT
{
    public partial class MenuForm : Form
    {
        SoundPlayer menu = new SoundPlayer(Properties.Resources.selection);
        public MenuForm()
        {
            InitializeComponent();
            
        }
        

        private void Botao_jogar_Click(object sender, EventArgs e)
        {
            TimeForm escolherTime = new TimeForm();
            escolherTime.Show();
            menu.Play();

            this.Hide();

        }

        private void Botao_sair_Click(object sender, EventArgs e)
        {
            menu.Play();

            this.Close();
        }
    }
}
