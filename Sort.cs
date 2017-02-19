using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Sorted.Src.Interface;
using Sorted.Src.Utils;
using Sorted.Src.Utils.Endianess;
using Sorted.Src.Factory;
using System.Windows.Forms;

namespace Sorted.Src
{
    public static class Sort
    {
        public static BinaryReader reader { get; set; }
        public static BinaryWriter writter { get; set; }
        private static int _Position;
        public static string _Offset;
        public static int Position
        { 
		    get
			{
				return _Position;
			}
			set
			{
                _Position = value;
				reader.BaseStream.Position = _Position;
			}
		}

        private static int Index { get; set; }

        public static byte[] Offset
        { 
            set 
			{
                byte[] byteOffset = BigEndian.Convert(value);
                _Offset = DataParse.ParseToHex(byteOffset);
			}
        }

        public enum Offsets
        {
            dwGoodsID = 0x0,
            szItemName = 0x4,
            szItemDesc = 0x68,
            FIRST_ITEM_OFFSET = 0x8,
            NEXT_ITEM_OFFSET = 0x3A7,            
        };

        public static void Iterator(IItem item)
		{
            for (int i = (int)Offsets.FIRST_ITEM_OFFSET; i < reader.BaseStream.Length - 0x3AB; i += (int)Offsets.NEXT_ITEM_OFFSET)
            {
                Position = i;
                item.Search();
                if (item.dwGoodsID > item.dwTotalItem) break;
			}		 
		}

        public static string GetPosition()
		{
			return Position.ToString("x");
		}
    }
}
