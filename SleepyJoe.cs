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





            //  int i = 1;n
            //while(i < stair1.Length)
            //{
            //  stair1[i].DrawStairs(g);
            //i++;
            //}

        }

        private void TmrStairs_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                stair1[i].MoveStairs();

                //if a planet reaches the bottom of the Game Area reposition it at the top
                if (stair1[i].y >= PnlGame.Height)
                {
                    stair1[i].y = 30;
                }

            }
            PnlGame.Invalidate();//makes the paint event fire to redraw the panel

        }
    }
}
