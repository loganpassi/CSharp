using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Connect4
{



    public partial class Form1 : Form
    {

        //declare your board and variables here
        const int BOARD_WIDTH = 7;
        const int BOARD_HEIGHT = 6;

        enum SquareType { EMPTY, RED, BLACK };
        SquareType[,] board = new SquareType[BOARD_WIDTH, BOARD_HEIGHT];
        SoundPlayer checkerSnd = new SoundPlayer(Properties.Resources.snd_checker_drop);
        SquareType whoseTurn = SquareType.RED;


        public Form1()
        {
            InitializeComponent();
            Reset();
        }

        void Reset()
        {
            //to do
            for (int i = 0; i < BOARD_WIDTH; i++)
            {
                for (int j = 0; j < BOARD_HEIGHT; j++)
                {
                    board[i, j] = SquareType.EMPTY;
                }
            }
        }

        void DrawBoard(Graphics g)
        {
            //to do
            for (int i = 0; i < BOARD_WIDTH; i++)
            {
                for (int j = 0; j < BOARD_HEIGHT; j++)
                {
                    if (board[i, j] == SquareType.EMPTY)
                    {
                        g.DrawImage(Properties.Resources.square_empty, i * 50, j * 50);
                    }
                    else if (board[i, j] == SquareType.BLACK)
                    {
                        g.DrawImage(Properties.Resources.square_black, i * 50, j * 50);
                    }
                    else if (board[i, j] == SquareType.RED)
                    {
                        g.DrawImage(Properties.Resources.square_red, i * 50, j * 50);
                    }
                }
            }
        }


        void DropChecker(int col)
        {
            //to do
            int i = BOARD_HEIGHT - 1;
            while (i >= 0)
            {
                if (board[col, i] == SquareType.EMPTY)
                {
                    //place the checker
                    board[col, i] = whoseTurn;

                    //switch turns
                    if (whoseTurn == SquareType.BLACK)
                        whoseTurn = SquareType.RED;
                    else
                        whoseTurn = SquareType.BLACK;

                    //checkSnd.
                    break;
                }
                i--;
            }
            pictureBox1.Invalidate();
        }


        bool IsWinningMove()
        {
            //to do
            return false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DropChecker(2);
        }

        //call this from the menu bar
        void Test()
        {
            // singlePlayer = false;            
            button1.PerformClick();
            button2.PerformClick();
            button1.PerformClick();
            button2.PerformClick();
            button1.PerformClick();
            button2.PerformClick();
            button1.PerformClick();

            Reset();

            button1.PerformClick();
            button1.PerformClick();
            button2.PerformClick();
            button2.PerformClick();
            button3.PerformClick();
            button3.PerformClick();
            button4.PerformClick();

            Reset();

            button1.PerformClick();
            button2.PerformClick();
            button1.PerformClick();
            button2.PerformClick();
            button3.PerformClick();
            button3.PerformClick();
            button4.PerformClick();

            Reset();

            button1.PerformClick();
            button2.PerformClick();
            button2.PerformClick();
            button3.PerformClick();
            button3.PerformClick();
            button4.PerformClick();
            button3.PerformClick();
            button4.PerformClick();
            button4.PerformClick();
            button6.PerformClick();
            button4.PerformClick();
            //button4.PerformClick();

            Reset();

            button1.PerformClick();
            button1.PerformClick();
            button1.PerformClick();
            button1.PerformClick();

            button2.PerformClick();
            button3.PerformClick();
            button2.PerformClick();
            button2.PerformClick();

            button5.PerformClick();
            button3.PerformClick();
            button6.PerformClick();
            button4.PerformClick();

        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Test();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            DrawBoard(e.Graphics);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DropChecker(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DropChecker(1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DropChecker(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DropChecker(4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DropChecker(5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DropChecker(6);
        }
    }
}
