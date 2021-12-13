using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTKcollabTimer
{
    public partial class Form1 : Form
    {
        float countdown = 0;
        string[] temp;
        public Point MouseDownLocation;
        public Form1()
        {
            InitializeComponent();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            countdown = 0;
            timeBox.Text = Math.Round(countdown, 1).ToString() + ":00";
            startButton.Text = "Start";
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (timer1.Enabled)
                {
                    timer1.Enabled = false;
                    startButton.Text = "Start";
                }
                else
                {
                    temp = timeBox.Text.Split(':');
                    if (temp.Length == 2)
                    {
                        countdown = Convert.ToInt32(temp[0]) * 60 + Convert.ToInt32(temp[1]);
                    }
                    else if (temp.Length == 1)
                    {
                        countdown = Convert.ToInt32(temp[0]) * 60;
                        Console.WriteLine(countdown);
                    }
                    Console.WriteLine(temp.Length);
                    timer1.Enabled = true;
                    startButton.Text = "Stop";
                }
            }
            catch (Exception) { }
        }
        private void add30_Click(object sender, EventArgs e)
        {
            if (countdown + 30 <= 3540)
            {
                countdown += 30;
            }
            else
            {
                countdown += 3600 - countdown;
            }

            string secs = Math.Floor(countdown % 60).ToString();

            if ((Math.Floor(countdown % 60)).ToString().Length == 1)
            {
                secs = "0" + Math.Floor(countdown % 60).ToString();
            }
            timeBox.Text = Math.Floor(countdown / 60).ToString() + ":" + secs;
        }

        private void add2_Click(object sender, EventArgs e)
        {
            if (countdown + 120 <= 3540)
            {
                countdown += 120;
            }
            else
            {
                countdown += 3600 - countdown;

            }
            string secs = Math.Floor(countdown % 60).ToString();

            if ((Math.Floor(countdown % 60)).ToString().Length == 1)
            {
                secs = "0" + Math.Floor(countdown % 60).ToString();
            }

            timeBox.Text = Math.Floor(countdown / 60).ToString() + ":" + secs;
        }

        private void add5_Click(object sender, EventArgs e)
        {
            if (countdown + 300 <= 3540)
            {
                countdown += 300;
            }
            else
            {
                countdown += 3600 - countdown;
            }

            string secs = Math.Floor(countdown % 60).ToString();

            if ((Math.Floor(countdown % 60)).ToString().Length == 1)
            {
                secs = "0" + Math.Floor(countdown % 60).ToString();
            }

            timeBox.Text = Math.Floor(countdown / 60).ToString() + ":" + secs;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countdown -= 1;

            string secs = Math.Floor(countdown % 60).ToString();

            if ((Math.Floor(countdown % 60)).ToString().Length == 1)
            {
                secs = "0" + Math.Floor(countdown % 60).ToString();
            }

            timeBox.Text = Math.Floor(countdown / 60).ToString() + ":" + secs;
            if (countdown == 0f)
            {
                timer1.Enabled = false;
                startButton.Text = "Start";
            }
            Console.WriteLine(Math.Floor(countdown / 60).ToString() + ":" + secs);
        }
    }
}
