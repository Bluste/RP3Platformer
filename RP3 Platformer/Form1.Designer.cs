using System.Drawing;

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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.realShield1 = new System.Windows.Forms.PictureBox();
            this.shield1 = new System.Windows.Forms.PictureBox();
            this.flower1 = new System.Windows.Forms.PictureBox();
            this.plantStopper1_D = new System.Windows.Forms.PictureBox();
            this.plantStopper1_U = new System.Windows.Forms.PictureBox();
            this.plantStopper2_D = new System.Windows.Forms.PictureBox();
            this.plantStopper2_U = new System.Windows.Forms.PictureBox();
            this.pipePlant2 = new System.Windows.Forms.PictureBox();
            this.ceilingChecker = new System.Windows.Forms.PictureBox();
            this.rightChecker = new System.Windows.Forms.PictureBox();
            this.leftChecker = new System.Windows.Forms.PictureBox();
            this.brickBoxShield = new System.Windows.Forms.PictureBox();
            this.pictureBoxEnemyPlant2 = new System.Windows.Forms.PictureBox();
            this.pipePlant1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxEnemyPlant1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin36 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin35 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin34 = new System.Windows.Forms.PictureBox();
            this.pipeFinal = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin10 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin9 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin8 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin7 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin6 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin5 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin23 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin24 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin26 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin25 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin27 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin29 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin28 = new System.Windows.Forms.PictureBox();
            this.platform4_3 = new System.Windows.Forms.PictureBox();
            this.platform4_2 = new System.Windows.Forms.PictureBox();
            this.platform4_1 = new System.Windows.Forms.PictureBox();
            this.platform3_3 = new System.Windows.Forms.PictureBox();
            this.platform3_2 = new System.Windows.Forms.PictureBox();
            this.platform3_1 = new System.Windows.Forms.PictureBox();
            this.platform5_5 = new System.Windows.Forms.PictureBox();
            this.platform5_4 = new System.Windows.Forms.PictureBox();
            this.platform5_3 = new System.Windows.Forms.PictureBox();
            this.platform5_2 = new System.Windows.Forms.PictureBox();
            this.platform5_1 = new System.Windows.Forms.PictureBox();
            this.platform2_5 = new System.Windows.Forms.PictureBox();
            this.platform2_4 = new System.Windows.Forms.PictureBox();
            this.platform2_3 = new System.Windows.Forms.PictureBox();
            this.platform2_2 = new System.Windows.Forms.PictureBox();
            this.platform2_1 = new System.Windows.Forms.PictureBox();
            this.platform1_5 = new System.Windows.Forms.PictureBox();
            this.platform1_4 = new System.Windows.Forms.PictureBox();
            this.platform1_3 = new System.Windows.Forms.PictureBox();
            this.platform1_2 = new System.Windows.Forms.PictureBox();
            this.platform1_1 = new System.Windows.Forms.PictureBox();
            this.floor1 = new System.Windows.Forms.PictureBox();
            this.floor2 = new System.Windows.Forms.PictureBox();
            this.groundChecker = new System.Windows.Forms.PictureBox();
            this.verticalMovingPlatform = new System.Windows.Forms.PictureBox();
            this.brickBoxFlower = new System.Windows.Forms.PictureBox();
            this.horizontalMovingPlatform = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin19 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin18 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin17 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin16 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin15 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin14 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin13 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin12 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin11 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin20 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin22 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin21 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin30 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin33 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin32 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin31 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlayer = new System.Windows.Forms.PictureBox();
            this.level2platform1_1 = new System.Windows.Forms.PictureBox();
            this.level2platform1_2 = new System.Windows.Forms.PictureBox();
            this.level2platform1_4 = new System.Windows.Forms.PictureBox();
            this.level2platform1_3 = new System.Windows.Forms.PictureBox();
            this.level2platform1_5 = new System.Windows.Forms.PictureBox();
            this.level2platform2_5 = new System.Windows.Forms.PictureBox();
            this.level2platform2_4 = new System.Windows.Forms.PictureBox();
            this.level2platform2_3 = new System.Windows.Forms.PictureBox();
            this.level2platform2_2 = new System.Windows.Forms.PictureBox();
            this.level2platform2_1 = new System.Windows.Forms.PictureBox();
            this.level2platform3_5 = new System.Windows.Forms.PictureBox();
            this.level2platform3_4 = new System.Windows.Forms.PictureBox();
            this.level2platform3_3 = new System.Windows.Forms.PictureBox();
            this.level2platform3_2 = new System.Windows.Forms.PictureBox();
            this.level2platform3_1 = new System.Windows.Forms.PictureBox();
            this.level2platform4_5 = new System.Windows.Forms.PictureBox();
            this.level2platform4_4 = new System.Windows.Forms.PictureBox();
            this.level2platform4_3 = new System.Windows.Forms.PictureBox();
            this.level2platform4_2 = new System.Windows.Forms.PictureBox();
            this.level2platform4_1 = new System.Windows.Forms.PictureBox();
            this.level2platform6_3 = new System.Windows.Forms.PictureBox();
            this.level2platform6_2 = new System.Windows.Forms.PictureBox();
            this.level2platform6_1 = new System.Windows.Forms.PictureBox();
            this.level2platform5_3 = new System.Windows.Forms.PictureBox();
            this.level2platform5_2 = new System.Windows.Forms.PictureBox();
            this.level2platform5_1 = new System.Windows.Forms.PictureBox();
            this.horizontalMovingPlatform2 = new System.Windows.Forms.PictureBox();
            this.level2platform7_5 = new System.Windows.Forms.PictureBox();
            this.level2platform7_4 = new System.Windows.Forms.PictureBox();
            this.level2platform7_3 = new System.Windows.Forms.PictureBox();
            this.level2platform7_2 = new System.Windows.Forms.PictureBox();
            this.level2platform7_1 = new System.Windows.Forms.PictureBox();
            this.verticalMovingPlatform2 = new System.Windows.Forms.PictureBox();
            this.level2platform2_6 = new System.Windows.Forms.PictureBox();
            this.level2platform2_7 = new System.Windows.Forms.PictureBox();
            this.flower2 = new System.Windows.Forms.PictureBox();
            this.brickBoxFlower2 = new System.Windows.Forms.PictureBox();
            this.shield2 = new System.Windows.Forms.PictureBox();
            this.brickBoxShield2 = new System.Windows.Forms.PictureBox();
            this.floor3 = new System.Windows.Forms.PictureBox();
            this.peach = new System.Windows.Forms.PictureBox();
            this.lava = new System.Windows.Forms.PictureBox();
            this.pictureBoxEnemyFire2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxEnemyFire1 = new System.Windows.Forms.PictureBox();
            this.fireStopper1_U = new System.Windows.Forms.PictureBox();
            this.fireStopper2_U = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoinTwo1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoinTwo2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoinTwo3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoinTwo4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoinTwo5 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoinTwo6 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoinTwo7 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoinTwo8 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoinTwo10 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoinTwo9 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoinTwo13 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoinTwo12 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoinTwo11 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoinTwo14 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoinTwo15 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoinTwo16 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoinTwo29 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoinTwo28 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoinTwo27 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoinTwo26 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoinTwo20 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoinTwo19 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoinTwo18 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoinTwo17 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoinTwo25 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoinTwo24 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoinTwo23 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoinTwo22 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoinTwo21 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pipefinal2 = new System.Windows.Forms.PictureBox();
            this.brickBoxMushroom = new System.Windows.Forms.PictureBox();
            this.mushroom1 = new System.Windows.Forms.PictureBox();
            this.cooldownlabel = new System.Windows.Forms.PictureBox();
            this.mushroomlabel = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoinTwo106 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.realShield1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shield1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flower1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantStopper1_D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantStopper1_U)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantStopper2_D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantStopper2_U)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipePlant2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceilingChecker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightChecker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftChecker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brickBoxShield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemyPlant2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipePlant1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemyPlant1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform4_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform4_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform4_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform3_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform3_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform3_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform5_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform5_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform5_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform5_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform5_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundChecker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalMovingPlatform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brickBoxFlower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalMovingPlatform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform1_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform1_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform1_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform1_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform1_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform2_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform2_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform2_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform2_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform2_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform3_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform3_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform3_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform3_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform3_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform4_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform4_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform4_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform4_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform4_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform6_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform6_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform6_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform5_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform5_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform5_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalMovingPlatform2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform7_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform7_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform7_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform7_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform7_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalMovingPlatform2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform2_6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform2_7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flower2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brickBoxFlower2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shield2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brickBoxShield2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lava)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemyFire2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemyFire1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStopper1_U)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStopper2_U)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipefinal2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brickBoxMushroom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mushroom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cooldownlabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mushroomlabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo106)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLives
            // 
            this.labelLives.AutoSize = true;
            this.labelLives.BackColor = System.Drawing.Color.Transparent;
            this.labelLives.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLives.Location = new System.Drawing.Point(13, 14);
            this.labelLives.Name = "labelLives";
            this.labelLives.Size = new System.Drawing.Size(91, 25);
            this.labelLives.TabIndex = 0;
            this.labelLives.Text = "Lives: 10";
            // 
            // labelScore
            // 
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(844, 14);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(125, 25);
            this.labelScore.TabIndex = 1;
            this.labelScore.Text = "Score: 0";
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // realShield1
            // 
            this.realShield1.BackColor = System.Drawing.Color.Transparent;
            this.realShield1.Image = ((System.Drawing.Image)(resources.GetObject("realShield1.Image")));
            this.realShield1.InitialImage = null;
            this.realShield1.Location = new System.Drawing.Point(95, 276);
            this.realShield1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.realShield1.Name = "realShield1";
            this.realShield1.Size = new System.Drawing.Size(84, 87);
            this.realShield1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.realShield1.TabIndex = 107;
            this.realShield1.TabStop = false;
            this.realShield1.Tag = "shield";
            this.realShield1.Visible = false;
            // 
            // shield1
            // 
            this.shield1.BackColor = System.Drawing.Color.Transparent;
            this.shield1.Image = ((System.Drawing.Image)(resources.GetObject("shield1.Image")));
            this.shield1.Location = new System.Drawing.Point(227, 391);
            this.shield1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shield1.Name = "shield1";
            this.shield1.Size = new System.Drawing.Size(29, 27);
            this.shield1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.shield1.TabIndex = 106;
            this.shield1.TabStop = false;
            this.shield1.Tag = "level1shield";
            this.shield1.Visible = false;
            // 
            // flower1
            // 
            this.flower1.BackColor = System.Drawing.Color.Transparent;
            this.flower1.Image = ((System.Drawing.Image)(resources.GetObject("flower1.Image")));
            this.flower1.Location = new System.Drawing.Point(213, 103);
            this.flower1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flower1.Name = "flower1";
            this.flower1.Size = new System.Drawing.Size(29, 27);
            this.flower1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.flower1.TabIndex = 105;
            this.flower1.TabStop = false;
            this.flower1.Tag = "level1flower";
            this.flower1.Visible = false;
            // 
            // plantStopper1_D
            // 
            this.plantStopper1_D.BackColor = System.Drawing.Color.Transparent;
            this.plantStopper1_D.InitialImage = null;
            this.plantStopper1_D.Location = new System.Drawing.Point(543, 525);
            this.plantStopper1_D.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plantStopper1_D.Name = "plantStopper1_D";
            this.plantStopper1_D.Size = new System.Drawing.Size(53, 15);
            this.plantStopper1_D.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.plantStopper1_D.TabIndex = 104;
            this.plantStopper1_D.TabStop = false;
            this.plantStopper1_D.Tag = "plantStopper";
            this.plantStopper1_D.Visible = false;
            // 
            // plantStopper1_U
            // 
            this.plantStopper1_U.BackColor = System.Drawing.Color.Transparent;
            this.plantStopper1_U.InitialImage = null;
            this.plantStopper1_U.Location = new System.Drawing.Point(543, 405);
            this.plantStopper1_U.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plantStopper1_U.Name = "plantStopper1_U";
            this.plantStopper1_U.Size = new System.Drawing.Size(53, 15);
            this.plantStopper1_U.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.plantStopper1_U.TabIndex = 103;
            this.plantStopper1_U.TabStop = false;
            this.plantStopper1_U.Tag = "plantStopper";
            this.plantStopper1_U.Visible = false;
            // 
            // plantStopper2_D
            // 
            this.plantStopper2_D.BackColor = System.Drawing.Color.Transparent;
            this.plantStopper2_D.InitialImage = null;
            this.plantStopper2_D.Location = new System.Drawing.Point(640, 265);
            this.plantStopper2_D.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plantStopper2_D.Name = "plantStopper2_D";
            this.plantStopper2_D.Size = new System.Drawing.Size(53, 15);
            this.plantStopper2_D.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.plantStopper2_D.TabIndex = 102;
            this.plantStopper2_D.TabStop = false;
            this.plantStopper2_D.Tag = "plantStopper";
            this.plantStopper2_D.Visible = false;
            // 
            // plantStopper2_U
            // 
            this.plantStopper2_U.BackColor = System.Drawing.Color.Transparent;
            this.plantStopper2_U.InitialImage = null;
            this.plantStopper2_U.Location = new System.Drawing.Point(639, 146);
            this.plantStopper2_U.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plantStopper2_U.Name = "plantStopper2_U";
            this.plantStopper2_U.Size = new System.Drawing.Size(53, 15);
            this.plantStopper2_U.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.plantStopper2_U.TabIndex = 101;
            this.plantStopper2_U.TabStop = false;
            this.plantStopper2_U.Tag = "plantStopper";
            this.plantStopper2_U.Visible = false;
            // 
            // pipePlant2
            // 
            this.pipePlant2.BackColor = System.Drawing.Color.Transparent;
            this.pipePlant2.Image = global::RP3_Platformer.Properties.Resources.pipe2;
            this.pipePlant2.InitialImage = null;
            this.pipePlant2.Location = new System.Drawing.Point(649, 212);
            this.pipePlant2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pipePlant2.Name = "pipePlant2";
            this.pipePlant2.Size = new System.Drawing.Size(35, 31);
            this.pipePlant2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipePlant2.TabIndex = 92;
            this.pipePlant2.TabStop = false;
            this.pipePlant2.Tag = "level1platform";
            // 
            // ceilingChecker
            // 
            this.ceilingChecker.BackColor = System.Drawing.Color.Transparent;
            this.ceilingChecker.InitialImage = null;
            this.ceilingChecker.Location = new System.Drawing.Point(405, 498);
            this.ceilingChecker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ceilingChecker.Name = "ceilingChecker";
            this.ceilingChecker.Size = new System.Drawing.Size(20, 53);
            this.ceilingChecker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ceilingChecker.TabIndex = 91;
            this.ceilingChecker.TabStop = false;
            this.ceilingChecker.Tag = "ceilingChecker";
            this.ceilingChecker.Visible = false;
            // 
            // rightChecker
            // 
            this.rightChecker.BackColor = System.Drawing.Color.Transparent;
            this.rightChecker.InitialImage = null;
            this.rightChecker.Location = new System.Drawing.Point(316, 498);
            this.rightChecker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rightChecker.Name = "rightChecker";
            this.rightChecker.Size = new System.Drawing.Size(20, 53);
            this.rightChecker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightChecker.TabIndex = 90;
            this.rightChecker.TabStop = false;
            this.rightChecker.Tag = "rightChecker";
            this.rightChecker.Visible = false;
            // 
            // leftChecker
            // 
            this.leftChecker.BackColor = System.Drawing.Color.Transparent;
            this.leftChecker.InitialImage = null;
            this.leftChecker.Location = new System.Drawing.Point(357, 498);
            this.leftChecker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leftChecker.Name = "leftChecker";
            this.leftChecker.Size = new System.Drawing.Size(20, 53);
            this.leftChecker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftChecker.TabIndex = 89;
            this.leftChecker.TabStop = false;
            this.leftChecker.Tag = "leftChecker";
            this.leftChecker.Visible = false;
            // 
            // brickBoxShield
            // 
            this.brickBoxShield.BackColor = System.Drawing.Color.Transparent;
            this.brickBoxShield.Image = ((System.Drawing.Image)(resources.GetObject("brickBoxShield.Image")));
            this.brickBoxShield.Location = new System.Drawing.Point(226, 390);
            this.brickBoxShield.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brickBoxShield.Name = "brickBoxShield";
            this.brickBoxShield.Size = new System.Drawing.Size(31, 30);
            this.brickBoxShield.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.brickBoxShield.TabIndex = 88;
            this.brickBoxShield.TabStop = false;
            this.brickBoxShield.Tag = "level1brick";
            // 
            // pictureBoxEnemyPlant2
            // 
            this.pictureBoxEnemyPlant2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEnemyPlant2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEnemyPlant2.Image")));
            this.pictureBoxEnemyPlant2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxEnemyPlant2.InitialImage")));
            this.pictureBoxEnemyPlant2.Location = new System.Drawing.Point(645, 162);
            this.pictureBoxEnemyPlant2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxEnemyPlant2.Name = "pictureBoxEnemyPlant2";
            this.pictureBoxEnemyPlant2.Size = new System.Drawing.Size(43, 50);
            this.pictureBoxEnemyPlant2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEnemyPlant2.TabIndex = 86;
            this.pictureBoxEnemyPlant2.TabStop = false;
            this.pictureBoxEnemyPlant2.Tag = "level1EnemyPlant";
            // 
            // pipePlant1
            // 
            this.pipePlant1.BackColor = System.Drawing.Color.Transparent;
            this.pipePlant1.Image = global::RP3_Platformer.Properties.Resources.pipe2;
            this.pipePlant1.InitialImage = null;
            this.pipePlant1.Location = new System.Drawing.Point(557, 471);
            this.pipePlant1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pipePlant1.Name = "pipePlant1";
            this.pipePlant1.Size = new System.Drawing.Size(35, 31);
            this.pipePlant1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipePlant1.TabIndex = 85;
            this.pipePlant1.TabStop = false;
            this.pipePlant1.Tag = "level1platform";
            // 
            // pictureBoxEnemyPlant1
            // 
            this.pictureBoxEnemyPlant1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEnemyPlant1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEnemyPlant1.Image")));
            this.pictureBoxEnemyPlant1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxEnemyPlant1.InitialImage")));
            this.pictureBoxEnemyPlant1.Location = new System.Drawing.Point(553, 421);
            this.pictureBoxEnemyPlant1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxEnemyPlant1.Name = "pictureBoxEnemyPlant1";
            this.pictureBoxEnemyPlant1.Size = new System.Drawing.Size(43, 50);
            this.pictureBoxEnemyPlant1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEnemyPlant1.TabIndex = 84;
            this.pictureBoxEnemyPlant1.TabStop = false;
            this.pictureBoxEnemyPlant1.Tag = "level1EnemyPlant";
            // 
            // pictureBoxCoin36
            // 
            this.pictureBoxCoin36.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin36.InitialImage = null;
            this.pictureBoxCoin36.Location = new System.Drawing.Point(781, 473);
            this.pictureBoxCoin36.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoin36.Name = "pictureBoxCoin36";
            this.pictureBoxCoin36.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoin36.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin36.TabIndex = 83;
            this.pictureBoxCoin36.TabStop = false;
            this.pictureBoxCoin36.Tag = "level1coin";
            // 
            // pictureBoxCoin35
            // 
            this.pictureBoxCoin35.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin35.InitialImage = null;
            this.pictureBoxCoin35.Location = new System.Drawing.Point(744, 473);
            this.pictureBoxCoin35.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoin35.Name = "pictureBoxCoin35";
            this.pictureBoxCoin35.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoin35.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin35.TabIndex = 82;
            this.pictureBoxCoin35.TabStop = false;
            this.pictureBoxCoin35.Tag = "level1coin";
            // 
            // pictureBoxCoin34
            // 
            this.pictureBoxCoin34.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin34.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxCoin34.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin34.Image")));
            this.pictureBoxCoin34.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin34.InitialImage")));
            this.pictureBoxCoin34.Location = new System.Drawing.Point(709, 473);
            this.pictureBoxCoin34.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoin34.Name = "pictureBoxCoin34";
            this.pictureBoxCoin34.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoin34.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin34.TabIndex = 81;
            this.pictureBoxCoin34.TabStop = false;
            this.pictureBoxCoin34.Tag = "level1coin";
            // 
            // pipeFinal
            // 
            this.pipeFinal.BackColor = System.Drawing.Color.Transparent;
            this.pipeFinal.Image = ((System.Drawing.Image)(resources.GetObject("pipeFinal.Image")));
            this.pipeFinal.InitialImage = ((System.Drawing.Image)(resources.GetObject("pipeFinal.InitialImage")));
            this.pipeFinal.Location = new System.Drawing.Point(903, 303);
            this.pipeFinal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pipeFinal.Name = "pipeFinal";
            this.pipeFinal.Size = new System.Drawing.Size(97, 60);
            this.pipeFinal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeFinal.TabIndex = 80;
            this.pipeFinal.TabStop = false;
            this.pipeFinal.Tag = "level1FinalPipe";
            // 
            // pictureBoxCoin10
            // 
            this.pictureBoxCoin10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin10.InitialImage = null;
            this.pictureBoxCoin10.Location = new System.Drawing.Point(19, 286);
            this.pictureBoxCoin10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoin10.Name = "pictureBoxCoin10";
            this.pictureBoxCoin10.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoin10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin10.TabIndex = 76;
            this.pictureBoxCoin10.TabStop = false;
            this.pictureBoxCoin10.Tag = "level1coin";
            // 
            // pictureBoxCoin9
            // 
            this.pictureBoxCoin9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin9.InitialImage = null;
            this.pictureBoxCoin9.Location = new System.Drawing.Point(19, 255);
            this.pictureBoxCoin9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoin9.Name = "pictureBoxCoin9";
            this.pictureBoxCoin9.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoin9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin9.TabIndex = 75;
            this.pictureBoxCoin9.TabStop = false;
            this.pictureBoxCoin9.Tag = "level1coin";
            // 
            // pictureBoxCoin8
            // 
            this.pictureBoxCoin8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin8.InitialImage = null;
            this.pictureBoxCoin8.Location = new System.Drawing.Point(19, 219);
            this.pictureBoxCoin8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoin8.Name = "pictureBoxCoin8";
            this.pictureBoxCoin8.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoin8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin8.TabIndex = 74;
            this.pictureBoxCoin8.TabStop = false;
            this.pictureBoxCoin8.Tag = "level1coin";
            // 
            // pictureBoxCoin7
            // 
            this.pictureBoxCoin7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin7.InitialImage = null;
            this.pictureBoxCoin7.Location = new System.Drawing.Point(19, 190);
            this.pictureBoxCoin7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoin7.Name = "pictureBoxCoin7";
            this.pictureBoxCoin7.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoin7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin7.TabIndex = 73;
            this.pictureBoxCoin7.TabStop = false;
            this.pictureBoxCoin7.Tag = "level1coin";
            // 
            // pictureBoxCoin6
            // 
            this.pictureBoxCoin6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin6.InitialImage = null;
            this.pictureBoxCoin6.Location = new System.Drawing.Point(19, 158);
            this.pictureBoxCoin6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoin6.Name = "pictureBoxCoin6";
            this.pictureBoxCoin6.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoin6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin6.TabIndex = 72;
            this.pictureBoxCoin6.TabStop = false;
            this.pictureBoxCoin6.Tag = "level1coin";
            // 
            // pictureBoxCoin5
            // 
            this.pictureBoxCoin5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin5.InitialImage = null;
            this.pictureBoxCoin5.Location = new System.Drawing.Point(19, 127);
            this.pictureBoxCoin5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoin5.Name = "pictureBoxCoin5";
            this.pictureBoxCoin5.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoin5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin5.TabIndex = 71;
            this.pictureBoxCoin5.TabStop = false;
            this.pictureBoxCoin5.Tag = "level1coin";
            // 
            // pictureBoxCoin23
            // 
            this.pictureBoxCoin23.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin23.InitialImage = null;
            this.pictureBoxCoin23.Location = new System.Drawing.Point(557, 79);
            this.pictureBoxCoin23.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoin23.Name = "pictureBoxCoin23";
            this.pictureBoxCoin23.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoin23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin23.TabIndex = 70;
            this.pictureBoxCoin23.TabStop = false;
            this.pictureBoxCoin23.Tag = "level1coin";
            // 
            // pictureBoxCoin24
            // 
            this.pictureBoxCoin24.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin24.InitialImage = null;
            this.pictureBoxCoin24.Location = new System.Drawing.Point(595, 53);
            this.pictureBoxCoin24.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoin24.Name = "pictureBoxCoin24";
            this.pictureBoxCoin24.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoin24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin24.TabIndex = 69;
            this.pictureBoxCoin24.TabStop = false;
            this.pictureBoxCoin24.Tag = "level1coin";
            // 
            // pictureBoxCoin26
            // 
            this.pictureBoxCoin26.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin26.InitialImage = null;
            this.pictureBoxCoin26.Location = new System.Drawing.Point(672, 70);
            this.pictureBoxCoin26.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoin26.Name = "pictureBoxCoin26";
            this.pictureBoxCoin26.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoin26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin26.TabIndex = 68;
            this.pictureBoxCoin26.TabStop = false;
            this.pictureBoxCoin26.Tag = "level1coin";
            // 
            // pictureBoxCoin25
            // 
            this.pictureBoxCoin25.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin25.InitialImage = null;
            this.pictureBoxCoin25.Location = new System.Drawing.Point(633, 53);
            this.pictureBoxCoin25.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoin25.Name = "pictureBoxCoin25";
            this.pictureBoxCoin25.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoin25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin25.TabIndex = 67;
            this.pictureBoxCoin25.TabStop = false;
            this.pictureBoxCoin25.Tag = "level1coin";
            // 
            // pictureBoxCoin27
            // 
            this.pictureBoxCoin27.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin27.InitialImage = null;
            this.pictureBoxCoin27.Location = new System.Drawing.Point(379, 110);
            this.pictureBoxCoin27.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoin27.Name = "pictureBoxCoin27";
            this.pictureBoxCoin27.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoin27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin27.TabIndex = 66;
            this.pictureBoxCoin27.TabStop = false;
            this.pictureBoxCoin27.Tag = "level1coin";
            // 
            // pictureBoxCoin29
            // 
            this.pictureBoxCoin29.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin29.InitialImage = null;
            this.pictureBoxCoin29.Location = new System.Drawing.Point(723, 219);
            this.pictureBoxCoin29.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoin29.Name = "pictureBoxCoin29";
            this.pictureBoxCoin29.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoin29.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin29.TabIndex = 65;
            this.pictureBoxCoin29.TabStop = false;
            this.pictureBoxCoin29.Tag = "level1coin";
            // 
            // pictureBoxCoin28
            // 
            this.pictureBoxCoin28.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin28.InitialImage = null;
            this.pictureBoxCoin28.Location = new System.Drawing.Point(688, 219);
            this.pictureBoxCoin28.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoin28.Name = "pictureBoxCoin28";
            this.pictureBoxCoin28.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoin28.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin28.TabIndex = 64;
            this.pictureBoxCoin28.TabStop = false;
            this.pictureBoxCoin28.Tag = "level1coin";
            // 
            // platform4_3
            // 
            this.platform4_3.BackColor = System.Drawing.Color.Transparent;
            this.platform4_3.Image = ((System.Drawing.Image)(resources.GetObject("platform4_3.Image")));
            this.platform4_3.InitialImage = ((System.Drawing.Image)(resources.GetObject("platform4_3.InitialImage")));
            this.platform4_3.Location = new System.Drawing.Point(711, 242);
            this.platform4_3.Margin = new System.Windows.Forms.Padding(0);
            this.platform4_3.Name = "platform4_3";
            this.platform4_3.Size = new System.Drawing.Size(31, 30);
            this.platform4_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform4_3.TabIndex = 63;
            this.platform4_3.TabStop = false;
            this.platform4_3.Tag = "level1platform";
            // 
            // platform4_2
            // 
            this.platform4_2.BackColor = System.Drawing.Color.Transparent;
            this.platform4_2.Image = ((System.Drawing.Image)(resources.GetObject("platform4_2.Image")));
            this.platform4_2.InitialImage = ((System.Drawing.Image)(resources.GetObject("platform4_2.InitialImage")));
            this.platform4_2.Location = new System.Drawing.Point(681, 242);
            this.platform4_2.Margin = new System.Windows.Forms.Padding(0);
            this.platform4_2.Name = "platform4_2";
            this.platform4_2.Size = new System.Drawing.Size(31, 30);
            this.platform4_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform4_2.TabIndex = 62;
            this.platform4_2.TabStop = false;
            this.platform4_2.Tag = "level1platform";
            // 
            // platform4_1
            // 
            this.platform4_1.BackColor = System.Drawing.Color.Transparent;
            this.platform4_1.Image = ((System.Drawing.Image)(resources.GetObject("platform4_1.Image")));
            this.platform4_1.InitialImage = ((System.Drawing.Image)(resources.GetObject("platform4_1.InitialImage")));
            this.platform4_1.Location = new System.Drawing.Point(651, 242);
            this.platform4_1.Margin = new System.Windows.Forms.Padding(0);
            this.platform4_1.Name = "platform4_1";
            this.platform4_1.Size = new System.Drawing.Size(31, 30);
            this.platform4_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform4_1.TabIndex = 61;
            this.platform4_1.TabStop = false;
            this.platform4_1.Tag = "level1platform";
            // 
            // platform3_3
            // 
            this.platform3_3.BackColor = System.Drawing.Color.Transparent;
            this.platform3_3.Image = ((System.Drawing.Image)(resources.GetObject("platform3_3.Image")));
            this.platform3_3.InitialImage = ((System.Drawing.Image)(resources.GetObject("platform3_3.InitialImage")));
            this.platform3_3.Location = new System.Drawing.Point(509, 274);
            this.platform3_3.Margin = new System.Windows.Forms.Padding(0);
            this.platform3_3.Name = "platform3_3";
            this.platform3_3.Size = new System.Drawing.Size(31, 30);
            this.platform3_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform3_3.TabIndex = 60;
            this.platform3_3.TabStop = false;
            this.platform3_3.Tag = "level1platform";
            // 
            // platform3_2
            // 
            this.platform3_2.BackColor = System.Drawing.Color.Transparent;
            this.platform3_2.Image = ((System.Drawing.Image)(resources.GetObject("platform3_2.Image")));
            this.platform3_2.InitialImage = ((System.Drawing.Image)(resources.GetObject("platform3_2.InitialImage")));
            this.platform3_2.Location = new System.Drawing.Point(479, 274);
            this.platform3_2.Margin = new System.Windows.Forms.Padding(0);
            this.platform3_2.Name = "platform3_2";
            this.platform3_2.Size = new System.Drawing.Size(31, 30);
            this.platform3_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform3_2.TabIndex = 59;
            this.platform3_2.TabStop = false;
            this.platform3_2.Tag = "level1platform";
            // 
            // platform3_1
            // 
            this.platform3_1.BackColor = System.Drawing.Color.Transparent;
            this.platform3_1.Image = ((System.Drawing.Image)(resources.GetObject("platform3_1.Image")));
            this.platform3_1.InitialImage = ((System.Drawing.Image)(resources.GetObject("platform3_1.InitialImage")));
            this.platform3_1.Location = new System.Drawing.Point(449, 274);
            this.platform3_1.Margin = new System.Windows.Forms.Padding(0);
            this.platform3_1.Name = "platform3_1";
            this.platform3_1.Size = new System.Drawing.Size(31, 30);
            this.platform3_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform3_1.TabIndex = 58;
            this.platform3_1.TabStop = false;
            this.platform3_1.Tag = "level1platform";
            // 
            // platform5_5
            // 
            this.platform5_5.BackColor = System.Drawing.Color.Transparent;
            this.platform5_5.Image = ((System.Drawing.Image)(resources.GetObject("platform5_5.Image")));
            this.platform5_5.InitialImage = ((System.Drawing.Image)(resources.GetObject("platform5_5.InitialImage")));
            this.platform5_5.Location = new System.Drawing.Point(867, 127);
            this.platform5_5.Margin = new System.Windows.Forms.Padding(0);
            this.platform5_5.Name = "platform5_5";
            this.platform5_5.Size = new System.Drawing.Size(31, 30);
            this.platform5_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform5_5.TabIndex = 57;
            this.platform5_5.TabStop = false;
            this.platform5_5.Tag = "level1platform";
            // 
            // platform5_4
            // 
            this.platform5_4.BackColor = System.Drawing.Color.Transparent;
            this.platform5_4.Image = ((System.Drawing.Image)(resources.GetObject("platform5_4.Image")));
            this.platform5_4.InitialImage = ((System.Drawing.Image)(resources.GetObject("platform5_4.InitialImage")));
            this.platform5_4.Location = new System.Drawing.Point(837, 127);
            this.platform5_4.Margin = new System.Windows.Forms.Padding(0);
            this.platform5_4.Name = "platform5_4";
            this.platform5_4.Size = new System.Drawing.Size(31, 30);
            this.platform5_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform5_4.TabIndex = 56;
            this.platform5_4.TabStop = false;
            this.platform5_4.Tag = "level1platform";
            // 
            // platform5_3
            // 
            this.platform5_3.BackColor = System.Drawing.Color.Transparent;
            this.platform5_3.Image = ((System.Drawing.Image)(resources.GetObject("platform5_3.Image")));
            this.platform5_3.InitialImage = ((System.Drawing.Image)(resources.GetObject("platform5_3.InitialImage")));
            this.platform5_3.Location = new System.Drawing.Point(807, 127);
            this.platform5_3.Margin = new System.Windows.Forms.Padding(0);
            this.platform5_3.Name = "platform5_3";
            this.platform5_3.Size = new System.Drawing.Size(31, 30);
            this.platform5_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform5_3.TabIndex = 55;
            this.platform5_3.TabStop = false;
            this.platform5_3.Tag = "level1platform";
            // 
            // platform5_2
            // 
            this.platform5_2.BackColor = System.Drawing.Color.Transparent;
            this.platform5_2.Image = ((System.Drawing.Image)(resources.GetObject("platform5_2.Image")));
            this.platform5_2.InitialImage = ((System.Drawing.Image)(resources.GetObject("platform5_2.InitialImage")));
            this.platform5_2.Location = new System.Drawing.Point(777, 127);
            this.platform5_2.Margin = new System.Windows.Forms.Padding(0);
            this.platform5_2.Name = "platform5_2";
            this.platform5_2.Size = new System.Drawing.Size(31, 30);
            this.platform5_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform5_2.TabIndex = 54;
            this.platform5_2.TabStop = false;
            this.platform5_2.Tag = "level1platform";
            // 
            // platform5_1
            // 
            this.platform5_1.BackColor = System.Drawing.Color.Transparent;
            this.platform5_1.Image = ((System.Drawing.Image)(resources.GetObject("platform5_1.Image")));
            this.platform5_1.InitialImage = ((System.Drawing.Image)(resources.GetObject("platform5_1.InitialImage")));
            this.platform5_1.Location = new System.Drawing.Point(747, 127);
            this.platform5_1.Margin = new System.Windows.Forms.Padding(0);
            this.platform5_1.Name = "platform5_1";
            this.platform5_1.Size = new System.Drawing.Size(31, 30);
            this.platform5_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform5_1.TabIndex = 53;
            this.platform5_1.TabStop = false;
            this.platform5_1.Tag = "level1platform";
            // 
            // platform2_5
            // 
            this.platform2_5.BackColor = System.Drawing.Color.Transparent;
            this.platform2_5.Image = ((System.Drawing.Image)(resources.GetObject("platform2_5.Image")));
            this.platform2_5.InitialImage = ((System.Drawing.Image)(resources.GetObject("platform2_5.InitialImage")));
            this.platform2_5.Location = new System.Drawing.Point(213, 197);
            this.platform2_5.Margin = new System.Windows.Forms.Padding(0);
            this.platform2_5.Name = "platform2_5";
            this.platform2_5.Size = new System.Drawing.Size(31, 30);
            this.platform2_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform2_5.TabIndex = 52;
            this.platform2_5.TabStop = false;
            this.platform2_5.Tag = "level1platform";
            // 
            // platform2_4
            // 
            this.platform2_4.BackColor = System.Drawing.Color.Transparent;
            this.platform2_4.Image = ((System.Drawing.Image)(resources.GetObject("platform2_4.Image")));
            this.platform2_4.InitialImage = ((System.Drawing.Image)(resources.GetObject("platform2_4.InitialImage")));
            this.platform2_4.Location = new System.Drawing.Point(183, 197);
            this.platform2_4.Margin = new System.Windows.Forms.Padding(0);
            this.platform2_4.Name = "platform2_4";
            this.platform2_4.Size = new System.Drawing.Size(31, 30);
            this.platform2_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform2_4.TabIndex = 51;
            this.platform2_4.TabStop = false;
            this.platform2_4.Tag = "level1platform";
            // 
            // platform2_3
            // 
            this.platform2_3.BackColor = System.Drawing.Color.Transparent;
            this.platform2_3.Image = ((System.Drawing.Image)(resources.GetObject("platform2_3.Image")));
            this.platform2_3.InitialImage = ((System.Drawing.Image)(resources.GetObject("platform2_3.InitialImage")));
            this.platform2_3.Location = new System.Drawing.Point(153, 197);
            this.platform2_3.Margin = new System.Windows.Forms.Padding(0);
            this.platform2_3.Name = "platform2_3";
            this.platform2_3.Size = new System.Drawing.Size(31, 30);
            this.platform2_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform2_3.TabIndex = 50;
            this.platform2_3.TabStop = false;
            this.platform2_3.Tag = "level1platform";
            // 
            // platform2_2
            // 
            this.platform2_2.BackColor = System.Drawing.Color.Transparent;
            this.platform2_2.Image = ((System.Drawing.Image)(resources.GetObject("platform2_2.Image")));
            this.platform2_2.InitialImage = ((System.Drawing.Image)(resources.GetObject("platform2_2.InitialImage")));
            this.platform2_2.Location = new System.Drawing.Point(123, 197);
            this.platform2_2.Margin = new System.Windows.Forms.Padding(0);
            this.platform2_2.Name = "platform2_2";
            this.platform2_2.Size = new System.Drawing.Size(31, 30);
            this.platform2_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform2_2.TabIndex = 49;
            this.platform2_2.TabStop = false;
            this.platform2_2.Tag = "level1platform";
            // 
            // platform2_1
            // 
            this.platform2_1.BackColor = System.Drawing.Color.Transparent;
            this.platform2_1.Image = ((System.Drawing.Image)(resources.GetObject("platform2_1.Image")));
            this.platform2_1.InitialImage = ((System.Drawing.Image)(resources.GetObject("platform2_1.InitialImage")));
            this.platform2_1.Location = new System.Drawing.Point(93, 197);
            this.platform2_1.Margin = new System.Windows.Forms.Padding(0);
            this.platform2_1.Name = "platform2_1";
            this.platform2_1.Size = new System.Drawing.Size(31, 30);
            this.platform2_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform2_1.TabIndex = 48;
            this.platform2_1.TabStop = false;
            this.platform2_1.Tag = "level1platform";
            // 
            // platform1_5
            // 
            this.platform1_5.BackColor = System.Drawing.Color.Transparent;
            this.platform1_5.Image = ((System.Drawing.Image)(resources.GetObject("platform1_5.Image")));
            this.platform1_5.InitialImage = ((System.Drawing.Image)(resources.GetObject("platform1_5.InitialImage")));
            this.platform1_5.Location = new System.Drawing.Point(448, 390);
            this.platform1_5.Margin = new System.Windows.Forms.Padding(0);
            this.platform1_5.Name = "platform1_5";
            this.platform1_5.Size = new System.Drawing.Size(31, 30);
            this.platform1_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform1_5.TabIndex = 47;
            this.platform1_5.TabStop = false;
            this.platform1_5.Tag = "level1platform";
            // 
            // platform1_4
            // 
            this.platform1_4.BackColor = System.Drawing.Color.Transparent;
            this.platform1_4.Image = ((System.Drawing.Image)(resources.GetObject("platform1_4.Image")));
            this.platform1_4.InitialImage = ((System.Drawing.Image)(resources.GetObject("platform1_4.InitialImage")));
            this.platform1_4.Location = new System.Drawing.Point(419, 390);
            this.platform1_4.Margin = new System.Windows.Forms.Padding(0);
            this.platform1_4.Name = "platform1_4";
            this.platform1_4.Size = new System.Drawing.Size(31, 30);
            this.platform1_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform1_4.TabIndex = 46;
            this.platform1_4.TabStop = false;
            this.platform1_4.Tag = "level1platform";
            // 
            // platform1_3
            // 
            this.platform1_3.BackColor = System.Drawing.Color.Transparent;
            this.platform1_3.Image = ((System.Drawing.Image)(resources.GetObject("platform1_3.Image")));
            this.platform1_3.InitialImage = ((System.Drawing.Image)(resources.GetObject("platform1_3.InitialImage")));
            this.platform1_3.Location = new System.Drawing.Point(388, 390);
            this.platform1_3.Margin = new System.Windows.Forms.Padding(0);
            this.platform1_3.Name = "platform1_3";
            this.platform1_3.Size = new System.Drawing.Size(31, 30);
            this.platform1_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform1_3.TabIndex = 45;
            this.platform1_3.TabStop = false;
            this.platform1_3.Tag = "level1platform";
            // 
            // platform1_2
            // 
            this.platform1_2.BackColor = System.Drawing.Color.Transparent;
            this.platform1_2.Image = ((System.Drawing.Image)(resources.GetObject("platform1_2.Image")));
            this.platform1_2.InitialImage = ((System.Drawing.Image)(resources.GetObject("platform1_2.InitialImage")));
            this.platform1_2.Location = new System.Drawing.Point(357, 390);
            this.platform1_2.Margin = new System.Windows.Forms.Padding(0);
            this.platform1_2.Name = "platform1_2";
            this.platform1_2.Size = new System.Drawing.Size(31, 30);
            this.platform1_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform1_2.TabIndex = 44;
            this.platform1_2.TabStop = false;
            this.platform1_2.Tag = "level1platform";
            // 
            // platform1_1
            // 
            this.platform1_1.BackColor = System.Drawing.Color.Transparent;
            this.platform1_1.Image = ((System.Drawing.Image)(resources.GetObject("platform1_1.Image")));
            this.platform1_1.InitialImage = ((System.Drawing.Image)(resources.GetObject("platform1_1.InitialImage")));
            this.platform1_1.Location = new System.Drawing.Point(328, 390);
            this.platform1_1.Margin = new System.Windows.Forms.Padding(0);
            this.platform1_1.Name = "platform1_1";
            this.platform1_1.Size = new System.Drawing.Size(31, 30);
            this.platform1_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform1_1.TabIndex = 43;
            this.platform1_1.TabStop = false;
            this.platform1_1.Tag = "level1platform";
            // 
            // floor1
            // 
            this.floor1.BackColor = System.Drawing.Color.Transparent;
            this.floor1.Location = new System.Drawing.Point(-3, 498);
            this.floor1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.floor1.Name = "floor1";
            this.floor1.Size = new System.Drawing.Size(997, 14);
            this.floor1.TabIndex = 42;
            this.floor1.TabStop = false;
            this.floor1.Tag = "level1platform";
            // 
            // floor2
            // 
            this.floor2.BackColor = System.Drawing.Color.Transparent;
            this.floor2.Location = new System.Drawing.Point(827, 363);
            this.floor2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.floor2.Name = "floor2";
            this.floor2.Size = new System.Drawing.Size(147, 25);
            this.floor2.TabIndex = 41;
            this.floor2.TabStop = false;
            this.floor2.Tag = "level1platform";
            // 
            // groundChecker
            // 
            this.groundChecker.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groundChecker.Location = new System.Drawing.Point(12, 498);
            this.groundChecker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groundChecker.Name = "groundChecker";
            this.groundChecker.Size = new System.Drawing.Size(51, 2);
            this.groundChecker.TabIndex = 40;
            this.groundChecker.TabStop = false;
            // 
            // verticalMovingPlatform
            // 
            this.verticalMovingPlatform.BackColor = System.Drawing.Color.Transparent;
            this.verticalMovingPlatform.Image = ((System.Drawing.Image)(resources.GetObject("verticalMovingPlatform.Image")));
            this.verticalMovingPlatform.Location = new System.Drawing.Point(695, 398);
            this.verticalMovingPlatform.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.verticalMovingPlatform.Name = "verticalMovingPlatform";
            this.verticalMovingPlatform.Size = new System.Drawing.Size(113, 22);
            this.verticalMovingPlatform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.verticalMovingPlatform.TabIndex = 39;
            this.verticalMovingPlatform.TabStop = false;
            this.verticalMovingPlatform.Tag = "level1platform";
            // 
            // brickBoxFlower
            // 
            this.brickBoxFlower.BackColor = System.Drawing.Color.Transparent;
            this.brickBoxFlower.Image = ((System.Drawing.Image)(resources.GetObject("brickBoxFlower.Image")));
            this.brickBoxFlower.Location = new System.Drawing.Point(213, 100);
            this.brickBoxFlower.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brickBoxFlower.Name = "brickBoxFlower";
            this.brickBoxFlower.Size = new System.Drawing.Size(31, 32);
            this.brickBoxFlower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.brickBoxFlower.TabIndex = 38;
            this.brickBoxFlower.TabStop = false;
            this.brickBoxFlower.Tag = "level1brick";
            // 
            // horizontalMovingPlatform
            // 
            this.horizontalMovingPlatform.BackColor = System.Drawing.Color.Transparent;
            this.horizontalMovingPlatform.Image = ((System.Drawing.Image)(resources.GetObject("horizontalMovingPlatform.Image")));
            this.horizontalMovingPlatform.Location = new System.Drawing.Point(477, 135);
            this.horizontalMovingPlatform.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.horizontalMovingPlatform.Name = "horizontalMovingPlatform";
            this.horizontalMovingPlatform.Size = new System.Drawing.Size(149, 21);
            this.horizontalMovingPlatform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.horizontalMovingPlatform.TabIndex = 37;
            this.horizontalMovingPlatform.TabStop = false;
            this.horizontalMovingPlatform.Tag = "level1platform";
            // 
            // pictureBoxCoin19
            // 
            this.pictureBoxCoin19.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin19.InitialImage = null;
            this.pictureBoxCoin19.Location = new System.Drawing.Point(477, 110);
            this.pictureBoxCoin19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoin19.Name = "pictureBoxCoin19";
            this.pictureBoxCoin19.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoin19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin19.TabIndex = 36;
            this.pictureBoxCoin19.TabStop = false;
            this.pictureBoxCoin19.Tag = "level1coin";
            // 
            // pictureBoxCoin18
            // 
            this.pictureBoxCoin18.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin18.InitialImage = null;
            this.pictureBoxCoin18.Location = new System.Drawing.Point(441, 110);
            this.pictureBoxCoin18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoin18.Name = "pictureBoxCoin18";
            this.pictureBoxCoin18.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoin18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin18.TabIndex = 35;
            this.pictureBoxCoin18.TabStop = false;
            this.pictureBoxCoin18.Tag = "level1coin";
            // 
            // pictureBoxCoin17
            // 
            this.pictureBoxCoin17.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin17.InitialImage = null;
            this.pictureBoxCoin17.Location = new System.Drawing.Point(405, 110);
            this.pictureBoxCoin17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoin17.Name = "pictureBoxCoin17";
            this.pictureBoxCoin17.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoin17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin17.TabIndex = 34;
            this.pictureBoxCoin17.TabStop = false;
            this.pictureBoxCoin17.Tag = "level1coin";
            // 
            // pictureBoxCoin16
            // 
            this.pictureBoxCoin16.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin16.InitialImage = null;
            this.pictureBoxCoin16.Location = new System.Drawing.Point(419, 363);
            this.pictureBoxCoin16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoin16.Name = "pictureBoxCoin16";
            this.pictureBoxCoin16.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoin16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin16.TabIndex = 32;
            this.pictureBoxCoin16.TabStop = false;
            this.pictureBoxCoin16.Tag = "level1coin";
            // 
            // pictureBoxCoin15
            // 
            this.pictureBoxCoin15.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin15.InitialImage = null;
            this.pictureBoxCoin15.Location = new System.Drawing.Point(381, 363);
            this.pictureBoxCoin15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoin15.Name = "pictureBoxCoin15";
            this.pictureBoxCoin15.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoin15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin15.TabIndex = 31;
            this.pictureBoxCoin15.TabStop = false;
            this.pictureBoxCoin15.Tag = "level1coin";
            // 
            // pictureBoxCoin14
            // 
            this.pictureBoxCoin14.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin14.InitialImage = null;
            this.pictureBoxCoin14.Location = new System.Drawing.Point(347, 363);
            this.pictureBoxCoin14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoin14.Name = "pictureBoxCoin14";
            this.pictureBoxCoin14.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoin14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin14.TabIndex = 30;
            this.pictureBoxCoin14.TabStop = false;
            this.pictureBoxCoin14.Tag = "level1coin";
            // 
            // pictureBoxCoin13
            // 
            this.pictureBoxCoin13.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin13.InitialImage = null;
            this.pictureBoxCoin13.Location = new System.Drawing.Point(156, 473);
            this.pictureBoxCoin13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoin13.Name = "pictureBoxCoin13";
            this.pictureBoxCoin13.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoin13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin13.TabIndex = 29;
            this.pictureBoxCoin13.TabStop = false;
            this.pictureBoxCoin13.Tag = "level1coin";
            // 
            // pictureBoxCoin12
            // 
            this.pictureBoxCoin12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin12.InitialImage = null;
            this.pictureBoxCoin12.Location = new System.Drawing.Point(119, 473);
            this.pictureBoxCoin12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoin12.Name = "pictureBoxCoin12";
            this.pictureBoxCoin12.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoin12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin12.TabIndex = 28;
            this.pictureBoxCoin12.TabStop = false;
            this.pictureBoxCoin12.Tag = "level1coin";
            // 
            // pictureBoxCoin11
            // 
            this.pictureBoxCoin11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxCoin11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin11.Image")));
            this.pictureBoxCoin11.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin11.InitialImage")));
            this.pictureBoxCoin11.Location = new System.Drawing.Point(84, 473);
            this.pictureBoxCoin11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoin11.Name = "pictureBoxCoin11";
            this.pictureBoxCoin11.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoin11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin11.TabIndex = 27;
            this.pictureBoxCoin11.TabStop = false;
            this.pictureBoxCoin11.Tag = "level1coin";
            // 
            // pictureBoxCoin20
            // 
            this.pictureBoxCoin20.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin20.InitialImage = null;
            this.pictureBoxCoin20.Location = new System.Drawing.Point(448, 252);
            this.pictureBoxCoin20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoin20.Name = "pictureBoxCoin20";
            this.pictureBoxCoin20.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoin20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin20.TabIndex = 26;
            this.pictureBoxCoin20.TabStop = false;
            this.pictureBoxCoin20.Tag = "level1coin";
            // 
            // pictureBoxCoin22
            // 
            this.pictureBoxCoin22.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin22.InitialImage = null;
            this.pictureBoxCoin22.Location = new System.Drawing.Point(519, 252);
            this.pictureBoxCoin22.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoin22.Name = "pictureBoxCoin22";
            this.pictureBoxCoin22.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoin22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin22.TabIndex = 25;
            this.pictureBoxCoin22.TabStop = false;
            this.pictureBoxCoin22.Tag = "level1coin";
            // 
            // pictureBoxCoin21
            // 
            this.pictureBoxCoin21.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin21.InitialImage = null;
            this.pictureBoxCoin21.Location = new System.Drawing.Point(480, 252);
            this.pictureBoxCoin21.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoin21.Name = "pictureBoxCoin21";
            this.pictureBoxCoin21.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoin21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin21.TabIndex = 24;
            this.pictureBoxCoin21.TabStop = false;
            this.pictureBoxCoin21.Tag = "level1coin";
            // 
            // pictureBoxCoin30
            // 
            this.pictureBoxCoin30.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin30.InitialImage = null;
            this.pictureBoxCoin30.Location = new System.Drawing.Point(757, 100);
            this.pictureBoxCoin30.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoin30.Name = "pictureBoxCoin30";
            this.pictureBoxCoin30.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoin30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin30.TabIndex = 19;
            this.pictureBoxCoin30.TabStop = false;
            this.pictureBoxCoin30.Tag = "level1coin";
            // 
            // pictureBoxCoin33
            // 
            this.pictureBoxCoin33.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin33.InitialImage = null;
            this.pictureBoxCoin33.Location = new System.Drawing.Point(865, 100);
            this.pictureBoxCoin33.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoin33.Name = "pictureBoxCoin33";
            this.pictureBoxCoin33.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoin33.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin33.TabIndex = 18;
            this.pictureBoxCoin33.TabStop = false;
            this.pictureBoxCoin33.Tag = "level1coin";
            // 
            // pictureBoxCoin32
            // 
            this.pictureBoxCoin32.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin32.InitialImage = null;
            this.pictureBoxCoin32.Location = new System.Drawing.Point(828, 100);
            this.pictureBoxCoin32.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoin32.Name = "pictureBoxCoin32";
            this.pictureBoxCoin32.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoin32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin32.TabIndex = 17;
            this.pictureBoxCoin32.TabStop = false;
            this.pictureBoxCoin32.Tag = "level1coin";
            // 
            // pictureBoxCoin31
            // 
            this.pictureBoxCoin31.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin31.InitialImage = null;
            this.pictureBoxCoin31.Location = new System.Drawing.Point(793, 100);
            this.pictureBoxCoin31.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoin31.Name = "pictureBoxCoin31";
            this.pictureBoxCoin31.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoin31.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin31.TabIndex = 16;
            this.pictureBoxCoin31.TabStop = false;
            this.pictureBoxCoin31.Tag = "level1coin";
            // 
            // pictureBoxCoin2
            // 
            this.pictureBoxCoin2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin2.InitialImage = null;
            this.pictureBoxCoin2.Location = new System.Drawing.Point(123, 174);
            this.pictureBoxCoin2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoin2.Name = "pictureBoxCoin2";
            this.pictureBoxCoin2.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin2.TabIndex = 15;
            this.pictureBoxCoin2.TabStop = false;
            this.pictureBoxCoin2.Tag = "level1coin";
            // 
            // pictureBoxCoin1
            // 
            this.pictureBoxCoin1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin1.InitialImage = null;
            this.pictureBoxCoin1.Location = new System.Drawing.Point(93, 174);
            this.pictureBoxCoin1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoin1.Name = "pictureBoxCoin1";
            this.pictureBoxCoin1.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin1.TabIndex = 14;
            this.pictureBoxCoin1.TabStop = false;
            this.pictureBoxCoin1.Tag = "level1coin";
            // 
            // pictureBoxCoin4
            // 
            this.pictureBoxCoin4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin4.InitialImage = null;
            this.pictureBoxCoin4.Location = new System.Drawing.Point(195, 174);
            this.pictureBoxCoin4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoin4.Name = "pictureBoxCoin4";
            this.pictureBoxCoin4.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoin4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin4.TabIndex = 13;
            this.pictureBoxCoin4.TabStop = false;
            this.pictureBoxCoin4.Tag = "level1coin";
            // 
            // pictureBoxCoin3
            // 
            this.pictureBoxCoin3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoin3.InitialImage = null;
            this.pictureBoxCoin3.Location = new System.Drawing.Point(159, 174);
            this.pictureBoxCoin3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoin3.Name = "pictureBoxCoin3";
            this.pictureBoxCoin3.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin3.TabIndex = 12;
            this.pictureBoxCoin3.TabStop = false;
            this.pictureBoxCoin3.Tag = "level1coin";
            // 
            // pictureBoxPlayer
            // 
            this.pictureBoxPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxPlayer.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPlayer.Image")));
            this.pictureBoxPlayer.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxPlayer.InitialImage")));
            this.pictureBoxPlayer.Location = new System.Drawing.Point(0, 450);
            this.pictureBoxPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxPlayer.Name = "pictureBoxPlayer";
            this.pictureBoxPlayer.Size = new System.Drawing.Size(56, 50);
            this.pictureBoxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlayer.TabIndex = 6;
            this.pictureBoxPlayer.TabStop = false;
            // 
            // level2platform1_1
            // 
            this.level2platform1_1.BackColor = System.Drawing.Color.Transparent;
            this.level2platform1_1.Image = ((System.Drawing.Image)(resources.GetObject("level2platform1_1.Image")));
            this.level2platform1_1.InitialImage = ((System.Drawing.Image)(resources.GetObject("level2platform1_1.InitialImage")));
            this.level2platform1_1.Location = new System.Drawing.Point(28, 117);
            this.level2platform1_1.Margin = new System.Windows.Forms.Padding(0);
            this.level2platform1_1.Name = "level2platform1_1";
            this.level2platform1_1.Size = new System.Drawing.Size(31, 30);
            this.level2platform1_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.level2platform1_1.TabIndex = 109;
            this.level2platform1_1.TabStop = false;
            this.level2platform1_1.Tag = "level2platform";
            // 
            // level2platform1_2
            // 
            this.level2platform1_2.BackColor = System.Drawing.Color.Transparent;
            this.level2platform1_2.Image = ((System.Drawing.Image)(resources.GetObject("level2platform1_2.Image")));
            this.level2platform1_2.InitialImage = ((System.Drawing.Image)(resources.GetObject("level2platform1_2.InitialImage")));
            this.level2platform1_2.Location = new System.Drawing.Point(59, 117);
            this.level2platform1_2.Margin = new System.Windows.Forms.Padding(0);
            this.level2platform1_2.Name = "level2platform1_2";
            this.level2platform1_2.Size = new System.Drawing.Size(31, 30);
            this.level2platform1_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.level2platform1_2.TabIndex = 110;
            this.level2platform1_2.TabStop = false;
            this.level2platform1_2.Tag = "level2platform";
            // 
            // level2platform1_4
            // 
            this.level2platform1_4.BackColor = System.Drawing.Color.Transparent;
            this.level2platform1_4.Image = ((System.Drawing.Image)(resources.GetObject("level2platform1_4.Image")));
            this.level2platform1_4.InitialImage = ((System.Drawing.Image)(resources.GetObject("level2platform1_4.InitialImage")));
            this.level2platform1_4.Location = new System.Drawing.Point(118, 117);
            this.level2platform1_4.Margin = new System.Windows.Forms.Padding(0);
            this.level2platform1_4.Name = "level2platform1_4";
            this.level2platform1_4.Size = new System.Drawing.Size(31, 30);
            this.level2platform1_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.level2platform1_4.TabIndex = 112;
            this.level2platform1_4.TabStop = false;
            this.level2platform1_4.Tag = "level2platform";
            // 
            // level2platform1_3
            // 
            this.level2platform1_3.BackColor = System.Drawing.Color.Transparent;
            this.level2platform1_3.Image = ((System.Drawing.Image)(resources.GetObject("level2platform1_3.Image")));
            this.level2platform1_3.InitialImage = ((System.Drawing.Image)(resources.GetObject("level2platform1_3.InitialImage")));
            this.level2platform1_3.Location = new System.Drawing.Point(88, 117);
            this.level2platform1_3.Margin = new System.Windows.Forms.Padding(0);
            this.level2platform1_3.Name = "level2platform1_3";
            this.level2platform1_3.Size = new System.Drawing.Size(31, 30);
            this.level2platform1_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.level2platform1_3.TabIndex = 111;
            this.level2platform1_3.TabStop = false;
            this.level2platform1_3.Tag = "level2platform";
            // 
            // level2platform1_5
            // 
            this.level2platform1_5.BackColor = System.Drawing.Color.Transparent;
            this.level2platform1_5.Image = ((System.Drawing.Image)(resources.GetObject("level2platform1_5.Image")));
            this.level2platform1_5.InitialImage = ((System.Drawing.Image)(resources.GetObject("level2platform1_5.InitialImage")));
            this.level2platform1_5.Location = new System.Drawing.Point(148, 117);
            this.level2platform1_5.Margin = new System.Windows.Forms.Padding(0);
            this.level2platform1_5.Name = "level2platform1_5";
            this.level2platform1_5.Size = new System.Drawing.Size(31, 30);
            this.level2platform1_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.level2platform1_5.TabIndex = 113;
            this.level2platform1_5.TabStop = false;
            this.level2platform1_5.Tag = "level2platform";
            // 
            // level2platform2_5
            // 
            this.level2platform2_5.BackColor = System.Drawing.Color.Transparent;
            this.level2platform2_5.Image = ((System.Drawing.Image)(resources.GetObject("level2platform2_5.Image")));
            this.level2platform2_5.InitialImage = ((System.Drawing.Image)(resources.GetObject("level2platform2_5.InitialImage")));
            this.level2platform2_5.Location = new System.Drawing.Point(328, 274);
            this.level2platform2_5.Margin = new System.Windows.Forms.Padding(0);
            this.level2platform2_5.Name = "level2platform2_5";
            this.level2platform2_5.Size = new System.Drawing.Size(31, 30);
            this.level2platform2_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.level2platform2_5.TabIndex = 118;
            this.level2platform2_5.TabStop = false;
            this.level2platform2_5.Tag = "level2platform";
            // 
            // level2platform2_4
            // 
            this.level2platform2_4.BackColor = System.Drawing.Color.Transparent;
            this.level2platform2_4.Image = ((System.Drawing.Image)(resources.GetObject("level2platform2_4.Image")));
            this.level2platform2_4.InitialImage = ((System.Drawing.Image)(resources.GetObject("level2platform2_4.InitialImage")));
            this.level2platform2_4.Location = new System.Drawing.Point(298, 274);
            this.level2platform2_4.Margin = new System.Windows.Forms.Padding(0);
            this.level2platform2_4.Name = "level2platform2_4";
            this.level2platform2_4.Size = new System.Drawing.Size(31, 30);
            this.level2platform2_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.level2platform2_4.TabIndex = 117;
            this.level2platform2_4.TabStop = false;
            this.level2platform2_4.Tag = "level2platform";
            // 
            // level2platform2_3
            // 
            this.level2platform2_3.BackColor = System.Drawing.Color.Transparent;
            this.level2platform2_3.Image = ((System.Drawing.Image)(resources.GetObject("level2platform2_3.Image")));
            this.level2platform2_3.InitialImage = ((System.Drawing.Image)(resources.GetObject("level2platform2_3.InitialImage")));
            this.level2platform2_3.Location = new System.Drawing.Point(268, 274);
            this.level2platform2_3.Margin = new System.Windows.Forms.Padding(0);
            this.level2platform2_3.Name = "level2platform2_3";
            this.level2platform2_3.Size = new System.Drawing.Size(31, 30);
            this.level2platform2_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.level2platform2_3.TabIndex = 116;
            this.level2platform2_3.TabStop = false;
            this.level2platform2_3.Tag = "level2platform";
            // 
            // level2platform2_2
            // 
            this.level2platform2_2.BackColor = System.Drawing.Color.Transparent;
            this.level2platform2_2.Image = ((System.Drawing.Image)(resources.GetObject("level2platform2_2.Image")));
            this.level2platform2_2.InitialImage = ((System.Drawing.Image)(resources.GetObject("level2platform2_2.InitialImage")));
            this.level2platform2_2.Location = new System.Drawing.Point(239, 274);
            this.level2platform2_2.Margin = new System.Windows.Forms.Padding(0);
            this.level2platform2_2.Name = "level2platform2_2";
            this.level2platform2_2.Size = new System.Drawing.Size(31, 30);
            this.level2platform2_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.level2platform2_2.TabIndex = 115;
            this.level2platform2_2.TabStop = false;
            this.level2platform2_2.Tag = "level2platform";
            // 
            // level2platform2_1
            // 
            this.level2platform2_1.BackColor = System.Drawing.Color.Transparent;
            this.level2platform2_1.Image = ((System.Drawing.Image)(resources.GetObject("level2platform2_1.Image")));
            this.level2platform2_1.InitialImage = ((System.Drawing.Image)(resources.GetObject("level2platform2_1.InitialImage")));
            this.level2platform2_1.Location = new System.Drawing.Point(208, 274);
            this.level2platform2_1.Margin = new System.Windows.Forms.Padding(0);
            this.level2platform2_1.Name = "level2platform2_1";
            this.level2platform2_1.Size = new System.Drawing.Size(31, 30);
            this.level2platform2_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.level2platform2_1.TabIndex = 114;
            this.level2platform2_1.TabStop = false;
            this.level2platform2_1.Tag = "level2platform";
            // 
            // level2platform3_5
            // 
            this.level2platform3_5.BackColor = System.Drawing.Color.Transparent;
            this.level2platform3_5.Image = ((System.Drawing.Image)(resources.GetObject("level2platform3_5.Image")));
            this.level2platform3_5.InitialImage = ((System.Drawing.Image)(resources.GetObject("level2platform3_5.InitialImage")));
            this.level2platform3_5.Location = new System.Drawing.Point(449, 76);
            this.level2platform3_5.Margin = new System.Windows.Forms.Padding(0);
            this.level2platform3_5.Name = "level2platform3_5";
            this.level2platform3_5.Size = new System.Drawing.Size(31, 30);
            this.level2platform3_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.level2platform3_5.TabIndex = 123;
            this.level2platform3_5.TabStop = false;
            this.level2platform3_5.Tag = "level2platform";
            // 
            // level2platform3_4
            // 
            this.level2platform3_4.BackColor = System.Drawing.Color.Transparent;
            this.level2platform3_4.Image = ((System.Drawing.Image)(resources.GetObject("level2platform3_4.Image")));
            this.level2platform3_4.InitialImage = ((System.Drawing.Image)(resources.GetObject("level2platform3_4.InitialImage")));
            this.level2platform3_4.Location = new System.Drawing.Point(419, 76);
            this.level2platform3_4.Margin = new System.Windows.Forms.Padding(0);
            this.level2platform3_4.Name = "level2platform3_4";
            this.level2platform3_4.Size = new System.Drawing.Size(31, 30);
            this.level2platform3_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.level2platform3_4.TabIndex = 122;
            this.level2platform3_4.TabStop = false;
            this.level2platform3_4.Tag = "level2platform";
            // 
            // level2platform3_3
            // 
            this.level2platform3_3.BackColor = System.Drawing.Color.Transparent;
            this.level2platform3_3.Image = ((System.Drawing.Image)(resources.GetObject("level2platform3_3.Image")));
            this.level2platform3_3.InitialImage = ((System.Drawing.Image)(resources.GetObject("level2platform3_3.InitialImage")));
            this.level2platform3_3.Location = new System.Drawing.Point(389, 76);
            this.level2platform3_3.Margin = new System.Windows.Forms.Padding(0);
            this.level2platform3_3.Name = "level2platform3_3";
            this.level2platform3_3.Size = new System.Drawing.Size(31, 30);
            this.level2platform3_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.level2platform3_3.TabIndex = 121;
            this.level2platform3_3.TabStop = false;
            this.level2platform3_3.Tag = "level2platform";
            // 
            // level2platform3_2
            // 
            this.level2platform3_2.BackColor = System.Drawing.Color.Transparent;
            this.level2platform3_2.Image = ((System.Drawing.Image)(resources.GetObject("level2platform3_2.Image")));
            this.level2platform3_2.InitialImage = ((System.Drawing.Image)(resources.GetObject("level2platform3_2.InitialImage")));
            this.level2platform3_2.Location = new System.Drawing.Point(360, 76);
            this.level2platform3_2.Margin = new System.Windows.Forms.Padding(0);
            this.level2platform3_2.Name = "level2platform3_2";
            this.level2platform3_2.Size = new System.Drawing.Size(31, 30);
            this.level2platform3_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.level2platform3_2.TabIndex = 120;
            this.level2platform3_2.TabStop = false;
            this.level2platform3_2.Tag = "level2platform";
            // 
            // level2platform3_1
            // 
            this.level2platform3_1.BackColor = System.Drawing.Color.Transparent;
            this.level2platform3_1.Image = ((System.Drawing.Image)(resources.GetObject("level2platform3_1.Image")));
            this.level2platform3_1.InitialImage = ((System.Drawing.Image)(resources.GetObject("level2platform3_1.InitialImage")));
            this.level2platform3_1.Location = new System.Drawing.Point(329, 76);
            this.level2platform3_1.Margin = new System.Windows.Forms.Padding(0);
            this.level2platform3_1.Name = "level2platform3_1";
            this.level2platform3_1.Size = new System.Drawing.Size(31, 30);
            this.level2platform3_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.level2platform3_1.TabIndex = 119;
            this.level2platform3_1.TabStop = false;
            this.level2platform3_1.Tag = "level2platform";
            // 
            // level2platform4_5
            // 
            this.level2platform4_5.BackColor = System.Drawing.Color.Transparent;
            this.level2platform4_5.Image = ((System.Drawing.Image)(resources.GetObject("level2platform4_5.Image")));
            this.level2platform4_5.InitialImage = ((System.Drawing.Image)(resources.GetObject("level2platform4_5.InitialImage")));
            this.level2platform4_5.Location = new System.Drawing.Point(770, 119);
            this.level2platform4_5.Margin = new System.Windows.Forms.Padding(0);
            this.level2platform4_5.Name = "level2platform4_5";
            this.level2platform4_5.Size = new System.Drawing.Size(31, 30);
            this.level2platform4_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.level2platform4_5.TabIndex = 128;
            this.level2platform4_5.TabStop = false;
            this.level2platform4_5.Tag = "level2platform";
            // 
            // level2platform4_4
            // 
            this.level2platform4_4.BackColor = System.Drawing.Color.Transparent;
            this.level2platform4_4.Image = ((System.Drawing.Image)(resources.GetObject("level2platform4_4.Image")));
            this.level2platform4_4.InitialImage = ((System.Drawing.Image)(resources.GetObject("level2platform4_4.InitialImage")));
            this.level2platform4_4.Location = new System.Drawing.Point(740, 119);
            this.level2platform4_4.Margin = new System.Windows.Forms.Padding(0);
            this.level2platform4_4.Name = "level2platform4_4";
            this.level2platform4_4.Size = new System.Drawing.Size(31, 30);
            this.level2platform4_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.level2platform4_4.TabIndex = 127;
            this.level2platform4_4.TabStop = false;
            this.level2platform4_4.Tag = "level2platform";
            // 
            // level2platform4_3
            // 
            this.level2platform4_3.BackColor = System.Drawing.Color.Transparent;
            this.level2platform4_3.Image = ((System.Drawing.Image)(resources.GetObject("level2platform4_3.Image")));
            this.level2platform4_3.InitialImage = ((System.Drawing.Image)(resources.GetObject("level2platform4_3.InitialImage")));
            this.level2platform4_3.Location = new System.Drawing.Point(710, 119);
            this.level2platform4_3.Margin = new System.Windows.Forms.Padding(0);
            this.level2platform4_3.Name = "level2platform4_3";
            this.level2platform4_3.Size = new System.Drawing.Size(31, 30);
            this.level2platform4_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.level2platform4_3.TabIndex = 126;
            this.level2platform4_3.TabStop = false;
            this.level2platform4_3.Tag = "level2platform";
            // 
            // level2platform4_2
            // 
            this.level2platform4_2.BackColor = System.Drawing.Color.Transparent;
            this.level2platform4_2.Image = ((System.Drawing.Image)(resources.GetObject("level2platform4_2.Image")));
            this.level2platform4_2.InitialImage = ((System.Drawing.Image)(resources.GetObject("level2platform4_2.InitialImage")));
            this.level2platform4_2.Location = new System.Drawing.Point(681, 119);
            this.level2platform4_2.Margin = new System.Windows.Forms.Padding(0);
            this.level2platform4_2.Name = "level2platform4_2";
            this.level2platform4_2.Size = new System.Drawing.Size(31, 30);
            this.level2platform4_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.level2platform4_2.TabIndex = 125;
            this.level2platform4_2.TabStop = false;
            this.level2platform4_2.Tag = "level2platform";
            // 
            // level2platform4_1
            // 
            this.level2platform4_1.BackColor = System.Drawing.Color.Transparent;
            this.level2platform4_1.Image = ((System.Drawing.Image)(resources.GetObject("level2platform4_1.Image")));
            this.level2platform4_1.InitialImage = ((System.Drawing.Image)(resources.GetObject("level2platform4_1.InitialImage")));
            this.level2platform4_1.Location = new System.Drawing.Point(650, 119);
            this.level2platform4_1.Margin = new System.Windows.Forms.Padding(0);
            this.level2platform4_1.Name = "level2platform4_1";
            this.level2platform4_1.Size = new System.Drawing.Size(31, 30);
            this.level2platform4_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.level2platform4_1.TabIndex = 124;
            this.level2platform4_1.TabStop = false;
            this.level2platform4_1.Tag = "level2platform";
            // 
            // level2platform6_3
            // 
            this.level2platform6_3.BackColor = System.Drawing.Color.Transparent;
            this.level2platform6_3.Image = ((System.Drawing.Image)(resources.GetObject("level2platform6_3.Image")));
            this.level2platform6_3.InitialImage = ((System.Drawing.Image)(resources.GetObject("level2platform6_3.InitialImage")));
            this.level2platform6_3.Location = new System.Drawing.Point(58, 405);
            this.level2platform6_3.Margin = new System.Windows.Forms.Padding(0);
            this.level2platform6_3.Name = "level2platform6_3";
            this.level2platform6_3.Size = new System.Drawing.Size(31, 30);
            this.level2platform6_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.level2platform6_3.TabIndex = 131;
            this.level2platform6_3.TabStop = false;
            this.level2platform6_3.Tag = "level2platform";
            // 
            // level2platform6_2
            // 
            this.level2platform6_2.BackColor = System.Drawing.Color.Transparent;
            this.level2platform6_2.Image = ((System.Drawing.Image)(resources.GetObject("level2platform6_2.Image")));
            this.level2platform6_2.InitialImage = ((System.Drawing.Image)(resources.GetObject("level2platform6_2.InitialImage")));
            this.level2platform6_2.Location = new System.Drawing.Point(28, 405);
            this.level2platform6_2.Margin = new System.Windows.Forms.Padding(0);
            this.level2platform6_2.Name = "level2platform6_2";
            this.level2platform6_2.Size = new System.Drawing.Size(31, 30);
            this.level2platform6_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.level2platform6_2.TabIndex = 130;
            this.level2platform6_2.TabStop = false;
            this.level2platform6_2.Tag = "level2platform";
            // 
            // level2platform6_1
            // 
            this.level2platform6_1.BackColor = System.Drawing.Color.Transparent;
            this.level2platform6_1.Image = ((System.Drawing.Image)(resources.GetObject("level2platform6_1.Image")));
            this.level2platform6_1.InitialImage = ((System.Drawing.Image)(resources.GetObject("level2platform6_1.InitialImage")));
            this.level2platform6_1.Location = new System.Drawing.Point(-2, 405);
            this.level2platform6_1.Margin = new System.Windows.Forms.Padding(0);
            this.level2platform6_1.Name = "level2platform6_1";
            this.level2platform6_1.Size = new System.Drawing.Size(31, 30);
            this.level2platform6_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.level2platform6_1.TabIndex = 129;
            this.level2platform6_1.TabStop = false;
            this.level2platform6_1.Tag = "level2platform";
            // 
            // level2platform5_3
            // 
            this.level2platform5_3.BackColor = System.Drawing.Color.Transparent;
            this.level2platform5_3.Image = ((System.Drawing.Image)(resources.GetObject("level2platform5_3.Image")));
            this.level2platform5_3.InitialImage = ((System.Drawing.Image)(resources.GetObject("level2platform5_3.InitialImage")));
            this.level2platform5_3.Location = new System.Drawing.Point(709, 470);
            this.level2platform5_3.Margin = new System.Windows.Forms.Padding(0);
            this.level2platform5_3.Name = "level2platform5_3";
            this.level2platform5_3.Size = new System.Drawing.Size(31, 30);
            this.level2platform5_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.level2platform5_3.TabIndex = 134;
            this.level2platform5_3.TabStop = false;
            this.level2platform5_3.Tag = "level2platform";
            // 
            // level2platform5_2
            // 
            this.level2platform5_2.BackColor = System.Drawing.Color.Transparent;
            this.level2platform5_2.Image = ((System.Drawing.Image)(resources.GetObject("level2platform5_2.Image")));
            this.level2platform5_2.InitialImage = ((System.Drawing.Image)(resources.GetObject("level2platform5_2.InitialImage")));
            this.level2platform5_2.Location = new System.Drawing.Point(679, 470);
            this.level2platform5_2.Margin = new System.Windows.Forms.Padding(0);
            this.level2platform5_2.Name = "level2platform5_2";
            this.level2platform5_2.Size = new System.Drawing.Size(31, 30);
            this.level2platform5_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.level2platform5_2.TabIndex = 133;
            this.level2platform5_2.TabStop = false;
            this.level2platform5_2.Tag = "level2platform";
            // 
            // level2platform5_1
            // 
            this.level2platform5_1.BackColor = System.Drawing.Color.Transparent;
            this.level2platform5_1.Image = ((System.Drawing.Image)(resources.GetObject("level2platform5_1.Image")));
            this.level2platform5_1.InitialImage = ((System.Drawing.Image)(resources.GetObject("level2platform5_1.InitialImage")));
            this.level2platform5_1.Location = new System.Drawing.Point(649, 470);
            this.level2platform5_1.Margin = new System.Windows.Forms.Padding(0);
            this.level2platform5_1.Name = "level2platform5_1";
            this.level2platform5_1.Size = new System.Drawing.Size(31, 30);
            this.level2platform5_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.level2platform5_1.TabIndex = 132;
            this.level2platform5_1.TabStop = false;
            this.level2platform5_1.Tag = "level2platform";
            // 
            // horizontalMovingPlatform2
            // 
            this.horizontalMovingPlatform2.BackColor = System.Drawing.Color.Transparent;
            this.horizontalMovingPlatform2.Image = ((System.Drawing.Image)(resources.GetObject("horizontalMovingPlatform2.Image")));
            this.horizontalMovingPlatform2.Location = new System.Drawing.Point(153, 491);
            this.horizontalMovingPlatform2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.horizontalMovingPlatform2.Name = "horizontalMovingPlatform2";
            this.horizontalMovingPlatform2.Size = new System.Drawing.Size(149, 21);
            this.horizontalMovingPlatform2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.horizontalMovingPlatform2.TabIndex = 135;
            this.horizontalMovingPlatform2.TabStop = false;
            this.horizontalMovingPlatform2.Tag = "level2platform";
            // 
            // level2platform7_5
            // 
            this.level2platform7_5.BackColor = System.Drawing.Color.Transparent;
            this.level2platform7_5.Image = ((System.Drawing.Image)(resources.GetObject("level2platform7_5.Image")));
            this.level2platform7_5.InitialImage = ((System.Drawing.Image)(resources.GetObject("level2platform7_5.InitialImage")));
            this.level2platform7_5.Location = new System.Drawing.Point(496, 421);
            this.level2platform7_5.Margin = new System.Windows.Forms.Padding(0);
            this.level2platform7_5.Name = "level2platform7_5";
            this.level2platform7_5.Size = new System.Drawing.Size(31, 30);
            this.level2platform7_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.level2platform7_5.TabIndex = 140;
            this.level2platform7_5.TabStop = false;
            this.level2platform7_5.Tag = "level2platform";
            // 
            // level2platform7_4
            // 
            this.level2platform7_4.BackColor = System.Drawing.Color.Transparent;
            this.level2platform7_4.Image = ((System.Drawing.Image)(resources.GetObject("level2platform7_4.Image")));
            this.level2platform7_4.InitialImage = ((System.Drawing.Image)(resources.GetObject("level2platform7_4.InitialImage")));
            this.level2platform7_4.Location = new System.Drawing.Point(466, 421);
            this.level2platform7_4.Margin = new System.Windows.Forms.Padding(0);
            this.level2platform7_4.Name = "level2platform7_4";
            this.level2platform7_4.Size = new System.Drawing.Size(31, 30);
            this.level2platform7_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.level2platform7_4.TabIndex = 139;
            this.level2platform7_4.TabStop = false;
            this.level2platform7_4.Tag = "level2platform";
            // 
            // level2platform7_3
            // 
            this.level2platform7_3.BackColor = System.Drawing.Color.Transparent;
            this.level2platform7_3.Image = ((System.Drawing.Image)(resources.GetObject("level2platform7_3.Image")));
            this.level2platform7_3.InitialImage = ((System.Drawing.Image)(resources.GetObject("level2platform7_3.InitialImage")));
            this.level2platform7_3.Location = new System.Drawing.Point(436, 421);
            this.level2platform7_3.Margin = new System.Windows.Forms.Padding(0);
            this.level2platform7_3.Name = "level2platform7_3";
            this.level2platform7_3.Size = new System.Drawing.Size(31, 30);
            this.level2platform7_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.level2platform7_3.TabIndex = 138;
            this.level2platform7_3.TabStop = false;
            this.level2platform7_3.Tag = "level2platform";
            // 
            // level2platform7_2
            // 
            this.level2platform7_2.BackColor = System.Drawing.Color.Transparent;
            this.level2platform7_2.Image = ((System.Drawing.Image)(resources.GetObject("level2platform7_2.Image")));
            this.level2platform7_2.InitialImage = ((System.Drawing.Image)(resources.GetObject("level2platform7_2.InitialImage")));
            this.level2platform7_2.Location = new System.Drawing.Point(407, 421);
            this.level2platform7_2.Margin = new System.Windows.Forms.Padding(0);
            this.level2platform7_2.Name = "level2platform7_2";
            this.level2platform7_2.Size = new System.Drawing.Size(31, 30);
            this.level2platform7_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.level2platform7_2.TabIndex = 137;
            this.level2platform7_2.TabStop = false;
            this.level2platform7_2.Tag = "level2platform";
            // 
            // level2platform7_1
            // 
            this.level2platform7_1.BackColor = System.Drawing.Color.Transparent;
            this.level2platform7_1.Image = ((System.Drawing.Image)(resources.GetObject("level2platform7_1.Image")));
            this.level2platform7_1.InitialImage = ((System.Drawing.Image)(resources.GetObject("level2platform7_1.InitialImage")));
            this.level2platform7_1.Location = new System.Drawing.Point(376, 421);
            this.level2platform7_1.Margin = new System.Windows.Forms.Padding(0);
            this.level2platform7_1.Name = "level2platform7_1";
            this.level2platform7_1.Size = new System.Drawing.Size(31, 30);
            this.level2platform7_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.level2platform7_1.TabIndex = 136;
            this.level2platform7_1.TabStop = false;
            this.level2platform7_1.Tag = "level2platform";
            // 
            // verticalMovingPlatform2
            // 
            this.verticalMovingPlatform2.BackColor = System.Drawing.Color.Transparent;
            this.verticalMovingPlatform2.Image = ((System.Drawing.Image)(resources.GetObject("verticalMovingPlatform2.Image")));
            this.verticalMovingPlatform2.Location = new System.Drawing.Point(502, 205);
            this.verticalMovingPlatform2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.verticalMovingPlatform2.Name = "verticalMovingPlatform2";
            this.verticalMovingPlatform2.Size = new System.Drawing.Size(113, 22);
            this.verticalMovingPlatform2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.verticalMovingPlatform2.TabIndex = 141;
            this.verticalMovingPlatform2.TabStop = false;
            this.verticalMovingPlatform2.Tag = "level2platform";
            // 
            // level2platform2_6
            // 
            this.level2platform2_6.BackColor = System.Drawing.Color.Transparent;
            this.level2platform2_6.Image = ((System.Drawing.Image)(resources.GetObject("level2platform2_6.Image")));
            this.level2platform2_6.InitialImage = ((System.Drawing.Image)(resources.GetObject("level2platform2_6.InitialImage")));
            this.level2platform2_6.Location = new System.Drawing.Point(359, 274);
            this.level2platform2_6.Margin = new System.Windows.Forms.Padding(0);
            this.level2platform2_6.Name = "level2platform2_6";
            this.level2platform2_6.Size = new System.Drawing.Size(31, 30);
            this.level2platform2_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.level2platform2_6.TabIndex = 142;
            this.level2platform2_6.TabStop = false;
            this.level2platform2_6.Tag = "level2platform";
            // 
            // level2platform2_7
            // 
            this.level2platform2_7.BackColor = System.Drawing.Color.Transparent;
            this.level2platform2_7.Image = ((System.Drawing.Image)(resources.GetObject("level2platform2_7.Image")));
            this.level2platform2_7.InitialImage = ((System.Drawing.Image)(resources.GetObject("level2platform2_7.InitialImage")));
            this.level2platform2_7.Location = new System.Drawing.Point(388, 274);
            this.level2platform2_7.Margin = new System.Windows.Forms.Padding(0);
            this.level2platform2_7.Name = "level2platform2_7";
            this.level2platform2_7.Size = new System.Drawing.Size(31, 30);
            this.level2platform2_7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.level2platform2_7.TabIndex = 143;
            this.level2platform2_7.TabStop = false;
            this.level2platform2_7.Tag = "level2platform";
            // 
            // flower2
            // 
            this.flower2.BackColor = System.Drawing.Color.Transparent;
            this.flower2.Image = ((System.Drawing.Image)(resources.GetObject("flower2.Image")));
            this.flower2.Location = new System.Drawing.Point(371, 180);
            this.flower2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flower2.Name = "flower2";
            this.flower2.Size = new System.Drawing.Size(29, 27);
            this.flower2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.flower2.TabIndex = 145;
            this.flower2.TabStop = false;
            this.flower2.Tag = "level2flower";
            this.flower2.Visible = false;
            // 
            // brickBoxFlower2
            // 
            this.brickBoxFlower2.BackColor = System.Drawing.Color.Transparent;
            this.brickBoxFlower2.Image = ((System.Drawing.Image)(resources.GetObject("brickBoxFlower2.Image")));
            this.brickBoxFlower2.Location = new System.Drawing.Point(370, 178);
            this.brickBoxFlower2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brickBoxFlower2.Name = "brickBoxFlower2";
            this.brickBoxFlower2.Size = new System.Drawing.Size(31, 32);
            this.brickBoxFlower2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.brickBoxFlower2.TabIndex = 144;
            this.brickBoxFlower2.TabStop = false;
            this.brickBoxFlower2.Tag = "level2brick";
            // 
            // shield2
            // 
            this.shield2.BackColor = System.Drawing.Color.Transparent;
            this.shield2.Image = ((System.Drawing.Image)(resources.GetObject("shield2.Image")));
            this.shield2.Location = new System.Drawing.Point(85, 278);
            this.shield2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shield2.Name = "shield2";
            this.shield2.Size = new System.Drawing.Size(29, 27);
            this.shield2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.shield2.TabIndex = 147;
            this.shield2.TabStop = false;
            this.shield2.Tag = "level2shield";
            this.shield2.Visible = false;
            // 
            // brickBoxShield2
            // 
            this.brickBoxShield2.BackColor = System.Drawing.Color.Transparent;
            this.brickBoxShield2.Image = ((System.Drawing.Image)(resources.GetObject("brickBoxShield2.Image")));
            this.brickBoxShield2.Location = new System.Drawing.Point(84, 276);
            this.brickBoxShield2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brickBoxShield2.Name = "brickBoxShield2";
            this.brickBoxShield2.Size = new System.Drawing.Size(31, 30);
            this.brickBoxShield2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.brickBoxShield2.TabIndex = 146;
            this.brickBoxShield2.TabStop = false;
            this.brickBoxShield2.Tag = "level2brick";
            // 
            // floor3
            // 
            this.floor3.BackColor = System.Drawing.Color.Transparent;
            this.floor3.Location = new System.Drawing.Point(822, 450);
            this.floor3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.floor3.Name = "floor3";
            this.floor3.Size = new System.Drawing.Size(157, 25);
            this.floor3.TabIndex = 148;
            this.floor3.TabStop = false;
            this.floor3.Tag = "level2platform";
            // 
            // peach
            // 
            this.peach.BackColor = System.Drawing.Color.Transparent;
            this.peach.Image = ((System.Drawing.Image)(resources.GetObject("peach.Image")));
            this.peach.InitialImage = ((System.Drawing.Image)(resources.GetObject("peach.InitialImage")));
            this.peach.Location = new System.Drawing.Point(930, 382);
            this.peach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.peach.Name = "peach";
            this.peach.Size = new System.Drawing.Size(49, 69);
            this.peach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.peach.TabIndex = 149;
            this.peach.TabStop = false;
            this.peach.Tag = "level2Peach";
            // 
            // lava
            // 
            this.lava.BackColor = System.Drawing.Color.Transparent;
            this.lava.Image = ((System.Drawing.Image)(resources.GetObject("lava.Image")));
            this.lava.InitialImage = ((System.Drawing.Image)(resources.GetObject("lava.InitialImage")));
            this.lava.Location = new System.Drawing.Point(-3, 511);
            this.lava.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lava.Name = "lava";
            this.lava.Size = new System.Drawing.Size(997, 153);
            this.lava.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lava.TabIndex = 153;
            this.lava.TabStop = false;
            this.lava.Tag = "level2lava";
            // 
            // pictureBoxEnemyFire2
            // 
            this.pictureBoxEnemyFire2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEnemyFire2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEnemyFire2.Image")));
            this.pictureBoxEnemyFire2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxEnemyFire2.InitialImage")));
            this.pictureBoxEnemyFire2.Location = new System.Drawing.Point(308, 450);
            this.pictureBoxEnemyFire2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxEnemyFire2.Name = "pictureBoxEnemyFire2";
            this.pictureBoxEnemyFire2.Size = new System.Drawing.Size(39, 43);
            this.pictureBoxEnemyFire2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEnemyFire2.TabIndex = 154;
            this.pictureBoxEnemyFire2.TabStop = false;
            this.pictureBoxEnemyFire2.Tag = "level2EnemyFire";
            // 
            // pictureBoxEnemyFire1
            // 
            this.pictureBoxEnemyFire1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEnemyFire1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEnemyFire1.Image")));
            this.pictureBoxEnemyFire1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxEnemyFire1.InitialImage")));
            this.pictureBoxEnemyFire1.Location = new System.Drawing.Point(757, 464);
            this.pictureBoxEnemyFire1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxEnemyFire1.Name = "pictureBoxEnemyFire1";
            this.pictureBoxEnemyFire1.Size = new System.Drawing.Size(39, 43);
            this.pictureBoxEnemyFire1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEnemyFire1.TabIndex = 155;
            this.pictureBoxEnemyFire1.TabStop = false;
            this.pictureBoxEnemyFire1.Tag = "level2EnemyFire";
            // 
            // fireStopper1_U
            // 
            this.fireStopper1_U.BackColor = System.Drawing.Color.Transparent;
            this.fireStopper1_U.InitialImage = null;
            this.fireStopper1_U.Location = new System.Drawing.Point(0, 31);
            this.fireStopper1_U.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fireStopper1_U.Name = "fireStopper1_U";
            this.fireStopper1_U.Size = new System.Drawing.Size(979, 15);
            this.fireStopper1_U.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fireStopper1_U.TabIndex = 156;
            this.fireStopper1_U.TabStop = false;
            this.fireStopper1_U.Tag = "fireStopper";
            this.fireStopper1_U.Visible = false;
            // 
            // fireStopper2_U
            // 
            this.fireStopper2_U.BackColor = System.Drawing.Color.Transparent;
            this.fireStopper2_U.InitialImage = null;
            this.fireStopper2_U.Location = new System.Drawing.Point(11, 212);
            this.fireStopper2_U.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fireStopper2_U.Name = "fireStopper2_U";
            this.fireStopper2_U.Size = new System.Drawing.Size(979, 15);
            this.fireStopper2_U.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fireStopper2_U.TabIndex = 157;
            this.fireStopper2_U.TabStop = false;
            this.fireStopper2_U.Tag = "fireStopper";
            this.fireStopper2_U.Visible = false;
            // 
            // pictureBoxCoinTwo1
            // 
            this.pictureBoxCoinTwo1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoinTwo1.InitialImage = null;
            this.pictureBoxCoinTwo1.Location = new System.Drawing.Point(557, 319);
            this.pictureBoxCoinTwo1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoinTwo1.Name = "pictureBoxCoinTwo1";
            this.pictureBoxCoinTwo1.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoinTwo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoinTwo1.TabIndex = 163;
            this.pictureBoxCoinTwo1.TabStop = false;
            this.pictureBoxCoinTwo1.Tag = "level2coin";
            // 
            // pictureBoxCoinTwo2
            // 
            this.pictureBoxCoinTwo2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoinTwo2.InitialImage = null;
            this.pictureBoxCoinTwo2.Location = new System.Drawing.Point(572, 286);
            this.pictureBoxCoinTwo2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoinTwo2.Name = "pictureBoxCoinTwo2";
            this.pictureBoxCoinTwo2.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoinTwo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoinTwo2.TabIndex = 162;
            this.pictureBoxCoinTwo2.TabStop = false;
            this.pictureBoxCoinTwo2.Tag = "level2coin";
            // 
            // pictureBoxCoinTwo3
            // 
            this.pictureBoxCoinTwo3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoinTwo3.InitialImage = null;
            this.pictureBoxCoinTwo3.Location = new System.Drawing.Point(585, 252);
            this.pictureBoxCoinTwo3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoinTwo3.Name = "pictureBoxCoinTwo3";
            this.pictureBoxCoinTwo3.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoinTwo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoinTwo3.TabIndex = 161;
            this.pictureBoxCoinTwo3.TabStop = false;
            this.pictureBoxCoinTwo3.Tag = "level2coin";
            // 
            // pictureBoxCoinTwo4
            // 
            this.pictureBoxCoinTwo4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoinTwo4.InitialImage = null;
            this.pictureBoxCoinTwo4.Location = new System.Drawing.Point(572, 219);
            this.pictureBoxCoinTwo4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoinTwo4.Name = "pictureBoxCoinTwo4";
            this.pictureBoxCoinTwo4.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoinTwo4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoinTwo4.TabIndex = 160;
            this.pictureBoxCoinTwo4.TabStop = false;
            this.pictureBoxCoinTwo4.Tag = "level2coin";
            // 
            // pictureBoxCoinTwo5
            // 
            this.pictureBoxCoinTwo5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoinTwo5.InitialImage = null;
            this.pictureBoxCoinTwo5.Location = new System.Drawing.Point(557, 191);
            this.pictureBoxCoinTwo5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoinTwo5.Name = "pictureBoxCoinTwo5";
            this.pictureBoxCoinTwo5.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoinTwo5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoinTwo5.TabIndex = 159;
            this.pictureBoxCoinTwo5.TabStop = false;
            this.pictureBoxCoinTwo5.Tag = "level2coin";
            // 
            // pictureBoxCoinTwo6
            // 
            this.pictureBoxCoinTwo6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoinTwo6.InitialImage = null;
            this.pictureBoxCoinTwo6.Location = new System.Drawing.Point(532, 162);
            this.pictureBoxCoinTwo6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoinTwo6.Name = "pictureBoxCoinTwo6";
            this.pictureBoxCoinTwo6.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoinTwo6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoinTwo6.TabIndex = 158;
            this.pictureBoxCoinTwo6.TabStop = false;
            this.pictureBoxCoinTwo6.Tag = "level2coin";
            // 
            // pictureBoxCoinTwo7
            // 
            this.pictureBoxCoinTwo7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoinTwo7.InitialImage = null;
            this.pictureBoxCoinTwo7.Location = new System.Drawing.Point(665, 89);
            this.pictureBoxCoinTwo7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoinTwo7.Name = "pictureBoxCoinTwo7";
            this.pictureBoxCoinTwo7.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoinTwo7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoinTwo7.TabIndex = 164;
            this.pictureBoxCoinTwo7.TabStop = false;
            this.pictureBoxCoinTwo7.Tag = "level2coin";
            // 
            // pictureBoxCoinTwo8
            // 
            this.pictureBoxCoinTwo8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoinTwo8.InitialImage = null;
            this.pictureBoxCoinTwo8.Location = new System.Drawing.Point(693, 89);
            this.pictureBoxCoinTwo8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoinTwo8.Name = "pictureBoxCoinTwo8";
            this.pictureBoxCoinTwo8.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoinTwo8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoinTwo8.TabIndex = 165;
            this.pictureBoxCoinTwo8.TabStop = false;
            this.pictureBoxCoinTwo8.Tag = "level2coin";
            // 
            // pictureBoxCoinTwo10
            // 
            this.pictureBoxCoinTwo10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoinTwo10.InitialImage = null;
            this.pictureBoxCoinTwo10.Location = new System.Drawing.Point(751, 89);
            this.pictureBoxCoinTwo10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoinTwo10.Name = "pictureBoxCoinTwo10";
            this.pictureBoxCoinTwo10.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoinTwo10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoinTwo10.TabIndex = 167;
            this.pictureBoxCoinTwo10.TabStop = false;
            this.pictureBoxCoinTwo10.Tag = "level2coin";
            // 
            // pictureBoxCoinTwo9
            // 
            this.pictureBoxCoinTwo9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoinTwo9.InitialImage = null;
            this.pictureBoxCoinTwo9.Location = new System.Drawing.Point(723, 89);
            this.pictureBoxCoinTwo9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoinTwo9.Name = "pictureBoxCoinTwo9";
            this.pictureBoxCoinTwo9.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoinTwo9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoinTwo9.TabIndex = 166;
            this.pictureBoxCoinTwo9.TabStop = false;
            this.pictureBoxCoinTwo9.Tag = "level2coin";
            // 
            // pictureBoxCoinTwo13
            // 
            this.pictureBoxCoinTwo13.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoinTwo13.InitialImage = null;
            this.pictureBoxCoinTwo13.Location = new System.Drawing.Point(723, 444);
            this.pictureBoxCoinTwo13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoinTwo13.Name = "pictureBoxCoinTwo13";
            this.pictureBoxCoinTwo13.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoinTwo13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoinTwo13.TabIndex = 171;
            this.pictureBoxCoinTwo13.TabStop = false;
            this.pictureBoxCoinTwo13.Tag = "level2coin";
            // 
            // pictureBoxCoinTwo12
            // 
            this.pictureBoxCoinTwo12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoinTwo12.InitialImage = null;
            this.pictureBoxCoinTwo12.Location = new System.Drawing.Point(695, 444);
            this.pictureBoxCoinTwo12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoinTwo12.Name = "pictureBoxCoinTwo12";
            this.pictureBoxCoinTwo12.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoinTwo12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoinTwo12.TabIndex = 170;
            this.pictureBoxCoinTwo12.TabStop = false;
            this.pictureBoxCoinTwo12.Tag = "level2coin";
            // 
            // pictureBoxCoinTwo11
            // 
            this.pictureBoxCoinTwo11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoinTwo11.InitialImage = null;
            this.pictureBoxCoinTwo11.Location = new System.Drawing.Point(665, 444);
            this.pictureBoxCoinTwo11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoinTwo11.Name = "pictureBoxCoinTwo11";
            this.pictureBoxCoinTwo11.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoinTwo11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoinTwo11.TabIndex = 169;
            this.pictureBoxCoinTwo11.TabStop = false;
            this.pictureBoxCoinTwo11.Tag = "level2coin";
            // 
            // pictureBoxCoinTwo14
            // 
            this.pictureBoxCoinTwo14.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoinTwo14.InitialImage = null;
            this.pictureBoxCoinTwo14.Location = new System.Drawing.Point(69, 382);
            this.pictureBoxCoinTwo14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoinTwo14.Name = "pictureBoxCoinTwo14";
            this.pictureBoxCoinTwo14.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoinTwo14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoinTwo14.TabIndex = 174;
            this.pictureBoxCoinTwo14.TabStop = false;
            this.pictureBoxCoinTwo14.Tag = "level2coin";
            // 
            // pictureBoxCoinTwo15
            // 
            this.pictureBoxCoinTwo15.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoinTwo15.InitialImage = null;
            this.pictureBoxCoinTwo15.Location = new System.Drawing.Point(41, 382);
            this.pictureBoxCoinTwo15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoinTwo15.Name = "pictureBoxCoinTwo15";
            this.pictureBoxCoinTwo15.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoinTwo15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoinTwo15.TabIndex = 173;
            this.pictureBoxCoinTwo15.TabStop = false;
            this.pictureBoxCoinTwo15.Tag = "level2coin";
            // 
            // pictureBoxCoinTwo16
            // 
            this.pictureBoxCoinTwo16.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoinTwo16.InitialImage = null;
            this.pictureBoxCoinTwo16.Location = new System.Drawing.Point(11, 382);
            this.pictureBoxCoinTwo16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoinTwo16.Name = "pictureBoxCoinTwo16";
            this.pictureBoxCoinTwo16.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoinTwo16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoinTwo16.TabIndex = 172;
            this.pictureBoxCoinTwo16.TabStop = false;
            this.pictureBoxCoinTwo16.Tag = "level2coin";
            // 
            // pictureBoxCoinTwo29
            // 
            this.pictureBoxCoinTwo29.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoinTwo29.InitialImage = null;
            this.pictureBoxCoinTwo29.Location = new System.Drawing.Point(357, 242);
            this.pictureBoxCoinTwo29.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoinTwo29.Name = "pictureBoxCoinTwo29";
            this.pictureBoxCoinTwo29.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoinTwo29.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoinTwo29.TabIndex = 178;
            this.pictureBoxCoinTwo29.TabStop = false;
            this.pictureBoxCoinTwo29.Tag = "level2coin";
            // 
            // pictureBoxCoinTwo28
            // 
            this.pictureBoxCoinTwo28.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoinTwo28.InitialImage = null;
            this.pictureBoxCoinTwo28.Location = new System.Drawing.Point(329, 242);
            this.pictureBoxCoinTwo28.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoinTwo28.Name = "pictureBoxCoinTwo28";
            this.pictureBoxCoinTwo28.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoinTwo28.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoinTwo28.TabIndex = 177;
            this.pictureBoxCoinTwo28.TabStop = false;
            this.pictureBoxCoinTwo28.Tag = "level2coin";
            // 
            // pictureBoxCoinTwo27
            // 
            this.pictureBoxCoinTwo27.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoinTwo27.InitialImage = null;
            this.pictureBoxCoinTwo27.Location = new System.Drawing.Point(299, 242);
            this.pictureBoxCoinTwo27.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoinTwo27.Name = "pictureBoxCoinTwo27";
            this.pictureBoxCoinTwo27.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoinTwo27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoinTwo27.TabIndex = 176;
            this.pictureBoxCoinTwo27.TabStop = false;
            this.pictureBoxCoinTwo27.Tag = "level2coin";
            // 
            // pictureBoxCoinTwo26
            // 
            this.pictureBoxCoinTwo26.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoinTwo26.InitialImage = null;
            this.pictureBoxCoinTwo26.Location = new System.Drawing.Point(271, 242);
            this.pictureBoxCoinTwo26.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoinTwo26.Name = "pictureBoxCoinTwo26";
            this.pictureBoxCoinTwo26.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoinTwo26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoinTwo26.TabIndex = 175;
            this.pictureBoxCoinTwo26.TabStop = false;
            this.pictureBoxCoinTwo26.Tag = "level2coin";
            // 
            // pictureBoxCoinTwo20
            // 
            this.pictureBoxCoinTwo20.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoinTwo20.InitialImage = null;
            this.pictureBoxCoinTwo20.Location = new System.Drawing.Point(156, 86);
            this.pictureBoxCoinTwo20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoinTwo20.Name = "pictureBoxCoinTwo20";
            this.pictureBoxCoinTwo20.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoinTwo20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoinTwo20.TabIndex = 182;
            this.pictureBoxCoinTwo20.TabStop = false;
            this.pictureBoxCoinTwo20.Tag = "level2coin";
            // 
            // pictureBoxCoinTwo19
            // 
            this.pictureBoxCoinTwo19.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoinTwo19.InitialImage = null;
            this.pictureBoxCoinTwo19.Location = new System.Drawing.Point(128, 86);
            this.pictureBoxCoinTwo19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoinTwo19.Name = "pictureBoxCoinTwo19";
            this.pictureBoxCoinTwo19.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoinTwo19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoinTwo19.TabIndex = 181;
            this.pictureBoxCoinTwo19.TabStop = false;
            this.pictureBoxCoinTwo19.Tag = "level2coin";
            // 
            // pictureBoxCoinTwo18
            // 
            this.pictureBoxCoinTwo18.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoinTwo18.InitialImage = null;
            this.pictureBoxCoinTwo18.Location = new System.Drawing.Point(98, 86);
            this.pictureBoxCoinTwo18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoinTwo18.Name = "pictureBoxCoinTwo18";
            this.pictureBoxCoinTwo18.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoinTwo18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoinTwo18.TabIndex = 180;
            this.pictureBoxCoinTwo18.TabStop = false;
            this.pictureBoxCoinTwo18.Tag = "level2coin";
            // 
            // pictureBoxCoinTwo17
            // 
            this.pictureBoxCoinTwo17.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoinTwo17.InitialImage = null;
            this.pictureBoxCoinTwo17.Location = new System.Drawing.Point(70, 86);
            this.pictureBoxCoinTwo17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoinTwo17.Name = "pictureBoxCoinTwo17";
            this.pictureBoxCoinTwo17.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoinTwo17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoinTwo17.TabIndex = 179;
            this.pictureBoxCoinTwo17.TabStop = false;
            this.pictureBoxCoinTwo17.Tag = "level2coin";
            // 
            // pictureBoxCoinTwo25
            // 
            this.pictureBoxCoinTwo25.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoinTwo25.InitialImage = null;
            this.pictureBoxCoinTwo25.Location = new System.Drawing.Point(238, 242);
            this.pictureBoxCoinTwo25.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoinTwo25.Name = "pictureBoxCoinTwo25";
            this.pictureBoxCoinTwo25.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoinTwo25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoinTwo25.TabIndex = 183;
            this.pictureBoxCoinTwo25.TabStop = false;
            this.pictureBoxCoinTwo25.Tag = "level2coin";
            // 
            // pictureBoxCoinTwo24
            // 
            this.pictureBoxCoinTwo24.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoinTwo24.InitialImage = null;
            this.pictureBoxCoinTwo24.Location = new System.Drawing.Point(430, 54);
            this.pictureBoxCoinTwo24.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoinTwo24.Name = "pictureBoxCoinTwo24";
            this.pictureBoxCoinTwo24.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoinTwo24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoinTwo24.TabIndex = 187;
            this.pictureBoxCoinTwo24.TabStop = false;
            this.pictureBoxCoinTwo24.Tag = "level2coin";
            // 
            // pictureBoxCoinTwo23
            // 
            this.pictureBoxCoinTwo23.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoinTwo23.InitialImage = null;
            this.pictureBoxCoinTwo23.Location = new System.Drawing.Point(402, 54);
            this.pictureBoxCoinTwo23.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoinTwo23.Name = "pictureBoxCoinTwo23";
            this.pictureBoxCoinTwo23.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoinTwo23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoinTwo23.TabIndex = 186;
            this.pictureBoxCoinTwo23.TabStop = false;
            this.pictureBoxCoinTwo23.Tag = "level2coin";
            // 
            // pictureBoxCoinTwo22
            // 
            this.pictureBoxCoinTwo22.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoinTwo22.InitialImage = null;
            this.pictureBoxCoinTwo22.Location = new System.Drawing.Point(372, 54);
            this.pictureBoxCoinTwo22.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoinTwo22.Name = "pictureBoxCoinTwo22";
            this.pictureBoxCoinTwo22.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoinTwo22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoinTwo22.TabIndex = 185;
            this.pictureBoxCoinTwo22.TabStop = false;
            this.pictureBoxCoinTwo22.Tag = "level2coin";
            // 
            // pictureBoxCoinTwo21
            // 
            this.pictureBoxCoinTwo21.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoinTwo21.InitialImage = null;
            this.pictureBoxCoinTwo21.Location = new System.Drawing.Point(344, 54);
            this.pictureBoxCoinTwo21.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoinTwo21.Name = "pictureBoxCoinTwo21";
            this.pictureBoxCoinTwo21.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoinTwo21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoinTwo21.TabIndex = 184;
            this.pictureBoxCoinTwo21.TabStop = false;
            this.pictureBoxCoinTwo21.Tag = "level2coin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 117);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 188;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "level2platform";
            // 
            // pipefinal2
            // 
            this.pipefinal2.BackColor = System.Drawing.Color.Transparent;
            this.pipefinal2.Image = ((System.Drawing.Image)(resources.GetObject("pipefinal2.Image")));
            this.pipefinal2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pipefinal2.InitialImage")));
            this.pipefinal2.Location = new System.Drawing.Point(-37, 56);
            this.pipefinal2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pipefinal2.Name = "pipefinal2";
            this.pipefinal2.Size = new System.Drawing.Size(65, 60);
            this.pipefinal2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipefinal2.TabIndex = 189;
            this.pipefinal2.TabStop = false;
            this.pipefinal2.Tag = "level2FinalPipe";
            // 
            // brickBoxMushroom
            // 
            this.brickBoxMushroom.BackColor = System.Drawing.Color.Transparent;
            this.brickBoxMushroom.Image = ((System.Drawing.Image)(resources.GetObject("brickBoxMushroom.Image")));
            this.brickBoxMushroom.Location = new System.Drawing.Point(543, 27);
            this.brickBoxMushroom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brickBoxMushroom.Name = "brickBoxMushroom";
            this.brickBoxMushroom.Size = new System.Drawing.Size(31, 32);
            this.brickBoxMushroom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.brickBoxMushroom.TabIndex = 190;
            this.brickBoxMushroom.TabStop = false;
            this.brickBoxMushroom.Tag = "level1brick";
            // 
            // mushroom1
            // 
            this.mushroom1.BackColor = System.Drawing.Color.Transparent;
            this.mushroom1.Image = global::RP3_Platformer.Properties.Resources.mush6;
            this.mushroom1.Location = new System.Drawing.Point(544, 29);
            this.mushroom1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mushroom1.Name = "mushroom1";
            this.mushroom1.Size = new System.Drawing.Size(29, 27);
            this.mushroom1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mushroom1.TabIndex = 191;
            this.mushroom1.TabStop = false;
            this.mushroom1.Tag = "level1mushroom";
            this.mushroom1.Visible = false;
            // 
            // cooldownlabel
            // 
            this.cooldownlabel.BackColor = System.Drawing.Color.Transparent;
            this.cooldownlabel.Image = ((System.Drawing.Image)(resources.GetObject("cooldownlabel.Image")));
            this.cooldownlabel.Location = new System.Drawing.Point(18, 41);
            this.cooldownlabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cooldownlabel.Name = "cooldownlabel";
            this.cooldownlabel.Size = new System.Drawing.Size(29, 27);
            this.cooldownlabel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cooldownlabel.TabIndex = 192;
            this.cooldownlabel.TabStop = false;
            this.cooldownlabel.Tag = "cooldownlabel";
            this.cooldownlabel.Visible = false;
            // 
            // mushroomlabel
            // 
            this.mushroomlabel.BackColor = System.Drawing.Color.Transparent;
            this.mushroomlabel.Image = ((System.Drawing.Image)(resources.GetObject("mushroomlabel.Image")));
            this.mushroomlabel.Location = new System.Drawing.Point(61, 41);
            this.mushroomlabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mushroomlabel.Name = "mushroomlabel";
            this.mushroomlabel.Size = new System.Drawing.Size(29, 27);
            this.mushroomlabel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mushroomlabel.TabIndex = 193;
            this.mushroomlabel.TabStop = false;
            this.mushroomlabel.Tag = "mushroomlabel";
            this.mushroomlabel.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(-10, -74);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(13, 586);
            this.pictureBox2.TabIndex = 194;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "level1platform";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(986, -128);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(13, 434);
            this.pictureBox3.TabIndex = 195;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "level1platform";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Location = new System.Drawing.Point(898, 291);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(81, 13);
            this.pictureBox4.TabIndex = 196;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "level1platform";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Location = new System.Drawing.Point(-10, -7);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(13, 586);
            this.pictureBox5.TabIndex = 197;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "level2platform";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Location = new System.Drawing.Point(978, -93);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(16, 442);
            this.pictureBox6.TabIndex = 198;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "level2platform";
            // 
            // pictureBoxCoinTwo106
            // 
            this.pictureBoxCoinTwo106.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoinTwo106.InitialImage = null;
            this.pictureBoxCoinTwo106.Location = new System.Drawing.Point(460, 54);
            this.pictureBoxCoinTwo106.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCoinTwo106.Name = "pictureBoxCoinTwo106";
            this.pictureBoxCoinTwo106.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxCoinTwo106.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoinTwo106.TabIndex = 199;
            this.pictureBoxCoinTwo106.TabStop = false;
            this.pictureBoxCoinTwo106.Tag = "level2coin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(981, 553);
            this.Controls.Add(this.pictureBoxCoinTwo106);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.mushroomlabel);
            this.Controls.Add(this.cooldownlabel);
            this.Controls.Add(this.mushroom1);
            this.Controls.Add(this.brickBoxMushroom);
            this.Controls.Add(this.pipefinal2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxCoinTwo24);
            this.Controls.Add(this.pictureBoxCoinTwo23);
            this.Controls.Add(this.pictureBoxCoinTwo22);
            this.Controls.Add(this.pictureBoxCoinTwo21);
            this.Controls.Add(this.pictureBoxCoinTwo25);
            this.Controls.Add(this.pictureBoxCoinTwo20);
            this.Controls.Add(this.pictureBoxCoinTwo19);
            this.Controls.Add(this.pictureBoxCoinTwo18);
            this.Controls.Add(this.pictureBoxCoinTwo17);
            this.Controls.Add(this.pictureBoxCoinTwo29);
            this.Controls.Add(this.pictureBoxCoinTwo28);
            this.Controls.Add(this.pictureBoxCoinTwo27);
            this.Controls.Add(this.pictureBoxCoinTwo26);
            this.Controls.Add(this.pictureBoxCoinTwo14);
            this.Controls.Add(this.pictureBoxCoinTwo15);
            this.Controls.Add(this.pictureBoxCoinTwo16);
            this.Controls.Add(this.pictureBoxCoinTwo13);
            this.Controls.Add(this.pictureBoxCoinTwo12);
            this.Controls.Add(this.pictureBoxCoinTwo11);
            this.Controls.Add(this.pictureBoxCoinTwo10);
            this.Controls.Add(this.pictureBoxCoinTwo9);
            this.Controls.Add(this.pictureBoxCoinTwo8);
            this.Controls.Add(this.pictureBoxCoinTwo7);
            this.Controls.Add(this.pictureBoxCoinTwo1);
            this.Controls.Add(this.pictureBoxCoinTwo2);
            this.Controls.Add(this.pictureBoxCoinTwo3);
            this.Controls.Add(this.pictureBoxCoinTwo4);
            this.Controls.Add(this.pictureBoxCoinTwo5);
            this.Controls.Add(this.pictureBoxCoinTwo6);
            this.Controls.Add(this.lava);
            this.Controls.Add(this.fireStopper2_U);
            this.Controls.Add(this.fireStopper1_U);
            this.Controls.Add(this.pictureBoxEnemyFire1);
            this.Controls.Add(this.pictureBoxEnemyFire2);
            this.Controls.Add(this.peach);
            this.Controls.Add(this.floor3);
            this.Controls.Add(this.shield2);
            this.Controls.Add(this.brickBoxShield2);
            this.Controls.Add(this.flower2);
            this.Controls.Add(this.brickBoxFlower2);
            this.Controls.Add(this.level2platform2_7);
            this.Controls.Add(this.level2platform2_6);
            this.Controls.Add(this.verticalMovingPlatform2);
            this.Controls.Add(this.level2platform7_5);
            this.Controls.Add(this.level2platform7_4);
            this.Controls.Add(this.level2platform7_3);
            this.Controls.Add(this.level2platform7_2);
            this.Controls.Add(this.level2platform7_1);
            this.Controls.Add(this.horizontalMovingPlatform2);
            this.Controls.Add(this.level2platform5_3);
            this.Controls.Add(this.level2platform5_2);
            this.Controls.Add(this.level2platform5_1);
            this.Controls.Add(this.level2platform6_3);
            this.Controls.Add(this.level2platform6_2);
            this.Controls.Add(this.level2platform6_1);
            this.Controls.Add(this.level2platform4_5);
            this.Controls.Add(this.level2platform4_4);
            this.Controls.Add(this.level2platform4_3);
            this.Controls.Add(this.level2platform4_2);
            this.Controls.Add(this.level2platform4_1);
            this.Controls.Add(this.level2platform3_5);
            this.Controls.Add(this.level2platform3_4);
            this.Controls.Add(this.level2platform3_3);
            this.Controls.Add(this.level2platform3_2);
            this.Controls.Add(this.level2platform3_1);
            this.Controls.Add(this.level2platform2_5);
            this.Controls.Add(this.level2platform2_4);
            this.Controls.Add(this.level2platform2_3);
            this.Controls.Add(this.level2platform2_2);
            this.Controls.Add(this.level2platform2_1);
            this.Controls.Add(this.level2platform1_5);
            this.Controls.Add(this.level2platform1_4);
            this.Controls.Add(this.level2platform1_3);
            this.Controls.Add(this.level2platform1_2);
            this.Controls.Add(this.level2platform1_1);
            this.Controls.Add(this.realShield1);
            this.Controls.Add(this.shield1);
            this.Controls.Add(this.flower1);
            this.Controls.Add(this.plantStopper1_D);
            this.Controls.Add(this.plantStopper1_U);
            this.Controls.Add(this.plantStopper2_D);
            this.Controls.Add(this.plantStopper2_U);
            this.Controls.Add(this.pipePlant2);
            this.Controls.Add(this.ceilingChecker);
            this.Controls.Add(this.rightChecker);
            this.Controls.Add(this.leftChecker);
            this.Controls.Add(this.brickBoxShield);
            this.Controls.Add(this.pictureBoxEnemyPlant2);
            this.Controls.Add(this.pipePlant1);
            this.Controls.Add(this.pictureBoxEnemyPlant1);
            this.Controls.Add(this.pictureBoxCoin36);
            this.Controls.Add(this.pictureBoxCoin35);
            this.Controls.Add(this.pictureBoxCoin34);
            this.Controls.Add(this.pipeFinal);
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
            this.Controls.Add(this.brickBoxFlower);
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
            this.Controls.Add(this.pictureBoxPlayer);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelLives);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Dario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.realShield1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shield1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flower1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantStopper1_D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantStopper1_U)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantStopper2_D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantStopper2_U)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipePlant2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceilingChecker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightChecker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftChecker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brickBoxShield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemyPlant2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipePlant1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemyPlant1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform4_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform4_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform4_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform3_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform3_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform3_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform5_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform5_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform5_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform5_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform5_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundChecker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalMovingPlatform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brickBoxFlower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalMovingPlatform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform1_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform1_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform1_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform1_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform1_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform2_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform2_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform2_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform2_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform2_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform3_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform3_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform3_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform3_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform3_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform4_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform4_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform4_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform4_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform4_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform6_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform6_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform6_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform5_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform5_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform5_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalMovingPlatform2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform7_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform7_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform7_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform7_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform7_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalMovingPlatform2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform2_6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2platform2_7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flower2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brickBoxFlower2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shield2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brickBoxShield2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lava)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemyFire2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemyFire1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStopper1_U)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStopper2_U)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipefinal2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brickBoxMushroom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mushroom1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cooldownlabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mushroomlabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoinTwo106)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLives;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.PictureBox pictureBoxPlayer;
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
        private System.Windows.Forms.PictureBox brickBoxFlower;
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
        private System.Windows.Forms.PictureBox pipeFinal;
        private System.Windows.Forms.PictureBox pictureBoxCoin36;
        private System.Windows.Forms.PictureBox pictureBoxCoin35;
        private System.Windows.Forms.PictureBox pictureBoxCoin34;
        private System.Windows.Forms.PictureBox pictureBoxEnemyPlant1;
        private System.Windows.Forms.PictureBox pipePlant1;
        private System.Windows.Forms.PictureBox pictureBoxEnemyPlant2;
        private System.Windows.Forms.PictureBox brickBoxShield;
        private System.Windows.Forms.PictureBox leftChecker;
        private System.Windows.Forms.PictureBox rightChecker;
        private System.Windows.Forms.PictureBox ceilingChecker;
        private System.Windows.Forms.PictureBox pipePlant2;
        private System.Windows.Forms.PictureBox plantStopper2_U;
        private System.Windows.Forms.PictureBox plantStopper2_D;
        private System.Windows.Forms.PictureBox plantStopper1_U;
        private System.Windows.Forms.PictureBox plantStopper1_D;
        private System.Windows.Forms.PictureBox flower1;
        private System.Windows.Forms.PictureBox shield1;
        private System.Windows.Forms.PictureBox realShield1;
        private System.Windows.Forms.PictureBox level2platform1_1;
        private System.Windows.Forms.PictureBox level2platform1_2;
        private System.Windows.Forms.PictureBox level2platform1_4;
        private System.Windows.Forms.PictureBox level2platform1_3;
        private System.Windows.Forms.PictureBox level2platform1_5;
        private System.Windows.Forms.PictureBox level2platform2_5;
        private System.Windows.Forms.PictureBox level2platform2_4;
        private System.Windows.Forms.PictureBox level2platform2_3;
        private System.Windows.Forms.PictureBox level2platform2_2;
        private System.Windows.Forms.PictureBox level2platform2_1;
        private System.Windows.Forms.PictureBox level2platform3_5;
        private System.Windows.Forms.PictureBox level2platform3_4;
        private System.Windows.Forms.PictureBox level2platform3_3;
        private System.Windows.Forms.PictureBox level2platform3_2;
        private System.Windows.Forms.PictureBox level2platform3_1;
        private System.Windows.Forms.PictureBox level2platform4_5;
        private System.Windows.Forms.PictureBox level2platform4_4;
        private System.Windows.Forms.PictureBox level2platform4_3;
        private System.Windows.Forms.PictureBox level2platform4_2;
        private System.Windows.Forms.PictureBox level2platform4_1;
        private System.Windows.Forms.PictureBox level2platform6_3;
        private System.Windows.Forms.PictureBox level2platform6_2;
        private System.Windows.Forms.PictureBox level2platform6_1;
        private System.Windows.Forms.PictureBox level2platform5_3;
        private System.Windows.Forms.PictureBox level2platform5_2;
        private System.Windows.Forms.PictureBox level2platform5_1;
        private System.Windows.Forms.PictureBox horizontalMovingPlatform2;
        private System.Windows.Forms.PictureBox level2platform7_5;
        private System.Windows.Forms.PictureBox level2platform7_4;
        private System.Windows.Forms.PictureBox level2platform7_3;
        private System.Windows.Forms.PictureBox level2platform7_2;
        private System.Windows.Forms.PictureBox level2platform7_1;
        private System.Windows.Forms.PictureBox verticalMovingPlatform2;
        private System.Windows.Forms.PictureBox level2platform2_6;
        private System.Windows.Forms.PictureBox level2platform2_7;
        private System.Windows.Forms.PictureBox flower2;
        private System.Windows.Forms.PictureBox brickBoxFlower2;
        private System.Windows.Forms.PictureBox shield2;
        private System.Windows.Forms.PictureBox brickBoxShield2;
        private System.Windows.Forms.PictureBox floor3;
        private System.Windows.Forms.PictureBox peach;
        private System.Windows.Forms.PictureBox lava;
        private System.Windows.Forms.PictureBox pictureBoxEnemyFire2;
        private System.Windows.Forms.PictureBox pictureBoxEnemyFire1;
        private System.Windows.Forms.PictureBox fireStopper1_U;
        private System.Windows.Forms.PictureBox fireStopper2_U;
        private System.Windows.Forms.PictureBox pictureBoxCoinTwo1;
        private System.Windows.Forms.PictureBox pictureBoxCoinTwo2;
        private System.Windows.Forms.PictureBox pictureBoxCoinTwo3;
        private System.Windows.Forms.PictureBox pictureBoxCoinTwo4;
        private System.Windows.Forms.PictureBox pictureBoxCoinTwo5;
        private System.Windows.Forms.PictureBox pictureBoxCoinTwo6;
        private System.Windows.Forms.PictureBox pictureBoxCoinTwo7;
        private System.Windows.Forms.PictureBox pictureBoxCoinTwo8;
        private System.Windows.Forms.PictureBox pictureBoxCoinTwo10;
        private System.Windows.Forms.PictureBox pictureBoxCoinTwo9;
        private System.Windows.Forms.PictureBox pictureBoxCoinTwo13;
        private System.Windows.Forms.PictureBox pictureBoxCoinTwo12;
        private System.Windows.Forms.PictureBox pictureBoxCoinTwo11;
        private System.Windows.Forms.PictureBox pictureBoxCoinTwo14;
        private System.Windows.Forms.PictureBox pictureBoxCoinTwo15;
        private System.Windows.Forms.PictureBox pictureBoxCoinTwo16;
        private System.Windows.Forms.PictureBox pictureBoxCoinTwo29;
        private System.Windows.Forms.PictureBox pictureBoxCoinTwo28;
        private System.Windows.Forms.PictureBox pictureBoxCoinTwo27;
        private System.Windows.Forms.PictureBox pictureBoxCoinTwo26;
        private System.Windows.Forms.PictureBox pictureBoxCoinTwo20;
        private System.Windows.Forms.PictureBox pictureBoxCoinTwo19;
        private System.Windows.Forms.PictureBox pictureBoxCoinTwo18;
        private System.Windows.Forms.PictureBox pictureBoxCoinTwo17;
        private System.Windows.Forms.PictureBox pictureBoxCoinTwo25;
        private System.Windows.Forms.PictureBox pictureBoxCoinTwo24;
        private System.Windows.Forms.PictureBox pictureBoxCoinTwo23;
        private System.Windows.Forms.PictureBox pictureBoxCoinTwo22;
        private System.Windows.Forms.PictureBox pictureBoxCoinTwo21;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pipefinal2;
        private System.Windows.Forms.PictureBox brickBoxMushroom;
        private System.Windows.Forms.PictureBox mushroom1;
        private System.Windows.Forms.PictureBox cooldownlabel;
        private System.Windows.Forms.PictureBox mushroomlabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBoxCoinTwo106;
    }
}