using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp2.Properties;

namespace WindowsFormsApp2
{


    public partial class Form1 : Form
    {
        char[,] xo = new char[3, 3] {
                            { ' ', ' ', ' ' },
                            { ' ', ' ',' ' },
                            { ' ', ' ', ' ' }
                        };

        bool IsPlayerOneTurn;
        byte TotalTurnsPlayed = 0;
        PictureBox[] xo_gridImages;

        public Form1()
        {
            InitializeComponent();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 9;
            xo_gridImages = new PictureBox[9];
            IsPlayerOneTurn = true;
        }

        void ResetGame()
        {
            for (int i = 0; i < 3; i++)
            {
                ChangeColumOrRowWithChar_Xo(true, i, ' ');
            }
            ClearImages();
            IsPlayerOneTurn = true;
            CurrentPlayerLabel.Text = "Player 1";
            progressBar1.Value = 0;
            TotalTurnsPlayed = 0;
        }
        void ClearImages()
        {
            for (int i = 0; i < 9; i++)
            {
                if (xo_gridImages[i] != null)
                {
                    xo_gridImages[i].Image = null; ;
                    xo_gridImages[i] = null;
                }
            }
        }
        bool CheckRowOrColum_Xo(bool ColumCheck, int Index, char c)
        {
            for (int i = 0; i < 3; i++)
            {
                if (xo[(ColumCheck ? i : Index), (ColumCheck ? Index : i)] != c)
                    return false;
            }
            return true;
        }

        bool CheckDiagonal(bool CheckFromRight, char c)
        {
            byte height = 0;
            for (byte i = (CheckFromRight ? i = 0 : i = 2); (CheckFromRight ? i <= 2 : i >= 0) && height < 3; height++)
            {
                if (xo[height, i] != c || xo[height, i] == ' ')
                {
                    return false;
                }

                if (CheckFromRight)
                    i++;
                else
                    i--;
            }

            return true;
        }

