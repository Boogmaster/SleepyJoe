
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
            this.tmrItems = new System.Windows.Forms.Timer(this.components);
            this.TmrBiden = new System.Windows.Forms.Timer(this.components);
            this.lbltitle = new System.Windows.Forms.Label();
            this.lblscore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
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
            // tmrItems
            // 
            this.tmrItems.Enabled = true;
            this.tmrItems.Tick += new System.EventHandler(this.tmrItems_Tick);
            // 
            // TmrBiden
            // 
            this.TmrBiden.Enabled = true;
            this.TmrBiden.Interval = 50;
            this.TmrBiden.Tick += new System.EventHandler(this.TmrBiden_Tick);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Location = new System.Drawing.Point(13, 13);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(35, 13);
            this.lbltitle.TabIndex = 1;
            this.lbltitle.Text = "Score";
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.Location = new System.Drawing.Point(13, 26);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(13, 13);
            this.lblscore.TabIndex = 2;
            this.lblscore.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(674, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(733, 126);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(35, 13);
            this.lblTemp.TabIndex = 4;
            this.lblTemp.Text = "label1";
            // 
            // SleepyJoe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 637);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.PnlGame);
            this.KeyPreview = true;
            this.Name = "SleepyJoe";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SleepyJoe_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SleepyJoe_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlGame;
        private System.Windows.Forms.Timer tmrItems;
        private System.Windows.Forms.Timer TmrBiden;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTemp;
    }
}

