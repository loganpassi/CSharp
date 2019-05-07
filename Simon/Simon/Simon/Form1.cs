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
using System.Threading;

namespace Simon
{
    enum Colors { Red, Blue, Yellow, Green, Buzzer }


    public partial class Form1 : Form
    {
        SoundPlayer redSound = new SoundPlayer(Properties.Resources.snd_a_High);
        SoundPlayer blueSound = new SoundPlayer(Properties.Resources.snd_a_low);
        SoundPlayer yellowSound = new SoundPlayer(Properties.Resources.snd_middle_c);
        SoundPlayer greenSound = new SoundPlayer(Properties.Resources.snd_E);
        SoundPlayer buzzerSound = new SoundPlayer(Properties.Resources.snd_buzzer);

        int currIndex = 0;
        List<Colors> sequence = new List<Colors>();
        Dictionary<Colors, PictureBox> buttonMap = new Dictionary<Colors, PictureBox>();

        public Form1()
        {
            InitializeComponent();
            buttonMap[Colors.Red] = pictureBoxRed;
            buttonMap[Colors.Blue] = pictureBoxBlue;
            buttonMap[Colors.Green] = pictureBoxGreen;
            buttonMap[Colors.Yellow] = pictureBoxYellow;
        }

        private void pictureBoxYellow_Click(object sender, EventArgs e)
        {
            // FlashButton(pictureBoxYellow, Colors.Yellow);
            HandleButton(Colors.Yellow);

        }

        private void pictureBoxBlue_Click(object sender, EventArgs e)
        {
            // FlashButton(pictureBoxBlue, Colors.Blue);
            HandleButton(Colors.Blue);

        }

        private void pictureBoxGreen_Click(object sender, EventArgs e)
        {
            //FlashButton(pictureBoxGreen, Colors.Green);
            HandleButton(Colors.Green);
        }

        private void pictureBoxRed_Click(object sender, EventArgs e)
        {
            //FlashButton(pictureBoxRed, Colors.Red);
            HandleButton(Colors.Red);

        }

        void LightOn(PictureBox pb, Colors c)
        {
            if(c == Colors.Red)
            {
                pb.Image = Properties.Resources.img_red_on;
            }
            else if (c == Colors.Green)
            {
                pb.Image = Properties.Resources.img_green_on;
            }
            else if (c == Colors.Blue)
            {
                pb.Image = Properties.Resources.img_blue_on;
            }
            else if (c == Colors.Yellow)
            {
                pb.Image = Properties.Resources.img_yellow_on;
            }
            pb.Refresh();
        }
        void LightOff(PictureBox pb, Colors c)
        {
            if (c == Colors.Red)
            {
                pb.Image = Properties.Resources.img_red_off;
            }
            else if (c == Colors.Green)
            {
                pb.Image = Properties.Resources.img_green_off;
            }
            else if (c == Colors.Blue)
            {
                pb.Image = Properties.Resources.img_blue_off;
            }
            else if (c == Colors.Yellow)
            {
                pb.Image = Properties.Resources.img_yellow_off;
            }

            pb.Refresh();
        }
        void PlaySound(Colors c)
        {
            if(c == Colors.Red)
            {
                redSound.PlaySync();
            }
            else if(c == Colors.Yellow)
            {
                yellowSound.PlaySync();
            }
            else if(c == Colors.Blue)
            {
                blueSound.PlaySync();
            }
            else if(c == Colors.Green)
            {
                greenSound.PlaySync();
            }
            else if (c == Colors.Buzzer)
            {
                buzzerSound.PlaySync();
            }
        }

        private void testToolStripToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlaySound(Colors.Green);
            PlaySound(Colors.Blue);
            PlaySound(Colors.Yellow);
            PlaySound(Colors.Red);
            PlaySound(Colors.Buzzer);
        }

        void FlashButton(PictureBox pb, Colors c)
        {
            //turn on button
            LightOn(pb, c);
            //play sound
            PlaySound(c);
            //turn off button
            LightOff(pb, c);
        }
        private void testLightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FlashButton(pictureBoxBlue, Colors.Blue);
            FlashButton(pictureBoxYellow, Colors.Yellow);
            FlashButton(pictureBoxRed, Colors.Red);
            FlashButton(pictureBoxGreen, Colors.Green);
        }

        //puts a light in the sequence;
        void AddLight()
        {
            Random r = new Random();
            int next = r.Next(0, 3);
            Colors c = (Colors)next;

            sequence.Add((Colors)next);
        }

        

        void PlaySequence()
        {
            Thread.Sleep(500);
            foreach(Colors c in sequence)
            {
                FlashButton(buttonMap[c], c);
                Thread.Sleep(200);
            }
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restart();
        }

        void Restart()
        {
            sequence.Clear();
            currIndex=0;
            AddLight();
            PlaySequence();
        }


        void HandleButton(Colors c)
        {
            if(sequence.Count > 0)
            {
                if(c== sequence[currIndex])
                {
                    FlashButton(buttonMap[c], c);
                    currIndex++; //go to the next button

                    //did the player get to the end?
                    if(currIndex == sequence.Count)
                    {
                        AddLight();
                        currIndex = 0;
                        PlaySequence();
                    }
                }
                else
                {
                    PlaySound(Colors.Buzzer);
                    Restart();
                }
            }
            else
            {
                Restart();
            }
        }
    }
}
