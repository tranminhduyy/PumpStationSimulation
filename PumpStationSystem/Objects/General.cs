using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PumpStationSystem
{
    public class General
    {

        public bool FaultACB;

        public bool EmergencyStopPLC;
        public bool EmergencyStopACB;
        public bool EmergencyStopCR;
        public bool DoorOpenedClosedACB;
        public bool DoorOpenedClosedPLC;
        public bool DoorOpenedClosedCR;
        public bool LockACB;
        public bool AlarmACB;
        public bool EmptySuctionTank;
        public bool GlobalInterlock;
        public short LevelInSuctionTank = 27000;
        public short LevelOutDischargeTank = 0;
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

        public Page_General Faceplate;

        public short DBNumber;
        Random rndInt;
        public string Name;

        public int Period;
        System.Timers.Timer MainTimer = null;
        Thread TaskThread;

        public SCADA Parent = null;

        public General(string name, short dbnumber, Page_General hmi)
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

        bool faultacb;

        bool emergencystopplc;
        bool emergencystopacb;
        bool emergencystopcr;
        bool dooropenedclosedacb;
        bool dooropenedclosedplc;
        bool dooropenedclosedcr;
        bool lockacb;
        bool alarmacb;
        bool emptysuctiontank;
        bool globalinterlock;
        short levelinsuctiontank;
        short leveloutdischargetank;
        int v;
        int vab;
        int vbc;
        int vca;
        int i;
        int ia;
        int ib;
        int ic;
        int p;
        int pf;
        short temperature;
        short humidity;
        string address;

        void TimerElapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
 
            FaultACB = Faceplate.FaultACB;
       
            EmergencyStopPLC = Faceplate.EmergencyStopPLC;
            EmergencyStopACB = Faceplate.EmergencyStopACB;
            EmergencyStopCR = Faceplate.EmergencyStopCR;
            DoorOpenedClosedACB = Faceplate.DoorOpenedClosedACB;
            DoorOpenedClosedPLC = Faceplate.DoorOpenedClosedPLC;
            DoorOpenedClosedCR = Faceplate.DoorOpenedClosedCR;

            Faceplate.LockACB = LockACB;
            Faceplate.AlarmACB = AlarmACB;

            Faceplate.GlobalInterlock = GlobalInterlock;

            if (!Faceplate.BreakAnalog)
            {
                Faceplate.LevelInSuctionTank = LevelInSuctionTank;
                Faceplate.LevelOutDischargeTank = LevelOutDischargeTank;
            }
            else
            {
                LevelInSuctionTank = Faceplate.LevelInSuctionTank;
                LevelOutDischargeTank = Faceplate.LevelOutDischargeTank;
            }
            if (LevelInSuctionTank == 0)
            {
                EmptySuctionTank = true;
            }
            else
            {
                EmptySuctionTank = false;
            }
            Faceplate.EmptySuctionTank = EmptySuctionTank;


            if (!Faceplate.BreakPM)
            {
                V = (int)(380 + (rndInt.Next(-10, 10)));
                Vab = (int)(380 + (rndInt.Next(-10, 10)));
                Vbc = (int)(380 + (rndInt.Next(-10, 10)));
                Vca = (int)(380 + (rndInt.Next(-10, 10)));
                I = (int)((10 + (float)(rndInt.Next(-5, 5) / 10.0)) * 1000);
                Ia = (int)((10 + (float)(rndInt.Next(-5, 5) / 10.0)) * 1000);
                Ib = (int)((10 + (float)(rndInt.Next(-5, 5) / 10.0)) * 1000);
                Ic = (int)((10 + (float)(rndInt.Next(-5, 5) / 10.0)) * 1000);
                PF = Convert.ToInt32(((float)(Math.Cos(Math.PI / 3)) + (float)(rndInt.Next(-5, 5) / 100.0)) * 1000);
                P = Convert.ToInt32((float)((Math.Sqrt(3) * V * I * PF)) / 10000000);
                Temperature = Convert.ToInt16((float)(50 + rndInt.Next(-100, 100) / 100.0) *100);
                Humidity = Convert.ToInt16((float)(50 + rndInt.Next(-100, 100) / 100.0) * 100);

                Faceplate.V = V;
                Faceplate.Vab = Vab;
                Faceplate.Vbc = Vbc;
                Faceplate.Vca = Vca;
                Faceplate.I = I;
                Faceplate.Ia = Ia;
                Faceplate.Ib = Ib;
                Faceplate.Ic = Ic;
                Faceplate.PF = PF;
                Faceplate.P = P;
                Faceplate.Temperature = Temperature;
                Faceplate.Humidity = Humidity;
            }
            else
            {
                V = Faceplate.V;
                Vab = Faceplate.Vab;
                Vbc = Faceplate.Vbc;
                Vca = Faceplate.Vca;
                I = Faceplate.I;
                Ia = Faceplate.Ia;
                Ib = Faceplate.Ib;
                Ic = Faceplate.Ic;
                P = Faceplate.P;
                PF = Faceplate.PF;
                Temperature = Faceplate.Temperature;
                Humidity = Faceplate.Humidity;
            }

            lock (Parent.TheLock)
            {
               
                if (faultacb != FaultACB)
                {
                    address = "DB" + DBNumber.ToString() + ".DBX0.0";
                    Parent.plc.Write(address, FaultACB);
                    faultacb = FaultACB;
                }
                
                if (emergencystopplc != EmergencyStopPLC)
                {
                    address = "DB" + DBNumber.ToString() + ".DBX0.1";
                    Parent.plc.Write(address, EmergencyStopPLC);
                    emergencystopplc = EmergencyStopPLC;
                }
                if (emergencystopacb != EmergencyStopACB)
                {
                    address = "DB" + DBNumber.ToString() + ".DBX0.2";
                    Parent.plc.Write(address, EmergencyStopACB);
                    emergencystopacb = EmergencyStopACB;
                }
                if (emergencystopcr != EmergencyStopCR)
                {
                    address = "DB" + DBNumber.ToString() + ".DBX0.3";
                    Parent.plc.Write(address, EmergencyStopCR);
                    emergencystopcr = EmergencyStopCR;
                }
                if (dooropenedclosedacb != DoorOpenedClosedACB)
                {
                    address = "DB" + DBNumber.ToString() + ".DBX0.4";
                    Parent.plc.Write(address, DoorOpenedClosedACB);
                    dooropenedclosedacb = DoorOpenedClosedACB;
                }
                if (dooropenedclosedplc != DoorOpenedClosedPLC)
                {
                    address = "DB" + DBNumber.ToString() + ".DBX0.5";
                    Parent.plc.Write(address, DoorOpenedClosedPLC);
                    dooropenedclosedplc = DoorOpenedClosedPLC;
                }
                if (dooropenedclosedcr != DoorOpenedClosedCR)
                {
                    address = "DB" + DBNumber.ToString() + ".DBX0.6";
                    Parent.plc.Write(address, DoorOpenedClosedCR);
                    dooropenedclosedcr = DoorOpenedClosedCR;
                }

                address = "DB" + (DBNumber).ToString() + ".DBX0.7";
                LockACB = (bool)Parent.plc.Read(address);
                address = "DB" + DBNumber.ToString() + ".DBX1.0";
                AlarmACB = (bool)Parent.plc.Read(address);

                if (emptysuctiontank != EmptySuctionTank)
                {
                    address = "DB" + DBNumber.ToString() + ".DBX1.1";
                    Parent.plc.Write(address, EmptySuctionTank);
                    emptysuctiontank = EmptySuctionTank;
                }

                address = "DB" + DBNumber.ToString() + ".DBX1.2";
                GlobalInterlock = (bool)Parent.plc.Read(address);

                if (levelinsuctiontank != LevelInSuctionTank)
                {
                    address = "DB" + DBNumber.ToString() + ".DBW2.0";
                    Parent.plc.Write(address, LevelInSuctionTank);
                    levelinsuctiontank = LevelInSuctionTank;
                }
                if (leveloutdischargetank != LevelOutDischargeTank)
                {
                    address = "DB" + DBNumber.ToString() + ".DBW4.0";
                    Parent.plc.Write(address, LevelOutDischargeTank);
                    leveloutdischargetank = LevelOutDischargeTank;
                }
                if (v != V)
                {
                    address = "DB" + DBNumber.ToString() + ".DBD6.0";
                    Parent.plc.Write(address, V);
                    v = V;
                }
                if (vab != Vab)
                {
                    address = "DB" + DBNumber.ToString() + ".DBD10.0";
                    Parent.plc.Write(address, Vab);
                    vab = Vab;
                }
                if (vbc != Vbc)
                {
                    address = "DB" + DBNumber.ToString() + ".DBD14.0";
                    Parent.plc.Write(address, Vbc);
                    vbc = Vbc;
                }
                if (vca != Vca)
                {
                    address = "DB" + DBNumber.ToString() + ".DBD18.0";
                    Parent.plc.Write(address, Vca);
                    vca = Vca;
                }
                if (i != I)
                {
                    address = "DB" + DBNumber.ToString() + ".DBD22.0";
                    Parent.plc.Write(address, I);
                    i = I;
                }
                if (ia != Ia)
                {
                    address = "DB" + DBNumber.ToString() + ".DBD26.0";
                    Parent.plc.Write(address, Ia);
                    ia = Ia;
                }
                if (ib != Ib)
                {
                    address = "DB" + DBNumber.ToString() + ".DBD30.0";
                    Parent.plc.Write(address, Ib);
                    ib = Ib;
                }
                if (ic != Ic)
                {
                    address = "DB" + DBNumber.ToString() + ".DBD34.0";
                    Parent.plc.Write(address, Ic);
                    ic = Ic;
                }
                if (p != P)
                {
                    address = "DB" + DBNumber.ToString() + ".DBD38.0";
                    Parent.plc.Write(address, P);
                    p = P;
                }
                if (pf != PF)
                {
                    address = "DB" + DBNumber.ToString() + ".DBD42.0";
                    Parent.plc.Write(address, PF);
                    pf = PF;
                }
                if (temperature != Temperature)
                {
                    address = "DB" + DBNumber.ToString() + ".DBW46.0";
                    Parent.plc.Write(address, Temperature);
                    temperature = Temperature;
                }
                if (humidity != Humidity)
                {
                    address = "DB" + DBNumber.ToString() + ".DBW48.0";
                    Parent.plc.Write(address, Humidity);
                    humidity = Humidity;
                }
            }
        }
    }
}
