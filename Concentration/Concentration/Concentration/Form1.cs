using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concentration
{
    public partial class Form1 : Form
    {
        const int NUM_CARDS = 14;
        const int NOT_SELECTED = -1;
        Card[] cards = new Card[NUM_CARDS];
        int firstPos = NOT_SELECTED;
        int secondPos = NOT_SELECTED;
        public Form1()
        {
            InitializeComponent();
            CreateCards();
            ShuffleCards();
            AssignPictureBoxes();
            HideCards();
        }

        void AssignPictureBoxes()
        {
            for (int i = 1; i <= NUM_CARDS; i++)
            {
                Control[] c = this.Controls.Find("pictureBox" + (i+1), false);
                cards[i-1].Pb = (PictureBox)c[0];
            }

        }

        void HideCards()
        {
            if (cards[firstPos].Type == cards[secondPos].Type)
            {

            }
            cards[firstPos].Hide();
            cards[secondPos].Hide();
            firstPos = NOT_SELECTED;
            secondPos = NOT_SELECTED;
            timer1.Stop();
        }

        void ShuffleCards()
        {

        }

        void CreateCards()
        {
            //allocates cards
            for (int i = 0; i < NUM_CARDS; i++)
            {
                cards[i] = new Card();
            }
            for (int i = 0; i < NUM_CARDS/2; i++)
            {
                cards[i].Type = i;
                cards[i + NUM_CARDS / 2].Type = i;
            }
        }


        void FlipCard(int card)
        {
            if (firstPos == NOT_SELECTED)
            {
                cards[card].Show();
                firstPos = cards[card].Type;
            }
            else if(secondPos == NOT_SELECTED)
            {
                if(card == firstPos)
                {
                    MessageBox.Show("No Cheating!");
                }
                cards[card].Show();
                secondPos = cards[card].Type;
                timer1.Interval = 2000;
                timer1.Start();
            }

        }
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 box = new AboutBox1();
            box.ShowDialog();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            FlipCard(14);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FlipCard(1);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FlipCard(2);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FlipCard(3);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FlipCard(4);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            FlipCard(10);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            FlipCard(11);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FlipCard(5);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            FlipCard(6);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            FlipCard(7);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            FlipCard(8);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            FlipCard(9);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            FlipCard(12);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            FlipCard(13);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            HideCards();
        }
    }
}
