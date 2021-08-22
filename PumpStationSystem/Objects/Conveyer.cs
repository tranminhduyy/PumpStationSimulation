using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PumpStationSystem
{
    public class Conveyer
    {
        public bool Start;
        public bool Stop;
        public bool RunFeedback;
        public bool FaultVSD;
        public bool CMD;
        public short FaultVSDModbus;

        public Page_Conveyer Faceplate;

        public short DBNumber;
        Random rndInt;
        public string Name;

        public int Period;
        System.Timers.Timer MainTimer = null;
        Thread TaskThread;

        public SCADA Parent = null;

        public Conveyer(string name, short dbnumber, Page_Conveyer hmi)
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

        bool runfeedback;
        bool faultvsd;
        short faultvsdmodbus;
        string address;

        void TimerElapsed(object sender, System.Timers.ElapsedEventArgs e)
        {


            Faceplate.Start = Start;
            Faceplate.Stop = Stop;

            FaultVSD = Faceplate.FaultVSD;

            Faceplate.CMD = CMD;

                if (!Faceplate.Break)
                {
                    RunFeedback = CMD;
                    Faceplate.RunFeedback = RunFeedback;
                }
                else
                {
                    RunFeedback = Faceplate.RunFeedback;
                }

            FaultVSDModbus = Faceplate.FaultVSDModbus;
            

            lock (Parent.TheLock)
            {
               

                address = "DB" + (DBNumber).ToString() + ".DBX0.0";
                Start = (bool)Parent.plc.Read(address);
                address = "DB" + DBNumber.ToString() + ".DBX0.1";
                Stop = (bool)Parent.plc.Read(address);

                if (runfeedback != RunFeedback)
                {
                    address = "DB" + DBNumber.ToString() + ".DBX0.2";
                    Parent.plc.Write(address, RunFeedback);
                    runfeedback = RunFeedback;
                }
                if (faultvsd != FaultVSD)
                {
                    address = "DB" + DBNumber.ToString() + ".DBX0.3";
                    Parent.plc.Write(address, FaultVSD);
                    faultvsd = FaultVSD;
                }

                address = "DB" + DBNumber.ToString() + ".DBX0.4";
                CMD = (bool)Parent.plc.Read(address);

               
                if (faultvsdmodbus != FaultVSDModbus)
                {
                    address = "DB" + DBNumber.ToString() + ".DBW2.0";
                    Parent.plc.Write(address, FaultVSDModbus);
                    faultvsdmodbus = FaultVSDModbus;
                }
            }
        }
    }
}
