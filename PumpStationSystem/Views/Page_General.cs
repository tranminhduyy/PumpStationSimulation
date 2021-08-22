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
    public partial class Page_General : Form
    {
        public bool FaultACB;
        public bool EmergencyStopPLC;
        public bool EmergencyStopACB;
        public bool EmergencyStopCR;
        public bool DoorOpenedClosedACB = true;
        public bool DoorOpenedClosedPLC = true;
        public bool DoorOpenedClosedCR = true;
        public bool LockACB = true;
        public bool AlarmACB;
        public bool EmptySuctionTank;
        public bool GlobalInterlock;
        public short LevelInSuctionTank;
        public short LevelOutDischargeTank;
        public int V;
        public int Vab;
        public int Vbc;
        public int Vca;
        public int I;
        public int Ia;
        public int Ib;
        public int Ic;
        public int P;
        public int PF;
        public short Temperature;
        public short Humidity;

        public bool BreakAnalog;
        public bool BreakPM;

        public Page_General()
        {
            InitializeComponent();
        }

        private void Page_General_Load(object sender, EventArgs e)
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



        private void btFaultACB_Click(object sender, EventArgs e)
        {
            FaultACB = !FaultACB;
        }



        private void btEmergencyStopPLC_Click(object sender, EventArgs e)
        {
            EmergencyStopPLC = !EmergencyStopPLC;
        }

        private void btEmergencyStopACB_Click(object sender, EventArgs e)
        {
            EmergencyStopACB = !EmergencyStopACB;
        }

        private void btEmergencyStopCR_Click(object sender, EventArgs e)
        {
            EmergencyStopCR = !EmergencyStopCR;
        }

        private void btDoorOpenedClosedACB_Click(object sender, EventArgs e)
        {
            DoorOpenedClosedACB = !DoorOpenedClosedACB;
        }

        private void btDoorOpenedClosedPLC_Click(object sender, EventArgs e)
        {
            DoorOpenedClosedPLC = !DoorOpenedClosedPLC;
        }

        private void btDoorOpenedClosedCR_Click(object sender, EventArgs e)
        {
            DoorOpenedClosedCR = !DoorOpenedClosedCR;
        }

        private void btBreakAnalog_Click(object sender, EventArgs e)
        {
            BreakAnalog = !BreakAnalog;
        }

        private void btBreakPM_Click(object sender, EventArgs e)
        {
            BreakPM = !BreakPM;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Image off_img = Image.FromFile(@"Images\Off_Light.png");
            Image on_img = Image.FromFile(@"Images\On_Light.png");

          
            if (FaultACB)
            {
                pbFaultACB.BackgroundImage = on_img;
                pbFaultACB.BackColor = Color.Transparent;
                pbFaultACB.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbFaultACB.BackgroundImage = off_img;
                pbFaultACB.BackColor = Color.Transparent;
                pbFaultACB.BackgroundImageLayout = ImageLayout.Stretch;
            }
         
            if (EmergencyStopPLC)
            {
                pbEmergencyStopPLC.BackgroundImage = on_img;
                pbEmergencyStopPLC.BackColor = Color.Transparent;
                pbEmergencyStopPLC.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbEmergencyStopPLC.BackgroundImage = off_img;
                pbEmergencyStopPLC.BackColor = Color.Transparent;
                pbEmergencyStopPLC.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (EmergencyStopACB)
            {
                pbEmergencyStopACB.BackgroundImage = on_img;
                pbEmergencyStopACB.BackColor = Color.Transparent;
                pbEmergencyStopACB.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbEmergencyStopACB.BackgroundImage = off_img;
                pbEmergencyStopACB.BackColor = Color.Transparent;
                pbEmergencyStopACB.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (EmergencyStopCR)
            {
                pbEmergencyStopCR.BackgroundImage = on_img;
                pbEmergencyStopCR.BackColor = Color.Transparent;
                pbEmergencyStopCR.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbEmergencyStopCR.BackgroundImage = off_img;
                pbEmergencyStopCR.BackColor = Color.Transparent;
                pbEmergencyStopCR.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (DoorOpenedClosedACB)
            {
                pbDoorOpenedClosedACB.BackgroundImage = on_img;
                pbDoorOpenedClosedACB.BackColor = Color.Transparent;
                pbDoorOpenedClosedACB.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbDoorOpenedClosedACB.BackgroundImage = off_img;
                pbDoorOpenedClosedACB.BackColor = Color.Transparent;
                pbDoorOpenedClosedACB.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (DoorOpenedClosedPLC)
            {
                pbDoorOpenedClosedPLC.BackgroundImage = on_img;
                pbDoorOpenedClosedPLC.BackColor = Color.Transparent;
                pbDoorOpenedClosedPLC.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbDoorOpenedClosedPLC.BackgroundImage = off_img;
                pbDoorOpenedClosedPLC.BackColor = Color.Transparent;
                pbDoorOpenedClosedPLC.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (DoorOpenedClosedCR)
            {
                pbDoorOpenedClosedCR.BackgroundImage = on_img;
                pbDoorOpenedClosedCR.BackColor = Color.Transparent;
                pbDoorOpenedClosedCR.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbDoorOpenedClosedCR.BackgroundImage = off_img;
                pbDoorOpenedClosedCR.BackColor = Color.Transparent;
                pbDoorOpenedClosedCR.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (LockACB)
            {
                pbLockACB.BackgroundImage = on_img;
                pbLockACB.BackColor = Color.Transparent;
                pbLockACB.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbLockACB.BackgroundImage = off_img;
                pbLockACB.BackColor = Color.Transparent;
                pbLockACB.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (AlarmACB)
            {
                pbAlarmACB.BackgroundImage = on_img;
                pbAlarmACB.BackColor = Color.Transparent;
                pbAlarmACB.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbAlarmACB.BackgroundImage = off_img;
                pbAlarmACB.BackColor = Color.Transparent;
                pbAlarmACB.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (EmptySuctionTank)
            {
                pbEmptySuctionTank.BackgroundImage = on_img;
                pbEmptySuctionTank.BackColor = Color.Transparent;
                pbEmptySuctionTank.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbEmptySuctionTank.BackgroundImage = off_img;
                pbEmptySuctionTank.BackColor = Color.Transparent;
                pbEmptySuctionTank.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (GlobalInterlock)
            {
                pbGlobalInterlock.BackgroundImage = on_img;
                pbGlobalInterlock.BackColor = Color.Transparent;
                pbGlobalInterlock.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbGlobalInterlock.BackgroundImage = off_img;
                pbGlobalInterlock.BackColor = Color.Transparent;
                pbGlobalInterlock.BackgroundImageLayout = ImageLayout.Stretch;
            }

            if (!BreakAnalog)
            {
                tbLevelInSuctionTank.Text = LevelInSuctionTank.ToString();
                tbLevelOutDischargeTank.Text = LevelOutDischargeTank.ToString();

                pbBreakAnalog.BackgroundImage = off_img;
                pbBreakAnalog.BackColor = Color.Transparent;
                pbBreakAnalog.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                object obj;
                bool ret;
                if (tbLevelInSuctionTank.Text != "")
                {
                    ret = Utilities.TryParse(tbLevelInSuctionTank.Text, "Int16", out obj);
                    if (ret)
                    {
                        LevelInSuctionTank = (short)obj;
                    }
                }

                if (tbLevelOutDischargeTank.Text != "")
                {
                    ret = Utilities.TryParse(tbLevelOutDischargeTank.Text, "Int16", out obj);
                    if (ret)
                    {
                        LevelOutDischargeTank = (short)obj;
                    }
                }

                pbBreakAnalog.BackgroundImage = on_img;
                pbBreakAnalog.BackColor = Color.Transparent;
                pbBreakAnalog.BackgroundImageLayout = ImageLayout.Stretch;
            }

            if (!BreakPM)
            {
                tbV.Text = V.ToString();
                tbVab.Text = Vab.ToString();
                tbVbc.Text = Vbc.ToString();
                tbVca.Text = Vca.ToString();
                tbI.Text = I.ToString();
                tbIa.Text = Ia.ToString();
                tbIb.Text = Ib.ToString();
                tbIc.Text = Ic.ToString();
                tbP.Text = P.ToString();
                tbPF.Text = PF.ToString();
                tbTemperature.Text = Temperature.ToString();
                tbHumidity.Text = Humidity.ToString();

                pbBreakPM.BackgroundImage = off_img;
                pbBreakPM.BackColor = Color.Transparent;
                pbBreakPM.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                object obj;
                bool ret;
                if (tbV.Text != "")
                {
                    ret = Utilities.TryParse(tbV.Text, "Int32", out obj);
                    if (ret)
                    {
                        V = (int)obj;
                    }
                }

                if (tbVab.Text != "")
                {
                    ret = Utilities.TryParse(tbVab.Text, "Int32", out obj);
                    if (ret)
                    {
                        Vab = (int)obj;
                    }
                }

                if (tbVbc.Text != "")
                {
                    ret = Utilities.TryParse(tbVbc.Text, "Int32", out obj);
                    if (ret)
                    {
                        Vbc = (int)obj;
                    }
                }

                if (tbVca.Text != "")
                {
                    ret = Utilities.TryParse(tbVca.Text, "Int32", out obj);
                    if (ret)
                    {
                        Vca = (int)obj;
                    }
                }

                if (tbI.Text != "")
                {
                    ret = Utilities.TryParse(tbI.Text, "Int32", out obj);
                    if (ret)
                    {
                        I = (int)obj;
                    }
                }

                if (tbIa.Text != "")
                {
                    ret = Utilities.TryParse(tbIa.Text, "Int32", out obj);
                    if (ret)
                    {
                        Ia = (int)obj;
                    }
                }

                if (tbIb.Text != "")
                {
                    ret = Utilities.TryParse(tbIb.Text, "Int32", out obj);
                    if (ret)
                    {
                        Ib = (int)obj;
                    }
                }

                if (tbIc.Text != "")
                {
                    ret = Utilities.TryParse(tbIc.Text, "Int32", out obj);
                    if (ret)
                    {
                        Ic = (int)obj;
                    }
                }

                if (tbP.Text != "")
                {
                    ret = Utilities.TryParse(tbP.Text, "Int32", out obj);
                    if (ret)
                    {
                        P = (int)obj;
                    }
                }

                if (tbPF.Text != "")
                {
                    ret = Utilities.TryParse(tbPF.Text, "Int32", out obj);
                    if (ret)
                    {
                        PF = (int)obj;
                    }
                }

                if (tbTemperature.Text != "")
                {
                    ret = Utilities.TryParse(tbTemperature.Text, "Int16", out obj);
                    if (ret)
                    {
                        Temperature = (short)obj;
                    }
                }

                if (tbHumidity.Text != "")
                {
                    ret = Utilities.TryParse(tbHumidity.Text, "Int16", out obj);
                    if (ret)
                    {
                        Humidity = (short)obj;
                    }
                }
                pbBreakPM.BackgroundImage = on_img;
                pbBreakPM.BackColor = Color.Transparent;
                pbBreakPM.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }
    }
}
