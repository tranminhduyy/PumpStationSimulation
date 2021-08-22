using System;
using System.Threading;
using System.Drawing;

namespace PumpStationSystem
{
    public class Utilities
    {
        public static void Convertto2Words(object val, string type, out ushort[] data)
        {
            byte[] valueConvert = null;
            switch (type)
            {
                case "Int32":
                    valueConvert = BitConverter.GetBytes(Convert.ToInt32(val));
                    break;
                case "UInt32":
                    valueConvert = BitConverter.GetBytes(Convert.ToUInt32(val));
                    break;
                case "Single":
                    valueConvert = BitConverter.GetBytes(Convert.ToSingle(val));
                    break;
            }

            data = new ushort[2];
            data[0] = BitConverter.ToUInt16(valueConvert, 0);
            data[1] = BitConverter.ToUInt16(valueConvert, 2);
        }

        public static void ConverttoWord(object val, string type, out ushort data)
        {
            byte[] valueConvert = null;
            switch (type)
            {
                case "Int16":
                    valueConvert = BitConverter.GetBytes(Convert.ToInt16(val));
                    break;
                case "UInt16":
                    valueConvert = BitConverter.GetBytes(Convert.ToInt32(val));
                    break;
            }

            data = BitConverter.ToUInt16(valueConvert, 0);
        }

        public static object ConverttoObject(ushort[] words, int nword, string type)
        {
            object retval = null;
            byte[] data0;
            byte[] data1;
            byte[] data = null;
            if (nword == 2)
            {
                data0 = BitConverter.GetBytes(words[0]);
                data1 = BitConverter.GetBytes(words[1]);
                data = new byte[] { data0[0], data0[1], data1[0], data1[1] };
            }
            if (nword == 1)
            {
                data0 = BitConverter.GetBytes(words[0]);
                data = new byte[] { data0[0], data0[1] };
            }

            switch (type)
            {
                case "Int16":
                    retval = (object)BitConverter.ToInt16(data, 0);
                    break;
                case "UInt16":
                    retval = (object)BitConverter.ToUInt16(data, 0);
                    break;
                case "Int32":
                    retval = (object)BitConverter.ToInt32(data, 0);
                    break;
                case "UInt32":
                    retval = (object)BitConverter.ToUInt32(data, 0);
                    break;
                case "Real":
                    retval = (object)BitConverter.ToSingle(data, 0);
                    break;
            }
            return retval;
        }


        public static bool TryParse(string input, string type, out object output)
        {
            output = null;
            bool retcode = false;
            switch (type)
            {
                case "Boolean":
                    bool btemp;
                    retcode = Boolean.TryParse(input, out btemp);
                    output = (object)btemp;
                    break;
                case "Int16":
                    short int16temp;
                    retcode = Int16.TryParse(input, out int16temp);
                    output = (object)int16temp;
                    break;
                case "UInt16":
                    ushort uint16temp;
                    retcode = UInt16.TryParse(input, out uint16temp);
                    output = (object)uint16temp;
                    break;
                case "Int32":
                    int int32temp;
                    retcode = Int32.TryParse(input, out int32temp);
                    output = (object)int32temp;
                    break;
                case "UInt32":
                    uint uint32temp;
                    retcode = UInt32.TryParse(input, out uint32temp);
                    output = (object)uint32temp;
                    break;
                case "Real":
                    float singletemp;
                    retcode = Single.TryParse(input, out singletemp);
                    output = (object)singletemp;
                    break;
                case "String":
                    output = (object)input;
                    retcode = true;
                    break;
                default:
                    retcode = false;
                    break;
            }

            return retcode;

        }
    }
}
