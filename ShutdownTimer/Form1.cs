using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ShutdownTimer
{
    public partial class Form1 : Form
    {
        int hours, mins, secs;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(counterTxt.Text))
            {
                string[] texts = counterTxt.Text.Split(':');
                hours = string.IsNullOrWhiteSpace(texts[0]) ? 0 : Convert.ToInt32(texts[0]);
                mins = string.IsNullOrWhiteSpace(texts[1]) ? 0 : Convert.ToInt32(texts[1]);
                secs = string.IsNullOrWhiteSpace(texts[2]) ? 0 : Convert.ToInt32(texts[2]);
                counterLbl.Text = fill(hours) + ':' + fill(mins) + ':' + fill(secs);
                int totalTimeInSec = secs + (60 * mins) + (60 * 60 * hours);
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/C shutdown /s /t " + totalTimeInSec.ToString();
                process.StartInfo = startInfo;
                process.Start();
                timer1.Start();
                counterTxt.ResetText();
                
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C shutdown /a";
            process.StartInfo = startInfo;
            process.Start();
            timer1.Stop();
            counterLbl.Text = "00:00:00";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*string[] texts = counterLbl.Text.Split(':');
            int hours = string.IsNullOrWhiteSpace(texts[0]) ? 0 : Convert.ToInt32(texts[0]);
            int mins = string.IsNullOrWhiteSpace(texts[1]) ? 0 : Convert.ToInt32(texts[1]);
            int secs = string.IsNullOrWhiteSpace(texts[2]) ? 0 : Convert.ToInt32(texts[2]);*/
            if (counterLbl.Text != "00:00:00")
            {
                if (secs == 0 && mins != 0)
                {
                    mins--;
                    secs = 59;
                }
                if (mins == 0 && hours != 0)
                {
                    hours--;
                    mins = 59;
                }
                counterLbl.Text = fill(hours) + ':' + fill(mins) + ':' + fill(secs);
                secs--;
            }
        }
        private string fill(int i)
        {
            if (i < 10)
            {
                return "0" + i.ToString();
            }
            else return i.ToString();
        }
    }
}
