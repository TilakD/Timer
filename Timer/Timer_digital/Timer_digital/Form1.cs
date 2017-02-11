using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_digital
{
    public partial class Form1 : Form
    {
        int h;
        int m;
        int s;
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            if(hour_textbox.Text == "")
            {
                hour_textbox.Text = "00";
            }

            if (minutes_textbox.Text == "")
            {
                minutes_textbox.Text = "00";
            }

            if (seconds_textbox.Text == "")
            {
                seconds_textbox.Text = "00";
            }
            h = Convert.ToInt32(hour_textbox.Text);
            m = Convert.ToInt32(minutes_textbox.Text);
            s = Convert.ToInt32(seconds_textbox.Text);

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s = s - 1;

            if(s == -1)
            {
                m = m - 1;
                s = 59;
            }

            if(m == -1)
            {
                h = h - 1;
                m = 59;
            }

            if (h == 0 && m == 10 && s == 0)
            {
                hours.ForeColor = Color.FromArgb(0, 192, 0);
                minutes.ForeColor = Color.FromArgb(0, 192, 0);
                seconds.ForeColor = Color.FromArgb(0, 192, 0);
            }

            if (h == 0 && m == 5 && s == 0)
            {
                hours.ForeColor = Color.Blue;
                minutes.ForeColor = Color.Blue;
                seconds.ForeColor = Color.Blue;
            }

            if (h == 0 && m == 1 && s == 0)
            {
                hours.ForeColor = Color.Red;
                minutes.ForeColor = Color.Red;
                seconds.ForeColor = Color.Red;
            }

            if(h == 0 && m ==0 && s==0)
            {
                timer1.Stop();
            }

            string hh = Convert.ToString(h);
            string mm = Convert.ToString(m);
            string ss = Convert.ToString(s);

            hours.Text = hh;
            minutes.Text = mm;
            seconds.Text = ss;

        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
