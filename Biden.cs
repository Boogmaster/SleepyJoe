using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepyJoe
{
    class Biden
    {
        // declare fields to use in the class

        public int x, y, width, height;//variables for the rectangle
        public Image biden;//variable for the planet's image

        public Rectangle bidenRec;//variable for a rectangle to place our image in

        //Create a constructor (initialises the values of the fields)
        public Biden()
        {
            x = 125;
            y = 360;
            width = 400;
            height = 400;
            biden = Properties.Resources.biren;
            bidenRec = new Rectangle(x, y, width, height);
        }

       

        //methods
        public void DrawBiden(Graphics g)
        {

            g.DrawImage(biden, bidenRec);
        }
        public void MoveBiden(string move)
        {
            bidenRec.Location = new Point(x, y);

            if (move == "right")
            {
                if (bidenRec.Location.X == 125)
                {
                    //Biden is in the centre lane
                    x = 350;
                    bidenRec.Location = new Point(x, y);

                }
                else if (bidenRec.Location.X == -60)
                { 
                  x = 125;
                  bidenRec.Location = new Point(x, y);
                }
               
            }

            if (move == "left")
            { 
                if (bidenRec.Location.X == 125)
                {
                    x = -60;
                    bidenRec.Location = new Point(x, y);

                }
                else if(bidenRec.Location.X == 350)
                {
                    x = 125;
                    bidenRec.Location = new Point(x, y);
                }

            }

        }

    }
}
