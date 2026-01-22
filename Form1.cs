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


        bool IsWinner()
        {
            // Player 1 is the winner (X)

            if (pb1.Tag.ToString() == "X" && pb2.Tag.ToString() == "X" && pb3.Tag.ToString() == "X")
            {
                lbWinner.Text = "Player 1";
                return true;
            }
            if (pb1.Tag.ToString() == "X" && pb4.Tag.ToString() == "X" && pb7.Tag.ToString() == "X")
            {
                lbWinner.Text = "Player 1";
                return true;
            }
            if (pb2.Tag.ToString() == "X" && pb5.Tag.ToString() == "X" && pb8.Tag.ToString() == "X")
            {
                lbWinner.Text = "Player 1";
                return true;
            }
            if (pb3.Tag.ToString() == "X" && pb6.Tag.ToString() == "X" && pb9.Tag.ToString() == "X")
            {
                lbWinner.Text = "Player 1";
                return true;
            }
            if (pb4.Tag.ToString() == "X" && pb5.Tag.ToString() == "X" && pb6.Tag.ToString() == "X")
            {
                lbWinner.Text = "Player 1";
                return true;
            }
            if (pb7.Tag.ToString() == "X" && pb8.Tag.ToString() == "X" && pb9.Tag.ToString() == "X")
            {
                lbWinner.Text = "Player 1";
                return true;
            }
            if (pb1.Tag.ToString() == "X" && pb5.Tag.ToString() == "X" && pb9.Tag.ToString() == "X")
            {
                lbWinner.Text = "Player 1";
                return true;
            }
            if (pb3.Tag.ToString() == "X" && pb5.Tag.ToString() == "X" && pb7.Tag.ToString() == "X")
            {
                lbWinner.Text = "Player 1";
                return true;
            }



            // Player 2 is the winner (O)

            if (pb1.Tag.ToString() == "O" && pb2.Tag.ToString() == "O" && pb3.Tag.ToString() == "O")
            {
                lbWinner.Text = "Player 2";
                return true;
            }
            if (pb1.Tag.ToString() == "O" && pb4.Tag.ToString() == "O" && pb7.Tag.ToString() == "O")
            {
                lbWinner.Text = "Player 2";
                return true;
            }
            if (pb2.Tag.ToString() == "O" && pb5.Tag.ToString() == "O" && pb8.Tag.ToString() == "O")
            {
                lbWinner.Text = "Player 2";
                return true;
            }
            if (pb3.Tag.ToString() == "O" && pb6.Tag.ToString() == "O" && pb9.Tag.ToString() == "O")
            {
                lbWinner.Text = "Player 2";
                return true;
            }
            if (pb4.Tag.ToString() == "O" && pb5.Tag.ToString() == "O" && pb6.Tag.ToString() == "O")
            {
                lbWinner.Text = "Player 2";
                return true;
            }
            if (pb7.Tag.ToString() == "O" && pb8.Tag.ToString() == "O" && pb9.Tag.ToString() == "O")
            {
                lbWinner.Text = "Player 2";
                return true;
            }
            if (pb1.Tag.ToString() == "O" && pb5.Tag.ToString() == "O" && pb9.Tag.ToString() == "O")
            {
                lbWinner.Text = "Player 2";
                return true;
            }
            if (pb3.Tag.ToString() == "O" && pb5.Tag.ToString() == "O" && pb7.Tag.ToString() == "O")
            {
                lbWinner.Text = "Player 2";
                return true;
            }

            return false;
            
        }


        bool IsGameOver()
        {
            if(pb1.Tag.ToString() != "empty" && pb2.Tag.ToString() != "empty" &&
                pb3.Tag.ToString() != "empty" && pb4.Tag.ToString() != "empty" &&
                pb5.Tag.ToString() != "empty" && pb6.Tag.ToString() != "empty" &&
                pb7.Tag.ToString() != "empty" && pb8.Tag.ToString() != "empty" &&
                pb9.Tag.ToString() != "empty")
                return true;

            return false;
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


                if (IsWinner())
                {
                    lbPlayer.Text = "Game Over";

                    pb1.Enabled = false;
                    pb2.Enabled = false;
                    pb3.Enabled = false;
                    pb4.Enabled = false;
                    pb5.Enabled = false;
                    pb6.Enabled = false;
                    pb7.Enabled = false;
                    pb8.Enabled = false;
                    pb9.Enabled = false;
                    return;
                }

                if (IsGameOver())
                {
                    lbPlayer.Text = "Game Over";
                    lbWinner.Text = "Draw";

                    pb1.Enabled = false;
                    pb2.Enabled = false;
                    pb3.Enabled = false;
                    pb4.Enabled = false;
                    pb5.Enabled = false;
                    pb6.Enabled = false;
                    pb7.Enabled = false;
                    pb8.Enabled = false;
                    pb9.Enabled = false;
                    return;


                }

            }
            else
            {
                MessageBox.Show("Invalid input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }


        void RestartGame()
        {

            if(MessageBox.Show("Restart the game?","Confirmation",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                pb1.Enabled = true;
                pb2.Enabled = true;
                pb3.Enabled = true;
                pb4.Enabled = true;
                pb5.Enabled = true;
                pb6.Enabled = true;
                pb7.Enabled = true;
                pb8.Enabled = true;
                pb9.Enabled = true;



                lbPlayer.Text = "Player 1";
                lbWinner.Text = "In Progress";

                pb1.Image = Resources.QuestionMark;
                pb1.Tag = "empty";

                pb2.Image = Resources.QuestionMark;
                pb2.Tag = "empty";

                pb3.Image = Resources.QuestionMark;
                pb3.Tag = "empty";

                pb4.Image = Resources.QuestionMark;
                pb4.Tag = "empty";

                pb5.Image = Resources.QuestionMark;
                pb5.Tag = "empty";

                pb6.Image = Resources.QuestionMark;
                pb6.Tag = "empty";

                pb7.Image = Resources.QuestionMark;
                pb7.Tag = "empty";

                pb8.Image = Resources.QuestionMark;
                pb8.Tag = "empty";

                pb9.Image = Resources.QuestionMark;
                pb9.Tag = "empty";


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

        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
    }
}
