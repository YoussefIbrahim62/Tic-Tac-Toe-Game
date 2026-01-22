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


        bool CheckPictureBox(PictureBox pb1, PictureBox pb2, PictureBox pb3)
        {
            if (pb1.Tag.ToString() != "empty" && pb1.Tag.ToString() == pb2.Tag.ToString() && pb1.Tag.ToString() == pb3.Tag.ToString())
            {
                pb1.BackColor = Color.GreenYellow;
                pb2.BackColor = Color.GreenYellow;
                pb3.BackColor = Color.GreenYellow;

                if (pb1.Tag.ToString() == "X")
                    lbWinner.Text = "Player 1";
                else if (pb1.Tag.ToString() == "O")
                    lbWinner.Text = "Player 2";

                return true;
            }
            return false;
        }



        bool IsWinner()
        {
            // Player 1 is the winner (X)

            if (CheckPictureBox(pb1,pb2,pb3))
            {
                return true;
            }
            if (CheckPictureBox(pb1, pb4, pb7))
            {
                return true;
            }
            if (CheckPictureBox(pb2, pb5, pb8))
            {
                return true;
            }
            if (CheckPictureBox(pb3, pb6, pb9))
            {
                return true;
            }
            if (CheckPictureBox(pb4, pb5, pb6))
            {
                return true;
            }
            if (CheckPictureBox(pb7, pb8, pb9))
            {
                return true;
            }
            if (CheckPictureBox(pb1, pb5, pb9))
            {
                return true;
            }
            if (CheckPictureBox(pb3, pb5, pb7))
            {
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



        void ResetPictureBoxToDefault(PictureBox pb)
        {
            pb.Image = Resources.QuestionMark;
            pb.Tag = "empty";
            pb.BackColor = Color.Transparent;
            pb.Enabled = true;
        }

        void RestartGame()
        {

            if(MessageBox.Show("Restart the game?","Confirmation",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                lbPlayer.Text = "Player 1";
                lbWinner.Text = "In Progress";


                ResetPictureBoxToDefault(pb1);
                ResetPictureBoxToDefault(pb2);
                ResetPictureBoxToDefault(pb3);
                ResetPictureBoxToDefault(pb4);
                ResetPictureBoxToDefault(pb5);
                ResetPictureBoxToDefault(pb6);
                ResetPictureBoxToDefault(pb7);
                ResetPictureBoxToDefault(pb8);
                ResetPictureBoxToDefault(pb9);

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
