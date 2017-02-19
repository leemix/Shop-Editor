using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted.Src
{
    static class Characters
    {
        public enum CharType
		{
			Elesis = 0,
            Lire,
            Arme,
            Lass,
            Ryan,
            Ronan,
            Amy,
            Jin,
            Sieghart,
            Mari,
            Dio,
            Zero,
            Rey,
            Lupus,
            Lin,
            Azin,
            Holy,
            Edel,
            Veigas,
            Uno,
		};

        public static IDictionary<int, string> ECHARTYPE = new Dictionary<int, string>
		{
			{ 0x1, "Elesis" },
			{ 0x2, "Lire" },
			{ 0x4, "Arme" },
			{ 0x8, "Lass" },
            { 0x10, "Ryan" },
            { 0x20, "Ronan" },
            { 0x40, "Amy" },
            { 0x80, "Jin" },
            { 0x100, "Sieghart" },
            { 0x200, "Mari" },
            { 0x400, "Dio" },
            { 0x800, "Zero" },
            { 0x1000, "Ley" },
            { 0x1FFF, "ECT_ALL" },
		};
    }
}
