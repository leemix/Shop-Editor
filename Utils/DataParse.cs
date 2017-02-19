using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted.Src.Utils
{
    public static class DataParse
    {
        public static string ParseToHex(byte[] Value)
        {
            string hexOffset = BitConverter.ToString(Value);
            String hexValue = "0x";
            hexValue += hexOffset;
            hexValue = hexValue.Replace("-", string.Empty);
            return hexValue;
        }
    }
}
