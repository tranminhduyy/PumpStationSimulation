using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PumpStationSystem
{
    public class Pump
    {
        public bool MCCB;
        public bool Start;
        public bool Stop;
        public bool EmergencyStop;
        public bool RunFeedback;
        public bool OutletValve;
        public bool DoorOpenedClosed;
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

        public Page_Pump Faceplate;

        public short DBNumber;
        Random rndInt;
        public string Name;

        public int Period;
        System.Timers.Timer MainTimer = null;
        Thread TaskThread;

        public SCADA Parent = null;

        public Pump(string name, short dbnumber, Page_Pump hmi)
        {
            Name = name;
            DBNumber = dbnumber;
            rndInt = new Random();
            Period = 100;
            Faceplate = hmi;
        }

        public void Liquidate()
        {
            StopTimer();
        }

        public void StopTimer()      // Dừng hẳn Task
        {
            if (MainTimer != null)
            {
                MainTimer.Dispose();
                MainTimer = null;
            }
        }

        public void Run()
        {
            TaskThread = new Thread(ThreadRun);
            TaskThread.Priority = ThreadPriority.Normal;
            TaskThread.Start();
        }

        void ThreadRun()        // Chạy Task
        {
            if (MainTimer == null)
            {
                MainTimer = new System.Timers.Timer(Period);
                MainTimer.AutoReset = true;
                MainTimer.Elapsed += new System.Timers.ElapsedEventHandler(TimerElapsed);
                MainTimer.Start();
            }
        }

        bool mccb;
        bool emergencystop;
        bool runfeedback;
        bool outletvalve;
        bool dooropenedclosed;
        bool faultsoftstarter;
        bool overheatedcoil;
        bool overheatedbearingabove;
        bool overheatedbearingbelow;
        bool humidityinelectrical;
        bool humidityinmotorchamber;
        bool humidityinoilchamber;
        short vibration;
        short levelinpumpchamber;

        string address;
        short timefaultsoftstarter;
        int pumpvibration;
        int pumplevelpumpchamber;

        void TimerElapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            MCCB = Faceplate.MCCB;

            Faceplate.Start = Start;
            Faceplate.Stop = Stop;

            EmergencyStop = Faceplate.EmergencyStop;

            DoorOpenedClosed = Faceplate.DoorOpenedClosed;

            OverheatedCoil = Faceplate.OverheatedCoil;
            OverheatedBearingAbove = Faceplate.OverheatedBearingAbove;
            OverheatedBearingBelow = Faceplate.OverheatedBearingBelow;
            HumidityInElectrical = Faceplate.HumidityInElectrical;
            HumidityInMotorChamber = Faceplate.HumidityInMotorChamber;
            HumidityInOilChamber = Faceplate.HumidityInOilChamber;

            Faceplate.CMD = CMD;
            if (!EmergencyStop)
            {
                    if (!Faceplate.Break)
                    {
                        RunFeedback = CMD;
                        OutletValve = CMD;

                        Faceplate.RunFeedback = RunFeedback;
                        Faceplate.OutletValve = OutletValve;               
                    }
                    else
                    {
                        RunFeedback = Faceplate.RunFeedback;
                        OutletValve = Faceplate.OutletValve;                       
                    }               
            }
            else
            {
                RunFeedback = false;
                OutletValve = false;
                FaultSoftstarter = false;
                Faceplate.RunFeedback = RunFeedback;
                Faceplate.OutletValve = OutletValve;
                Faceplate.FaultSoftstarter = FaultSoftstarter;
            }

            if (RunFeedback)
            {
                pumpvibration += 200 + rndInt.Next(0, 10);
                if (pumpvibration >= 13000)
                    pumpvibration = 13000 + rndInt.Next(0, 200);
                Vibration = Convert.ToInt16(pumpvibration);
                Faceplate.Vibration = Vibration;
            }
            else
            {
                pumpvibration -= (200 + rndInt.Next(0, 10));
                if (pumpvibration <= 0)
                    pumpvibration = 0;
                Vibration = Convert.ToInt16(pumpvibration);
                Faceplate.Vibration = Vibration;
            }

            Faceplate.LevelInPumpChamber = LevelInPumpChamber;

            if (CMD && !RunFeedback)
            {
                timefaultsoftstarter += 100;
                if (timefaultsoftstarter >= 10000)
                {
                    FaultSoftstarter = true;
                    Faceplate.FaultSoftstarter = FaultSoftstarter;
                    timefaultsoftstarter = 0;
                }
            }
            else
            {
                FaultSoftstarter = false;
                Faceplate.FaultSoftstarter = FaultSoftstarter;
            }



            

            lock (Parent.TheLock)
            {
                
                if (mccb != MCCB)
                {
                    address = "DB" + DBNumber.ToString() + ".DBX0.0";
                    Parent.plc.Write(address, MCCB);
                    mccb = MCCB;
                }

                address = "DB" + (DBNumber).ToString() + ".DBX0.1";
                Start = (bool)Parent.plc.Read(address);
                address = "DB" + DBNumber.ToString() + ".DBX0.2";
                Stop = (bool)Parent.plc.Read(address);

                if (emergencystop != EmergencyStop)
                {
                    address = "DB" + DBNumber.ToString() + ".DBX0.3";
                    Parent.plc.Write(address, EmergencyStop);
                    emergencystop = EmergencyStop;
                }
                if (runfeedback != RunFeedback)
                {
                    address = "DB" + DBNumber.ToString() + ".DBX0.4";
                    Parent.plc.Write(address, RunFeedback);
                    runfeedback = RunFeedback;
                }
                if (outletvalve != OutletValve)
                {
                    address = "DB" + DBNumber.ToString() + ".DBX0.5";
                    Parent.plc.Write(address, OutletValve);
                    outletvalve = OutletValve;
                }
                if (dooropenedclosed != DoorOpenedClosed)
                {
                    address = "DB" + DBNumber.ToString() + ".DBX0.6";
                    Parent.plc.Write(address, DoorOpenedClosed);
                    dooropenedclosed = DoorOpenedClosed;
                }
                
                if (faultsoftstarter != FaultSoftstarter)
                {
                    address = "DB" + DBNumber.ToString() + ".DBX0.7";
                    Parent.plc.Write(address, FaultSoftstarter);
                    faultsoftstarter = FaultSoftstarter;
                }
                if (overheatedcoil != OverheatedCoil)
                {
                    address = "DB" + DBNumber.ToString() + ".DBX1.0";
                    Parent.plc.Write(address, OverheatedCoil);
                    overheatedcoil = OverheatedCoil;
                }
                if (overheatedbearingabove != OverheatedBearingAbove)
                {
                    address = "DB" + DBNumber.ToString() + ".DBX1.1";
                    Parent.plc.Write(address, OverheatedBearingAbove);
                    overheatedbearingabove = OverheatedBearingAbove;
                }
                if (overheatedbearingbelow != OverheatedBearingBelow)
                {
                    address = "DB" + DBNumber.ToString() + ".DBX1.2";
                    Parent.plc.Write(address, OverheatedBearingBelow);
                    overheatedbearingbelow = OverheatedBearingBelow;
                }
                if (humidityinelectrical != HumidityInElectrical)
                {
                    address = "DB" + DBNumber.ToString() + ".DBX1.3";
                    Parent.plc.Write(address, HumidityInElectrical);
                    humidityinelectrical = HumidityInElectrical;
                }
                if (humidityinmotorchamber != HumidityInMotorChamber)
                {
                    address = "DB" + DBNumber.ToString() + ".DBX1.4";
                    Parent.plc.Write(address, HumidityInMotorChamber);
                    humidityinmotorchamber = HumidityInMotorChamber;
                }
                if (humidityinoilchamber != HumidityInOilChamber)
                {
                    address = "DB" + DBNumber.ToString() + ".DBX1.5";
                    Parent.plc.Write(address, HumidityInOilChamber);
                    humidityinoilchamber = HumidityInOilChamber;
                }

                address = "DB" + DBNumber.ToString() + ".DBX1.6";
                CMD = (bool)Parent.plc.Read(address);

                if (vibration != Vibration)
                {
                    address = "DB" + DBNumber.ToString() + ".DBW2.0";
                    Parent.plc.Write(address, Vibration);
                    vibration = Vibration;
                }
                if (levelinpumpchamber != LevelInPumpChamber)
                {
                    address = "DB" + DBNumber.ToString() + ".DBW4.0";
                    Parent.plc.Write(address, LevelInPumpChamber);
                    levelinpumpchamber = LevelInPumpChamber;
                }
                
            }
        }
    }
}
