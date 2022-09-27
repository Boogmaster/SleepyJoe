using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace SleepyJoe
{
    class Stairs
    {
        public int x, y, width, height; // rectangle variables
        public Image stairImage; //variable for stair image

        public Rectangle stairRec; //variable for a rectangle to place the image in
        

        //Create a constructor (initialises the values of the fields)
        public Stairs(int spacing)
        {
            x = -spacing;
            y = 10;
            width = 200;
            height = 200;
            //stairImage contains the stair.png image
            stairImage = Properties.Resources.stair;
            stairRec = new Rectangle(x, y, width, height);
        }

        public void DrawStairs(Graphics g)
        {
            stairRec = new Rectangle(x, y, width, height);
            g.DrawImage(stairImage, stairRec);
        }
        public void MoveStairs()
        {
            y += 5;
            stairRec.Location = new Point(x, y);
        }
    }
}
