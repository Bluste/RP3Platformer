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
        bool gameStarted, isGameOver, level1Started=false;
        Player player = new Player();

        //Level 1 settings
        int level1PlayerXPosition = 60;
        int level1PlayerYPosition = 270;


        public Form1()
        {
            InitializeComponent();

            if (level1Started == false)
            {
                StartLevel(1);
                level1Started = true;
            }
        }

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
                player.JumpingSpeed = -12;
                player.Force -= 1;
            }
            else
            {
                player.JumpingSpeed = 2;
            }

            foreach (Control control in this.Controls)
            {
                if (control is PictureBox)
                {
                    if (control.Tag == "platform") {
                        if (pictureBoxPlayer.Bounds.IntersectsWith(control.Bounds)) {
                            control.BringToFront();
                            player.JumpingSpeed = 0;
                            player.Force = 8;
                            pictureBoxPlayer.Top = control.Top - pictureBoxPlayer.Height;
                            
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
        /// Funkcija namijenjena postavljanju levela, kao parametar prima broj levela koji 
        /// treba postaviti, na početku igre je level 1.
        /// </summary>
        private void StartLevel(int levelNumber)
        {
            player.JumpingOnce = false; 
            player.JumpingTwice = false;

            player.MovingLeft = false;
            player.MovingRight = false;
            isGameOver = false;

            switch (levelNumber)
            {
                case 1:
                    player.Lives = 10;
                    player.Score = 0;
                    labelLives.Text = "Lives: " + player.Lives;
                    labelScore.Text = "Score: " + player.Score;

                    foreach (Control control in this.Controls)
                    {
                        if (control is PictureBox && control.Tag == "level1coin") { 
                            control.Visible = true;
                        }
                    }

                    pictureBoxPlayer.Left = level1PlayerXPosition;
                    pictureBoxPlayer.Top = level1PlayerYPosition;
                    gameTimer.Start();
                    break;

                case 2:
                    break;

                default:
                    break;
            }
            


        }
    }
}
