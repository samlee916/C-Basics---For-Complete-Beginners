using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeCSharpGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int player = 2; //even X turn; odd O turn
        public int turns = 0;
        public int s1 = 0; 
        public int s2 = 0;
        public int sd = 0;

        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "") {
                if (player % 2 == 0)
                {
                    button.Text = "X";
                    player++;
                    turns++;
                }
                else
                {
                    button.Text = "O";
                    player++;
                    turns++;
                }
                if(CheckDraw() == true)
                {
                    MessageBox.Show("It's a tie game!!!");
                    sd++;
                    NewGame();
                }
                if(CheckWinner() == true) {
                    if(button.Text == "X")
                    {
                        MessageBox.Show("X Wins!!!");
                        s1++;
                        NewGame();
                    }
                    else
                    {
                        MessageBox.Show("O Wins!!!");
                        s2++;
                        NewGame();
                    }
                }
            }
        }
        //to display the scores of x's and o's
        private void Form1_Load(object sender, EventArgs e)
        {
            XWin.Text = "X: " + s1;
            OWin.Text = "O: " + s2;
            Draws.Text = "Draws: " + sd;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //to exit from the game
            Close();
        }

        void NewGame()
        {
            //for a new game to appear
            player = 2;
            turns = 0;
            A00.Text = A01.Text = A02.Text = A10.Text = A11.Text = A12.Text = A20.Text = A21.Text = A22.Text = "";

            //displays a new label
            XWin.Text = "X: " + s1;
            OWin.Text = "O: " + s2;
            Draws.Text = "Draws: " + sd;
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            NewGame(); 
        }

        bool CheckDraw()
        {
            if ((turns == 9) && CheckWinner() == false)
                return true;
            else
                return false;
        }

        bool CheckWinner()
        {
            //these are the rows and columns for the 3 x 3 tic tac toe game
            //horizontal checks
            if ((A00.Text == A01.Text) && (A01.Text == A02.Text) && (A00.Text != ""))
                return true;
            else if ((A10.Text == A11.Text) && (A11.Text == A12.Text) && (A10.Text != ""))
                return true;
            else if ((A20.Text == A21.Text) && (A21.Text == A22.Text) && (A20.Text != ""))
                return true;
            //vertical checks
            if ((A00.Text == A10.Text) && (A10.Text == A20.Text) && (A00.Text != ""))
                return true;
            else if ((A01.Text == A11.Text) && (A11.Text == A21.Text) && (A01.Text != ""))
                return true;
            else if ((A02.Text == A12.Text) && (A12.Text == A22.Text) && (A02.Text != ""))
                return true;
            //diagonal checks
            if ((A00.Text == A11.Text) && (A11.Text == A22.Text) && (A00.Text != ""))
                return true;
            else if ((A02.Text == A11.Text) && (A11.Text == A20.Text) && (A02.Text != ""))
                return true;
            else
                return false;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            s1 = s2 = sd = 0;
            NewGame();
        }
    }
}
