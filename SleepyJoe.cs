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
        bool left, right;
        string move;


        public SleepyJoe()
        {
            InitializeComponent();

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PnlGame, new object[] { true });

            for (int i = 0; i < 3; i++)

            {
                int x = -20 - (i * 200);
                stair1[i] = new Stairs(x);
            }

        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            for (int i = 0; i < 3; i++)
            {
                //call the Planet class's drawPlanet method to draw the images
                stair1[i].DrawStairs(g);
            }

            biden.DrawBiden(g);





        }

        private void SleepyJoe_KeyDown(object sender, KeyEventArgs e)
        {
            //if left/right key is pressed then set left/right to true
            if (e.KeyData == Keys.Left) { left = true; }
            if (e.KeyData == Keys.Right) { right = true; }


        }

        private void SleepyJoe_KeyUp(object sender, KeyEventArgs e)
        {
            //once key is released set left/right to false
            if (e.KeyData == Keys.Left) { left = false; }
            if (e.KeyData == Keys.Right) { right = false; }

        }

        private void TmrBiden_Tick(object sender, EventArgs e)
        {
            if (right) //if right is pressed
            {
                move = "right";
                biden.MoveBiden(move);

            }

            if (left) // if left arrow key pressed
            {
                move = "left";
                biden.MoveBiden(move);
            }

        }

        private void TmrStairs_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                stair1[i].MoveStairs();

                //when a stair reaches the bottom reposition to the top of the screen
                if (stair1[i].y >= PnlGame.Height)
                {
                    stair1[i].y = 30;
                }

            }
            PnlGame.Invalidate();//makes the paint event fire to redraw the panel

        }
    }
}
