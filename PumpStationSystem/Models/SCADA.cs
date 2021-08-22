using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;
using S7.Net;
using System.Windows.Forms;

namespace PumpStationSystem
{
    public class SCADA
    {
        public System.Timers.Timer DeviceInterationTimer = null;
        public Object TheLock = null;
        public Plc plc = null;
        public ArrayList Pumps;
        public ArrayList Rakers;
        public ArrayList Conveyers;
        public ArrayList Generals;

        public SCADA()
        {
            TheLock = new Object();
            Pumps = new ArrayList();
            Rakers = new ArrayList();
            Conveyers = new ArrayList();
            Generals = new ArrayList();

            Pump Pump_1 = new Pump("Pump_1", 1, Program.Pump_1);
            Pump_1.Parent = this;
            Pumps.Add(Pump_1);

            Pump Pump_2 = new Pump("Pump_2", 2, Program.Pump_2);
            Pump_2.Parent = this;
            Pumps.Add(Pump_2);

            Pump Pump_3 = new Pump("Pump_3", 3, Program.Pump_3);
            Pump_3.Parent = this;
            Pumps.Add(Pump_3);

            Pump Pump_4 = new Pump("Pump_4", 4, Program.Pump_4);
            Pump_4.Parent = this;
            Pumps.Add(Pump_4);

            Raker Raker_1 = new Raker("Raker_1", 5, Program.Raker_1);
            Raker_1.Parent = this;
            Rakers.Add(Raker_1);

            Raker Raker_2 = new Raker("Raker_2", 6, Program.Raker_2);
            Raker_2.Parent = this;
            Rakers.Add(Raker_2);

            Raker Raker_3 = new Raker("Raker_3", 7, Program.Raker_3);
            Raker_3.Parent = this;
            Rakers.Add(Raker_3);

            Raker Raker_4 = new Raker("Raker_4", 8, Program.Raker_4);
            Raker_4.Parent = this;
            Rakers.Add(Raker_4);

            Conveyer Conveyer = new Conveyer("Conveyer", 9, Program.Conveyer);
            Conveyer.Parent = this;
            Conveyers.Add(Conveyer);

            General General = new General("General", 10, Program.General);
            General.Parent = this;
            Generals.Add(General);
            //Pump Pump_2 = new Pump("Pump_2", 2, Program.p)
            //DeviceInterationTimer = new System.Timers.Timer(100);
            //DeviceInterationTimer.AutoReset = true;
            //DeviceInterationTimer.Elapsed += new System.Timers.ElapsedEventHandler(DeviceInteraction);
            //DeviceInterationTimer.Start();
        }

        public void S7NetPlus()
        {
            plc = new Plc(CpuType.S71200, "192.168.10.5", 0, 1);
            try
            {
                plc.Open();
            }
            catch
            {
                ;
            }

            if (plc.IsConnected)
            {
                MessageBox.Show("Device Connected");
            }
            else
            {
                MessageBox.Show("Device Not Connected");
            }
        }

        public void Liquidate()
        {
            while (Pumps.Count > 0)
            {
                RemovePumpAt(0);
            }
            while (Rakers.Count > 0)
            {
                RemoveRakerAt(0);
            }
            while (Conveyers.Count > 0)
            {
                RemoveConveyerAt(0);
            }
            while (Generals.Count > 0)
            {
                RemoveGeneralAt(0);
            }
        }

        public bool RemovePumpAt(int index)
        {
            if (index >= Pumps.Count)
                return false;
            Pump obj = (Pump)Pumps[index];
            obj.Liquidate();
            Pumps.RemoveAt(index);
            return true;
        }

        public bool RemoveRakerAt(int index)
        {
            if (index >= Rakers.Count)
                return false;
            Raker obj = (Raker)Rakers[index];
            obj.Liquidate();
            Rakers.RemoveAt(index);
            return true;
        }

        public bool RemoveConveyerAt(int index)
        {
            if (index >= Conveyers.Count)
                return false;
            Conveyer obj = (Conveyer)Conveyers[index];
            obj.Liquidate();
            Conveyers.RemoveAt(index);
            return true;
        }

        public bool RemoveGeneralAt (int index)
        {
            if (index >= Generals.Count)
                return false;
            General obj = (General)Generals[index];
            obj.Liquidate();
            Generals.RemoveAt(index);
            return true;
        }


        public Pump FindPumps(string name)
        {
            int i;
            Pump pu = null;
            for (i = 0; i < Pumps.Count; i++)
            {
                Pump temp = (Pump)Pumps[i];
                if (temp.Name == name)
                {
                    pu = temp;
                    break;
                }
            }

            return pu;
        }

        public Raker FindRakers(string name)
        {
            int i;
            Raker rk = null;
            for (i = 0; i < Rakers.Count; i++)
            {
                Raker temp = (Raker)Rakers[i];
                if (temp.Name == name)
                {
                    rk = temp;
                    break;
                }
            }

            return rk;
        }

        public Conveyer FindConveyers(string name)
        {
            int i;
            Conveyer co = null;
            for (i = 0; i < Conveyers.Count; i++)
            {
                Conveyer temp = (Conveyer)Conveyers[i];
                if (temp.Name == name)
                {
                    co = temp;
                    break;
                }
            }

            return co;
        }

        public General FindGenerals(string name)
        {
            int i;
            General ge = null;
            for (i = 0; i < Generals.Count; i++)
            {
                General temp = (General)Generals[i];
                if (temp.Name == name)
                {
                    ge = temp;
                    break;
                }
            }

            return ge;
        }
    }
}
