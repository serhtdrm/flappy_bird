using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappy_bird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int pipeSpeed = 8; 
        int gravity = 15;
        int score = 0;


        private void GameTimerEvent(object sender, EventArgs e)
        {
           Kus.Top += gravity; 
            BoruAlt.Left -= pipeSpeed;

            BoruUst.Left -= pipeSpeed; 

            skorText.Text = "Score: " + score;
            
            if (BoruAlt.Left < -150)
            {
               
                BoruAlt.Left = 800;
                score++;
            }
            if (BoruUst.Left < -180)
            {
               
               BoruUst.Left = 950;
                score++;
            }
            
            


            if (Kus.Bounds.IntersectsWith(BoruAlt.Bounds) ||
                Kus.Bounds.IntersectsWith(BoruUst.Bounds) ||
                Kus.Bounds.IntersectsWith(Zamin.Bounds) || Kus.Top < -25
                )
            {
               
                endGame();
            }
            
            if (score > 5)
            {
                pipeSpeed = 15;
            }
            

        }
        private void restart()
        {
            gameover = false;
            Kus.Location = new Point(87,82);
            BoruUst.Left = 800;
            BoruAlt.Left = 1200;
            score = 0;
            pipeSpeed = 8;
            skorText.Text = "Score:0";
            GameTimer.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
               
                gravity = -15;
            }
        }
        public bool gameover;
        private void endGame()
        {
            
            GameTimer.Stop();
            skorText.Text += " Game over!!!"; 
            gameover = true;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Space)
            {
              
                gravity = 15;
            }
           if(e.KeyCode==Keys.R && gameover)
            {
                restart(); 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GameTimer.Start();
            
        }
    }
}
