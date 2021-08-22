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
    public partial class MainPagePumpStation : Form
    {
        public SCADA Parent;
        public MainPagePumpStation()
        {
            InitializeComponent();
        }

        private void btPump_1_Click(object sender, EventArgs e)
        {
            Program.Pump_1.Show();
        }

        private void btPump_2_Click(object sender, EventArgs e)
        {
            Program.Pump_2.Show();
        }

        private void btPump_3_Click(object sender, EventArgs e)
        {
            Program.Pump_3.Show();
        }

        private void btPump_4_Click(object sender, EventArgs e)
        {
            Program.Pump_4.Show();
        }

        private void btRaker_1_Click(object sender, EventArgs e)
        {
            Program.Raker_1.Show();
        }

        private void btRaker_2_Click(object sender, EventArgs e)
        {
            Program.Raker_2.Show();
        }

        private void btRaker_3_Click(object sender, EventArgs e)
        {
            Program.Raker_3.Show();
        }

        private void btRaker_4_Click(object sender, EventArgs e)
        {
            Program.Raker_4.Show();
        }

        private void btConveyer_Click(object sender, EventArgs e)
        {
            Program.Conveyer.Show();
        }

        private void btGeneral_Click(object sender, EventArgs e)
        {
            Program.General.Show();
        }

        private void MainPagePumpStation_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int count;
        Random rndInt;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //vpgDischargeTank.Increment(1);

            Pump pump_1 = null;
            pump_1 = Parent.FindPumps("Pump_1");
            Pump pump_2 = null;
            pump_2 = Parent.FindPumps("Pump_2");
            Pump pump_3 = null;
            pump_3 = Parent.FindPumps("Pump_3");
            Pump pump_4 = null;
            pump_4 = Parent.FindPumps("Pump_4");

            Raker raker_1 = null;
            raker_1 = Parent.FindRakers("Raker_1");
            Raker raker_2 = null;
            raker_2 = Parent.FindRakers("Raker_2");
            Raker raker_3 = null;
            raker_3 = Parent.FindRakers("Raker_3");
            Raker raker_4 = null;
            raker_4 = Parent.FindRakers("Raker_4");

            Conveyer conveyer = null;
            conveyer = Parent.FindConveyers("Conveyer");

            General general = null;
            general = Parent.FindGenerals("General");

            Image off_img = Image.FromFile(@"Images\Off_Red_Light.png");
            Image on_img = Image.FromFile(@"Images\On_Red_Light.png");

            if (pump_1.RunFeedback)
            {
                pbPump_1.BackgroundImage = on_img;
                pbPump_1.BackColor = Color.Transparent;
                pbPump_1.BackgroundImageLayout = ImageLayout.Stretch;

                count += 250;
            }
            else
            {
                pbPump_1.BackgroundImage = off_img;
                pbPump_1.BackColor = Color.Transparent;
                pbPump_1.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (pump_2.RunFeedback)
            {
                pbPump_2.BackgroundImage = on_img;
                pbPump_2.BackColor = Color.Transparent;
                pbPump_2.BackgroundImageLayout = ImageLayout.Stretch;

                count += 250;
            }
            else
            {
                pbPump_2.BackgroundImage = off_img;
                pbPump_2.BackColor = Color.Transparent;
                pbPump_2.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (pump_3.RunFeedback)
            {
                pbPump_3.BackgroundImage = on_img;
                pbPump_3.BackColor = Color.Transparent;
                pbPump_3.BackgroundImageLayout = ImageLayout.Stretch;

                count += 250;
            }
            else
            {
                pbPump_3.BackgroundImage = off_img;
                pbPump_3.BackColor = Color.Transparent;
                pbPump_3.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (pump_4.RunFeedback)
            {
                pbPump_4.BackgroundImage = on_img;
                pbPump_4.BackColor = Color.Transparent;
                pbPump_4.BackgroundImageLayout = ImageLayout.Stretch;

                count += 250;
            }
            else
            {
                pbPump_4.BackgroundImage = off_img;
                pbPump_4.BackColor = Color.Transparent;
                pbPump_4.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (raker_1.RunFeedback)
            {
                pbRaker_1.BackgroundImage = on_img;
                pbRaker_1.BackColor = Color.Transparent;
                pbRaker_1.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbRaker_1.BackgroundImage = off_img;
                pbRaker_1.BackColor = Color.Transparent;
                pbRaker_1.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (raker_2.RunFeedback)
            {
                pbRaker_2.BackgroundImage = on_img;
                pbRaker_2.BackColor = Color.Transparent;
                pbRaker_2.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbRaker_2.BackgroundImage = off_img;
                pbRaker_2.BackColor = Color.Transparent;
                pbRaker_2.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (raker_3.RunFeedback)
            {
                pbRaker_3.BackgroundImage = on_img;
                pbRaker_3.BackColor = Color.Transparent;
                pbRaker_3.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbRaker_3.BackgroundImage = off_img;
                pbRaker_3.BackColor = Color.Transparent;
                pbRaker_3.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (raker_4.RunFeedback)
            { 
                pbRaker_4.BackgroundImage = on_img;
                pbRaker_4.BackColor = Color.Transparent;
                pbRaker_4.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbRaker_4.BackgroundImage = off_img;
                pbRaker_4.BackColor = Color.Transparent;
                pbRaker_4.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (conveyer.RunFeedback)
            {
                pbConveyer.BackgroundImage = on_img;
                pbConveyer.BackColor = Color.Transparent;
                pbConveyer.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbConveyer.BackgroundImage = off_img;
                pbConveyer.BackColor = Color.Transparent;
                pbConveyer.BackgroundImageLayout = ImageLayout.Stretch;
            }         



            if (count >= 4000)
            {
                //general.LevelOutDischargeTank += 1;
                general.LevelInSuctionTank -= 300;
                pump_1.LevelInPumpChamber = general.LevelInSuctionTank;
                pump_2.LevelInPumpChamber = pump_1.LevelInPumpChamber;
                pump_3.LevelInPumpChamber = pump_1.LevelInPumpChamber;
                pump_4.LevelInPumpChamber = pump_1.LevelInPumpChamber;
                general.LevelOutDischargeTank += 195;
                count = 0;
            }
            if (general.LevelInSuctionTank <= 0)
            {
                general.LevelInSuctionTank = 0;
                pump_1.LevelInPumpChamber = 0;
                pump_2.LevelInPumpChamber = 0;
                pump_3.LevelInPumpChamber = 0;
                pump_4.LevelInPumpChamber = 0;
            }   
            if (general.LevelOutDischargeTank >= 27648)
                general.LevelOutDischargeTank = 27648;
            vpgSuctionTank.Value = general.LevelInSuctionTank;
            vpgDischargeTank.Value = general.LevelOutDischargeTank;
        }

        private void btFullTank_Click(object sender, EventArgs e)
        {
            General general = null;
            general = Parent.FindGenerals("General");
            general.LevelInSuctionTank = 27648;
        }
    }
}
