using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using S7.Net;

namespace PumpStationSystem
{
    static class Program
    {
        public static SCADA MySCADA = null;
        public static Plc plc = null;

        public static Page_Pump Pump_1 = new Page_Pump();
        public static Page_Pump Pump_2 = new Page_Pump();
        public static Page_Pump Pump_3 = new Page_Pump();
        public static Page_Pump Pump_4 = new Page_Pump();
        public static Page_Raker Raker_1 = new Page_Raker();
        public static Page_Raker Raker_2 = new Page_Raker();
        public static Page_Raker Raker_3 = new Page_Raker();
        public static Page_Raker Raker_4 = new Page_Raker();
        public static Page_Conveyer Conveyer = new Page_Conveyer();
        public static Page_General General = new Page_General();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MySCADA = new SCADA();
            StartS7NetPlus();
            Run();
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            MainPagePumpStation PumpStation_Mainpage = new MainPagePumpStation();
            PumpStation_Mainpage.Parent = MySCADA;
            Application.Run(PumpStation_Mainpage);

            if (MySCADA != null)
                MySCADA.Liquidate();
        }

        public static void StartS7NetPlus()
        {
            MySCADA.S7NetPlus();
        }

        public static void Run()
        {
            Pump pump = null;
            Raker raker = null;
            Conveyer conveyer = null;
            General general = null;

            int i;
            for (i=0; i < MySCADA.Pumps.Count; i++)
            {
                pump = (Pump)MySCADA.Pumps[i];
                pump.Run();
            }

            for (i = 0; i < MySCADA.Rakers.Count; i++)
            {
                raker = (Raker)MySCADA.Rakers[i];
                raker.Run();
            }

            for (i = 0; i < MySCADA.Conveyers.Count; i++)
            {
                conveyer = (Conveyer)MySCADA.Conveyers[i];
                conveyer.Run();
            }
            for (i = 0; i < MySCADA.Generals.Count; i++)
            {
                general = (General)MySCADA.Generals[i];
                general.Run();
            }
        }
    }
}
