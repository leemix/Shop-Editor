using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sorted.Src;

namespace Sorted.Src.Utils
{
    public static class ItemReader
    {
        public static int ReadInt(int offset)
        {
            int pos = Sort.Position;
            Sort.Position += offset;           
            Sort.Offset = Sort.reader.ReadBytes(3);
            int Result = Convert.ToInt32(Sort._Offset, 16);
            Sort.Position = pos;
            return Result;
        }

        public static bool ReadBool(int offset)
        {
            int pos = Sort.Position;
			Sort.Position += offset;
            Sort.Offset = Sort.reader.ReadBytes(1); 
            bool Result = Convert.ToBoolean(Sort._Offset);
            Sort.Position = pos;
            return Result;
        }

        public static string ReadUnicodeString(int offset)
        {
            int pos = Sort.Position;
            Sort.Position += offset;        
            int size = StringProvider.CheckSize();
            string Result = Encoding.Unicode.GetString(Sort.reader.ReadBytes(size * 2));
            Sort.Position = pos;
            return Result;
        }

        public static string ReadString(int offset)
        {
            int pos = Sort.Position;
			Sort.Position += offset;
            string Result = Sort.reader.ReadString();
            Sort.Position = pos;
            return Result;
        }
    }
}
