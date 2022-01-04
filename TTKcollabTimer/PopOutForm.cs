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
    public partial class PopOutForm : Form
    {
        public PopOutForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Console.WriteLine(Form1.countdownNum);
            Console.WriteLine(Form1.mp.Volume);
            Form1.countdownNum -= 1;

            string secs = Math.Floor(Form1.countdownNum % 60).ToString();

            if ((Math.Floor(Form1.countdownNum % 60)).ToString().Length == 1)
            {
                secs = "0" + Math.Floor(Form1.countdownNum % 60).ToString();
            }

            timeBox.Text = Math.Floor(Form1.countdownNum / 60).ToString() + ":" + secs;
            if (Form1.countdownNum <= 0f)
            {
                Form1.countdownNum = 0;
                timeBox.Text = "0:00";
                timer1.Enabled = false;
                Form1.mp.Open(new Uri(AppDomain.CurrentDomain.BaseDirectory + @"/Resources/beep.wav"));
                Form1.mp.Play();
                Hide();
            }
        }
    }
}
