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
using SleepyJoe.Properties;

namespace SleepyJoe
{
    public partial class SleepyJoe : Form
    {
       
        Graphics g; //declare a graphics object called g
        Stairs [] stair1 = new Stairs[3]; //create the object, stair
        Biden biden = new Biden();
        Icecream icecream1 = new Icecream(); // create the object icecream
        Coffee cofcof = new Coffee();
        int energy = 100;
        string move;

        int itemI = 0;

        int lives = 3;


        public SleepyJoe()
        {
            InitializeComponent();
              MessageBox.Show("Welcome to Sleepy Joe! Use the arrow keys to move left and right to avoid the deadly icecream. If you get hit you'll lose a life. Lose 3 and its game over! \n Dont forget to keep stocking up on that coffee though - if you run out of energy you're done for! Collect coffee to give small boosts to your energy. \n" +
                "Press Start to begin.");
            lblLives.Text = "LIVES: " + lives.ToString();
            lblEnergy.Text = "ENERGY" + energy.ToString();
            tmrItems.Enabled = false;
            //Double buffering to stop the movign items from flickering a lot 
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PnlGame, new object[] { true });

            for (int i = 0; i < 3; i++)

            {
                int x = -20 - (i * 200);
                stair1[i] = new Stairs(x);
            }
            

        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmrItems.Enabled = true;
            textBox1.Enabled = false;
            lives = 3;
            lblLives.Text = "LIVES: " + lives.ToString();
            energy = 100;
            lblEnergy.Text = "ENERGY: " + energy.ToString();
            icecream1.SpeedReset();
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
            cofcof.DrawItem(g);




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
            cofcof.ItemMove();
            PnlGame.Invalidate();

            if (biden.bidenRec.IntersectsWith(icecream1.iceRec))
            {
                lives--;
                lblLives.Text = "LIVES: " + lives.ToString();
                icecream1.PopToTop();
            }
            if(lives <= 0)
            {
                tmrItems.Enabled = false;
                MessageBox.Show("you died from obesity");
            }

            //collecting of much cofcofs
            if (biden.bidenRec.IntersectsWith(cofcof.cofRec))
            {
                energy += 20;

                lblEnergy.Text = "ENERGY: " + energy.ToString();
                cofcof.PopToTop();
            }
            //decrease energy every tick
            energy--;
            lblEnergy.Text = "ENERGY: " + energy.ToString();
            if (energy == 0)
            {
                TmrBiden.Enabled = false;
                tmrItems.Enabled = false;
                MessageBox.Show("Game Over You Fell Asleep");

            }
            if (energy <=50)
            {
                icecream1.SpeedIncrease();
            }
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

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmrItems.Enabled = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
}
