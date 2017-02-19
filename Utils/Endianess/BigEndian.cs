using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted.Src.Utils.Endianess
{
    public static class BigEndian
    {
        public static Byte[] Convert(Byte[] Value)
        {
            Byte[] Convert = Value;
            Array.Reverse(Convert, 0, Convert.Length);
            return Convert;
        }
    }
}
