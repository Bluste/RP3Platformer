using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RP3_Platformer
{
    internal class Player
    {
        bool jumpingOnce, jumpingTwice, movingLeft, movingRight;

        int jumpingSpeed;
        int force;
        float score = 0;
        int lives = 10;
        int movingSpeed = 5;

        #region Getters and setters
        public bool JumpingOnce
        {
            get { return jumpingOnce; }
            set { jumpingOnce = value; }
        }
        public bool JumpingTwice
        {
            get { return jumpingTwice; }
            set { jumpingTwice = value; }
        }
        public bool MovingLeft
        {
            get { return movingLeft; }
            set { movingLeft = value; }
        }
        public bool MovingRight
        {
            get { return movingRight; }
            set { movingRight = value; }
        }
        public int JumpingSpeed
        {
            get { return jumpingSpeed; }
            set { jumpingSpeed = value; }
        }
        public int Force
        {
            get { return force; }
            set { force = value; }
        }
        public float Score
        {
            get { return score; }
            set { score = value; }
        }
        public int Lives
        {
            get { return lives; }
            set { lives = value; }
        }
        public int MovingSpeed { 
            get { return movingSpeed; }
            set { movingSpeed = value; }
        }
        #endregion

        public Player()
        {
        }

    }
}
