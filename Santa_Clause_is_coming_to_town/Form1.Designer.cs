namespace Santa_Clause_is_coming_to_town
{
    partial class backround
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(backround));
            this.Ground = new System.Windows.Forms.PictureBox();
            this.santa = new System.Windows.Forms.PictureBox();
            this.bottomtree = new System.Windows.Forms.PictureBox();
            this.house = new System.Windows.Forms.PictureBox();
            this.toptree = new System.Windows.Forms.PictureBox();
            this.moon = new System.Windows.Forms.PictureBox();
            this.SnowFlake = new System.Windows.Forms.PictureBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playAgain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.santa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomtree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.house)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toptree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SnowFlake)).BeginInit();
            this.SuspendLayout();
            // 
            // Ground
            // 
            this.Ground.Image = ((System.Drawing.Image)(resources.GetObject("Ground.Image")));
            this.Ground.Location = new System.Drawing.Point(-7, 730);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(1077, 120);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 0;
            this.Ground.TabStop = false;
            // 
            // santa
            // 
            this.santa.Image = ((System.Drawing.Image)(resources.GetObject("santa.Image")));
            this.santa.Location = new System.Drawing.Point(85, 286);
            this.santa.Name = "santa";
            this.santa.Size = new System.Drawing.Size(240, 130);
            this.santa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.santa.TabIndex = 1;
            this.santa.TabStop = false;
            this.santa.Click += new System.EventHandler(this.Santa_Click);
            // 
            // bottomtree
            // 
            this.bottomtree.BackColor = System.Drawing.Color.Transparent;
            this.bottomtree.Image = ((System.Drawing.Image)(resources.GetObject("bottomtree.Image")));
            this.bottomtree.Location = new System.Drawing.Point(212, 512);
            this.bottomtree.Name = "bottomtree";
            this.bottomtree.Size = new System.Drawing.Size(123, 243);
            this.bottomtree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bottomtree.TabIndex = 2;
            this.bottomtree.TabStop = false;
            this.bottomtree.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // house
            // 
            this.house.Image = ((System.Drawing.Image)(resources.GetObject("house.Image")));
            this.house.Location = new System.Drawing.Point(776, 583);
            this.house.Name = "house";
            this.house.Size = new System.Drawing.Size(136, 155);
            this.house.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.house.TabIndex = 3;
            this.house.TabStop = false;
            // 
            // toptree
            // 
            this.toptree.BackColor = System.Drawing.Color.Transparent;
            this.toptree.Image = ((System.Drawing.Image)(resources.GetObject("toptree.Image")));
            this.toptree.Location = new System.Drawing.Point(530, -2);
            this.toptree.Name = "toptree";
            this.toptree.Size = new System.Drawing.Size(119, 227);
            this.toptree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.toptree.TabIndex = 4;
            this.toptree.TabStop = false;
            // 
            // moon
            // 
            this.moon.Image = ((System.Drawing.Image)(resources.GetObject("moon.Image")));
            this.moon.Location = new System.Drawing.Point(803, 12);
            this.moon.Name = "moon";
            this.moon.Size = new System.Drawing.Size(184, 137);
            this.moon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moon.TabIndex = 5;
            this.moon.TabStop = false;
            this.moon.Click += new System.EventHandler(this.Moon_Click);
            // 
            // SnowFlake
            // 
            this.SnowFlake.Image = ((System.Drawing.Image)(resources.GetObject("SnowFlake.Image")));
            this.SnowFlake.Location = new System.Drawing.Point(12, 422);
            this.SnowFlake.Name = "SnowFlake";
            this.SnowFlake.Size = new System.Drawing.Size(102, 68);
            this.SnowFlake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SnowFlake.TabIndex = 6;
            this.SnowFlake.TabStop = false;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Century Gothic", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ScoreLabel.Location = new System.Drawing.Point(49, 30);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(164, 46);
            this.ScoreLabel.TabIndex = 7;
            this.ScoreLabel.Text = "Score: 0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // playAgain
            // 
            this.playAgain.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playAgain.Location = new System.Drawing.Point(485, 311);
            this.playAgain.Name = "playAgain";
            this.playAgain.Size = new System.Drawing.Size(201, 95);
            this.playAgain.TabIndex = 8;
            this.playAgain.Text = "playAgain";
            this.playAgain.UseVisualStyleBackColor = true;
            this.playAgain.Visible = false;
            this.playAgain.Click += new System.EventHandler(this.button1_Click);
            // 
            // backround
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(1069, 851);
            this.Controls.Add(this.playAgain);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.SnowFlake);
            this.Controls.Add(this.moon);
            this.Controls.Add(this.toptree);
            this.Controls.Add(this.house);
            this.Controls.Add(this.bottomtree);
            this.Controls.Add(this.santa);
            this.Controls.Add(this.Ground);
            this.Name = "backround";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.santa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomtree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.house)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toptree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SnowFlake)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.PictureBox santa;
        private System.Windows.Forms.PictureBox bottomtree;
        private System.Windows.Forms.PictureBox house;
        private System.Windows.Forms.PictureBox toptree;
        private System.Windows.Forms.PictureBox moon;
        private System.Windows.Forms.PictureBox SnowFlake;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button playAgain;
    }
}

