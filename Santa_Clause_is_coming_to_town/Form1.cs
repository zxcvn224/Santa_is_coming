using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Santa_Clause_is_coming_to_town
{
    public partial class backround : Form
    {
        int backroundSpeed = 3;
        int score = 0;
        int gravity = 10;
        int treeSpeed = 6;
        public backround()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Moon_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            santa.Top += gravity;
            toptree.Left -= treeSpeed;
            bottomtree.Left -= treeSpeed;
            moon.Left -= backroundSpeed;
            house.Left -= backroundSpeed;
            ScoreLabel.Text = $"score: {score}";

            if (toptree.Left < -100)
            {
                toptree.Left = 1000;
            }
            if (bottomtree.Left < -100)
            {
                bottomtree.Left = 900;
                score++;
            }
            if (moon.Left < -100)
            {
                moon.Left = 800;
            }
            if (house.Left < -100)
            {
                house.Left = 900;
            }
            if (santa.Top < -25)
            {
                gameOver();
            }
            if (santa.Bounds.IntersectsWith(bottomtree.Bounds) || santa.Bounds.IntersectsWith(toptree.Bounds) || santa.Bounds.IntersectsWith(Ground.Bounds))
            {
                gameOver();
            }
        }

        private void gameOver()
        {
            timer1.Stop();
            ScoreLabel.Text = $"Game Over";
            playAgain.Visible = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }

        private void Santa_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            backround NewForm = new backround();
            NewForm.Show();
            this.Dispose(false);
        }
    }
}
