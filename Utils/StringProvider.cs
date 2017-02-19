using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted.Src.Utils
{
    class StringProvider
    {        
        // <summary>
        //  Read a unicode string of the file until the end, and return the total size
        // </summary>
        public static int CheckSize()
        {
            int pos = Sort.Position;

            int sz = 0;
            for (int i = 0; i < 255; i++)
            {
                byte[] buffer = Sort.reader.ReadBytes(2);
                if (buffer[0] == 00 && buffer[1] == 00)
                {
                    break;
                }
                else
                {
                    sz += 1;
                }
            }
            Sort.Position = pos;
            return sz;
        }
    }
}