        bool CheckGridXo()
        {
            for (int i = 0; i < 3; i++)
            {
                if (CheckRowOrColum_Xo(true, i, CheckPlayerChar()))
                    return true;


            }

            for (int i = 0; i < 3; i++)
            {
                if (CheckRowOrColum_Xo(false, i, CheckPlayerChar()))
                    return true;

            }

            for (int i = 0; i < 3; i++)
            {
                if (!CheckDiagonal(false, CheckPlayerChar()))
                {
                    break;

                }
                else
                {
                    return true;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (!CheckDiagonal(true, CheckPlayerChar()))
                {
                    break;

                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        char CheckPlayerChar()
        {
            return IsPlayerOneTurn ? 'o' : 'x';
        }

        void UpdateGameStatus(int row, int colum)
        {

            UpdateProgressBar();

            FillOneGrid(row, colum);
            PrintXo();

            if (TotalTurnsPlayed >= 4)
            {
                CheckWin(CheckGridXo());

            }

           
            ChangeTurn();
        }
        void ChangeTurn()
        {
            if(TotalTurnsPlayed != 0)
            IsPlayerOneTurn = !IsPlayerOneTurn;
            else
            CurrentPlayerLabel.Text = IsPlayerOneTurn ? "Player 1" : "Player 2";
        }
        bool CheckPlayerTurnPicture(int index, ref PictureBox pictureBox)
        {
            if (IsPictureAdded(index, ref pictureBox))
            {
                ShowAlreadyTakenMessege();
                return true;
            }

            if (IsPlayerOneTurn)
                pictureBox.Image = Resources.OImg;
            else
                pictureBox.Image = Resources.XImg;

            currentPlayerLabel.Text = IsPlayerOneTurn ? "Player 2" : "Player 1";    

            return false;
        }
        void UpdateProgressBar()
        {
            TotalTurnsPlayed++;
            progressBar1.Value = TotalTurnsPlayed;
        }
        void PrintXo()
        {
            for (byte i = 0; i < 3; i++)
            {
                for (byte j = 0; j < 3; j++)
                {
                    Console.Write(xo[i, j] + (j >= 2 ? "" : "|"));
                }

                Console.Write(i >= 2 ? "\n" : "\n-----\n");
            }
        }

        void ShowAlreadyTakenMessege()
        {
            MessageBox.Show("This Grid Is Already Taken , Choose Another One ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void ChangeColumOrRowWithChar_Xo(bool ColumCheck, int Index, char c)
        {
            for (int i = 0; i < 3; i++)
            {
                xo[(ColumCheck ? i : Index), (ColumCheck ? Index : i)] = c;
            }
        }

        void MakeDiagonalTrue_Xo(char c, bool IncreaseColum = false)
        {
            byte height = 0;
            for (byte i = (IncreaseColum ? i = 0 : i = 2); (IncreaseColum ? i <= 2 : i >= 0) && height < 3; height++)
            {
                xo[height, i] = c;
                if (IncreaseColum)
                    i++;
                else
                    i--;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color color = Color.FromArgb(255, 255, 0, 0);
            Pen pen = new Pen(color);
            pen.Width = 10;
            e.Graphics.DrawLine(pen, 300, 125, 750, 125);
            e.Graphics.DrawLine(pen, 300, 275, 750, 275);
            e.Graphics.DrawLine(pen, ((300 + 750) / 2.30f) - 12.5f, 10, ((300 + 750) / 2.30f) - 12.5f, 400);
            e.Graphics.DrawLine(pen, ((300 + 750) / 2.30f) + 150, 10, ((300 + 750) / 2.30f) + 150, 400);
            Color color2 = Color.FromArgb(255, 0, 0, 0);
            pen.Color = color2;
            e.Graphics.DrawLine(pen, 275, 10, 275, 400);
        }

        bool IsPictureAdded(int index, ref PictureBox pictureBox)
        {
            if (xo_gridImages[index] == null)
            {
                xo_gridImages[index] = pictureBox;
                return false;
            }
            else
                return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        void CheckWin(bool HasWon)
        {
            if (HasWon)
            {
                string winner = IsPlayerOneTurn ? "Player 1 (o)" : "Player 2 (x)";
                DialogResult result = MessageBox.Show(winner + " has won! 🎉\nDo you want to play again?",
                                                      "Game Over",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    ResetGame(); // Restart the game
                }
                else
                {
                    Application.Exit(); // Exit the application
                }
            }
            else if (TotalTurnsPlayed == 9) // Check for a draw
            {
                DialogResult result = MessageBox.Show("It's a draw! 🤝\nDo you want to play again?",
                                                      "Game Over",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    ResetGame(); // Restart the game

                }
                else
                {
                    Application.Exit(); // Exit the application
                }
            }
        }

        void FillOneGrid(int row, int colum)
        {
            xo[row, colum] = CheckPlayerChar();
        }

        private void xo_grid1_Click(object sender, EventArgs e)
        {
            if (CheckPlayerTurnPicture(0, ref xo_grid1))
            {
                return;
            }
            UpdateGameStatus(0, 0);
        }

        private void xo_grid2_Click(object sender, EventArgs e)
        {
            if (CheckPlayerTurnPicture(1, ref xo_grid2))
            {
                return;
            }
            UpdateGameStatus(0, 1);
        }

        private void xo_grid3_Click(object sender, EventArgs e)
        {
            if (CheckPlayerTurnPicture(2, ref xo_grid3))
            {
                return;
            }
            UpdateGameStatus(0, 2);
        }

        private void xo_grid4_Click(object sender, EventArgs e)
        {
            if (CheckPlayerTurnPicture(3, ref xo_grid4))
            {
                return;
            }
            UpdateGameStatus(1, 0);
        }

        private void xo_grid5_Click(object sender, EventArgs e)
        {
            if (CheckPlayerTurnPicture(4, ref xo_grid5))
            {
                return;
            }
            UpdateGameStatus(1, 1);
        }

        private void xo_grid6_Click(object sender, EventArgs e)
        {
            if (CheckPlayerTurnPicture(5, ref xo_grid6))
            {
                return;
            }
            UpdateGameStatus(1, 2);
        }

        private void xo_grid7_Click(object sender, EventArgs e)
        {
            if (CheckPlayerTurnPicture(6, ref xo_grid7))
            {
                return;
            }
            UpdateGameStatus(2, 0);
        }

        private void xo_grid8_Click(object sender, EventArgs e)
        {
            if (CheckPlayerTurnPicture(7, ref xo_grid8))
            {
                return;
            }
            UpdateGameStatus(2, 1);
        }

        private void xo_grid9_Click(object sender, EventArgs e)
        {
            if (CheckPlayerTurnPicture(8, ref xo_grid9))
            {
                return;
            }
            UpdateGameStatus(2, 2);
        }
    }
}
