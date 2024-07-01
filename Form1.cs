using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRex
{
    public partial class Form1 : Form
    {
        bool jumping = false;
        bool isGameOver = false;
        Random Random = new Random();
        int jumpSpeed;
        int force = 12;
        int score = 0;
        int obstacleSpeed = 10;
        int position = 0;
       

        public Form1()
        {
            InitializeComponent();
            GameReset();
        }

        private void GameReset()
        {
            jumping = false;
            force = 12; 
            score = 0;
            jumpSpeed = 0;
            obstacleSpeed = 10;
            isGameOver = false;
          
            ScoreText.Text = "Score : " + score;
            TRexPictureBox.Image = Properties.Resources.running;
            isGameOver = false;

            foreach (Control x in this.Controls) 
            {
                if(x is PictureBox && (string)x.Tag == "ObstacleOmit") 
                {
                    position = this.ClientSize.Width + Random.Next(500, 800) + (x.Width * 10);
                    x.Left = position;
                
                }
            }
            GameTimer.Start();
        }

        private void GameEvent(object sender, EventArgs e)
        {
            TRexPictureBox.Top = TRexPictureBox.Top + jumpSpeed;

            ScoreText.Text = "Score: " + score + " Jumping speed: " + jumpSpeed + " force: " + force + " Top:" + TRexPictureBox.Top + " Bottom:" + TRexPictureBox.Bottom;

            if (jumping == true && force < 0)
            {
                jumping = false;
            }

            if (jumping == true)
            {
                jumpSpeed = -12;
                force--;
            }
            else
            {
                jumpSpeed = 12;
            } 


            if (TRexPictureBox.Top > 366 && jumping == false)
            {
                force = 12;
                TRexPictureBox.Top = 367;
                jumpSpeed = 0;
            }


            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "ObstacleOmit")
                {
                    x.Left -= obstacleSpeed;

                    if (x.Left < -100)
                    {
                        x.Left = this.ClientSize.Width + Random.Next(200, 500) + (x.Width * 15);
                        score++;
                    }

                    if (TRexPictureBox.Bounds.IntersectsWith(x.Bounds))
                    {
                        GameTimer.Stop();
                        TRexPictureBox.Image = Properties.Resources.dead;
                        ScoreText.Text += " Press R to restart the game!";
                        isGameOver = true;
                    }
                }
            }

            if (score > 5)
            {
                obstacleSpeed = 15;
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Space) && (jumping == false))
            {
                jumping = true;
                jumpSpeed = -force; 
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (jumping == true)
            {
                jumping = false;
                jumpSpeed = force;
            }

            if (e.KeyCode == Keys.R && isGameOver == true)
            {
                GameReset();
            }
        }

        private void TRexPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
