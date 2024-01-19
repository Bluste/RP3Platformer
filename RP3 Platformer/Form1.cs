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
using System.Runtime.InteropServices;
using System.Collections.Concurrent;
using System.Collections;
using System.IO;

namespace RP3_Platformer
{
    public partial class Form1 : Form
    {
        private List<string> Coinframes = new List<string>(new String[] {"coin1", "coin2", "coin3",
            "coin4", "coin5"});

        private List<string> Plantframes = new List<string>(new String[] { "plant1", "plant2", "plant3" });

        private List<string> TurtleRightframes = new List<string>(new string[] { "turtle1", "turtle2", "turtle3", "turtle4", "turtle5" });
        private List<string> TurtleLeftframes = new List<string>(new string[] { "kornjacalijevo1", "kornjacalijevo2", "kornjacalijevo3", "kornjacalijevo4", "kornjacalijevo5" });

        private List<string> BombRightframes = new List<string>(new string[] { "bomb1", "bomb2", "bomb3", "bomb4", "bomb5" });
        private List<string> BombLeftframes = new List<string>(new string[] { "bomblijevo1", "bomblijevo2", "bomblijevo3", "bomblijevo4", "bomblijevo5" });


        private List<int> turtleCurrentFrameIndices = new List<int>();
        private List<PictureBox> turtlePictureBoxes = new List<PictureBox>();
        private List<PictureBox> turtleStopperBoxes_R = new List<PictureBox>();
        private List<PictureBox> turtleStopperBoxes_L = new List<PictureBox>();

        private List<int> bombCurrentFrameIndices = new List<int>();
        private List<PictureBox> bombPictureBoxes = new List<PictureBox>();
        private List<PictureBox> bombStopperBoxes_R = new List<PictureBox>();
        private List<PictureBox> bombStopperBoxes_L = new List<PictureBox>();

        //lava elementi
        private int lavaAltitude = 347;
        private int lavaRiseSpeed = 1;   // Set the speed at which lava rises
        private int lavaRiseCounter = 0;
        //private int lavaRiseDuration = 20 * 1000;  // Set the duration for lava to reach the altitude (20 seconds)
        //private DateTime lavaStartTime;  // Variable to store the start time of lava rising

        //heeeeeey!

        private int currentCoinFrameIndex = 0;
        private int currentPlantFrameIndex = 0;
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

        int level2LeftStopPoint = 84;
        int level2RightStopPoint = 370;
        int level2BottomStopPoint = 350;
        int level2TopStopPoint = 79;
        int level2HorizontalPlatformSpeed = 4;
        int level2VerticalPlatformSpeed = 4;

        int[] turtlespeed = { -1, 1, -1, 1 };
        int[] bombspeed = { -1, 1, -1, 1 };
        /*PictureBox[] pictureBoxEnemyTurtle = {pictureBoxEnemyTurtle1, pictureBoxEnemyTurtle1,
            pictureBoxEnemyTurtle1, pictureBoxEnemyTurtle1};*/

        //int turtlespeed1 = 3;
        //int turtlespeed2 = 3;
        //int turtlespeed3 = 3;
        //int turtlespeed4 = 3;

        int previousLocation = 0;

        int plantspeed1 = 2;
        int plantspeed2 = 2;

        bool cooldown = false;
        bool shieldOn = false;
        bool mushOn = false;

        bool plantmover1 = false;
        bool plantmover2 = false;
        bool lethal1 = true;
        bool lethal2 = true;

        bool firemover1 = false;
        bool firemover2 = false;

        int firespeed1 = 5;
        int firespeed2 = 5;

        int flowerover = 0;
        int flowerover2 = 0;
        int shieldover = 0;
        int shieldover2 = 0;
        int mushroomover = 0;

        //Level 2 settings
        int level2PlayerXPosition = 47;
        int level2PlayerYPosition = 65;

        private Timer marioAnimationTimer = new Timer();
        private int marioAnimationFrameInterval = 200; // Adjust this value for the desired speed


        //List<string> marioMovements = new List<string>();
        private List<string> marioMovements = new List<string>(new string[] { "marioStaying", "marioStaying","marioWin", "marioJumping", "mariojumpinglijevo",
        "marioWalking1","marioWalking2","marioWalking3","marioWalking4","marioWalking5","marioWalking6","marioWalking7","marioWalking8","marioWalking9",
        "mariowalking1lijevo","mariowalking2lijevo","mariowalking3lijevo","mariowalking4lijevo","mariowalking5lijevo","mariowalking6lijevo","mariowalking7lijevo","mariowalking8lijevo","mariowalking9lijevo",
        "marioFlying1","marioFlying2","marioFlying3","marioFlying4","marioFlying5","marioFlying6","marioFlying7","marioFlying8",
        "marioflying1lijevo","marioflying2lijevo","marioflying3lijevo","marioflying4lijevo","marioflying5lijevo","marioflying6lijevo","marioflying7lijevo","marioflying8lijevo"});

        int steps = 0;

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

            FlowerAdvancement();

            ShieldAdvancement();

            ShieldProtection();

            MushroomAdvancement();

            HandleCollisions();

            HandlePlayerMovement();

            MovePlatforms();

            MoveTurtles();

            MovePlants();

            MoveFire();

            MoveBombs();

            CheckForNewLevel();

            CheckForGameOver();

