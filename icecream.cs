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
            x = -10;
            y = 0;
            width = 200;
            height = 200;
            //stairImage contains the stair.png image
            iceImage = Properties.Resources.iceream;
            iceRec = new Rectangle(x, y, width, height);
        }

       //methods for icecream

        public void DrawItem(Graphics g)
        {
            iceRec = new Rectangle(x, y, width, height);
            g.DrawImage(iceImage, iceRec);
        }
        public void ItemMove()
        {
            Random random = new Random();
            int lane;

            if (y >= 577)
            {
                y = 0;
                //now randomise lane
                lane = random.Next(1, 4);
                if(lane == 1)
                {
                    x = -10;
                }
                else if(lane == 2)
                {
                    x = 175;
                }
                else
                {
                    x = 400;
                }

            }
            else
            {
                y += 15;
                iceRec.Location = new Point(x, y);
            }
        }
    }

}
