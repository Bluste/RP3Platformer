
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

namespace RP3_Platformer
{
    public partial class Form1 : Form
    {
        private List<string> Coinframes = new List<string>(new String[] {"coin1", "coin2", "coin3",
            "coin4", "coin5"});

        private List<string> Plantframes = new List<string>(new String[] { "plant1", "plant2", "plant3" });

        private List<string> Turtleframes = new List<string>(new string[] { "turtle1", "turtle2", "turtle3", "turtle4", "turtle5" });
        private List<int> turtleCurrentFrameIndices = new List<int>();
        private List<PictureBox> turtlePictureBoxes = new List<PictureBox>();
        private List<PictureBox> turtleStopperBoxes_R = new List<PictureBox>();
        private List<PictureBox> turtleStopperBoxes_L = new List<PictureBox>();

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

        int[] turtlespeed = { 1, 1, 1, 1 };
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

        int flowerover = 0;
        int shieldover = 0;
        int mushroomover = 0;

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

            FlowerAdvancement();

            ShieldAdvancement();

            MushroomAdvancement();

            HandleCollisions();

            HandlePlayerMovement();

            MovePlatforms();

            MoveTurtles();

            MovePlants();

            CheckForNewLevel();

            CheckForGameOver();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                player.MovingLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                player.MovingRight = true;
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
            }
            if (e.KeyCode == Keys.Right)
            {
                player.MovingRight = false;
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

            turtlePictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(Turtleframes[0]);

            turtlePictureBox.Name = "pictureBoxEnemyTurtle" + turtleNumber;

            Controls.Add(turtlePictureBox);
            turtlePictureBoxes.Add(turtlePictureBox);
            turtleCurrentFrameIndices.Add(0);

            //Sad kreiramo turtleStoppers


            // azuriraj stoppere

            turtleStopper_R.Location = new Point(locationLastPlatform.X + 20, location.Y); // Adjust the position based on turtlePictureBox
            turtleStopper_L.Location = new Point(location.X - 20, location.Y);

            turtleStopper_R.Tag = turtleStopper_L.Tag = "turtleStopper"; // Adjust the tag as needed
            turtleStopper_L.Name = "turtleStopper" + turtleNumber + "_L";
            turtleStopper_R.Name = "turtleStopper" + turtleNumber + "_R";

            turtleStopper_R.BackColor = Color.Transparent; // Example color, you can change it
            turtleStopper_L.BackColor = Color.Transparent;

            Controls.Add(turtleStopper_R);
            Controls.Add(turtleStopper_L);

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
                        // Update the coin picture box with the next frame
                        ((PictureBox)control).Image = (Image)Properties.Resources.ResourceManager.GetObject(Coinframes[currentCoinFrameIndex]);
                    }
                }
            }
            // Update the turtle PictureBoxes with the next frame
            for (int i = 0; i < turtlePictureBoxes.Count; i++)
            {
                turtleCurrentFrameIndices[i] = (turtleCurrentFrameIndices[i] + 1) % Turtleframes.Count;
                turtlePictureBoxes[i].Image = (Image)Properties.Resources.ResourceManager.GetObject(Turtleframes[turtleCurrentFrameIndices[i]]);
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
                    player.Lives = 10;   //lakse za testirati nego 3
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
        private void UpdateLabels()
        {
            labelScore.Text = "Score: " + player.Score;
            labelLives.Text = "Lives: " + player.Lives;
            if (cooldown || shieldOn) cooldownlabel.Visible = true;
            else cooldownlabel.Visible = false;
            if (mushOn) mushroomlabel.Visible = true;
            else mushroomlabel.Visible = false;
            if (player.JumpingOnce) Console.WriteLine("skok");
            else Console.WriteLine("nope");
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
        /// Funkcija za pomicanje Super Daria
        /// </summary>
        private void HandlePlayerMovement()
        {
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
            else
            {
                player.JumpingOnce = false;
                player.JumpingTwice = false;
            }

            if (player.MovingLeft == true && player.MovingRight == false)
            {

                if (IsKeyDown(Keys.Left) && IsKeyDown(Keys.S))
                {
                    Console.WriteLine("speeed!");
                    pictureBoxPlayer.Left -= player.MovingSpeed * 2;
                }
                else
                {
                    pictureBoxPlayer.Left -= player.MovingSpeed;
                }
            }

            if (player.MovingRight == true && player.MovingLeft == false)
            {
                if (IsKeyDown(Keys.Right) && IsKeyDown(Keys.S))
                {
                    Console.WriteLine("speeed!");
                    pictureBoxPlayer.Left += player.MovingSpeed * 2;
                }
                else
                {
                    pictureBoxPlayer.Left += player.MovingSpeed;
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

            if (verticalMovingPlatform.Top < level1TopStopPoint || verticalMovingPlatform.Top > level1BottomStopPoint)
            {
                level1VerticalPlatformSpeed *= (-1);
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
                    if ((string)control.Tag == "level1EnemyTurtle" || (string)control.Tag == "level2EnemyTurtle" || (string)control.Tag == "level3EnemyTurtle")
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
                    if ((string)control.Tag == "level1EnemyPlant" || (string)control.Tag == "level2EnemyPlant" || (string)control.Tag == "level3EnemyPlant")
                    {
                        bool lethal = lethal1;
                        if (control.Name.EndsWith("2")) lethal = lethal2;
                        if (pictureBoxPlayer.Bounds.IntersectsWith(control.Bounds) && control.Visible == true && !cooldown && lethal && !shieldOn)
                        {
                            player.Lives -= 2;
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
            if (ceilingChecker.Bounds.IntersectsWith(brickBoxFlower.Bounds) &&
                flower1.Visible == false && flowerover == 0
                )  //aktivacija cvijeta
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

        private void ShieldAdvancement()
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
                cooldownTimer.Interval = 10000;
                cooldownTimer.Tick += (sender, e) =>
                {
                    shieldOn = false;
                    cooldownTimer.Stop();
                    cooldownTimer.Dispose();
                };
                cooldownTimer.Start();
            }

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
