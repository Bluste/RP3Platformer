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

        //Level 1 settings
        int level2PlayerXPosition = 40;
        int level2PlayerYPosition = 200;

        public Form1()
        {
            InitializeComponent();
            /*groundChecker = new PictureBox();
            groundChecker.Name = "groundChecker";
            groundChecker.Parent = pictureBoxPlayer;
            groundChecker.Top = pictureBoxPlayer.Height;
            groundChecker.Left = pictureBoxPlayer.Left;
            groundChecker.Height = 40;
            groundChecker.Width=pictureBoxPlayer.Width;
            groundChecker.BackColor = Color.Black;
            groundChecker.Visible = true;
            groundChecker.Enabled = true;*/
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
        /// Funkcija za pomicanje Super Daria
        /// </summary>
        private void HandlePlayerMovement() {
            playerOnThePlatform = false;
            foreach (Control control in this.Controls)
            {

                if (groundChecker.Bounds.IntersectsWith(control.Bounds) && ((string)control.Tag == "level1platform" ||
                    (string)control.Tag == "level2platform" ||
                    (string)control.Tag == "level3platform"))
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
        private void HandleCollisions() {
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox)
                {

                    if ((string)control.Tag == "level1platform" || (string)control.Tag == "level2platform" || (string)control.Tag == "level3platform")
                    {
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

        private void pictureBox34_Click(object sender, EventArgs e)
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













namespace RP3_Platformer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelLives = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.pictureBoxPlayer = new System.Windows.Forms.PictureBox();
            this.pictureBoxEnemyTurtle1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin30 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin33 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin32 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin31 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin20 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin22 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin21 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin13 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin12 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin11 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin16 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin15 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin14 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxCoin19 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin18 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin17 = new System.Windows.Forms.PictureBox();
            this.horizontalMovingPlatform = new System.Windows.Forms.PictureBox();
            this.brick1 = new System.Windows.Forms.PictureBox();
            this.verticalMovingPlatform = new System.Windows.Forms.PictureBox();
            this.groundChecker = new System.Windows.Forms.PictureBox();
            this.floor2 = new System.Windows.Forms.PictureBox();
            this.floor1 = new System.Windows.Forms.PictureBox();
            this.platform1_1 = new System.Windows.Forms.PictureBox();
            this.platform1_2 = new System.Windows.Forms.PictureBox();
            this.platform1_4 = new System.Windows.Forms.PictureBox();
            this.platform1_3 = new System.Windows.Forms.PictureBox();
            this.platform1_5 = new System.Windows.Forms.PictureBox();
            this.platform2_5 = new System.Windows.Forms.PictureBox();
            this.platform2_4 = new System.Windows.Forms.PictureBox();
            this.platform2_3 = new System.Windows.Forms.PictureBox();
            this.platform2_2 = new System.Windows.Forms.PictureBox();
            this.platform2_1 = new System.Windows.Forms.PictureBox();
            this.platform5_5 = new System.Windows.Forms.PictureBox();
            this.platform5_4 = new System.Windows.Forms.PictureBox();
            this.platform5_3 = new System.Windows.Forms.PictureBox();
            this.platform5_2 = new System.Windows.Forms.PictureBox();
            this.platform5_1 = new System.Windows.Forms.PictureBox();
            this.platform3_3 = new System.Windows.Forms.PictureBox();
            this.platform3_2 = new System.Windows.Forms.PictureBox();
            this.platform3_1 = new System.Windows.Forms.PictureBox();
            this.platform4_3 = new System.Windows.Forms.PictureBox();
            this.platform4_2 = new System.Windows.Forms.PictureBox();
            this.platform4_1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin27 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin29 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin28 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin24 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin26 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin25 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin23 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin5 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin6 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin8 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin7 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin10 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin9 = new System.Windows.Forms.PictureBox();
            this.pictureBoxEnemyTurtle2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxEnemyTurtle4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxEnemyTurtle3 = new System.Windows.Forms.PictureBox();
            this.pipeFinal = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin36 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin35 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin34 = new System.Windows.Forms.PictureBox();
            this.pictureBoxEnemyPlant1 = new System.Windows.Forms.PictureBox();
            this.pipePlant1 = new System.Windows.Forms.PictureBox();
            this.pipePlant2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxEnemyPlant2 = new System.Windows.Forms.PictureBox();
            this.brick2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemyTurtle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalMovingPlatform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalMovingPlatform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundChecker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform5_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform5_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform5_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform5_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform5_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform3_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform3_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform3_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform4_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform4_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform4_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemyTurtle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemyTurtle4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemyTurtle3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemyPlant1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipePlant1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipePlant2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemyPlant2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick2)).BeginInit();
            this.SuspendLayout();
            //
            // labelLives
            //
            this.labelLives.AutoSize = true;
            this.labelLives.BackColor = System.Drawing.Color.Transparent;
            this.labelLives.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLives.Location = new System.Drawing.Point(10, 11);
            this.labelLives.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLives.Name = "labelLives";
            this.labelLives.Size = new System.Drawing.Size(71, 20);
            this.labelLives.TabIndex = 0;
            this.labelLives.Text = "Lives: 10";
            //
            // labelScore
            //
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(633, 11);
            this.labelScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(94, 20);
            this.labelScore.TabIndex = 1;
            this.labelScore.Text = "Score: 0";
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // pictureBoxPlayer
            //
            this.pictureBoxPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxPlayer.Image = global::RP3_Platformer.Properties.Resources.marioStaying;
            this.pictureBoxPlayer.InitialImage = global::RP3_Platformer.Properties.Resources.marioStaying;
            this.pictureBoxPlayer.Location = new System.Drawing.Point(9, 366);
            this.pictureBoxPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxPlayer.Name = "pictureBoxPlayer";
            this.pictureBoxPlayer.Size = new System.Drawing.Size(42, 41);
            this.pictureBoxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlayer.TabIndex = 6;
            this.pictureBoxPlayer.TabStop = false;
            //
            // pictureBoxEnemyTurtle1
            //
            this.pictureBoxEnemyTurtle1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEnemyTurtle1.Image = global::RP3_Platformer.Properties.Resources.turtle1;
            this.pictureBoxEnemyTurtle1.InitialImage = global::RP3_Platformer.Properties.Resources.turtle1;
            this.pictureBoxEnemyTurtle1.Location = new System.Drawing.Point(327, 275);
            this.pictureBoxEnemyTurtle1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxEnemyTurtle1.Name = "pictureBoxEnemyTurtle1";
            this.pictureBoxEnemyTurtle1.Size = new System.Drawing.Size(32, 41);
            this.pictureBoxEnemyTurtle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEnemyTurtle1.TabIndex = 7;
            this.pictureBoxEnemyTurtle1.TabStop = false;
            this.pictureBoxEnemyTurtle1.Tag = "level1Enemy";
            //
            // pictureBoxCoin3
            //
            this.pictureBoxCoin3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin3.Image")));
            this.pictureBoxCoin3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin3.InitialImage")));
            this.pictureBoxCoin3.Location = new System.Drawing.Point(119, 141);
            this.pictureBoxCoin3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCoin3.Name = "pictureBoxCoin3";
            this.pictureBoxCoin3.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxCoin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin3.TabIndex = 12;
            this.pictureBoxCoin3.TabStop = false;
            this.pictureBoxCoin3.Tag = "level1coin";
            //
            // pictureBoxCoin4
            //
            this.pictureBoxCoin4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin4.Image")));
            this.pictureBoxCoin4.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin4.InitialImage")));
            this.pictureBoxCoin4.Location = new System.Drawing.Point(146, 141);
            this.pictureBoxCoin4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCoin4.Name = "pictureBoxCoin4";
            this.pictureBoxCoin4.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxCoin4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin4.TabIndex = 13;
            this.pictureBoxCoin4.TabStop = false;
            this.pictureBoxCoin4.Tag = "level1coin";
            //
            // pictureBoxCoin2
            //
            this.pictureBoxCoin2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin2.Image")));
            this.pictureBoxCoin2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin2.InitialImage")));
            this.pictureBoxCoin2.Location = new System.Drawing.Point(92, 141);
            this.pictureBoxCoin2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCoin2.Name = "pictureBoxCoin2";
            this.pictureBoxCoin2.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxCoin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin2.TabIndex = 15;
            this.pictureBoxCoin2.TabStop = false;
            this.pictureBoxCoin2.Tag = "level1coin";
            //
            // pictureBoxCoin1
            //
            this.pictureBoxCoin1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin1.Image")));
            this.pictureBoxCoin1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin1.InitialImage")));
            this.pictureBoxCoin1.Location = new System.Drawing.Point(70, 141);
            this.pictureBoxCoin1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCoin1.Name = "pictureBoxCoin1";
            this.pictureBoxCoin1.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxCoin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin1.TabIndex = 14;
            this.pictureBoxCoin1.TabStop = false;
            this.pictureBoxCoin1.Tag = "level1coin";
            //
            // pictureBoxCoin30
            //
            this.pictureBoxCoin30.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin30.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin30.Image")));
            this.pictureBoxCoin30.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin30.InitialImage")));
            this.pictureBoxCoin30.Location = new System.Drawing.Point(568, 81);
            this.pictureBoxCoin30.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCoin30.Name = "pictureBoxCoin30";
            this.pictureBoxCoin30.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxCoin30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin30.TabIndex = 19;
            this.pictureBoxCoin30.TabStop = false;
            this.pictureBoxCoin30.Tag = "level1coin";
            //
            // pictureBoxCoin33
            //
            this.pictureBoxCoin33.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin33.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin33.Image")));
            this.pictureBoxCoin33.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin33.InitialImage")));
            this.pictureBoxCoin33.Location = new System.Drawing.Point(649, 81);
            this.pictureBoxCoin33.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCoin33.Name = "pictureBoxCoin33";
            this.pictureBoxCoin33.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxCoin33.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin33.TabIndex = 18;
            this.pictureBoxCoin33.TabStop = false;
            this.pictureBoxCoin33.Tag = "level1coin";
            //
            // pictureBoxCoin32
            //
            this.pictureBoxCoin32.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin32.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin32.Image")));
            this.pictureBoxCoin32.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin32.InitialImage")));
            this.pictureBoxCoin32.Location = new System.Drawing.Point(621, 81);
            this.pictureBoxCoin32.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCoin32.Name = "pictureBoxCoin32";
            this.pictureBoxCoin32.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxCoin32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin32.TabIndex = 17;
            this.pictureBoxCoin32.TabStop = false;
            this.pictureBoxCoin32.Tag = "level1coin";
            //
            // pictureBoxCoin31
            //
            this.pictureBoxCoin31.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin31.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin31.Image")));
            this.pictureBoxCoin31.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin31.InitialImage")));
            this.pictureBoxCoin31.Location = new System.Drawing.Point(595, 81);
            this.pictureBoxCoin31.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCoin31.Name = "pictureBoxCoin31";
            this.pictureBoxCoin31.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxCoin31.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin31.TabIndex = 16;
            this.pictureBoxCoin31.TabStop = false;
            this.pictureBoxCoin31.Tag = "level1coin";
            //
            // pictureBoxCoin20
            //
            this.pictureBoxCoin20.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin20.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin20.Image")));
            this.pictureBoxCoin20.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin20.InitialImage")));
            this.pictureBoxCoin20.Location = new System.Drawing.Point(336, 205);
            this.pictureBoxCoin20.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCoin20.Name = "pictureBoxCoin20";
            this.pictureBoxCoin20.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxCoin20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin20.TabIndex = 26;
            this.pictureBoxCoin20.TabStop = false;
            this.pictureBoxCoin20.Tag = "level1coin";
            //
            // pictureBoxCoin22
            //
            this.pictureBoxCoin22.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin22.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin22.Image")));
            this.pictureBoxCoin22.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin22.InitialImage")));
            this.pictureBoxCoin22.Location = new System.Drawing.Point(389, 205);
            this.pictureBoxCoin22.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCoin22.Name = "pictureBoxCoin22";
            this.pictureBoxCoin22.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxCoin22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin22.TabIndex = 25;
            this.pictureBoxCoin22.TabStop = false;
            this.pictureBoxCoin22.Tag = "level1coin";
            //
            // pictureBoxCoin21
            //
            this.pictureBoxCoin21.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin21.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin21.Image")));
            this.pictureBoxCoin21.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin21.InitialImage")));
            this.pictureBoxCoin21.Location = new System.Drawing.Point(360, 205);
            this.pictureBoxCoin21.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCoin21.Name = "pictureBoxCoin21";
            this.pictureBoxCoin21.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxCoin21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin21.TabIndex = 24;
            this.pictureBoxCoin21.TabStop = false;
            this.pictureBoxCoin21.Tag = "level1coin";
            //
            // pictureBoxCoin13
            //
            this.pictureBoxCoin13.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin13.Image")));
            this.pictureBoxCoin13.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin13.InitialImage")));
            this.pictureBoxCoin13.Location = new System.Drawing.Point(117, 384);
            this.pictureBoxCoin13.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCoin13.Name = "pictureBoxCoin13";
            this.pictureBoxCoin13.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxCoin13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin13.TabIndex = 29;
            this.pictureBoxCoin13.TabStop = false;
            this.pictureBoxCoin13.Tag = "level1coin";
            //
            // pictureBoxCoin12
            //
            this.pictureBoxCoin12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin12.Image")));
            this.pictureBoxCoin12.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin12.InitialImage")));
            this.pictureBoxCoin12.Location = new System.Drawing.Point(89, 384);
            this.pictureBoxCoin12.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCoin12.Name = "pictureBoxCoin12";
            this.pictureBoxCoin12.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxCoin12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin12.TabIndex = 28;
            this.pictureBoxCoin12.TabStop = false;
            this.pictureBoxCoin12.Tag = "level1coin";
            //
            // pictureBoxCoin11
            //
            this.pictureBoxCoin11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxCoin11.Image = global::RP3_Platformer.Properties.Resources.coin1;
            this.pictureBoxCoin11.InitialImage = global::RP3_Platformer.Properties.Resources.coin1;
            this.pictureBoxCoin11.Location = new System.Drawing.Point(63, 384);
            this.pictureBoxCoin11.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCoin11.Name = "pictureBoxCoin11";
            this.pictureBoxCoin11.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxCoin11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin11.TabIndex = 27;
            this.pictureBoxCoin11.TabStop = false;
            this.pictureBoxCoin11.Tag = "level1coin";
            //
            // pictureBoxCoin16
            //
            this.pictureBoxCoin16.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin16.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin16.Image")));
            this.pictureBoxCoin16.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin16.InitialImage")));
            this.pictureBoxCoin16.Location = new System.Drawing.Point(314, 295);
            this.pictureBoxCoin16.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCoin16.Name = "pictureBoxCoin16";
            this.pictureBoxCoin16.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxCoin16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin16.TabIndex = 32;
            this.pictureBoxCoin16.TabStop = false;
            this.pictureBoxCoin16.Tag = "level1coin";
            //
            // pictureBoxCoin15
            //
            this.pictureBoxCoin15.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin15.Image")));
            this.pictureBoxCoin15.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin15.InitialImage")));
            this.pictureBoxCoin15.Location = new System.Drawing.Point(286, 295);
            this.pictureBoxCoin15.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCoin15.Name = "pictureBoxCoin15";
            this.pictureBoxCoin15.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxCoin15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin15.TabIndex = 31;
            this.pictureBoxCoin15.TabStop = false;
            this.pictureBoxCoin15.Tag = "level1coin";
            //
            // pictureBoxCoin14
            //
            this.pictureBoxCoin14.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin14.Image")));
            this.pictureBoxCoin14.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin14.InitialImage")));
            this.pictureBoxCoin14.Location = new System.Drawing.Point(260, 295);
            this.pictureBoxCoin14.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCoin14.Name = "pictureBoxCoin14";
            this.pictureBoxCoin14.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxCoin14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin14.TabIndex = 30;
            this.pictureBoxCoin14.TabStop = false;
            this.pictureBoxCoin14.Tag = "level1coin";
            //
            // gameTimer
            //
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            //
            // pictureBoxCoin19
            //
            this.pictureBoxCoin19.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin19.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin19.Image")));
            this.pictureBoxCoin19.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin19.InitialImage")));
            this.pictureBoxCoin19.Location = new System.Drawing.Point(358, 89);
            this.pictureBoxCoin19.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCoin19.Name = "pictureBoxCoin19";
            this.pictureBoxCoin19.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxCoin19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin19.TabIndex = 36;
            this.pictureBoxCoin19.TabStop = false;
            this.pictureBoxCoin19.Tag = "level1coin";
            //
            // pictureBoxCoin18
            //
            this.pictureBoxCoin18.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin18.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin18.Image")));
            this.pictureBoxCoin18.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin18.InitialImage")));
            this.pictureBoxCoin18.Location = new System.Drawing.Point(331, 89);
            this.pictureBoxCoin18.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCoin18.Name = "pictureBoxCoin18";
            this.pictureBoxCoin18.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxCoin18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin18.TabIndex = 35;
            this.pictureBoxCoin18.TabStop = false;
            this.pictureBoxCoin18.Tag = "level1coin";
            //
            // pictureBoxCoin17
            //
            this.pictureBoxCoin17.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin17.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin17.Image")));
            this.pictureBoxCoin17.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin17.InitialImage")));
            this.pictureBoxCoin17.Location = new System.Drawing.Point(304, 89);
            this.pictureBoxCoin17.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCoin17.Name = "pictureBoxCoin17";
            this.pictureBoxCoin17.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxCoin17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin17.TabIndex = 34;
            this.pictureBoxCoin17.TabStop = false;
            this.pictureBoxCoin17.Tag = "level1coin";
            //
            // horizontalMovingPlatform
            //
            this.horizontalMovingPlatform.BackColor = System.Drawing.Color.Transparent;
            this.horizontalMovingPlatform.Image = global::RP3_Platformer.Properties.Resources.platformMoving;
            this.horizontalMovingPlatform.Location = new System.Drawing.Point(358, 110);
            this.horizontalMovingPlatform.Margin = new System.Windows.Forms.Padding(2);
            this.horizontalMovingPlatform.Name = "horizontalMovingPlatform";
            this.horizontalMovingPlatform.Size = new System.Drawing.Size(112, 17);
            this.horizontalMovingPlatform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.horizontalMovingPlatform.TabIndex = 37;
            this.horizontalMovingPlatform.TabStop = false;
            this.horizontalMovingPlatform.Tag = "level1platform";
            //
            // brick1
            //
            this.brick1.BackColor = System.Drawing.Color.Transparent;
            this.brick1.Image = global::RP3_Platformer.Properties.Resources.brick;
            this.brick1.Location = new System.Drawing.Point(160, 81);
            this.brick1.Margin = new System.Windows.Forms.Padding(2);
            this.brick1.Name = "brick1";
            this.brick1.Size = new System.Drawing.Size(23, 26);
            this.brick1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.brick1.TabIndex = 38;
            this.brick1.TabStop = false;
            this.brick1.Tag = "level1brick";
            //
            // verticalMovingPlatform
            //
            this.verticalMovingPlatform.BackColor = System.Drawing.Color.Transparent;
            this.verticalMovingPlatform.Image = global::RP3_Platformer.Properties.Resources.platformMoving;
            this.verticalMovingPlatform.Location = new System.Drawing.Point(521, 323);
            this.verticalMovingPlatform.Margin = new System.Windows.Forms.Padding(2);
            this.verticalMovingPlatform.Name = "verticalMovingPlatform";
            this.verticalMovingPlatform.Size = new System.Drawing.Size(85, 18);
            this.verticalMovingPlatform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.verticalMovingPlatform.TabIndex = 39;
            this.verticalMovingPlatform.TabStop = false;
            this.verticalMovingPlatform.Tag = "level1platform";
            //
            // groundChecker
            //
            this.groundChecker.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groundChecker.Location = new System.Drawing.Point(9, 405);
            this.groundChecker.Margin = new System.Windows.Forms.Padding(2);
            this.groundChecker.Name = "groundChecker";
            this.groundChecker.Size = new System.Drawing.Size(38, 2);
            this.groundChecker.TabIndex = 40;
            this.groundChecker.TabStop = false;
            //
            // floor2
            //
            this.floor2.BackColor = System.Drawing.Color.Transparent;
            this.floor2.Location = new System.Drawing.Point(620, 295);
            this.floor2.Margin = new System.Windows.Forms.Padding(2);
            this.floor2.Name = "floor2";
            this.floor2.Size = new System.Drawing.Size(110, 20);
            this.floor2.TabIndex = 41;
            this.floor2.TabStop = false;
            this.floor2.Tag = "level1platform";
            //
            // floor1
            //
            this.floor1.BackColor = System.Drawing.Color.Transparent;
            this.floor1.Location = new System.Drawing.Point(-2, 405);
            this.floor1.Margin = new System.Windows.Forms.Padding(2);
            this.floor1.Name = "floor1";
            this.floor1.Size = new System.Drawing.Size(748, 11);
            this.floor1.TabIndex = 42;
            this.floor1.TabStop = false;
            this.floor1.Tag = "level1platform";
            //
            // platform1_1
            //
            this.platform1_1.BackColor = System.Drawing.Color.Transparent;
            this.platform1_1.Image = global::RP3_Platformer.Properties.Resources.platform2;
            this.platform1_1.InitialImage = global::RP3_Platformer.Properties.Resources.platform2;
            this.platform1_1.Location = new System.Drawing.Point(246, 317);
            this.platform1_1.Margin = new System.Windows.Forms.Padding(0);
            this.platform1_1.Name = "platform1_1";
            this.platform1_1.Size = new System.Drawing.Size(23, 24);
            this.platform1_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform1_1.TabIndex = 43;
            this.platform1_1.TabStop = false;
            this.platform1_1.Tag = "level1platform";
            //
            // platform1_2
            //
            this.platform1_2.BackColor = System.Drawing.Color.Transparent;
            this.platform1_2.Image = global::RP3_Platformer.Properties.Resources.platform2;
            this.platform1_2.InitialImage = global::RP3_Platformer.Properties.Resources.platform2;
            this.platform1_2.Location = new System.Drawing.Point(268, 317);
            this.platform1_2.Margin = new System.Windows.Forms.Padding(0);
            this.platform1_2.Name = "platform1_2";
            this.platform1_2.Size = new System.Drawing.Size(23, 24);
            this.platform1_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform1_2.TabIndex = 44;
            this.platform1_2.TabStop = false;
            this.platform1_2.Tag = "level1platform";
            //
            // platform1_4
            //
            this.platform1_4.BackColor = System.Drawing.Color.Transparent;
            this.platform1_4.Image = global::RP3_Platformer.Properties.Resources.platform2;
            this.platform1_4.InitialImage = global::RP3_Platformer.Properties.Resources.platform2;
            this.platform1_4.Location = new System.Drawing.Point(314, 317);
            this.platform1_4.Margin = new System.Windows.Forms.Padding(0);
            this.platform1_4.Name = "platform1_4";
            this.platform1_4.Size = new System.Drawing.Size(23, 24);
            this.platform1_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform1_4.TabIndex = 46;
            this.platform1_4.TabStop = false;
            this.platform1_4.Tag = "level1platform";
            //
            // platform1_3
            //
            this.platform1_3.BackColor = System.Drawing.Color.Transparent;
            this.platform1_3.Image = global::RP3_Platformer.Properties.Resources.platform2;
            this.platform1_3.InitialImage = global::RP3_Platformer.Properties.Resources.platform2;
            this.platform1_3.Location = new System.Drawing.Point(291, 317);
            this.platform1_3.Margin = new System.Windows.Forms.Padding(0);
            this.platform1_3.Name = "platform1_3";
            this.platform1_3.Size = new System.Drawing.Size(23, 24);
            this.platform1_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform1_3.TabIndex = 45;
            this.platform1_3.TabStop = false;
            this.platform1_3.Tag = "level1platform";
            //
            // platform1_5
            //
            this.platform1_5.BackColor = System.Drawing.Color.Transparent;
            this.platform1_5.Image = global::RP3_Platformer.Properties.Resources.platform2;
            this.platform1_5.InitialImage = global::RP3_Platformer.Properties.Resources.platform2;
            this.platform1_5.Location = new System.Drawing.Point(336, 317);
            this.platform1_5.Margin = new System.Windows.Forms.Padding(0);
            this.platform1_5.Name = "platform1_5";
            this.platform1_5.Size = new System.Drawing.Size(23, 24);
            this.platform1_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform1_5.TabIndex = 47;
            this.platform1_5.TabStop = false;
            this.platform1_5.Tag = "level1platform";
            //
            // platform2_5
            //
            this.platform2_5.BackColor = System.Drawing.Color.Transparent;
            this.platform2_5.Image = global::RP3_Platformer.Properties.Resources.platform2;
            this.platform2_5.InitialImage = global::RP3_Platformer.Properties.Resources.platform2;
            this.platform2_5.Location = new System.Drawing.Point(160, 160);
            this.platform2_5.Margin = new System.Windows.Forms.Padding(0);
            this.platform2_5.Name = "platform2_5";
            this.platform2_5.Size = new System.Drawing.Size(23, 24);
            this.platform2_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform2_5.TabIndex = 52;
            this.platform2_5.TabStop = false;
            this.platform2_5.Tag = "level1platform";
            //
            // platform2_4
            //
            this.platform2_4.BackColor = System.Drawing.Color.Transparent;
            this.platform2_4.Image = global::RP3_Platformer.Properties.Resources.platform2;
            this.platform2_4.InitialImage = global::RP3_Platformer.Properties.Resources.platform2;
            this.platform2_4.Location = new System.Drawing.Point(137, 160);
            this.platform2_4.Margin = new System.Windows.Forms.Padding(0);
            this.platform2_4.Name = "platform2_4";
            this.platform2_4.Size = new System.Drawing.Size(23, 24);
            this.platform2_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform2_4.TabIndex = 51;
            this.platform2_4.TabStop = false;
            this.platform2_4.Tag = "level1platform";
            //
            // platform2_3
            //
            this.platform2_3.BackColor = System.Drawing.Color.Transparent;
            this.platform2_3.Image = global::RP3_Platformer.Properties.Resources.platform2;
            this.platform2_3.InitialImage = global::RP3_Platformer.Properties.Resources.platform2;
            this.platform2_3.Location = new System.Drawing.Point(115, 160);
            this.platform2_3.Margin = new System.Windows.Forms.Padding(0);
            this.platform2_3.Name = "platform2_3";
            this.platform2_3.Size = new System.Drawing.Size(23, 24);
            this.platform2_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform2_3.TabIndex = 50;
            this.platform2_3.TabStop = false;
            this.platform2_3.Tag = "level1platform";
            //
            // platform2_2
            //
            this.platform2_2.BackColor = System.Drawing.Color.Transparent;
            this.platform2_2.Image = global::RP3_Platformer.Properties.Resources.platform2;
            this.platform2_2.InitialImage = global::RP3_Platformer.Properties.Resources.platform2;
            this.platform2_2.Location = new System.Drawing.Point(92, 160);
            this.platform2_2.Margin = new System.Windows.Forms.Padding(0);
            this.platform2_2.Name = "platform2_2";
            this.platform2_2.Size = new System.Drawing.Size(23, 24);
            this.platform2_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform2_2.TabIndex = 49;
            this.platform2_2.TabStop = false;
            this.platform2_2.Tag = "level1platform";
            //
            // platform2_1
            //
            this.platform2_1.BackColor = System.Drawing.Color.Transparent;
            this.platform2_1.Image = global::RP3_Platformer.Properties.Resources.platform2;
            this.platform2_1.InitialImage = global::RP3_Platformer.Properties.Resources.platform2;
            this.platform2_1.Location = new System.Drawing.Point(70, 160);
            this.platform2_1.Margin = new System.Windows.Forms.Padding(0);
            this.platform2_1.Name = "platform2_1";
            this.platform2_1.Size = new System.Drawing.Size(23, 24);
            this.platform2_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform2_1.TabIndex = 48;
            this.platform2_1.TabStop = false;
            this.platform2_1.Tag = "level1platform";
            //
            // platform5_5
            //
            this.platform5_5.BackColor = System.Drawing.Color.Transparent;
            this.platform5_5.Image = global::RP3_Platformer.Properties.Resources.platform2;
            this.platform5_5.InitialImage = global::RP3_Platformer.Properties.Resources.platform2;
            this.platform5_5.Location = new System.Drawing.Point(650, 103);
            this.platform5_5.Margin = new System.Windows.Forms.Padding(0);
            this.platform5_5.Name = "platform5_5";
            this.platform5_5.Size = new System.Drawing.Size(23, 24);
            this.platform5_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform5_5.TabIndex = 57;
            this.platform5_5.TabStop = false;
            this.platform5_5.Tag = "level1platform";
            //
            // platform5_4
            //
            this.platform5_4.BackColor = System.Drawing.Color.Transparent;
            this.platform5_4.Image = global::RP3_Platformer.Properties.Resources.platform2;
            this.platform5_4.InitialImage = global::RP3_Platformer.Properties.Resources.platform2;
            this.platform5_4.Location = new System.Drawing.Point(628, 103);
            this.platform5_4.Margin = new System.Windows.Forms.Padding(0);
            this.platform5_4.Name = "platform5_4";
            this.platform5_4.Size = new System.Drawing.Size(23, 24);
            this.platform5_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform5_4.TabIndex = 56;
            this.platform5_4.TabStop = false;
            this.platform5_4.Tag = "level1platform";
            //
            // platform5_3
            //
            this.platform5_3.BackColor = System.Drawing.Color.Transparent;
            this.platform5_3.Image = global::RP3_Platformer.Properties.Resources.platform2;
            this.platform5_3.InitialImage = global::RP3_Platformer.Properties.Resources.platform2;
            this.platform5_3.Location = new System.Drawing.Point(605, 103);
            this.platform5_3.Margin = new System.Windows.Forms.Padding(0);
            this.platform5_3.Name = "platform5_3";
            this.platform5_3.Size = new System.Drawing.Size(23, 24);
            this.platform5_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform5_3.TabIndex = 55;
            this.platform5_3.TabStop = false;
            this.platform5_3.Tag = "level1platform";
            //
            // platform5_2
            //
            this.platform5_2.BackColor = System.Drawing.Color.Transparent;
            this.platform5_2.Image = global::RP3_Platformer.Properties.Resources.platform2;
            this.platform5_2.InitialImage = global::RP3_Platformer.Properties.Resources.platform2;
            this.platform5_2.Location = new System.Drawing.Point(583, 103);
            this.platform5_2.Margin = new System.Windows.Forms.Padding(0);
            this.platform5_2.Name = "platform5_2";
            this.platform5_2.Size = new System.Drawing.Size(23, 24);
            this.platform5_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform5_2.TabIndex = 54;
            this.platform5_2.TabStop = false;
            this.platform5_2.Tag = "level1platform";
            //
            // platform5_1
            //
            this.platform5_1.BackColor = System.Drawing.Color.Transparent;
            this.platform5_1.Image = global::RP3_Platformer.Properties.Resources.platform2;
            this.platform5_1.InitialImage = global::RP3_Platformer.Properties.Resources.platform2;
            this.platform5_1.Location = new System.Drawing.Point(560, 103);
            this.platform5_1.Margin = new System.Windows.Forms.Padding(0);
            this.platform5_1.Name = "platform5_1";
            this.platform5_1.Size = new System.Drawing.Size(23, 24);
            this.platform5_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform5_1.TabIndex = 53;
            this.platform5_1.TabStop = false;
            this.platform5_1.Tag = "level1platform";
            //
            // platform3_3
            //
            this.platform3_3.BackColor = System.Drawing.Color.Transparent;
            this.platform3_3.Image = global::RP3_Platformer.Properties.Resources.platform2;
            this.platform3_3.InitialImage = global::RP3_Platformer.Properties.Resources.platform2;
            this.platform3_3.Location = new System.Drawing.Point(382, 223);
            this.platform3_3.Margin = new System.Windows.Forms.Padding(0);
            this.platform3_3.Name = "platform3_3";
            this.platform3_3.Size = new System.Drawing.Size(23, 24);
            this.platform3_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform3_3.TabIndex = 60;
            this.platform3_3.TabStop = false;
            this.platform3_3.Tag = "level1platform";
            //
            // platform3_2
            //
            this.platform3_2.BackColor = System.Drawing.Color.Transparent;
            this.platform3_2.Image = global::RP3_Platformer.Properties.Resources.platform2;
            this.platform3_2.InitialImage = global::RP3_Platformer.Properties.Resources.platform2;
            this.platform3_2.Location = new System.Drawing.Point(359, 223);
            this.platform3_2.Margin = new System.Windows.Forms.Padding(0);
            this.platform3_2.Name = "platform3_2";
            this.platform3_2.Size = new System.Drawing.Size(23, 24);
            this.platform3_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform3_2.TabIndex = 59;
            this.platform3_2.TabStop = false;
            this.platform3_2.Tag = "level1platform";
            //
            // platform3_1
            //
            this.platform3_1.BackColor = System.Drawing.Color.Transparent;
            this.platform3_1.Image = global::RP3_Platformer.Properties.Resources.platform2;
            this.platform3_1.InitialImage = global::RP3_Platformer.Properties.Resources.platform2;
            this.platform3_1.Location = new System.Drawing.Point(337, 223);
            this.platform3_1.Margin = new System.Windows.Forms.Padding(0);
            this.platform3_1.Name = "platform3_1";
            this.platform3_1.Size = new System.Drawing.Size(23, 24);
            this.platform3_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform3_1.TabIndex = 58;
            this.platform3_1.TabStop = false;
            this.platform3_1.Tag = "level1platform";
            //
            // platform4_3
            //
            this.platform4_3.BackColor = System.Drawing.Color.Transparent;
            this.platform4_3.Image = global::RP3_Platformer.Properties.Resources.platform2;
            this.platform4_3.InitialImage = global::RP3_Platformer.Properties.Resources.platform2;
            this.platform4_3.Location = new System.Drawing.Point(533, 197);
            this.platform4_3.Margin = new System.Windows.Forms.Padding(0);
            this.platform4_3.Name = "platform4_3";
            this.platform4_3.Size = new System.Drawing.Size(23, 24);
            this.platform4_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform4_3.TabIndex = 63;
            this.platform4_3.TabStop = false;
            this.platform4_3.Tag = "level1platform";
            //
            // platform4_2
            //
            this.platform4_2.BackColor = System.Drawing.Color.Transparent;
            this.platform4_2.Image = global::RP3_Platformer.Properties.Resources.platform2;
            this.platform4_2.InitialImage = global::RP3_Platformer.Properties.Resources.platform2;
            this.platform4_2.Location = new System.Drawing.Point(511, 197);
            this.platform4_2.Margin = new System.Windows.Forms.Padding(0);
            this.platform4_2.Name = "platform4_2";
            this.platform4_2.Size = new System.Drawing.Size(23, 24);
            this.platform4_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform4_2.TabIndex = 62;
            this.platform4_2.TabStop = false;
            this.platform4_2.Tag = "level1platform";
            //
            // platform4_1
            //
            this.platform4_1.BackColor = System.Drawing.Color.Transparent;
            this.platform4_1.Image = global::RP3_Platformer.Properties.Resources.platform2;
            this.platform4_1.InitialImage = global::RP3_Platformer.Properties.Resources.platform2;
            this.platform4_1.Location = new System.Drawing.Point(488, 197);
            this.platform4_1.Margin = new System.Windows.Forms.Padding(0);
            this.platform4_1.Name = "platform4_1";
            this.platform4_1.Size = new System.Drawing.Size(23, 24);
            this.platform4_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform4_1.TabIndex = 61;
            this.platform4_1.TabStop = false;
            this.platform4_1.Tag = "level1platform";
            //
            // pictureBoxCoin27
            //
            this.pictureBoxCoin27.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin27.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin27.Image")));
            this.pictureBoxCoin27.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin27.InitialImage")));
            this.pictureBoxCoin27.Location = new System.Drawing.Point(284, 89);
            this.pictureBoxCoin27.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCoin27.Name = "pictureBoxCoin27";
            this.pictureBoxCoin27.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxCoin27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin27.TabIndex = 66;
            this.pictureBoxCoin27.TabStop = false;
            this.pictureBoxCoin27.Tag = "level1coin";
            //
            // pictureBoxCoin29
            //
            this.pictureBoxCoin29.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin29.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin29.Image")));
            this.pictureBoxCoin29.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin29.InitialImage")));
            this.pictureBoxCoin29.Location = new System.Drawing.Point(542, 178);
            this.pictureBoxCoin29.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCoin29.Name = "pictureBoxCoin29";
            this.pictureBoxCoin29.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxCoin29.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin29.TabIndex = 65;
            this.pictureBoxCoin29.TabStop = false;
            this.pictureBoxCoin29.Tag = "level1coin";
            //
            // pictureBoxCoin28
            //
            this.pictureBoxCoin28.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin28.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin28.Image")));
            this.pictureBoxCoin28.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin28.InitialImage")));
            this.pictureBoxCoin28.Location = new System.Drawing.Point(516, 178);
            this.pictureBoxCoin28.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCoin28.Name = "pictureBoxCoin28";
            this.pictureBoxCoin28.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxCoin28.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin28.TabIndex = 64;
            this.pictureBoxCoin28.TabStop = false;
            this.pictureBoxCoin28.Tag = "level1coin";
            //
            // pictureBoxCoin24
            //
            this.pictureBoxCoin24.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin24.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin24.Image")));
            this.pictureBoxCoin24.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin24.InitialImage")));
            this.pictureBoxCoin24.Location = new System.Drawing.Point(446, 43);
            this.pictureBoxCoin24.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCoin24.Name = "pictureBoxCoin24";
            this.pictureBoxCoin24.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxCoin24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin24.TabIndex = 69;
            this.pictureBoxCoin24.TabStop = false;
            this.pictureBoxCoin24.Tag = "level1coin";
            //
            // pictureBoxCoin26
            //
            this.pictureBoxCoin26.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin26.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin26.Image")));
            this.pictureBoxCoin26.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin26.InitialImage")));
            this.pictureBoxCoin26.Location = new System.Drawing.Point(504, 57);
            this.pictureBoxCoin26.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCoin26.Name = "pictureBoxCoin26";
            this.pictureBoxCoin26.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxCoin26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin26.TabIndex = 68;
            this.pictureBoxCoin26.TabStop = false;
            this.pictureBoxCoin26.Tag = "level1coin";
            //
            // pictureBoxCoin25
            //
            this.pictureBoxCoin25.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin25.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin25.Image")));
            this.pictureBoxCoin25.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin25.InitialImage")));
            this.pictureBoxCoin25.Location = new System.Drawing.Point(475, 43);
            this.pictureBoxCoin25.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCoin25.Name = "pictureBoxCoin25";
            this.pictureBoxCoin25.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxCoin25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin25.TabIndex = 67;
            this.pictureBoxCoin25.TabStop = false;
            this.pictureBoxCoin25.Tag = "level1coin";
            //
            // pictureBoxCoin23
            //
            this.pictureBoxCoin23.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin23.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin23.Image")));
            this.pictureBoxCoin23.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin23.InitialImage")));
            this.pictureBoxCoin23.Location = new System.Drawing.Point(418, 64);
            this.pictureBoxCoin23.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCoin23.Name = "pictureBoxCoin23";
            this.pictureBoxCoin23.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxCoin23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin23.TabIndex = 70;
            this.pictureBoxCoin23.TabStop = false;
            this.pictureBoxCoin23.Tag = "level1coin";
            //
            // pictureBoxCoin5
            //
            this.pictureBoxCoin5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin5.Image")));
            this.pictureBoxCoin5.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin5.InitialImage")));
            this.pictureBoxCoin5.Location = new System.Drawing.Point(14, 103);
            this.pictureBoxCoin5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCoin5.Name = "pictureBoxCoin5";
            this.pictureBoxCoin5.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxCoin5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin5.TabIndex = 71;
            this.pictureBoxCoin5.TabStop = false;
            this.pictureBoxCoin5.Tag = "level1coin";
            //
            // pictureBoxCoin6
            //
            this.pictureBoxCoin6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin6.Image")));
            this.pictureBoxCoin6.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin6.InitialImage")));
            this.pictureBoxCoin6.Location = new System.Drawing.Point(14, 128);
            this.pictureBoxCoin6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCoin6.Name = "pictureBoxCoin6";
            this.pictureBoxCoin6.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxCoin6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin6.TabIndex = 72;
            this.pictureBoxCoin6.TabStop = false;
            this.pictureBoxCoin6.Tag = "level1coin";
            //
            // pictureBoxCoin8
            //
            this.pictureBoxCoin8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin8.Image")));
            this.pictureBoxCoin8.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin8.InitialImage")));
            this.pictureBoxCoin8.Location = new System.Drawing.Point(14, 178);
            this.pictureBoxCoin8.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCoin8.Name = "pictureBoxCoin8";
            this.pictureBoxCoin8.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxCoin8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin8.TabIndex = 74;
            this.pictureBoxCoin8.TabStop = false;
            this.pictureBoxCoin8.Tag = "level1coin";
            //
            // pictureBoxCoin7
            //
            this.pictureBoxCoin7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin7.Image")));
            this.pictureBoxCoin7.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin7.InitialImage")));
            this.pictureBoxCoin7.Location = new System.Drawing.Point(14, 154);
            this.pictureBoxCoin7.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCoin7.Name = "pictureBoxCoin7";
            this.pictureBoxCoin7.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxCoin7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin7.TabIndex = 73;
            this.pictureBoxCoin7.TabStop = false;
            this.pictureBoxCoin7.Tag = "level1coin";
            //
            // pictureBoxCoin10
            //
            this.pictureBoxCoin10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin10.Image")));
            this.pictureBoxCoin10.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin10.InitialImage")));
            this.pictureBoxCoin10.Location = new System.Drawing.Point(14, 232);
            this.pictureBoxCoin10.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCoin10.Name = "pictureBoxCoin10";
            this.pictureBoxCoin10.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxCoin10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin10.TabIndex = 76;
            this.pictureBoxCoin10.TabStop = false;
            this.pictureBoxCoin10.Tag = "level1coin";
            //
            // pictureBoxCoin9
            //
            this.pictureBoxCoin9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin9.Image")));
            this.pictureBoxCoin9.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin9.InitialImage")));
            this.pictureBoxCoin9.Location = new System.Drawing.Point(14, 207);
            this.pictureBoxCoin9.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCoin9.Name = "pictureBoxCoin9";
            this.pictureBoxCoin9.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxCoin9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin9.TabIndex = 75;
            this.pictureBoxCoin9.TabStop = false;
            this.pictureBoxCoin9.Tag = "level1coin";
            //
            // pictureBoxEnemyTurtle2
            //
            this.pictureBoxEnemyTurtle2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEnemyTurtle2.Image = global::RP3_Platformer.Properties.Resources.turtle1;
            this.pictureBoxEnemyTurtle2.InitialImage = global::RP3_Platformer.Properties.Resources.turtle1;
            this.pictureBoxEnemyTurtle2.Location = new System.Drawing.Point(160, 119);
            this.pictureBoxEnemyTurtle2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxEnemyTurtle2.Name = "pictureBoxEnemyTurtle2";
            this.pictureBoxEnemyTurtle2.Size = new System.Drawing.Size(32, 41);
            this.pictureBoxEnemyTurtle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEnemyTurtle2.TabIndex = 77;
            this.pictureBoxEnemyTurtle2.TabStop = false;
            this.pictureBoxEnemyTurtle2.Tag = "level1Enemy";
            //
            // pictureBoxEnemyTurtle4
            //
            this.pictureBoxEnemyTurtle4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEnemyTurtle4.Image = global::RP3_Platformer.Properties.Resources.turtle1;
            this.pictureBoxEnemyTurtle4.InitialImage = global::RP3_Platformer.Properties.Resources.turtle1;
            this.pictureBoxEnemyTurtle4.Location = new System.Drawing.Point(593, 63);
            this.pictureBoxEnemyTurtle4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxEnemyTurtle4.Name = "pictureBoxEnemyTurtle4";
            this.pictureBoxEnemyTurtle4.Size = new System.Drawing.Size(32, 41);
            this.pictureBoxEnemyTurtle4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEnemyTurtle4.TabIndex = 78;
            this.pictureBoxEnemyTurtle4.TabStop = false;
            this.pictureBoxEnemyTurtle4.Tag = "level1Enemy";
            //
            // pictureBoxEnemyTurtle3
            //
            this.pictureBoxEnemyTurtle3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEnemyTurtle3.Image = global::RP3_Platformer.Properties.Resources.turtle1;
            this.pictureBoxEnemyTurtle3.InitialImage = global::RP3_Platformer.Properties.Resources.turtle1;
            this.pictureBoxEnemyTurtle3.Location = new System.Drawing.Point(458, 366);
            this.pictureBoxEnemyTurtle3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxEnemyTurtle3.Name = "pictureBoxEnemyTurtle3";
            this.pictureBoxEnemyTurtle3.Size = new System.Drawing.Size(32, 41);
            this.pictureBoxEnemyTurtle3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEnemyTurtle3.TabIndex = 79;
            this.pictureBoxEnemyTurtle3.TabStop = false;
            this.pictureBoxEnemyTurtle3.Tag = "level1Enemy";
            //
            // pipeFinal
            //
            this.pipeFinal.BackColor = System.Drawing.Color.Transparent;
            this.pipeFinal.Image = global::RP3_Platformer.Properties.Resources.pipe;
            this.pipeFinal.InitialImage = global::RP3_Platformer.Properties.Resources.pipe;
            this.pipeFinal.Location = new System.Drawing.Point(677, 246);
            this.pipeFinal.Margin = new System.Windows.Forms.Padding(2);
            this.pipeFinal.Name = "pipeFinal";
            this.pipeFinal.Size = new System.Drawing.Size(73, 49);
            this.pipeFinal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeFinal.TabIndex = 80;
            this.pipeFinal.TabStop = false;
            this.pipeFinal.Tag = "level1FinalPipe";
            //
            // pictureBoxCoin36
            //
            this.pictureBoxCoin36.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin36.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin36.Image")));
            this.pictureBoxCoin36.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin36.InitialImage")));
            this.pictureBoxCoin36.Location = new System.Drawing.Point(586, 384);
            this.pictureBoxCoin36.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCoin36.Name = "pictureBoxCoin36";
            this.pictureBoxCoin36.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxCoin36.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin36.TabIndex = 83;
            this.pictureBoxCoin36.TabStop = false;
            this.pictureBoxCoin36.Tag = "level1coin";
            //
            // pictureBoxCoin35
            //
            this.pictureBoxCoin35.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin35.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin35.Image")));
            this.pictureBoxCoin35.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin35.InitialImage")));
            this.pictureBoxCoin35.Location = new System.Drawing.Point(558, 384);
            this.pictureBoxCoin35.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCoin35.Name = "pictureBoxCoin35";
            this.pictureBoxCoin35.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxCoin35.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin35.TabIndex = 82;
            this.pictureBoxCoin35.TabStop = false;
            this.pictureBoxCoin35.Tag = "level1coin";
            //
            // pictureBoxCoin34
            //
            this.pictureBoxCoin34.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin34.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxCoin34.Image = global::RP3_Platformer.Properties.Resources.coin1;
            this.pictureBoxCoin34.InitialImage = global::RP3_Platformer.Properties.Resources.coin1;
            this.pictureBoxCoin34.Location = new System.Drawing.Point(532, 384);
            this.pictureBoxCoin34.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCoin34.Name = "pictureBoxCoin34";
            this.pictureBoxCoin34.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxCoin34.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin34.TabIndex = 81;
            this.pictureBoxCoin34.TabStop = false;
            this.pictureBoxCoin34.Tag = "level1coin";
            //
            // pictureBoxEnemyPlant1
            //
            this.pictureBoxEnemyPlant1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEnemyPlant1.Image = global::RP3_Platformer.Properties.Resources.plant1;
            this.pictureBoxEnemyPlant1.InitialImage = global::RP3_Platformer.Properties.Resources.plant1;
            this.pictureBoxEnemyPlant1.Location = new System.Drawing.Point(415, 342);
            this.pictureBoxEnemyPlant1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxEnemyPlant1.Name = "pictureBoxEnemyPlant1";
            this.pictureBoxEnemyPlant1.Size = new System.Drawing.Size(32, 41);
            this.pictureBoxEnemyPlant1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEnemyPlant1.TabIndex = 84;
            this.pictureBoxEnemyPlant1.TabStop = false;
            this.pictureBoxEnemyPlant1.Tag = "level1Enemy";
            //
            // pipePlant1
            //
            this.pipePlant1.BackColor = System.Drawing.Color.Transparent;
            this.pipePlant1.Image = global::RP3_Platformer.Properties.Resources.pipe2;
            this.pipePlant1.InitialImage = global::RP3_Platformer.Properties.Resources.pipe2;
            this.pipePlant1.Location = new System.Drawing.Point(418, 381);
            this.pipePlant1.Margin = new System.Windows.Forms.Padding(2);
            this.pipePlant1.Name = "pipePlant1";
            this.pipePlant1.Size = new System.Drawing.Size(26, 25);
            this.pipePlant1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipePlant1.TabIndex = 85;
            this.pipePlant1.TabStop = false;
            this.pipePlant1.Tag = "level1Pipe";
            //
            // pipePlant2
            //
            this.pipePlant2.BackColor = System.Drawing.Color.Transparent;
            this.pipePlant2.Image = global::RP3_Platformer.Properties.Resources.pipe2;
            this.pipePlant2.InitialImage = global::RP3_Platformer.Properties.Resources.pipe2;
            this.pipePlant2.Location = new System.Drawing.Point(485, 173);
            this.pipePlant2.Margin = new System.Windows.Forms.Padding(2);
            this.pipePlant2.Name = "pipePlant2";
            this.pipePlant2.Size = new System.Drawing.Size(26, 25);
            this.pipePlant2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipePlant2.TabIndex = 87;
            this.pipePlant2.TabStop = false;
            this.pipePlant2.Tag = "level1Pipe";
            //
            // pictureBoxEnemyPlant2
            //
            this.pictureBoxEnemyPlant2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEnemyPlant2.Image = global::RP3_Platformer.Properties.Resources.plant1;
            this.pictureBoxEnemyPlant2.InitialImage = global::RP3_Platformer.Properties.Resources.plant1;
            this.pictureBoxEnemyPlant2.Location = new System.Drawing.Point(482, 132);
            this.pictureBoxEnemyPlant2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxEnemyPlant2.Name = "pictureBoxEnemyPlant2";
            this.pictureBoxEnemyPlant2.Size = new System.Drawing.Size(32, 41);
            this.pictureBoxEnemyPlant2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEnemyPlant2.TabIndex = 86;
            this.pictureBoxEnemyPlant2.TabStop = false;
            this.pictureBoxEnemyPlant2.Tag = "level1Enemy";
            //
            // brick2
            //
            this.brick2.BackColor = System.Drawing.Color.Transparent;
            this.brick2.Image = global::RP3_Platformer.Properties.Resources.brick;
            this.brick2.Location = new System.Drawing.Point(628, 103);
            this.brick2.Margin = new System.Windows.Forms.Padding(2);
            this.brick2.Name = "brick2";
            this.brick2.Size = new System.Drawing.Size(23, 24);
            this.brick2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.brick2.TabIndex = 88;
            this.brick2.TabStop = false;
            this.brick2.Tag = "level1brick";
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(736, 449);
            this.Controls.Add(this.brick2);
            this.Controls.Add(this.pipePlant2);
            this.Controls.Add(this.pictureBoxEnemyPlant2);
            this.Controls.Add(this.pipePlant1);
            this.Controls.Add(this.pictureBoxEnemyPlant1);
            this.Controls.Add(this.pictureBoxCoin36);
            this.Controls.Add(this.pictureBoxCoin35);
            this.Controls.Add(this.pictureBoxCoin34);
            this.Controls.Add(this.pipeFinal);
            this.Controls.Add(this.pictureBoxEnemyTurtle3);
            this.Controls.Add(this.pictureBoxEnemyTurtle4);
            this.Controls.Add(this.pictureBoxEnemyTurtle2);
            this.Controls.Add(this.pictureBoxCoin10);
            this.Controls.Add(this.pictureBoxCoin9);
            this.Controls.Add(this.pictureBoxCoin8);
            this.Controls.Add(this.pictureBoxCoin7);
            this.Controls.Add(this.pictureBoxCoin6);
            this.Controls.Add(this.pictureBoxCoin5);
            this.Controls.Add(this.pictureBoxCoin23);
            this.Controls.Add(this.pictureBoxCoin24);
            this.Controls.Add(this.pictureBoxCoin26);
            this.Controls.Add(this.pictureBoxCoin25);
            this.Controls.Add(this.pictureBoxCoin27);
            this.Controls.Add(this.pictureBoxCoin29);
            this.Controls.Add(this.pictureBoxCoin28);
            this.Controls.Add(this.platform4_3);
            this.Controls.Add(this.platform4_2);
            this.Controls.Add(this.platform4_1);
            this.Controls.Add(this.platform3_3);
            this.Controls.Add(this.platform3_2);
            this.Controls.Add(this.platform3_1);
            this.Controls.Add(this.platform5_5);
            this.Controls.Add(this.platform5_4);
            this.Controls.Add(this.platform5_3);
            this.Controls.Add(this.platform5_2);
            this.Controls.Add(this.platform5_1);
            this.Controls.Add(this.platform2_5);
            this.Controls.Add(this.platform2_4);
            this.Controls.Add(this.platform2_3);
            this.Controls.Add(this.platform2_2);
            this.Controls.Add(this.platform2_1);
            this.Controls.Add(this.platform1_5);
            this.Controls.Add(this.platform1_4);
            this.Controls.Add(this.platform1_3);
            this.Controls.Add(this.platform1_2);
            this.Controls.Add(this.platform1_1);
            this.Controls.Add(this.floor1);
            this.Controls.Add(this.floor2);
            this.Controls.Add(this.groundChecker);
            this.Controls.Add(this.verticalMovingPlatform);
            this.Controls.Add(this.brick1);
            this.Controls.Add(this.horizontalMovingPlatform);
            this.Controls.Add(this.pictureBoxCoin19);
            this.Controls.Add(this.pictureBoxCoin18);
            this.Controls.Add(this.pictureBoxCoin17);
            this.Controls.Add(this.pictureBoxCoin16);
            this.Controls.Add(this.pictureBoxCoin15);
            this.Controls.Add(this.pictureBoxCoin14);
            this.Controls.Add(this.pictureBoxCoin13);
            this.Controls.Add(this.pictureBoxCoin12);
            this.Controls.Add(this.pictureBoxCoin11);
            this.Controls.Add(this.pictureBoxCoin20);
            this.Controls.Add(this.pictureBoxCoin22);
            this.Controls.Add(this.pictureBoxCoin21);
            this.Controls.Add(this.pictureBoxCoin30);
            this.Controls.Add(this.pictureBoxCoin33);
            this.Controls.Add(this.pictureBoxCoin32);
            this.Controls.Add(this.pictureBoxCoin31);
            this.Controls.Add(this.pictureBoxCoin2);
            this.Controls.Add(this.pictureBoxCoin1);
            this.Controls.Add(this.pictureBoxCoin4);
            this.Controls.Add(this.pictureBoxCoin3);
            this.Controls.Add(this.pictureBoxEnemyTurtle1);
            this.Controls.Add(this.pictureBoxPlayer);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelLives);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemyTurtle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalMovingPlatform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalMovingPlatform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundChecker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform5_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform5_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform5_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform5_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform5_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform3_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform3_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform3_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform4_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform4_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform4_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemyTurtle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemyTurtle4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemyTurtle3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemyPlant1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipePlant1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipePlant2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemyPlant2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLives;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.PictureBox pictureBoxPlayer;
        private System.Windows.Forms.PictureBox pictureBoxEnemyTurtle1;
        private System.Windows.Forms.PictureBox pictureBoxCoin3;
        private System.Windows.Forms.PictureBox pictureBoxCoin4;
        private System.Windows.Forms.PictureBox pictureBoxCoin2;
        private System.Windows.Forms.PictureBox pictureBoxCoin1;
        private System.Windows.Forms.PictureBox pictureBoxCoin30;
        private System.Windows.Forms.PictureBox pictureBoxCoin33;
        private System.Windows.Forms.PictureBox pictureBoxCoin32;
        private System.Windows.Forms.PictureBox pictureBoxCoin31;
        private System.Windows.Forms.PictureBox pictureBoxCoin20;
        private System.Windows.Forms.PictureBox pictureBoxCoin22;
        private System.Windows.Forms.PictureBox pictureBoxCoin21;
        private System.Windows.Forms.PictureBox pictureBoxCoin13;
        private System.Windows.Forms.PictureBox pictureBoxCoin12;
        private System.Windows.Forms.PictureBox pictureBoxCoin11;
        private System.Windows.Forms.PictureBox pictureBoxCoin16;
        private System.Windows.Forms.PictureBox pictureBoxCoin15;
        private System.Windows.Forms.PictureBox pictureBoxCoin14;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pictureBoxCoin19;
        private System.Windows.Forms.PictureBox pictureBoxCoin18;
        private System.Windows.Forms.PictureBox pictureBoxCoin17;
        private System.Windows.Forms.PictureBox horizontalMovingPlatform;
        private System.Windows.Forms.PictureBox brick1;
        private System.Windows.Forms.PictureBox verticalMovingPlatform;
        private System.Windows.Forms.PictureBox groundChecker;
        private System.Windows.Forms.PictureBox floor2;
        private System.Windows.Forms.PictureBox floor1;
        private System.Windows.Forms.PictureBox platform1_1;
        private System.Windows.Forms.PictureBox platform1_2;
        private System.Windows.Forms.PictureBox platform1_4;
        private System.Windows.Forms.PictureBox platform1_3;
        private System.Windows.Forms.PictureBox platform1_5;
        private System.Windows.Forms.PictureBox platform2_5;
        private System.Windows.Forms.PictureBox platform2_4;
        private System.Windows.Forms.PictureBox platform2_3;
        private System.Windows.Forms.PictureBox platform2_2;
        private System.Windows.Forms.PictureBox platform2_1;
        private System.Windows.Forms.PictureBox platform5_5;
        private System.Windows.Forms.PictureBox platform5_4;
        private System.Windows.Forms.PictureBox platform5_3;
        private System.Windows.Forms.PictureBox platform5_2;
        private System.Windows.Forms.PictureBox platform5_1;
        private System.Windows.Forms.PictureBox platform3_3;
        private System.Windows.Forms.PictureBox platform3_2;
        private System.Windows.Forms.PictureBox platform3_1;
        private System.Windows.Forms.PictureBox platform4_3;
        private System.Windows.Forms.PictureBox platform4_2;
        private System.Windows.Forms.PictureBox platform4_1;
        private System.Windows.Forms.PictureBox pictureBoxCoin27;
        private System.Windows.Forms.PictureBox pictureBoxCoin29;
        private System.Windows.Forms.PictureBox pictureBoxCoin28;
        private System.Windows.Forms.PictureBox pictureBoxCoin24;
        private System.Windows.Forms.PictureBox pictureBoxCoin26;
        private System.Windows.Forms.PictureBox pictureBoxCoin25;
        private System.Windows.Forms.PictureBox pictureBoxCoin23;
        private System.Windows.Forms.PictureBox pictureBoxCoin5;
        private System.Windows.Forms.PictureBox pictureBoxCoin6;
        private System.Windows.Forms.PictureBox pictureBoxCoin8;
        private System.Windows.Forms.PictureBox pictureBoxCoin7;
        private System.Windows.Forms.PictureBox pictureBoxCoin10;
        private System.Windows.Forms.PictureBox pictureBoxCoin9;
        private System.Windows.Forms.PictureBox pictureBoxEnemyTurtle2;
        private System.Windows.Forms.PictureBox pictureBoxEnemyTurtle4;
        private System.Windows.Forms.PictureBox pictureBoxEnemyTurtle3;
        private System.Windows.Forms.PictureBox pipeFinal;
        private System.Windows.Forms.PictureBox pictureBoxCoin36;
        private System.Windows.Forms.PictureBox pictureBoxCoin35;
        private System.Windows.Forms.PictureBox pictureBoxCoin34;
        private System.Windows.Forms.PictureBox pictureBoxEnemyPlant1;
        private System.Windows.Forms.PictureBox pipePlant1;
        private System.Windows.Forms.PictureBox pipePlant2;
        private System.Windows.Forms.PictureBox pictureBoxEnemyPlant2;
        private System.Windows.Forms.PictureBox brick2;
    }
}

