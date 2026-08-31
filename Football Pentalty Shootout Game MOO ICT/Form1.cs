using System.Media;
namespace Football_Pentalty_Shootout_Game_MOO_ICT
{
    // Made by MOO ICT
    // For educational purpose only
    public partial class Form1 : Form
    {
        List<string> KeeperPosition = new List<string> { "left", "right", "top", "topLeft", "topRight" };
        List<PictureBox> goalTarget;
        int ballX = 0;
        int ballY = 0;
        int goal = 0;
        int miss = 0;
        int chutes = 5;
        string state;
        string playerTarget;
        bool acertou = false;
        List<PictureBox> checksPenalts;
        bool aimSet = false;
        Random random = new Random();

        private String timeEscolhido;
        SoundPlayer juiz = new SoundPlayer(Properties.Resources.apito);
        SoundPlayer chutesom = new SoundPlayer(Properties.Resources.chuteT);
        SoundPlayer defesasom = new SoundPlayer(Properties.Resources.tafarel);
        SoundPlayer torcidagritos = new SoundPlayer(Properties.Resources.torcida);
        public Form1(String time)
        {
            InitializeComponent();
            goalTarget = new List<PictureBox> { left, right, top, topLeft, topRight };
            timeEscolhido = time;
            juiz.Play();
            if (timeEscolhido == "Brasil")
            {
                Label_time.Text = "Brasil";
                Box_seuTime.Image = Properties.Resources.logobrasil1;
            }
            else if (timeEscolhido == "Argentina")
            {
                Label_time.Text = "Argentina";
                Box_seuTime.Image = Properties.Resources.logoargentina;
            }
            checksPenalts = new List<PictureBox> {checkPenalt1, checkPenalt2, checkPenalt3,checkPenalt4,checkPenalt5 }; 
        }

        private void SetGoalTargetEvent(object sender, EventArgs e)
        {
            if (aimSet == true) { return; }

            BallTimer.Start();
            KeeperTimer.Start();
            ChangeGoalKeeperImage();
            chutesom.Play();
            var senderObject = (PictureBox)sender;
            senderObject.BackColor = Color.Beige;

            if (senderObject.Tag.ToString() == "topRight")
            {
                ballX = -7;
                ballY = 15;
                playerTarget = senderObject.Tag.ToString();
                aimSet = true;
            }
            if (senderObject.Tag.ToString() == "right")
            {
                ballX = -11;
                ballY = 15;
                playerTarget = senderObject.Tag.ToString();
                aimSet = true;
            }
            if (senderObject.Tag.ToString() == "top")
            {
                ballX = 0;
                ballY = 20;
                playerTarget = senderObject.Tag.ToString();
                aimSet = true;
            }
            if (senderObject.Tag.ToString() == "topLeft")
            {
                ballX = 8;
                ballY = 15;
                playerTarget = senderObject.Tag.ToString();
                aimSet = true;
            }
            if (senderObject.Tag.ToString() == "left")
            {
                ballX = 7;
                ballY = 8;
                playerTarget = senderObject.Tag.ToString();
                aimSet = true;
            }

            CheckScore();

        }

        private void KeeperTimerEvent(object sender, EventArgs e)
        {
            switch (state)
            {

                case "left":
                    goalKeeper.Left -= 6;
                    goalKeeper.Top = 204;
                    break;
                case "right":
                    goalKeeper.Left += 6;
                    goalKeeper.Top = 204;
                    break;
                case "top":
                    goalKeeper.Top -= 6;
                    break;
                case "topLeft":
                    goalKeeper.Left -= 6;
                    goalKeeper.Top -= 3;
                    break;
                case "topRight":
                    goalKeeper.Left += 6;
                    goalKeeper.Top -= 3;
                    break;
            }

            foreach (PictureBox x in goalTarget)
            {
                if (goalKeeper.Bounds.IntersectsWith(x.Bounds))
                {

                    KeeperTimer.Stop();
                    goalKeeper.Location = new Point(418, 169);
                    goalKeeper.Image = Properties.Resources.stand_small;

                }
            }


        }

        private void BallTimerEvent(object sender, EventArgs e)
        {
            football.Left -= ballX;
            football.Top -= ballY;

            foreach (PictureBox x in goalTarget)
            {
                if (football.Bounds.IntersectsWith(x.Bounds))
                {

                    football.Location = new Point(430, 500);
                    ballX = 0;
                    ballY = 0;
                    aimSet = false;
                    BallTimer.Stop();

                    if (chutes == 0)
                    {
                        FormResultado resultado = new FormResultado(timeEscolhido, goal, miss);
                        resultado.Show();
                        this.Hide();
                    }
                }
            }


        }

        private void CheckScore()
        {
            if (state == playerTarget)
            {
                defesasom.Play();
                miss++;
                chutes--;
                acertou = false;
                lblMissed.Text = "Erros: " + miss;
            }
            else
            {
                goal++;
                chutes--;
                acertou = true;
                lblScore.Text = "Gols: " + goal;
            }

            //
            PictureBox check = checksPenalts[4 - chutes];

            if (acertou) 
            {
                check.Image = Properties.Resources.footballacerto;
            } else
                check.Image= Properties.Resources.footballerro;
            //

        }

        private void ChangeGoalKeeperImage()
        {
            KeeperTimer.Start();
            int i = random.Next(0, KeeperPosition.Count);
            state = KeeperPosition[i];

            switch (i)
            {
                case 0:
                    goalKeeper.Image = Properties.Resources.left_save_small;
                    break;
                case 1:
                    goalKeeper.Image = Properties.Resources.right_save_small;
                    break;
                case 2:
                    goalKeeper.Image = Properties.Resources.top_save_small;
                    break;
                case 3:
                    goalKeeper.Image = Properties.Resources.top_left_save_small;
                    break;
                case 4:
                    goalKeeper.Image = Properties.Resources.top_right_save_small;
                    break;
            }
        }

    }
}