            // Check if lava rising is in progress
            if (currentLevel == 2)
            {
                // Move the lava up slowly
                MoveLavaUp();
            }

        }
        private void MoveLavaUp()
        {


            // Iterate through controls to find and move lava-related objects
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox && control.Tag != null && control.Tag.ToString().Equals("level2lava"))
                {
                    //Console.WriteLine("lava going up!");
                    //Console.WriteLine($"lava altitude: {lavaAltitude}");
                    //Console.WriteLine($"control.Top: {control.Top}");
                    lavaRiseCounter++;

                    if (lavaRiseCounter % 100 == 0)
                    {
                        // Move the lava PictureBox upwards
                        control.Top -= lavaRiseSpeed;

                        // Check if the lava reaches the desired altitude
                        if (control.Top <= lavaAltitude)
                        {
                            // Game over condition when lava reaches the altitude
                            isGameOver = true;
                            // You can add additional game over logic here if needed
                        }
                    }

                }
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                player.MovingLeft = true;
                player.LastOrientation = 1;
            }
            if (e.KeyCode == Keys.Right)
            {
                player.MovingRight = true;
                player.LastOrientation = 0;
            }
            if (e.KeyCode == Keys.Space)
            {
                if (playerOnThePlatform == true)
                {
                    player.JumpingOnce = true;
                    player.Force = 6;
                }
                else if (player.JumpingTwice == false)
                {
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
                //player.LastOrientation = 1;
            }
            if (e.KeyCode == Keys.Right)
            {
                player.MovingRight = false;
                // player.LastOrientation = 0;
            }
        }
        /// <summary>
        /// Funkcija koja se bavi svim postavkama na početku igre i pokreće prvi level
        /// </summary>
        private void GameInitialization()
        {

            isGameOver = false;
            currentLevel = 1;

            CheckerInitialization();

            StartLevel(currentLevel);

            animationTimer.Interval = 150; //interval za animacije
            animationTimer.Tick += AnimationTimer_Tick;

            pictureBoxEnemyPlant1.SendToBack();
            pictureBoxEnemyPlant2.SendToBack();

            flower1.SendToBack();
            flower1.Visible = false;
            shield1.SendToBack();
            shield1.Visible = false;
            flower2.SendToBack();
            flower2.Visible = false;
            shield2.SendToBack();
            shield2.Visible = false;
            realShield1.SendToBack();
            mushroom1.SendToBack();
            mushroom1.Visible = false;

            //inicijalziramo turtlePictureBoxes
            for (int i = 0; i < 4; i++)
            {
                PictureBox turtlePictureBox = new PictureBox();
                turtlePictureBoxes.Add(turtlePictureBox);
                turtleCurrentFrameIndices.Add(0);
            }

            for (int i = 0; i < 4; i++)
            {
                // Create and add turtle stoppers
                PictureBox turtleStopper_R = new PictureBox();
                PictureBox turtleStopper_L = new PictureBox();
                turtleStopperBoxes_R.Add(turtleStopper_R);
                turtleStopperBoxes_L.Add(turtleStopper_L);

                turtleStopper_R.Size = turtleStopper_L.Size = new Size(20, 53); // Adjust size as needed
            }

            AdjustTurtleLocation(turtlePictureBoxes[0], turtleStopperBoxes_R[0], turtleStopperBoxes_L[0]);

            //inicijalziramo bombPictureBoxes
            for (int i = 0; i < 4; i++)
            {
                PictureBox bombPictureBox = new PictureBox();
                bombPictureBoxes.Add(bombPictureBox);
                bombCurrentFrameIndices.Add(0);
            }

            for (int i = 0; i < 4; i++)
            {
                // Create and add turtle stoppers
                PictureBox bombStopper_R = new PictureBox();
                PictureBox bombStopper_L = new PictureBox();
                bombStopperBoxes_R.Add(bombStopper_R);
                bombStopperBoxes_L.Add(bombStopper_L);

                bombStopper_R.Size = bombStopper_L.Size = new Size(20, 53); // Adjust size as needed
            }

            AdjustBombLocation(bombPictureBoxes[0], bombStopperBoxes_R[0], bombStopperBoxes_L[0]);


            this.DoubleBuffered = true;
            // Set the marioAnimationTimer interval for Mario's animation
            marioAnimationTimer.Interval = marioAnimationFrameInterval;
            marioAnimationTimer.Tick += MarioAnimationTimer_Tick;
        }
        private void MarioAnimationTimer_Tick(object sender, EventArgs e)
        {
            // Update Mario's animation frames
            if (player.MovingLeft || player.MovingRight)
            {
                steps = (steps + 1) % marioMovements.Count;

                foreach (Control control in this.Controls)
                {
                    if (control is PictureBox && control.Name == "pictureBoxPlayer")
                    {
                        ((PictureBox)control).Image = (Image)Properties.Resources.ResourceManager.GetObject(marioMovements[steps]);
                    }
                }
            }
        }

        private void AdjustTurtleLocation(PictureBox turtlePictureBox, PictureBox turtleStopper_R, PictureBox turtleStopper_L)
        {
            int sizeY = turtlePictureBox.Size.Height;

            // prva kornjaca

            Control platform1_1Control = this.Controls.Find("platform1_1", true).FirstOrDefault();
            Control platform1_5Control = this.Controls.Find("platform1_5", true).FirstOrDefault();


            Control platform2_1Control = this.Controls.Find("platform2_1", true).FirstOrDefault();
            Control platform2_5Control = this.Controls.Find("platform2_5", true).FirstOrDefault();


            Control floor1Control = this.Controls.Find("floor1", true).FirstOrDefault();
            Control floorStop = this.Controls.Find("pipePlant1", true).FirstOrDefault();


            Control platform5_1Control = this.Controls.Find("platform5_1", true).FirstOrDefault();
            Control platform5_5Control = this.Controls.Find("platform5_5", true).FirstOrDefault();



            if (platform1_1Control != null && platform1_1Control is PictureBox)
            {
                Point platform1_1Location = new Point(((PictureBox)platform1_1Control).Location.X, ((PictureBox)platform1_1Control).Location.Y - sizeY);
                Point platform1_5Location = new Point(((PictureBox)platform1_5Control).Location.X, ((PictureBox)platform1_5Control).Location.Y - sizeY);

                SetTurtleLocation(turtlePictureBoxes[0], turtleStopperBoxes_R[0], turtleStopperBoxes_L[0], platform1_1Location, platform1_5Location, 1);
            }

            if (platform2_1Control != null && platform2_1Control is PictureBox)
            {
                Point platform2_1Location = new Point(((PictureBox)platform2_1Control).Location.X, ((PictureBox)platform2_1Control).Location.Y - sizeY);
                Point platform2_5Location = new Point(((PictureBox)platform2_5Control).Location.X, ((PictureBox)platform2_5Control).Location.Y - sizeY);

                SetTurtleLocation(turtlePictureBoxes[1], turtleStopperBoxes_R[1], turtleStopperBoxes_L[1], platform2_1Location, platform2_5Location, 2);
            }

            if (floor1Control != null && floor1Control is PictureBox)
            {
                Point floor1Location = new Point(((PictureBox)platform2_1Control).Location.X, ((PictureBox)floor1Control).Location.Y - sizeY); // Use the Y component, X from platform1_1
                Point stopFloorLocation = new Point(((PictureBox)floorStop).Location.X, ((PictureBox)floorStop).Location.Y - sizeY);

                SetTurtleLocation(turtlePictureBoxes[2], turtleStopperBoxes_R[2], turtleStopperBoxes_L[2], floor1Location, stopFloorLocation, 3);
            }

            if (platform5_1Control != null && platform5_1Control is PictureBox)
            {
                Point platform5_1Location = new Point(((PictureBox)platform5_1Control).Location.X, ((PictureBox)platform5_1Control).Location.Y - sizeY);
                Point platform5_5Location = new Point(((PictureBox)platform5_5Control).Location.X, ((PictureBox)platform5_5Control).Location.Y - sizeY);

                SetTurtleLocation(turtlePictureBoxes[3], turtleStopperBoxes_R[3], turtleStopperBoxes_L[3], platform5_1Location, platform5_5Location, 4);
            }


        }
        /// <summary>
        /// kreira kornjace
        /// </summary>
        private void SetTurtleLocation(PictureBox turtlePictureBox, PictureBox turtleStopper_R, PictureBox turtleStopper_L, Point location, Point locationLastPlatform, int turtleNumber)
        {

            turtlePictureBox.Size = new Size(43, 50);//35,40
            turtlePictureBox.Location = location;
            turtlePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            turtlePictureBox.Tag = "level1EnemyTurtle"; // tag
            turtlePictureBox.BackColor = Color.Transparent;

            turtlePictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(TurtleRightframes[0]);

            turtlePictureBox.Name = "pictureBoxEnemyTurtle" + turtleNumber;

            Controls.Add(turtlePictureBox);
            turtlePictureBoxes.Add(turtlePictureBox);
            turtleCurrentFrameIndices.Add(0);

            //Sad kreiramo turtleStoppers


            // azuriraj stoppere

            turtleStopper_R.Location = new Point(locationLastPlatform.X + 20, location.Y); // Adjust the position based on turtlePictureBox
            turtleStopper_L.Location = new Point(location.X - 20, location.Y);

            turtleStopper_R.Tag = turtleStopper_L.Tag = "level1turtleStopper"; // Adjust the tag as needed
            turtleStopper_L.Name = "turtleStopper" + turtleNumber + "_L";
            turtleStopper_R.Name = "turtleStopper" + turtleNumber + "_R";

            turtleStopper_R.BackColor = Color.Transparent; // Example color, you can change it
            turtleStopper_L.BackColor = Color.Transparent;

            Controls.Add(turtleStopper_R);
            Controls.Add(turtleStopper_L);

            //MoveTurtles(turtlePictureBox, turtleStopper_R, turtleStopper_L, turtleNumber);

        }

        private void AdjustBombLocation(PictureBox bombPictureBox, PictureBox bombStopper_R, PictureBox bombStopper_L)
        {
            int sizeY = bombPictureBox.Size.Height - 8;

            Control platform4_1Control = this.Controls.Find("level2platform4_1", true).FirstOrDefault();
            Control platform4_5Control = this.Controls.Find("level2platform4_5", true).FirstOrDefault();


            Control platform2_1Control = this.Controls.Find("level2platform2_1", true).FirstOrDefault();
            Control platform2_7Control = this.Controls.Find("level2platform2_7", true).FirstOrDefault();


            Control platform3_1Control = this.Controls.Find("level2platform3_1", true).FirstOrDefault();
            Control platform3_5Control = this.Controls.Find("level2platform3_5", true).FirstOrDefault();


            Control platform7_1Control = this.Controls.Find("level2platform7_1", true).FirstOrDefault();
            Control platform7_5Control = this.Controls.Find("level2platform7_5", true).FirstOrDefault();



            if (platform4_1Control != null && platform4_1Control is PictureBox)
            {
                //Console.WriteLine("upala je bomba broj 1");
                Point platform4_1Location = new Point(((PictureBox)platform4_1Control).Location.X, ((PictureBox)platform4_1Control).Location.Y - sizeY);
                Point platform4_5Location = new Point(((PictureBox)platform4_5Control).Location.X, ((PictureBox)platform4_5Control).Location.Y - sizeY);

                SetBombLocation(bombPictureBoxes[0], bombStopperBoxes_R[0], bombStopperBoxes_L[0], platform4_1Location, platform4_5Location, 1);
            }

            if (platform2_1Control != null && platform2_1Control is PictureBox)
            {
                //Console.WriteLine("upala je bomba broj 2");
                Point platform2_1Location = new Point(((PictureBox)platform2_1Control).Location.X, ((PictureBox)platform2_1Control).Location.Y - sizeY);
                Point platform2_5Location = new Point(((PictureBox)platform2_7Control).Location.X, ((PictureBox)platform2_7Control).Location.Y - sizeY);

                SetBombLocation(bombPictureBoxes[1], bombStopperBoxes_R[1], bombStopperBoxes_L[1], platform2_1Location, platform2_5Location, 2);
            }

            if (platform3_1Control != null && platform3_1Control is PictureBox)
            {
                //Console.WriteLine("upala je bomba broj 3");
                Point platform3_1Location = new Point(((PictureBox)platform3_1Control).Location.X, ((PictureBox)platform3_1Control).Location.Y - sizeY); // Use the Y component, X from platform1_1
                Point platform3_5Location = new Point(((PictureBox)platform3_5Control).Location.X, ((PictureBox)platform3_5Control).Location.Y - sizeY);

                SetBombLocation(bombPictureBoxes[2], bombStopperBoxes_R[2], bombStopperBoxes_L[2], platform3_1Location, platform3_5Location, 3);
            }

            if (platform7_1Control != null && platform7_1Control is PictureBox)
            {
                //Console.WriteLine("upala je bomba broj 4");
                Point platform7_1Location = new Point(((PictureBox)platform7_1Control).Location.X, ((PictureBox)platform7_1Control).Location.Y - sizeY);
                Point platform7_3Location = new Point(((PictureBox)platform7_5Control).Location.X, ((PictureBox)platform7_5Control).Location.Y - sizeY);

                SetBombLocation(bombPictureBoxes[3], bombStopperBoxes_R[3], bombStopperBoxes_L[3], platform7_1Location, platform7_3Location, 4);
            }






        }
        /// <summary>
        /// kreira bombe
        /// </summary>
        private void SetBombLocation(PictureBox bombPictureBox, PictureBox bombStopper_R, PictureBox bombStopper_L, Point location, Point locationLastPlatform, int bombNumber)
        {
            bombPictureBox.Size = new Size(31, 44);
            bombPictureBox.Location = location;
            bombPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            bombPictureBox.Tag = "level2EnemyBomb"; // tag
            bombPictureBox.BackColor = Color.Transparent;

            bombPictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(BombRightframes[0]);

            bombPictureBox.Name = "pictureBoxEnemyBomb" + bombNumber;
            bombPictureBox.Visible = false;

            Controls.Add(bombPictureBox);
            bombPictureBoxes.Add(bombPictureBox);
            bombCurrentFrameIndices.Add(0);


            // azuriraj stoppere

            bombStopper_R.Location = new Point(locationLastPlatform.X + 20, location.Y); // Adjust the position based on turtlePictureBox
            bombStopper_L.Location = new Point(location.X - 20, location.Y);

            bombStopper_R.Tag = bombStopper_L.Tag = "level2BombStopper"; // Adjust the tag as needed
            bombStopper_L.Name = "level2BombStopper" + bombNumber + "_L";
            bombStopper_R.Name = "level2BombStopper" + bombNumber + "_R";

            bombStopper_R.BackColor = Color.Transparent; // Example color, you can change it
            bombStopper_L.BackColor = Color.Transparent; // Example color, you can change it
            ;

            bombStopper_R.Visible = false;
            bombStopper_L.Visible = false;
            Controls.Add(bombStopper_R);
            Controls.Add(bombStopper_L);

            //MoveTurtles(turtlePictureBox, turtleStopper_R, turtleStopper_L, turtleNumber);

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
                    // Move to the next frame
                    currentCoinFrameIndex = (currentCoinFrameIndex + 1) % Coinframes.Count;


                    if (int.TryParse(control.Name.Replace("pictureBoxCoin", ""), out pictureBoxNumber))
                    {
                        if (pictureBoxNumber == 1) Console.WriteLine($"coin:{pictureBoxNumber} korstis frame {currentCoinFrameIndex}");
                        // Update the coin picture box with the next frame
                        ((PictureBox)control).Image = 
                            (Image)Properties.Resources.ResourceManager.GetObject(Coinframes[currentCoinFrameIndex]);
                    }
                    if (int.TryParse(control.Name.Replace("pictureBoxCoinTwo", ""), out pictureBoxNumber))
                    {
                        // Update the coin picture box with the next frame
                        ((PictureBox)control).Image = (Image)Properties.Resources.ResourceManager.GetObject(Coinframes[currentCoinFrameIndex]);
                    }
                }
            }
            /*foreach (Control control in this.Controls)
            {
                if (control is PictureBox && control.Tag != null && control.Tag.ToString().EndsWith("coin"))
                {
                    int pictureBoxNumber;

                    // Move to the next frame
                    currentCoinFrameIndex = (currentCoinFrameIndex + 1) % Coinframes.Count;

                    if (int.TryParse(control.Name.Replace("pictureBoxCoin", ""), out pictureBoxNumber))
                    {
                        //Console.WriteLine($"coin:{pictureBoxNumber} korstis frame {currentCoinFrameIndex}");

                        // Update the coin picture box with the next frame
                        ((PictureBox)control).Image = (Image)Properties.Resources.ResourceManager.GetObject(Coinframes[currentCoinFrameIndex]);
                    }
                }
            }*/
            // Update the turtle and bomb PictureBoxes with the next frame
            for (int i = 0; i < 4; i++)
            {
                turtleCurrentFrameIndices[i] = (turtleCurrentFrameIndices[i] + 1) % TurtleRightframes.Count;

                if (turtlespeed[i] > 0)
                {
                    turtlePictureBoxes[i].Image = (Image)Properties.Resources.ResourceManager.GetObject(TurtleRightframes[turtleCurrentFrameIndices[i]]);
                }
                else
                {
                    turtlePictureBoxes[i].Image = (Image)Properties.Resources.ResourceManager.GetObject(TurtleLeftframes[turtleCurrentFrameIndices[i]]);
                }
            }
            for (int i = 0; i < 4; i++)
            {
                bombCurrentFrameIndices[i] = (bombCurrentFrameIndices[i] + 1) % BombRightframes.Count;

                if (turtlespeed[i] > 0)
                {
                    bombPictureBoxes[i].Image = (Image)Properties.Resources.ResourceManager.GetObject(BombRightframes[bombCurrentFrameIndices[i]]);
                }
                else
                {
                    bombPictureBoxes[i].Image = (Image)Properties.Resources.ResourceManager.GetObject(BombLeftframes[bombCurrentFrameIndices[i]]);
                }
            }


            // Start the marioAnimationTimer only when Mario is moving
            if (player.MovingLeft || player.MovingRight)
            {
                marioAnimationTimer.Start();
            }
            else
            {
                marioAnimationTimer.Stop();
            }

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
                    this.BackgroundImage = Properties.Resources.background1;
                    player.Lives = 3;// 10;   //lakse za testirati nego 3
                    player.Score = 0;
                    labelLives.Text = "Lives: " + player.Lives;
                    labelScore.Text = "Score: " + player.Score;

                    //postavlja sve pictureBox-eve s tag-om "level1..." na vidljivo
                    foreach (Control control in this.Controls)
                    {
                        if (control is PictureBox && control.Tag != null && Regex.IsMatch((string)control.Tag, @"^level1.*$"))
                        //(control is PictureBox && ((string)control.Tag == "level1coin" || (string)control.Tag == "level1platform" || (string)control.Tag == "level1enemy"))
                        {
                            control.Visible = true;

                            // Start the animation timer for coins  LPA
                            animationTimer.Start();


                        }
                        if (control is PictureBox && control.Tag != null && Regex.IsMatch((string)control.Tag, @"^level2.*$"))
                        //(control is PictureBox && ((string)control.Tag == "level1coin" || (string)control.Tag == "level1platform" || (string)control.Tag == "level1enemy"))
                        {
                            control.Visible = false;

                        }
                    }

                    pictureBoxPlayer.Left = level1PlayerXPosition;
                    pictureBoxPlayer.Top = level1PlayerYPosition;
                    gameTimer.Start();
                    break;

                case 2:
                    labelLives.Text = "Lives: " + player.Lives;
                    labelScore.Text = "Score: " + player.Score;

                    //postavlja sve pictureBox-eve s tag-om "level1..." na vidljivo
                    foreach (Control control in this.Controls)
                    {
                        if (control is PictureBox && control.Tag != null && Regex.IsMatch((string)control.Tag, @"^level1.*$"))
                        //(control is PictureBox && ((string)control.Tag == "level1coin" || (string)control.Tag == "level1platform" || (string)control.Tag == "level1enemy"))
                        {
                            control.Visible = false;

                        }
                        if (control is PictureBox && control.Tag != null && Regex.IsMatch((string)control.Tag, @"^level2.*$"))
                        //(control is PictureBox && ((string)control.Tag == "level1coin" || (string)control.Tag == "level1platform" || (string)control.Tag == "level1enemy"))
                        {
                            if (control.Tag == "level2coin") Console.WriteLine("sakjfvhsvdfj"); 
                            control.Visible = true;
                            shield2.Visible = false;
                            flower2.Visible = false;
                            animationTimer.Start();

                        }
                    }

                    //lavaStartTime = DateTime.Now;
                    pictureBoxPlayer.Left = level2PlayerXPosition;
                    pictureBoxPlayer.Top = level2PlayerYPosition;
                    gameTimer.Start();
                    break;

                default:
                    break;
            }


        }
        /// <summary>
        /// Updatea sve labele u igri
        /// </summary>
        private void UpdateLabels()
        {
            labelScore.Text = "Score: " + player.Score;
            labelLives.Text = "Lives: " + player.Lives;
            if (currentLevel == 1)
            {
                labelScore.ForeColor = Color.Black;
                labelLives.ForeColor = Color.Black;
            }
            else
            {
                labelScore.ForeColor = Color.White;
                labelLives.ForeColor = Color.White;
            }
            if (cooldown || shieldOn) cooldownlabel.Visible = true;
            else cooldownlabel.Visible = false;
            if (mushOn) mushroomlabel.Visible = true;
            else mushroomlabel.Visible = false;
        }
        /// <summary>
        /// Postavlja groundChecker koji disable-a gravitaciju ako je player na platformi, rijesen problem titranja
        /// </summary>
        private void SetGroundChecker()
        {
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
        /// Funkcija za animiranje Super Daria
        /// </summary>
        private void AnimatePlayer(int start, int end)
        {

            player.SlowDownFrameRate += 1;

            if (player.SlowDownFrameRate == 4)
            {
                steps++;
                player.SlowDownFrameRate = 0;
            }


            if (steps > end || steps < start)
            {
                steps = start;
            }

            foreach (Control control in this.Controls)
            {
                if (control is PictureBox && control.Name == "pictureBoxPlayer")
                {
                    // Update the player picture box with the next frame
                    ((PictureBox)control).Image = (Image)Properties.Resources.ResourceManager.GetObject(marioMovements[steps]);
                }
            }



        }

        /// <summary>
        /// Funkcija za pomicanje Super Daria
        /// </summary>
        private void HandlePlayerMovement()
        {
            playerOnThePlatform = false;
            foreach (Control control in this.Controls)
            {

                if (currentLevel == 1 && (groundChecker.Bounds.IntersectsWith(control.Bounds) && ((string)control.Tag == "level1platform" ||
                    (string)control.Tag == "level1brick")))
                {
                    playerOnThePlatform = true;

                    if (player.LastOrientation == 1)
                    {
                        AnimatePlayer(1, 1);
                    }
                    else
                    {
                        AnimatePlayer(0, 0);
                    }

                    break;
                }
                else if (currentLevel == 2 && (groundChecker.Bounds.IntersectsWith(control.Bounds) && ((string)control.Tag == "level2platform" ||
                        (string)control.Tag == "level2brick")))
                {
                    playerOnThePlatform = true;

                    if (player.LastOrientation == 1)
                    {
                        AnimatePlayer(1, 1);
                    }
                    else
                    {
                        AnimatePlayer(0, 0);
                    }

                    break;
                }
            }

            if (playerOnThePlatform == false || player.JumpingOnce == true)
            {
                pictureBoxPlayer.Top += player.JumpingSpeed;
                if (player.LastOrientation == 1)
                {
                    AnimatePlayer(4, 4);
                }
                else
                {
                    AnimatePlayer(3, 3);
                }
            }
            else
            {
                player.JumpingOnce = false;
                player.JumpingTwice = false;
                if (player.LastOrientation == 1)
                {
                    AnimatePlayer(1, 1);
                }
                else
                {
                    AnimatePlayer(0, 0);
                }
            }

            if (player.MovingLeft == true && player.MovingRight == false)
            {

                if (IsKeyDown(Keys.Left) && IsKeyDown(Keys.S))
                {
                    pictureBoxPlayer.Left -= player.MovingSpeed * 2;
                    AnimatePlayer(31, 38);
                }
                else
                {
                    pictureBoxPlayer.Left -= player.MovingSpeed;
                    AnimatePlayer(14, 22);
                }
            }

            if (player.MovingRight == true && player.MovingLeft == false)
            {
                if (IsKeyDown(Keys.Right) && IsKeyDown(Keys.S))
                {
                    pictureBoxPlayer.Left += player.MovingSpeed * 2;
                    AnimatePlayer(23, 30);
                }
                else
                {
                    pictureBoxPlayer.Left += player.MovingSpeed;
                    AnimatePlayer(5, 13);
                }
            }

            if (player.JumpingOnce == true && player.Force < 0)
            {
                player.JumpingOnce = false;
            }

            if (player.JumpingOnce == true)
            {
                player.JumpingSpeed = -8;
                player.Force -= 1;
                /*
                if (player.LastOrientation == 1)
                {
                    AnimatePlayer(4, 4);
                }
                else
                {
                    AnimatePlayer(3, 3);
                }*/
            }

            else
            {
                player.JumpingSpeed = 8;

                /*
                if (player.LastOrientation == 1)
                {
                    AnimatePlayer(4, 4);
                }
                else
                {
                    AnimatePlayer(3, 3);
                }
                */
            }

        }
        /// <summary>
        /// Funkcija za pomicanje svih platformi u levelu. Najjednostavnija implementacija. Za dodati nove
        /// potrebno je postaviti ogranicenje u Level Settings na pocetku skripte.
        /// </summary>
        private void MovePlatforms()
        {
            //za prvi level
            horizontalMovingPlatform.Left -= level1HorizontalPlatformSpeed;

            if (horizontalMovingPlatform.Left < level1LeftStopPoint || horizontalMovingPlatform.Left > level1RightStopPoint)
            {
                level1HorizontalPlatformSpeed *= (-1);
            }

            verticalMovingPlatform.Top -= level1VerticalPlatformSpeed;

            if (verticalMovingPlatform.Top < level1TopStopPoint || verticalMovingPlatform.Top > level1BottomStopPoint)
            {
                level1VerticalPlatformSpeed *= (-1);
            }

            //za drugi level
            horizontalMovingPlatform2.Left -= level2HorizontalPlatformSpeed;

            if (horizontalMovingPlatform2.Left < level2LeftStopPoint || horizontalMovingPlatform2.Left > level2RightStopPoint)
            {
                level2HorizontalPlatformSpeed *= (-1);
            }

            verticalMovingPlatform2.Top -= level2VerticalPlatformSpeed;

            if (verticalMovingPlatform2.Top < level2TopStopPoint || verticalMovingPlatform2.Top > level2BottomStopPoint)
            {
                level2VerticalPlatformSpeed *= (-1);
            }

        }

        /// <summary>
        /// Pomiče kornjače
        /// </summary>
        private void MoveTurtles()
        {
            for (int i = 0; i < 4; i++)
            {
                turtlePictureBoxes[i].Left += turtlespeed[i];
                if (turtlePictureBoxes[i].Bounds.IntersectsWith(turtleStopperBoxes_R[i].Bounds) || turtlePictureBoxes[i].Bounds.IntersectsWith(turtleStopperBoxes_L[i].Bounds))
                {
                    turtlespeed[i] *= (-1);
                }
            }
        }
        private void MoveBombs()
        {

            for (int i = 0; i < 4; i++)
            {
                bombPictureBoxes[i].Left += bombspeed[i];
                if (bombPictureBoxes[i].Bounds.IntersectsWith(bombStopperBoxes_R[i].Bounds) || bombPictureBoxes[i].Bounds.IntersectsWith(bombStopperBoxes_L[i].Bounds))
                {
                    bombspeed[i] *= (-1);
                }
            }
        }

        /// <summary>
        /// Pomiče biljke
        /// </summary>
        private void MovePlants()
        {
            if (!plantmover1) pictureBoxEnemyPlant1.Top += plantspeed1;
            if (pictureBoxEnemyPlant1.Bounds.IntersectsWith(plantStopper1_D.Bounds) || pictureBoxEnemyPlant1.Bounds.IntersectsWith(plantStopper1_U.Bounds))
            {
                pictureBoxEnemyPlant1.Top -= plantspeed1;
                plantmover1 = true;
                Timer plantTimer = new Timer();
                if (plantspeed1 == 2)
                {
                    plantTimer.Interval = 4000;
                    lethal1 = false;
                }
                else
                {
                    plantTimer.Interval = 1000;
                    lethal1 = true;
                }
                plantTimer.Tick += (sender, e) =>
                {
                    plantmover1 = false;
                    plantTimer.Stop();
                    plantTimer.Dispose();
                };
                plantTimer.Start();
                plantspeed1 *= (-1);
            }

            if (!plantmover2) pictureBoxEnemyPlant2.Top += plantspeed2;
            if (pictureBoxEnemyPlant2.Bounds.IntersectsWith(plantStopper2_D.Bounds) || pictureBoxEnemyPlant2.Bounds.IntersectsWith(plantStopper2_U.Bounds))
            {
                pictureBoxEnemyPlant2.Top -= plantspeed2;
                plantmover2 = true;
                Timer plantTimer = new Timer();
                if (plantspeed2 == 2)
                {
                    plantTimer.Interval = 5000;
                }
                else
                {
                    plantTimer.Interval = 1000;
                }
                plantTimer.Tick += (sender, e) =>
                {
                    plantmover2 = false;
                    plantTimer.Stop();
                    plantTimer.Dispose();
                };
                plantTimer.Start();
                plantspeed2 *= (-1);
            }
        }

        private void MoveFire()        //jos treba biljke move behind ili tak nekak
        {
            if (!firemover1) pictureBoxEnemyFire1.Top += firespeed1;
            if (pictureBoxEnemyFire1.Bounds.IntersectsWith(lava.Bounds) || pictureBoxEnemyFire1.Bounds.IntersectsWith(fireStopper1_U.Bounds))
            {
                pictureBoxEnemyFire1.Top -= firespeed1;
                firemover1 = true;
                Timer fireTimer = new Timer();
                if (firespeed1 == 5)
                {
                    fireTimer.Interval = 4000;
                    lethal1 = false;
                }
                else
                {
                    fireTimer.Interval = 1000;
                    lethal1 = true;
                }
                fireTimer.Tick += (sender, e) =>
                {
                    firemover1 = false;
                    fireTimer.Stop();
                    fireTimer.Dispose();
                };
                fireTimer.Start();
                firespeed1 *= (-1);
            }

            if (!firemover2) pictureBoxEnemyFire2.Top += firespeed2;
            if (pictureBoxEnemyFire2.Bounds.IntersectsWith(lava.Bounds) || pictureBoxEnemyFire2.Bounds.IntersectsWith(fireStopper2_U.Bounds))
            {
                pictureBoxEnemyFire2.Top -= firespeed2;
                firemover2 = true;
                Timer fireTimer = new Timer();
                if (firespeed2 == 5)
                {
                    fireTimer.Interval = 4000;
                    lethal2 = false;
                }
                else
                {
                    fireTimer.Interval = 1000;
                    lethal2 = true;
                }
                fireTimer.Tick += (sender, e) =>
                {
                    firemover2 = false;
                    fireTimer.Stop();
                    fireTimer.Dispose();
                };
                fireTimer.Start();
                firespeed2 *= (-1);
            }
        }


        /// <summary>
        /// Provjerava sve dodire igraca s ostalim objektima
        /// </summary>
        ///
        private void HandleCollisions()
        {
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox)
                {
                    if (currentLevel == 1)
                    {
                        if ((string)control.Tag == "level1platform" || (string)control.Tag == "level1brick")
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

                    }

                    else
                    {
                        if ((string)control.Tag == "level2platform" || (string)control.Tag == "level2brick")
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
                        if ((string)control.Tag == "level2lava")
                        {
                            if (ceilingChecker.Bounds.IntersectsWith(control.Bounds))
                            {
                                GameOver();
                            }
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
                        /*if ((string)control.Tag == "level1Enemy" || (string)control.Tag == "level2Enemy" || (string)control.Tag == "level3Enemy")
                        {
                            if (pictureBoxPlayer.Bounds.IntersectsWith(control.Bounds) && control.Visible == true && !shieldOn)
                            {
                                player.Lives -= 1;
                                control.Visible = false;
                                if (player.Lives <= 0)
                                {
                                    isGameOver = true;
                                }
                            }
                        }*/
                    }
                    if ((string)control.Tag == "level1EnemyTurtle" || (string)control.Tag == "level2EnemyBomb")
                    {
                        if (groundChecker.Bounds.IntersectsWith(control.Bounds) && control.Visible == true &&
                            pictureBoxPlayer.Location.Y > previousLocation) // ubijanje kornjace ako se na nju skoci
                        {
                            if (groundChecker.Bounds.Bottom - control.Bounds.Top < 5 &&
                                groundChecker.Bounds.Right - control.Bounds.Right > -20 &&
                                groundChecker.Bounds.Left - control.Bounds.Left < 20)
                            {
                                control.Visible = false;
                            }
                        }
                        if (pictureBoxPlayer.Bounds.IntersectsWith(control.Bounds) && control.Visible == true && !cooldown && !shieldOn)
                        {
                            player.Lives -= (float)0.5;
                            //control.Visible = false;
                            if (player.Lives <= 0)
                            {
                                isGameOver = true;
                            }
                            cooldown = true;
                            Timer cooldownTimer = new Timer();
                            cooldownTimer.Interval = 3000;   //3 sekunde cooldowna?
                            cooldownTimer.Tick += (sender, e) =>
                            {
                                cooldown = false;
                                cooldownTimer.Stop();
                                cooldownTimer.Dispose();
                            };
                            cooldownTimer.Start();
                        }
                    }
                    if ((string)control.Tag == "level1EnemyPlant" || (string)control.Tag == "level2EnemyFire")
                    {
                        bool lethal = lethal1;
                        if (control.Name.EndsWith("2")) lethal = lethal2;
                        if (pictureBoxPlayer.Bounds.IntersectsWith(control.Bounds) && control.Visible == true && !cooldown && lethal && !shieldOn)
                        {
                            player.Lives -= 1;
                            //control.Visible = false;
                            if (player.Lives <= 0)
                            {
                                isGameOver = true;
                            }
                            cooldown = true;
                            Timer cooldownTimer = new Timer();
                            cooldownTimer.Interval = 3000;   //3 sekunde cooldowna?
                            cooldownTimer.Tick += (sender, e) =>
                            {
                                cooldown = false;
                                cooldownTimer.Stop();
                                cooldownTimer.Dispose();
                            };
                            cooldownTimer.Start();
                        }
                    }
                }
            }
            previousLocation = pictureBoxPlayer.Location.Y;
        }


        private void CheckForNewLevel()
        {
            if (pictureBoxPlayer.Left > ClientSize.Width)
            {
                Console.WriteLine("Vrijeme za novi level");
                currentLevel++;
                this.BackgroundImage = Properties.Resources.background2;

                if (currentLevel >= 3)
                {
                    gameTimer.Stop();
                    MessageBox.Show("Presli ste igru!");
                }
                StartLevel(currentLevel);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CheckForGameOver()
        {
            if (pictureBoxPlayer.Top > ClientSize.Height)
            {
                isGameOver = true;
            }
            if (isGameOver == true)
            {
                GameOver();
            }
        }

        /// <summary>
        /// Funkcija koja obavlja kraj igre i nudi mogućnost ponovne igre od prvog levela.
        /// TODO: Dodati funkcionalnosti
        /// </summary>
        private void GameOver()
        {
            player.Lives = 0;
            labelLives.Text = "Lives: 0";
            gameTimer.Stop();
            //Privremeni kraj igre
            MessageBox.Show("Press Enter to play again!");

        }

        private void FlowerAdvancement()
        {
            //level1
            if (currentLevel == 1)
            {
                if (ceilingChecker.Bounds.IntersectsWith(brickBoxFlower.Bounds) &&
                        flower1.Visible == false && flowerover == 0)  //aktivacija cvijeta
                {
                    Console.WriteLine("cvijeticu");
                    flower1.Visible = true;
                    while (flower1.Bounds.IntersectsWith(brickBoxFlower.Bounds))
                    {
                        flower1.Top -= 1;
                    }
                }

                if (pictureBoxPlayer.Bounds.IntersectsWith(flower1.Bounds) && flower1.Visible == true)   //skupljanje cvijeta
                {
                    flower1.Visible = false;
                    player.Lives += 1;
                    flowerover = 1;
                }

            }
            else
            {
                if (ceilingChecker.Bounds.IntersectsWith(brickBoxFlower2.Bounds) &&
                        flower2.Visible == false && flowerover2 == 0)  //aktivacija cvijeta
                {
                    Console.WriteLine("cvijeticu");
                    flower2.Visible = true;
                    while (flower2.Bounds.IntersectsWith(brickBoxFlower2.Bounds))
                    {
                        flower2.Top -= 1;
                    }
                }

                if (pictureBoxPlayer.Bounds.IntersectsWith(flower2.Bounds) && flower2.Visible == true)   //skupljanje cvijeta
                {
                    flower2.Visible = false;
                    player.Lives += 1;
                    flowerover2 = 1;
                }

            }

        }

        private void MushroomAdvancement()
        {
            if (ceilingChecker.Bounds.IntersectsWith(brickBoxMushroom.Bounds) &&
                mushroom1.Visible == false && mushroomover == 0)  //aktivacija gljive
            {
                mushroom1.Visible = true;
                while (mushroom1.Bounds.IntersectsWith(brickBoxMushroom.Bounds))
                {
                    mushroom1.Top -= 1;
                }
            }

            if (pictureBoxPlayer.Bounds.IntersectsWith(mushroom1.Bounds) && mushroom1.Visible == true)   //skupljanje gljive
            {
                mushroom1.Visible = false;
                mushroomover = 1;

                mushOn = true;
                Timer cooldownTimer = new Timer();
                cooldownTimer.Interval = 10000;
                cooldownTimer.Tick += (sender, e) =>
                {
                    mushOn = false;
                    cooldownTimer.Stop();
                    cooldownTimer.Dispose();
                };
                cooldownTimer.Start();
            }

            if (mushOn == true)
            {
                player.MovingSpeed = 10;
            }
            else
            {
                player.MovingSpeed = 5;
            }
        }

        private void ShieldAdvancement()
        {
            if (currentLevel == 1)
            {
                if (ceilingChecker.Bounds.IntersectsWith(brickBoxShield.Bounds) &&
                     shield1.Visible == false && shieldover == 0)  //aktivacija štita
                {
                    shield1.Visible = true;
                    while (shield1.Bounds.IntersectsWith(brickBoxShield.Bounds))
                    {
                        shield1.Top -= 1;
                    }
                }

                if (pictureBoxPlayer.Bounds.IntersectsWith(shield1.Bounds) && shield1.Visible == true)   //skupljanje štita
                {
                    shield1.Visible = false;
                    shieldover = 1;

                    shieldOn = true;
                    Timer cooldownTimer = new Timer();
                    cooldownTimer.Interval = 7000;
                    cooldownTimer.Tick += (sender, e) =>
                    {
                        shieldOn = false;
                        cooldownTimer.Stop();
                        cooldownTimer.Dispose();
                    };
                    cooldownTimer.Start();
                }
            }
            else
            {
                if (ceilingChecker.Bounds.IntersectsWith(brickBoxShield2.Bounds) &&
                     shield2.Visible == false && shieldover2 == 0)  //aktivacija štita
                {
                    shield2.Visible = true;
                    while (shield2.Bounds.IntersectsWith(brickBoxShield2.Bounds))
                    {
                        shield2.Top -= 1;
                    }
                }

                if (pictureBoxPlayer.Bounds.IntersectsWith(shield2.Bounds) && shield2.Visible == true)   //skupljanje štita
                {
                    shield2.Visible = false;
                    shieldover2 = 1;

                    shieldOn = true;
                    Timer cooldownTimer = new Timer();
                    cooldownTimer.Interval = 7000;
                    cooldownTimer.Tick += (sender, e) =>
                    {
                        shieldOn = false;
                        cooldownTimer.Stop();
                        cooldownTimer.Dispose();
                    };
                    cooldownTimer.Start();
                }
            }
        }

        /// <summary>
        /// implementira rad štita
        /// </summary>
        private void ShieldProtection()
        {
            if (currentLevel == 1)
            {
                if (shieldOn == true)
                {
                    realShield1.Visible = true;
                    realShield1.Top = pictureBoxPlayer.Top - 15;
                    realShield1.Left = pictureBoxPlayer.Left - 10;
                }
                else
                {
                    realShield1.Visible = false;
                }
            }
            else
            {
                if (shieldOn == true)
                {
                    realShield1.Visible = true;
                    realShield1.Top = pictureBoxPlayer.Top - 15;
                    realShield1.Left = pictureBoxPlayer.Left - 10;
                }
                else
                {
                    realShield1.Visible = false;
                }
            }

        }


        /// <summary>
        /// za provjeru tipke
        /// </summary>
        private bool IsKeyDown(Keys key)
        {
            return (GetKeyState((int)key) & 0x8000) != 0;
        }

        [DllImport("user32.dll")]
        public static extern short GetKeyState(int nVrtKey);
    }
}