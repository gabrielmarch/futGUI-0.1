using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace Football_Pentalty_Shootout_Game_MOO_ICT
{
    public partial class FormResultado : Form
    {
        int gols;
        int erros;
        String timeEscolhido;
        SoundPlayer somfinal = new SoundPlayer(Properties.Resources.aplausos);
        public FormResultado(String time, int goal, int miss)
        {
            InitializeComponent();

            timeEscolhido = time;
            gols = goal;
            erros = miss;
            somfinal.Play();
      
            if (timeEscolhido == "Brasil")
                Box_seuTime.Image = Properties.Resources.logobrasil1;
            else
                Box_seuTime.Image = Properties.Resources.logoargentina;
            lblScore.Text = "Gols:" + gols;
            lblMissed.Text = "Erros:" + erros;
        }

        private void button_JogarDnv_Click(object sender, EventArgs e)
        {
            TimeForm selecionarTime = new TimeForm();
            selecionarTime.Show();

            this.Hide();
        }

        private void button_VoltarMenu_Click(object sender, EventArgs e)
        {
            MenuForm menuPrincipal = new MenuForm();
            menuPrincipal.Show();

            this.Hide();
        }
    }
}
