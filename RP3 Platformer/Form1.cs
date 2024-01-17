
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RP3_Platformer
{
    public partial class Form1 : Form
    {
        private List<string> frames = new List<string>(new String[] {"coin1", "coin2", "coin3",
            "coin4", "coin5"});


        //heeeeeey!

        private int currentFrameIndex = 0;
        private Timer animationTimer = new Timer();


        bool gameStarted, isGameOver, playerOnThePlatform = false;
        Player player = new Player();
        //PictureBox groundChecker;

        //Petre, tu mozes dodati enemije za cijelu igru
        int currentLevel = 1;

        //Level 1 settings
        int level1PlayerXPosition = 12;
        int level1PlayerYPosition = 350;
        int level1HorizontalPlatformSpeed = 2;
        int level1VerticalPlatformSpeed = 2;
        int level1LeftStopPoint = 212;
        int level1RightStopPoint = 400;
        int level1BottomStopPoint = 371;
        int level1TopStopPoint = 290;

        //Level 2 settings
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
            UpdateLabels();

            SetGroundChecker();

            SetCeilingChecker();

            SetLeftChecker();

            SetRightChecker();

            HandleCollisions();

            HandlePlayerMovement();

            MovePlatforms();

            CheckForNewLevel();

            CheckForGameOver();
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
                if (playerOnThePlatform == true)
                {
                    player.JumpingOnce = true;
                    player.Force = 6;
                }
                else if (player.JumpingTwice == false) {
                    player.JumpingTwice = true;
                    player.Force += 6;
                }
                //poraditi na logici double jumpa

            }
            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                Console.WriteLine("Restartiram Igru!");
                GameInitialization();
            }
            // dodati pucanje na X
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
        }
        /// <summary>
        /// Funkcija koja se bavi svim postavkama na početku igre i pokreće prvi level
        /// </summary>
        private void GameInitialization() {

            isGameOver = false;
            currentLevel = 1;

            CheckerInitialization();

            StartLevel(currentLevel);

            animationTimer.Interval = 20; //interval za animacije
            animationTimer.Tick += AnimationTimer_Tick;

        }

        // Add this event handler for the animation timer tick -LPA
        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            // Update the coin picture box with the next frame
            //coin.Image = (Image)Properties.Resources.ResourceManager.GetObject(frames[currentFrameIndex]);

            foreach (Control control in this.Controls)
            {
                if (control is PictureBox && control.Tag != null && control.Tag.ToString().EndsWith("coin"))
                {
                    // Extract the number from the PictureBox name
                    int pictureBoxNumber;
                    if (int.TryParse(control.Name.Replace("pictureBoxCoin", ""), out pictureBoxNumber))
                    {
                        // Update the coin picture box with the next frame
                        ((PictureBox)control).Image = (Image)Properties.Resources.ResourceManager.GetObject(frames[currentFrameIndex]);
                    }
                }
            }

            // Move to the next frame
            currentFrameIndex = (currentFrameIndex + 1) % frames.Count;
        }


        /// <summary>


        /// Inicijalizira provjeravače (checkere) kolizije igrača
        /// </summary>
        private void CheckerInitialization()
        {
            leftChecker.Width = 2;
            leftChecker.Height = pictureBoxPlayer.Height - 10;
            leftChecker.Visible = false;

            rightChecker.Width = 2;
            rightChecker.Height = pictureBoxPlayer.Height - 10;
            rightChecker.Visible = false;

            groundChecker.Width = pictureBoxPlayer.Width;
            groundChecker.Height = 2;
            groundChecker.Visible = false;

            ceilingChecker.Width = pictureBoxPlayer.Width;
            ceilingChecker.Height = 4;
            ceilingChecker.Visible = false;
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
                    player.Lives = 3;
                    player.Score = 0;
                    labelLives.Text = "Lives: " + player.Lives;
                    labelScore.Text = "Score: " + player.Score;

                    //postavlja sve pictureBox-eve s tag-om "level1..." na vidljivo
                    foreach (Control control in this.Controls)
                    {
                        if(control is PictureBox && control.Tag != null && Regex.IsMatch((string)control.Tag, @"^level1.*$"))
                        //(control is PictureBox && ((string)control.Tag == "level1coin" || (string)control.Tag == "level1platform" || (string)control.Tag == "level1enemy"))
                        {
                            control.Visible = true;

                            // Start the animation timer for coins  LPA
                            animationTimer.Start();


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
                    // zasad tako izmjenjujemo levele,
                    // NECE BAS DOBRO RADIT JOS JER I DALJE PROVJERAVA COLLISION S NJIMA U DRUGOM LEVELU
                    foreach (Control control in this.Controls)
                    {
                        if (control is PictureBox && ((string)control.Tag == "level2coin"
                            || (string)control.Tag == "level2platform"
                            || (string)control.Tag == "level2enemy"))
                        {
                            control.Visible = true;
                        }

                        if (control is PictureBox && ((string)control.Tag == "level1coin"
                            || (string)control.Tag == "level1platform"
                            || (string)control.Tag == "level1enemy"))
                        {
                            control.Visible = false;
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
        /// Updatea sve labele u igri
        /// </summary>
        private void UpdateLabels() {
            labelScore.Text = "Score: " + player.Score;
            labelLives.Text = "Lives: " + player.Lives;
        }
        /// <summary>
        /// Postavlja groundChecker koji disable-a gravitaciju ako je player na platformi, rijesen problem titranja
        /// </summary>
        private void SetGroundChecker() {
            groundChecker.Top = pictureBoxPlayer.Top + pictureBoxPlayer.Height;
            groundChecker.Left = pictureBoxPlayer.Left;
        }

        /// <summary>
        ///
        /// </summary>
        private void SetCeilingChecker()
        {
            ceilingChecker.Top = pictureBoxPlayer.Top - 8;
            ceilingChecker.Left = pictureBoxPlayer.Left;
        }

        private void SetLeftChecker()
        {
            leftChecker.Top = pictureBoxPlayer.Top - 4;
            leftChecker.Left = pictureBoxPlayer.Left - 4;
        }
        private void SetRightChecker()
        {
            rightChecker.Top = pictureBoxPlayer.Top - 4;
            rightChecker.Left = pictureBoxPlayer.Left + pictureBoxPlayer.Width + 2;
        }
       
        /// <summary>
        /// Funkcija za pomicanje Super Daria
        /// </summary>
        private void HandlePlayerMovement() {
            playerOnThePlatform = false;
            foreach (Control control in this.Controls)
            {

                if (groundChecker.Bounds.IntersectsWith(control.Bounds) && ((string)control.Tag == "level1platform" ||
                    (string)control.Tag == "level2platform" ||
                    (string)control.Tag == "level3platform" ||
                    (string)control.Tag == "level1brick"))
                {
                    playerOnThePlatform = true;
                    break;
                }
            }

            if (playerOnThePlatform == false || player.JumpingOnce == true)
            {
                pictureBoxPlayer.Top += player.JumpingSpeed;
            }
            else {
                player.JumpingOnce = false;
                player.JumpingTwice = false;
            }

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

            if (player.JumpingOnce == true)
            {
                player.JumpingSpeed = -8;
                player.Force -= 1;
            }
            else
            {
                player.JumpingSpeed = 8;
            }

        }
        /// <summary>
        /// Funkcija za pomicanje svih platformi u levelu. Najjednostavnija implementacija. Za dodati nove
        /// potrebno je postaviti ogranicenje u Level Settings na pocetku skripte.
        /// </summary>
        private void MovePlatforms()
        {
            horizontalMovingPlatform.Left -= level1HorizontalPlatformSpeed;

            if (horizontalMovingPlatform.Left < level1LeftStopPoint || horizontalMovingPlatform.Left > level1RightStopPoint)
            {
                level1HorizontalPlatformSpeed *= (-1);
            }

            verticalMovingPlatform.Top -= level1VerticalPlatformSpeed;

            if (verticalMovingPlatform.Top < level1TopStopPoint || verticalMovingPlatform.Top > level1BottomStopPoint) {
                level1VerticalPlatformSpeed *= (-1);
            }

        }

        /// <summary>
        /// Provjerava sve dodire igraca s ostalim objektima
        /// </summary>
        ///
        private void HandleCollisions() {
            /*if (ceilingChecker.Bounds.IntersectsWith(brickBoxFlower.Bounds))
            {
                Console.WriteLine("cvijeticu");
                player.JumpingOnce = false;
                player.JumpingTwice = false;
                player.Force = 0;
                player.JumpingSpeed = 8;
                //izbaci flower
            }*/
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox)
                {

                    if ((string)control.Tag == "level1platform" || (string)control.Tag == "level2platform" || (string)control.Tag == "level3platform" || (string)control.Tag == "level1brick")
                    {
                        if (ceilingChecker.Bounds.IntersectsWith(control.Bounds))
                        {
                            player.JumpingOnce = false;
                            player.JumpingTwice = false;
                            player.Force = 0;
                            player.JumpingSpeed = 8;
                        }
                        if (leftChecker.Bounds.IntersectsWith(control.Bounds))
                        {
                            player.MovingLeft = false;
                        }
                        if (rightChecker.Bounds.IntersectsWith(control.Bounds))
                        {
                            player.MovingRight = false;
                        }
                        if (pictureBoxPlayer.Bounds.IntersectsWith(control.Bounds))
                        {
                            control.BringToFront();
                            pictureBoxPlayer.Top = control.Top - pictureBoxPlayer.Height;
                        }
                    }
                    if ((string)control.Tag == "level1coin" || (string)control.Tag == "level2coin" || (string)control.Tag == "level3coin")
                    {
                        if (pictureBoxPlayer.Bounds.IntersectsWith(control.Bounds) && control.Visible == true)
                        {
                            control.Visible = false;
                            player.Score += 1;

                            //animation stops. treba li?
                            //animationTimer.Stop();
                        }
                        if ((string)control.Tag == "level1Enemy" || (string)control.Tag == "level2Enemy" || (string)control.Tag == "level3Enemy")
                        {
                            if (pictureBoxPlayer.Bounds.IntersectsWith(control.Bounds) && control.Visible == true)
                            {
                                player.Lives -= 1;
                                control.Visible = false;
                                if (player.Lives <= 0)
                                {
                                    isGameOver = true;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void CheckForNewLevel() {
            if (pictureBoxPlayer.Left > ClientSize.Width) {
                Console.WriteLine("Vrijeme za novi level");
                currentLevel++;
                if (currentLevel >= 3) {
                    gameTimer.Stop();
                    MessageBox.Show("Presli ste igru!");
                }
                StartLevel(currentLevel);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void CheckForGameOver() {
            if (pictureBoxPlayer.Top > ClientSize.Height) {
                isGameOver = true;
            }
            if (isGameOver == true) {
                GameOver();
            }
        }

        /// <summary>
        /// Funkcija koja obavlja kraj igre i nudi mogućnost ponovne igre od prvog levela.
        /// TODO: Dodati funkcionalnosti
        /// </summary>
        private void GameOver() {
            player.Lives = 0;
            labelLives.Text = "Lives: 0";
            gameTimer.Stop();
            //Privremeni kraj igre
            MessageBox.Show("Press Enter to play again!");

        }
    }
}