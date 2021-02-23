using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIT
{
    public partial class FrmMain : Form
    {
        private const int MAX_TIME = 30;
        private int countDown = MAX_TIME;
        private SoundPlayer timerTickPlayer = new SoundPlayer(Properties.Resources.timeSound);
        private SoundPlayer timerFinish = new SoundPlayer(Properties.Resources.timeFinish);

        public FrmMain()
        {
            InitializeComponent();
            lbTimer.Text = MAX_TIME.ToString();
            progressBar1.Value = MAX_TIME;
            progressBar1.Maximum = MAX_TIME;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (countDown > 0)
            {
                countDown -= 1;
                progressBar1.Value = countDown;
                lbTimer.Text = countDown.ToString();
                timerTickPlayer.Play();
            }    
            else
            {
                timer1.Stop();
                timer1.Enabled = false;
                btnStart.Enabled = true;
                btnSolution.Enabled = true;
                timerFinish.Play();
                Msg.ShowMsg(Msg.MsgType.CorrectAnswer);
                countDown = MAX_TIME;
                progressBar1.Value = MAX_TIME;
                lbTimer.Text = MAX_TIME.ToString();
            }    
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            timer1.Enabled = true;
            timer1.Start();
        }
    }
}
