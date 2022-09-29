using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SleepyJoe
{
    class Icecream
    {
        public int x, y, width, height; // rectangle variables
        public Image iceImage; //variable for stair image

        public Rectangle iceRec; //variable for a rectangle to place the image in


        //Create a constructor (initialises the values of the fields)
        public Icecream ()
        {
            x = 70;
            y = 10;
            width = 200;
            height = 200;
            //stairImage contains the stair.png image
            iceImage = Properties.Resources.iceream;
            iceRec = new Rectangle(x, y, width, height);
        }

       //methods for icecream
       public void DrawIce(Graphics g)
        {
            g.DrawImage(iceImage, iceRec);
        }
    }

}
