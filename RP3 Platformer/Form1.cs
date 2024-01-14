using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RP3_Platformer
{
    public partial class Form1 : Form
    {
        bool gameStarted, isGameOver;
        Player player = new Player();
        int currentLevel = 1;

        //Level 1 settings
        int level1PlayerXPosition = 60;
        int level1PlayerYPosition = 270;

        //Level 1 settings
        int level2PlayerXPosition = 40;
        int level2PlayerYPosition = 200;

        public Form1()
        {
            InitializeComponent();
            GameInitialization();
        }

        /// <summary>
        /// Glavna funkcija (timer) za odvijanje igre, provjerava sve uvjete i radi potrebne promjene
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            labelScore.Text = "Score: " + player.Score;
            labelLives.Text = "Lives: " + player.Lives;

            pictureBoxPlayer.Top += player.JumpingSpeed;

            if (player.MovingLeft == true && player.MovingRight == false)
            {
                pictureBoxPlayer.Left -= player.MovingSpeed;
            }
            if (player.MovingRight == true && player.MovingLeft == false)
            {
                pictureBoxPlayer.Left += player.MovingSpeed;
            }
            if (player.JumpingOnce == true && player.Force < 0)
            {
                player.JumpingOnce = false;
            }
            if (player.JumpingTwice == true && player.Force < 0)
            {
                player.JumpingTwice = false;
            }
            if (player.JumpingOnce == true)
            {
                player.JumpingSpeed = -8;
                player.Force -= 1;
            }
            else if (player.JumpingTwice == true) {
                player.JumpingSpeed -= 12;
                player.Force -= 2;
            }
            else
            {
                player.JumpingSpeed = 8;
            }

            foreach (Control control in this.Controls)
            {
                if (control is PictureBox)
                {
                    if ((string)control.Tag == "level1platform" || (string)control.Tag == "level2platform")
                    {
                        if (pictureBoxPlayer.Bounds.IntersectsWith(control.Bounds))
                        {
                            control.BringToFront();
                            player.JumpingSpeed = 0;
                            player.Force = 8;
                            pictureBoxPlayer.Top = control.Top - pictureBoxPlayer.Height;
                        }
                    }
                    if ((string)control.Tag == "level1coin" || (string)control.Tag == "level2coin")
                    {
                        if (pictureBoxPlayer.Bounds.IntersectsWith(control.Bounds) && control.Visible == true)
                        {
                            control.Visible = false;
                            player.Score += 1;
                        }
                    }
                    if ((string)control.Tag == "level1Enemy")
                    {
                        if (pictureBoxPlayer.Bounds.IntersectsWith(control.Bounds) && control.Visible == true)
                        {
                            player.Lives -= 1;
                            control.Visible= false;
                            if (player.Lives <= 0) { 
                                isGameOver = true;
                            }
                        }
                    }
                }
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) { 
                player.MovingLeft = true;
            }
            if (e.KeyCode == Keys.Right) { 
                player.MovingRight = true;
            }
            if (e.KeyCode == Keys.Space) {
                if (player.JumpingOnce == false && player.JumpingTwice == false) { 
                    player.JumpingOnce = true;
                }
                //poraditi na logici double jumpa
                else if (player.JumpingOnce == true)
                {
                    player.JumpingOnce= false;
                    player.JumpingTwice = true;
                }
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                player.MovingLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                player.MovingRight = false;
            }
            //poraditi na logici double jumpa
            if (player.JumpingTwice == true) { 
                player.JumpingTwice= false;
            }
            if (e.KeyCode == Keys.Enter && isGameOver == true) {
                StartLevel(1);
            }

        }
        /// <summary>
        /// Funkcija koja se bavi svim postavkama na početku igre i pokreće prvi level
        /// </summary>
        private void GameInitialization() {
            isGameOver = false;
            if (currentLevel != 1)
            {
                StartLevel(1);
            }
        }

        /// <summary>
        /// Funkcija namijenjena postavljanju levela, kao parametar prima broj levela koji 
        /// treba postaviti, na početku igre je level 1.
        /// </summary>
        private void StartLevel(int levelNumber)
        {
            currentLevel = levelNumber;

            player.JumpingOnce = false; 
            player.JumpingTwice = false;

            player.MovingLeft = false;
            player.MovingRight = false;

            

            switch (levelNumber)
            {
                case 1:
                    player.Lives = 10;
                    player.Score = 0;
                    labelLives.Text = "Lives: " + player.Lives;
                    labelScore.Text = "Score: " + player.Score;
                    
                    //postavlja sve pictureBox-eve s tag-om "level1..." na vidljivo
                    foreach (Control control in this.Controls)
                    {
                        if (control is PictureBox && ((string)control.Tag == "level1coin"
                            || (string)control.Tag == "level1platform"
                            || (string)control.Tag == "level1enemy"))
                        { 
                            control.Visible = true;
                        }
                    }

                    pictureBoxPlayer.Left = level1PlayerXPosition;
                    pictureBoxPlayer.Top = level1PlayerYPosition;
                    gameTimer.Start();
                    break;

                case 2:
                    labelLives.Text = "Lives: " + player.Lives;
                    labelScore.Text = "Score: " + player.Score;

                    // postavlja sve pictureBox-eve s tag-om "level1..." na Visible,
                    // zasad tako izmjenjujemo levele
                    foreach (Control control in this.Controls)
                    {
                        if (control is PictureBox && ((string)control.Tag == "level2coin"
                            || (string)control.Tag == "level2platform"
                            || (string)control.Tag == "level2enemy"))
                        {
                            control.Visible = true;
                        }
                    }

                    pictureBoxPlayer.Left = level2PlayerXPosition;
                    pictureBoxPlayer.Top = level2PlayerYPosition;
                    break;

                default:
                    break;
            }
            

        }
        /// <summary>
        /// Funkcija koja obavlja kraj igre i nudi mogućnost ponovne igre od prvog levela.
        /// TODO: Dodati funkcionalnosti
        /// </summary>
        private void GameOver() { 
            
        }
    }
}
