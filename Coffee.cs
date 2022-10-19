using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SleepyJoe.Properties
{
    class Coffee
    {
        public int x, y, width, height; // rectangle variables
        public Image cofImage; //variable for Coffee image

        public Rectangle cofRec; //variable for a rectangle to place the image in


        //Create a constructor (initialises the values of the fields)
        public Coffee()
        {
            x = 100;
            y = -100;
            width = 50;
            height = 50;
            //CoffeeImage contains the Coffee.png image
            cofImage = Properties.Resources.cof;

            cofRec = new Rectangle(x, y, width, height);
        }

        //methods for Coffee

        public void DrawItem(Graphics g)
        {
            cofRec = new Rectangle(x, y, width, height);
            g.DrawImage(cofImage, cofRec);
        }
        public void ItemMove()
        {
            Random cofRand = new Random();
            int lane;

            if (y >= 577)
            {
                y = -100;
                //now randomise lane
                lane = cofRand.Next(1, 4);
                if (lane == 1)
                {
                    x = 20;
                }
                else if (lane == 2)
                {
                    x = 205;
                }
                else
                {
                    x = 430;
                }

            }
            else
            {
                y += 15;
                cofRec.Location = new Point(x, y);
            }
        }
        public void PopToTop()
        {
            Random cofRand = new Random();
            int lane;

            y = -100;
            //now randomise lane
            lane = cofRand.Next(1, 4);
            if (lane == 2)
            {
                x = 20;
            }
            else if (lane == 3)
            {
                x = 205;
            }
            else
            {
                x = 430;
            }

        }
    }
}
