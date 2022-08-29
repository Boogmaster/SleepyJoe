using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SleepyJoe
{
    public partial class SleepyJoe : Form
    {
        Graphics g; //declare a graphics object called g
        Stairs [] stair1 = new Stairs[3]; //create the object, stair

        public SleepyJoe()
        {
            InitializeComponent();
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







            //  int i = 1;
            //while(i < stair1.Length)
            //{
            //  stair1[i].DrawStairs(g);
            //i++;
            //}

        }
    }
}
