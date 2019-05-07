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

namespace SnailRacer
{
    public partial class Form1 : Form
    {

        List<Snail> snails = new List<Snail>();
        SoundPlayer vroom = new SoundPlayer(Properties.Resources.vroom);

        public Form1()
        {
            const int StartX = 50;
            InitializeComponent();
            Snail s = new Snail(StartX, 75, Properties.Resources.snail1);
            snails.Add(s);
            s = new Snail(StartX, 150, Properties.Resources.snail2);
            snails.Add(s);
            s = new Snail(StartX, 250, Properties.Resources.snail3);
            snails.Add(s);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach(Snail s in snails)
            {
                s.Draw(e.Graphics);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach(Snail s in snails)
            {
                s.Move();
                if(s.X >= 750)
                {
                    timer1.Stop();
                }
            }
            pictureBox1.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Snail s in snails)
            {
                s.X = 50;
            }
            vroom.Play();
            timer1.Start();
        }
    }
}
