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
    public partial class TimeForm : Form
    {
        SoundPlayer menu = new SoundPlayer(Properties.Resources.selection);
        bool selecTime = false;
        private String TimeEscolhido { get; set; }
        public TimeForm()
        {
            InitializeComponent();

        }

        private void Botao_voltarMenu_Click(object sender, EventArgs e)
        {
            MenuForm menuPrincipal = new MenuForm();
            menuPrincipal.Show();

            menu.Play();
            this.Hide();
        }

        private void Botao_confirmarTime_Click(object sender, EventArgs e)
        {
            if (selecTime == true)
            {
                Form1 jogofut = new Form1(TimeEscolhido);
                jogofut.Show();

                this.Hide();
            }

        }

        private void escolher_timeAR_Click(object sender, EventArgs e)
        {
            selecTime = true;
            TimeEscolhido = "Argentina";
            menu.Play();
            Botao_confirmarTime.Visible = true;
        }

        private void escolher_timeBR_Click(object sender, EventArgs e)
        {
            selecTime = true;
            TimeEscolhido = "Brasil";
            menu.Play();
            Botao_confirmarTime.Visible = true;
        
          }
    }
}
