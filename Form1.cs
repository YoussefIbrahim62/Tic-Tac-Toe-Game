using Project__13__Tic_Tac_Toe_Game.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project__13__Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

        }


        bool DoesButtonEqualQuestionMark(object sender)
        {
            return ((PictureBox)sender).Tag.ToString() == "empty";
        }


        string CurrentPlayer()
        {
            return lbPlayer.Text;
        }

        void DetermineNextPlayer()
        {
            if (CurrentPlayer() == "Player 1")
            {
                lbPlayer.Text = "Player 2";
            }
            else if (CurrentPlayer() == "Player 2")
            {
                lbPlayer.Text = "Player 1";
            }
        }

        void PlayXOGame(object sender)
        {
            if (DoesButtonEqualQuestionMark(sender))
            {
                if (CurrentPlayer() == "Player 1")
                {
                    ((PictureBox)sender).Image = Resources.X;

                    DetermineNextPlayer();

                    ((PictureBox)sender).Tag = "X";
                }
                else if (CurrentPlayer() == "Player 2")
                {
                    ((PictureBox)sender).Image = Resources.O;

                    DetermineNextPlayer();

                    ((PictureBox)sender).Tag = "O";
                }



            }
            else
            {
                MessageBox.Show("Invalid input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }





        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(255, 255, 255, 255);
            Pen pen = new Pen(White);

            pen.Width = 12;


            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            // Vertical lines
            e.Graphics.DrawLine(pen, 600, 95, 600, 400);
            e.Graphics.DrawLine(pen, 435, 95, 435, 400);

            //// Horizontal lines
            e.Graphics.DrawLine(pen, 325, 190, 720, 190);
            e.Graphics.DrawLine(pen, 325, 295, 720, 295);

        }

        private void pb1_Click(object sender, EventArgs e)
        {
            PlayXOGame(sender);
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            PlayXOGame(sender);
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            PlayXOGame(sender);
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            PlayXOGame(sender);
        }

        private void pb5_Click(object sender, EventArgs e)
        {
            PlayXOGame(sender);
        }

        private void pb6_Click(object sender, EventArgs e)
        {
            PlayXOGame(sender);
        }

        private void pb7_Click(object sender, EventArgs e)
        {
            PlayXOGame(sender);
        }

        private void pb8_Click(object sender, EventArgs e)
        {
            PlayXOGame(sender);
        }

        private void pb9_Click(object sender, EventArgs e)
        {
            PlayXOGame(sender);
        }



    }
}
