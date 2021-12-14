using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Santa_is_coming
{
    public partial class Form1 : Form
    {
        int gravity = 8;
        int pipeSpeed = 6;
        int score = 0;
        int backroundSpeed = 2;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }




        private void bird_Click(object sender, EventArgs e)
        {

        }
        private void gameOver()
        {
            timer1.Stop();
            scoreLabel.Text = $"Game Over";
           

        }



        private void ScoreLabel_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            {
                bird.Top += gravity;
                treeTop.Left -= pipeSpeed;
                treeBottom.Left -= pipeSpeed;
                moon.Left -= backroundSpeed;
                house.Left -= backroundSpeed;
                scoreLabel.Text = $"score: {score}";

                if (treeTop.Left < -100)
                {
                    treeTop.Left = 1000;
                }
                if (treeBottom.Left < -100)
                {
                    treeBottom.Left = 900;
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
                if (bird.Top < -25)
                {
                    gameOver();
                }
                if (bird.Bounds.IntersectsWith(treeBottom.Bounds) || bird.Bounds.IntersectsWith(Ground.Bounds))
                {
                    gameOver();
                }
            }
        }

        private void Form1_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void playAgain_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);

        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }
    }
}
