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
    public partial class Page_Pump : Form
    {
        public bool MCCB = true;
        public bool Start;
        public bool Stop;
        public bool EmergencyStop;
        public bool RunFeedback;
        public bool OutletValve;
        public bool DoorOpenedClosed = true;
        public bool FaultSoftstarter;
        public bool OverheatedCoil;
        public bool OverheatedBearingAbove;
        public bool OverheatedBearingBelow;
        public bool HumidityInElectrical;
        public bool HumidityInMotorChamber;
        public bool HumidityInOilChamber;
        public bool CMD;
        public short Vibration;
        public short LevelInPumpChamber;

        public bool Break;

        public Page_Pump()
        {
            InitializeComponent();
        }

        private void Page_Pump_Load(object sender, EventArgs e)
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

        

        private void btMCCB_Click(object sender, EventArgs e)
        {
            MCCB = !MCCB;
        }

        private void btEmergencyStop_Click(object sender, EventArgs e)
        {
            EmergencyStop = !EmergencyStop;
        }

        private void btRunFeedback_Click(object sender, EventArgs e)
        {
            RunFeedback = !RunFeedback;
        }

        private void btOutletValve_Click(object sender, EventArgs e)
        {
            OutletValve = !OutletValve;
        }

        private void btDoorOpenedClosed_Click(object sender, EventArgs e)
        {
            DoorOpenedClosed = !DoorOpenedClosed;
        }

        private void btFaultSoftstarter_Click(object sender, EventArgs e)
        {
            FaultSoftstarter = !FaultSoftstarter;
        }

        private void btOverheatedCoil_Click(object sender, EventArgs e)
        {
            OverheatedCoil = !OverheatedCoil;
        }

        private void btOverheatedBearingAbove_Click(object sender, EventArgs e)
        {
            OverheatedBearingAbove = !OverheatedBearingAbove;
        }

        private void btOverheatedBearingBelow_Click(object sender, EventArgs e)
        {
            OverheatedBearingBelow = !OverheatedBearingBelow;
        }

        private void btHumidityInElectrical_Click(object sender, EventArgs e)
        {
            HumidityInElectrical = !HumidityInElectrical;
        }

        private void btHumidityInMotorChamber_Click(object sender, EventArgs e)
        {
            HumidityInMotorChamber = !HumidityInMotorChamber;
        }

        private void btHumidityInOilChamber_Click(object sender, EventArgs e)
        {
            HumidityInOilChamber = !HumidityInOilChamber;
        }

        private void btBreak_Click(object sender, EventArgs e)
        {
            Break = !Break;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            Image off_img = Image.FromFile(@"Images\Off_Light.png");
            Image on_img = Image.FromFile(@"Images\On_Light.png");

            

            if (MCCB)
            {
                pbMCCB.BackgroundImage = on_img;
                pbMCCB.BackColor = Color.Transparent;
                pbMCCB.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbMCCB.BackgroundImage = off_img;
                pbMCCB.BackColor = Color.Transparent;
                pbMCCB.BackgroundImageLayout = ImageLayout.Stretch;
            }

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

            if (EmergencyStop)
            {
                pbEmergencyStop.BackgroundImage = on_img;
                pbEmergencyStop.BackColor = Color.Transparent;
                pbEmergencyStop.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbEmergencyStop.BackgroundImage = off_img;
                pbEmergencyStop.BackColor = Color.Transparent;
                pbEmergencyStop.BackgroundImageLayout = ImageLayout.Stretch;
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

            if (OutletValve)
            {
                pbOutletValve.BackgroundImage = on_img;
                pbOutletValve.BackColor = Color.Transparent;
                pbOutletValve.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbOutletValve.BackgroundImage = off_img;
                pbOutletValve.BackColor = Color.Transparent;
                pbOutletValve.BackgroundImageLayout = ImageLayout.Stretch;
            }

            if (DoorOpenedClosed)
            {
                pbDoorOpenedClosed.BackgroundImage = on_img;
                pbDoorOpenedClosed.BackColor = Color.Transparent;
                pbDoorOpenedClosed.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbDoorOpenedClosed.BackgroundImage = off_img;
                pbDoorOpenedClosed.BackColor = Color.Transparent;
                pbDoorOpenedClosed.BackgroundImageLayout = ImageLayout.Stretch;
            }

            

            if (FaultSoftstarter)
            {
                pbFaultSoftstarter.BackgroundImage = on_img;
                pbFaultSoftstarter.BackColor = Color.Transparent;
                pbFaultSoftstarter.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbFaultSoftstarter.BackgroundImage = off_img;
                pbFaultSoftstarter.BackColor = Color.Transparent;
                pbFaultSoftstarter.BackgroundImageLayout = ImageLayout.Stretch;
            }

            if (OverheatedCoil)
            {
                pbOverheatedCoil.BackgroundImage = on_img;
                pbOverheatedCoil.BackColor = Color.Transparent;
                pbOverheatedCoil.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbOverheatedCoil.BackgroundImage = off_img;
                pbOverheatedCoil.BackColor = Color.Transparent;
                pbOverheatedCoil.BackgroundImageLayout = ImageLayout.Stretch;
            }

            if (OverheatedBearingAbove)
            {
                pbOverheatedBearingAbove.BackgroundImage = on_img;
                pbOverheatedBearingAbove.BackColor = Color.Transparent;
                pbOverheatedBearingAbove.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbOverheatedBearingAbove.BackgroundImage = off_img;
                pbOverheatedBearingAbove.BackColor = Color.Transparent;
                pbOverheatedBearingAbove.BackgroundImageLayout = ImageLayout.Stretch;
            }

            if (OverheatedBearingBelow)
            {
                pbOverheatedBearingBelow.BackgroundImage = on_img;
                pbOverheatedBearingBelow.BackColor = Color.Transparent;
                pbOverheatedBearingBelow.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbOverheatedBearingBelow.BackgroundImage = off_img;
                pbOverheatedBearingBelow.BackColor = Color.Transparent;
                pbOverheatedBearingBelow.BackgroundImageLayout = ImageLayout.Stretch;
            }

            if (HumidityInElectrical)
            {
                pbHumidityInElectrical.BackgroundImage = on_img;
                pbHumidityInElectrical.BackColor = Color.Transparent;
                pbHumidityInElectrical.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbHumidityInElectrical.BackgroundImage = off_img;
                pbHumidityInElectrical.BackColor = Color.Transparent;
                pbHumidityInElectrical.BackgroundImageLayout = ImageLayout.Stretch;
            }

            if (HumidityInMotorChamber)
            {
                pbHumidityInMotorChamber.BackgroundImage = on_img;
                pbHumidityInMotorChamber.BackColor = Color.Transparent;
                pbHumidityInMotorChamber.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbHumidityInMotorChamber.BackgroundImage = off_img;
                pbHumidityInMotorChamber.BackColor = Color.Transparent;
                pbHumidityInMotorChamber.BackgroundImageLayout = ImageLayout.Stretch;
            }

            if (HumidityInOilChamber)
            {
                pbHumidityInOilChamber.BackgroundImage = on_img;
                pbHumidityInOilChamber.BackColor = Color.Transparent;
                pbHumidityInOilChamber.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbHumidityInOilChamber.BackgroundImage = off_img;
                pbHumidityInOilChamber.BackColor = Color.Transparent;
                pbHumidityInOilChamber.BackgroundImageLayout = ImageLayout.Stretch;
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

            if (!Break)
            {               
                pbBreak.BackgroundImage = off_img;
                pbBreak.BackColor = Color.Transparent;
                pbBreak.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbBreak.BackgroundImage = on_img;
                pbBreak.BackColor = Color.Transparent;
                pbBreak.BackgroundImageLayout = ImageLayout.Stretch;
            }


            tbVibration.Text = Vibration.ToString();
            tbLevelInPumpChamber.Text = LevelInPumpChamber.ToString();

        }
        
    }
}
