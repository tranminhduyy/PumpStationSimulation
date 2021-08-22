using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PumpStationSystem
{
    public partial class Page_Conveyer : Form
    {
        public bool Start;
        public bool Stop;
        public bool RunFeedback;
        public bool FaultVSD;
        public bool CMD;

        public short FaultVSDModbus;

        public bool Break;


        public Page_Conveyer()
        {
            InitializeComponent();
        }

        private void Page_Conveyer_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        public void StopTimer1()
        {
            if (timer1 != null)
            {
                timer1.Dispose();
                timer1 = null;
            }
        }



        private void btRunFeedback_Click(object sender, EventArgs e)
        {
            RunFeedback = !RunFeedback;
        }

        private void btFaultVSD_Click(object sender, EventArgs e)
        {
            FaultVSD = !FaultVSD;
        }

        private void btBreak_Click(object sender, EventArgs e)
        {
            Break = !Break;
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            Image off_img = Image.FromFile(@"Images\Off_Light.png");
            Image on_img = Image.FromFile(@"Images\On_Light.png");


            if (Start)
            {
                pbStart.BackgroundImage = on_img;
                pbStart.BackColor = Color.Transparent;
                pbStart.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbStart.BackgroundImage = off_img;
                pbStart.BackColor = Color.Transparent;
                pbStart.BackgroundImageLayout = ImageLayout.Stretch;
            }

            if (Stop)
            {
                pbStop.BackgroundImage = on_img;
                pbStop.BackColor = Color.Transparent;
                pbStop.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbStop.BackgroundImage = off_img;
                pbStop.BackColor = Color.Transparent;
                pbStop.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (RunFeedback)
            {
                pbRunFeedback.BackgroundImage = on_img;
                pbRunFeedback.BackColor = Color.Transparent;
                pbRunFeedback.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbRunFeedback.BackgroundImage = off_img;
                pbRunFeedback.BackColor = Color.Transparent;
                pbRunFeedback.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (FaultVSD)
            {
                pbFaultVSD.BackgroundImage = on_img;
                pbFaultVSD.BackColor = Color.Transparent;
                pbFaultVSD.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbFaultVSD.BackgroundImage = off_img;
                pbFaultVSD.BackColor = Color.Transparent;
                pbFaultVSD.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (CMD)
            {
                pbCMD.BackgroundImage = on_img;
                pbCMD.BackColor = Color.Transparent;
                pbCMD.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbCMD.BackgroundImage = off_img;
                pbCMD.BackColor = Color.Transparent;
                pbCMD.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (Break)
            {
                pbBreak.BackgroundImage = on_img;
                pbBreak.BackColor = Color.Transparent;
                pbBreak.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbBreak.BackgroundImage = off_img;
                pbBreak.BackColor = Color.Transparent;
                pbBreak.BackgroundImageLayout = ImageLayout.Stretch;
            }

            object obj;
            bool ret;
            if (tbFaultVSBModbus.Text != "")
            {
                ret = Utilities.TryParse(tbFaultVSBModbus.Text, "Int16", out obj);
                if (ret)
                {
                    FaultVSDModbus = (short)obj;
                }
            }
            
        }

        
    }
}
