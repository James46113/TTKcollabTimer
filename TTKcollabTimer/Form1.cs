using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;

namespace TTKcollabTimer
{
    public partial class Form1 : Form
    {
        float countdown = 0;
        string[] temp;
        public Point MouseDownLocation;
        int volume = 50;
        int tempvol;
        bool muted = false;
        string spkr = "🔊";
        private MediaPlayer mp = new MediaPlayer();

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
            start();
        }

        private void start()
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
                    Console.WriteLine("sdf");
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
            Console.WriteLine(mp.Volume);
            countdown -= 1;

            string secs = Math.Floor(countdown % 60).ToString();

            if ((Math.Floor(countdown % 60)).ToString().Length == 1)
            {
                secs = "0" + Math.Floor(countdown % 60).ToString();
            }

            timeBox.Text = Math.Floor(countdown / 60).ToString() + ":" + secs;
            if (countdown <= 0f)
            {
                countdown = 0;
                timeBox.Text = "0:00";
                timer1.Enabled = false;
                startButton.Text = "Start";
                mp.Open(new Uri(AppDomain.CurrentDomain.BaseDirectory + @"/Resources/beep.wav"));
                mp.Play();
            }
            //Console.WriteLine(Math.Floor(countdown / 60).ToString() + ":" + secs);
        }

        private void timeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==  (int)Keys.Enter)
            {
                start();
                label1.Focus();
            }
        }

        private void timeBox_Enter(object sender, EventArgs e)
        {
            timeBox.Text = "";
            timer1.Enabled = false;
            startButton.Text = "Start";
        }

        private void volumeUp_Click(object sender, EventArgs e)
        {
            
        }

        private void volumeDown_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            volumeLabel.Text = volume.ToString();
        }

        private void muteButton_Click(object sender, EventArgs e)
        {
            if (!muted)
            {
                muted = true;
                muteButton.Text = "🔇";
                tempvol = volume;
                volume = 0;
                volumeLabel.Text = volume.ToString();
            }
            else
            {
                muted = false;
                muteButton.Text = "🔊";
                volume = tempvol;
                volumeLabel.Text = volume.ToString();
            }
            Console.WriteLine(tempvol);
        }

        private void volumeDownTimer_Tick(object sender, EventArgs e)
        {
            if (muted)
            {
                muted = false;
                muteButton.Text = "🔊";
                volume = tempvol;
            }
            if (volume - 5 >= 0)
            {
                volume -= 5;
            }

            mp.Volume = volume / 100.0f;
            volumeLabel.Text = volume.ToString();
        }

        private void volumeUpTimer_Tick(object sender, EventArgs e)
        {
            if (muted)
            {
                muted = false;
                muteButton.Text = "🔊";
                volume = tempvol;
            }
            if (volume + 5 <= 100)
            {
                volume += 5;
            }

            mp.Volume = volume / 100.0f;
            volumeLabel.Text = volume.ToString();
        }
    }
}
