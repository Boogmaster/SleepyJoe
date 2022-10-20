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

        int speed = 15;

        //Create a constructor (initialises the values of the fields)
        public Icecream ()
        {
            x = 20;
            y = 0;
            width = 50;
            height = 50;
            //stairImage contains the stair.png image
            iceImage = Properties.Resources.icecrem;
            
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
                    x = 20;
                }
                else if(lane == 2)
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
                y += speed;
                iceRec.Location = new Point(x, y);
            }
        }
        public void PopToTop()
        {
            Random random = new Random();
            int lane;

            y = 0;
            //now randomise lane
            lane = random.Next(1, 4);
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

        public void SpeedIncrease()
        {
            speed += 5;
        }
        public void SpeedReset()
        {
            speed = 15;
        }
    }

}
