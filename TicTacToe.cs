using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGame
{
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
        }

        string[] gameBoard = new string[9];
        int currentTurn=0;

        public string  returnSymbol(int turn)
        {
            if (turn % 2 == 0)
            {
                return "O";
            }
            else
            { 
                return "X";
            }
        }

        public System.Drawing.Color findColor(string symbol)
        {
            if (symbol.Equals("O"))
            {
                return System.Drawing.Color.LightBlue;
            }
            else if(symbol.Equals("X"))
            {
                return System.Drawing.Color.RoyalBlue;

            }
            return System.Drawing.Color.WhiteSmoke;
        }

        public void checkWinner()
        {
            for(int i = 0; i < 8; i++)
            {
                string combinations = "";
                int one=0 , two=0 , three=0 ;

                switch (i)
                {
                    case 0:
                        combinations = gameBoard[0] + gameBoard[4] + gameBoard[8];
                        one = 0;
                        two = 4;
                        three = 8;
                        break;
                    case 1:
                        combinations = gameBoard[2] + gameBoard[4] + gameBoard[6];
                        one = 2;
                        two = 4;
                        three = 6;
                        break;
                    case 2:
                        combinations = gameBoard[0] + gameBoard[1] + gameBoard[2];
                        one = 0;
                        two = 1;
                        three = 2;
                        break;
                    case 3:
                        combinations = gameBoard[3] + gameBoard[4] + gameBoard[5];
                        one = 3;
                        two = 4;
                        three = 5;
                        break;
                    case 4:
                        combinations = gameBoard[6] + gameBoard[7] + gameBoard[8];
                        one = 6;
                        two = 7;
                        three = 8;
                        break;
                    case 5:
                        combinations = gameBoard[0] + gameBoard[3] + gameBoard[6];
                        one = 0;
                        two = 3;
                        three = 6;
                        break;
                    case 6:
                        combinations = gameBoard[1] + gameBoard[4] + gameBoard[7];
                        one = 1;
                        two = 4;
                        three = 7;
                        break;
                    case 7:
                        combinations = gameBoard[2] + gameBoard[5] + gameBoard[8];
                        one = 2;
                        two = 5;
                        three = 8;
                        break;

                }
                if(combinations.Equals("OOO"))
                {
                    changeColor(one);
                    changeColor(two);
                    changeColor(three);
                    MessageBox.Show("O WON THE GAME!", "WE HAVE A WINNER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if(combinations.Equals("XXX"))
                {

                    changeColor(one);
                    changeColor(two);
                    changeColor(three);
                    MessageBox.Show("X WON THE GAME!", "WE HAVE A WINNER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                checkDraw();
            }
        }


        public void reset()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button1.BackColor  = System.Drawing.Color.WhiteSmoke;
            button2.BackColor = System.Drawing.Color.WhiteSmoke;
            button3.BackColor = System.Drawing.Color.WhiteSmoke;
            button4.BackColor = System.Drawing.Color.WhiteSmoke;
            button5.BackColor = System.Drawing.Color.WhiteSmoke;
            button6.BackColor = System.Drawing.Color.WhiteSmoke;
            button7.BackColor = System.Drawing.Color.WhiteSmoke;
            button8.BackColor = System.Drawing.Color.WhiteSmoke;
            button9.BackColor = System.Drawing.Color.WhiteSmoke;
            gameBoard=new string[9];
            currentTurn=0;  
        }

        public void changeColor(int number)
        {
            switch (number)
            {
                case 0:
                    button1.BackColor = System.Drawing.Color.Red;
                    break;
                case 1:
                    button2.BackColor = System.Drawing.Color.Red;
                    break;
                case 2:
                    button3.BackColor = System.Drawing.Color.Red;
                    break;
                case 3:
                    button4.BackColor = System.Drawing.Color.Red;
                    break;
                case 4:
                    button5.BackColor = System.Drawing.Color.Red;
                    break;
                case 5:
                    button6.BackColor = System.Drawing.Color.Red;
                    break;
                case 6:
                    button7.BackColor = System.Drawing.Color.Red;
                    break;
                case 7:
                    button8.BackColor = System.Drawing.Color.Red;
                    break;
                case 8:
                    button9.BackColor = System.Drawing.Color.Red;
                    break;
            }
        }

        public void checkDraw()
        {
            int count=0;
            for(int i=0; i < gameBoard.Length; i++)
            {
                if (gameBoard[i] != null) { count++; }
                if (count == 9)
                {
                    reset();
                    MessageBox.Show("DRAW!", "NO WINNER :(", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[8] = returnSymbol(currentTurn);
            Color btnColor = findColor(gameBoard[8]);
            button9.BackColor = btnColor;
            button9.Text = gameBoard[8];
            checkWinner();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[7] = returnSymbol(currentTurn);
            Color btnColor = findColor(gameBoard[7]);
            button8.BackColor = btnColor;
            button8.Text = gameBoard[7];
            checkWinner();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[6] = returnSymbol(currentTurn);
            Color btnColor = findColor(gameBoard[6]);
            button7.BackColor = btnColor;
            button7.Text = gameBoard[6];
            checkWinner();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[5] = returnSymbol(currentTurn);
            Color btnColor = findColor(gameBoard[5]);
            button6.BackColor = btnColor;
            button6.Text = gameBoard[5];
            checkWinner();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[4] = returnSymbol(currentTurn);
            Color btnColor = findColor(gameBoard[4]);
            button5.BackColor = btnColor;
            button5.Text = gameBoard[4];
            checkWinner();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[3] = returnSymbol(currentTurn);
            Color btnColor = findColor(gameBoard[3]);
            button4.BackColor = btnColor;
            button4.Text = gameBoard[3];
            checkWinner();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[2] = returnSymbol(currentTurn);
            Color btnColor = findColor(gameBoard[2]);
            button3.BackColor = btnColor;
            button3.Text = gameBoard[2];
            checkWinner();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[1] = returnSymbol(currentTurn);
            Color btnColor = findColor(gameBoard[1]);
            button2.BackColor = btnColor;
            button2.Text = gameBoard[1];
            checkWinner();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[0]=returnSymbol(currentTurn);
            Color btnColor =findColor(gameBoard[0]);
            button1.BackColor=btnColor;
            button1.Text = gameBoard[0];
            checkWinner();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
