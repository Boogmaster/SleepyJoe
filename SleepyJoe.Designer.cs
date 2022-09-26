
namespace SleepyJoe
{
    partial class SleepyJoe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PnlGame = new System.Windows.Forms.Panel();
            this.TmrStairs = new System.Windows.Forms.Timer(this.components);
            this.TmrBiden = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // PnlGame
            // 
            this.PnlGame.BackColor = System.Drawing.Color.Silver;
            this.PnlGame.Location = new System.Drawing.Point(1, 60);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(650, 577);
            this.PnlGame.TabIndex = 0;
            this.PnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGame_Paint);
            // 
            // TmrStairs
            // 
            this.TmrStairs.Enabled = true;
            this.TmrStairs.Tick += new System.EventHandler(this.TmrStairs_Tick);
            // 
            // TmrBiden
            // 
            this.TmrBiden.Enabled = true;
            this.TmrBiden.Interval = 50;
            this.TmrBiden.Tick += new System.EventHandler(this.TmrBiden_Tick);
            // 
            // SleepyJoe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 637);
            this.Controls.Add(this.PnlGame);
            this.KeyPreview = true;
            this.Name = "SleepyJoe";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SleepyJoe_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SleepyJoe_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlGame;
        private System.Windows.Forms.Timer TmrStairs;
        private System.Windows.Forms.Timer TmrBiden;
    }
}

