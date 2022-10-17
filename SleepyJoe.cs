using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace SleepyJoe
{
    public partial class SleepyJoe : Form
    {
        Graphics g; //declare a graphics object called g
        Stairs [] stair1 = new Stairs[3]; //create the object, stair
        Biden biden = new Biden();
        Icecream icecream1 = new Icecream(); // create the object icecream
        bool left, right;
        int score, energy;
        string move;

        int itemI = 0;


        public SleepyJoe()
        {
            InitializeComponent();
            //Double buffering to stop the movign items from flickering a lot 
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PnlGame, new object[] { true });

            for (int i = 0; i < 3; i++)

            {
                int x = -20 - (i * 200);
                stair1[i] = new Stairs(x);
            }
            

        }
        //drowsiness code
        private void CheckEnergy()
        {
            if (energy == 0)
            {
                TmrBiden.Enabled = false;
                tmrItems.Enabled = false;
                MessageBox.Show("Game Over You Fell Asleep");

            }
        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            for (int i = 0; i < 3; i++)
            {
                //call bidens class's drawBiden method to draw the images
                stair1[i].DrawStairs(g);
            }

            biden.DrawBiden(g);
            icecream1.DrawItem(g);




        }

        private void SleepyJoe_KeyDown(object sender, KeyEventArgs e)
        {
            //if left/right key is pressed then set left/right to true
            //if (e.KeyData == Keys.Left) { left = true; }
            // (e.KeyData == Keys.Right) { right = true; }
            if(e.KeyData == Keys.Left)
            {
                move = "left";
                biden.MoveBiden(move);
            }
            if(e.KeyData == Keys.Right)
            {
                move = "right";
                biden.MoveBiden(move);
            }


        }

        private void tmrItems_Tick(object sender, EventArgs e)
        {
            icecream1.ItemMove();
            PnlGame.Invalidate();


        }

        private void tmrItemSpawn_Tick(object sender, EventArgs e)
        {
            /*if(itemI == 5)
            {
                //spawn an icecream
                icecream1.DrawItem(g);
                itemI = 0;
            }

            itemI++;*/
        }

        private void SleepyJoe_KeyUp(object sender, KeyEventArgs e)
        {
            //once key is released set left/right to false
            //if (e.KeyData == Keys.Left) { left = false; }
            //if (e.KeyData == Keys.Right) { right = false; }

        }

       


        private void TmrBiden_Tick(object sender, EventArgs e)
        {
            /*if (right) //if right is pressed
            {
                move = "right";
                biden.MoveBiden(move);

            }

            if (left) // if left arrow key pressed
            {
                move = "left";
                biden.MoveBiden(move);
            }*/
            PnlGame.Invalidate();

        }

    }
}
