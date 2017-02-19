using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted
{
    public class Pet
    {
        enum EPET_ITEM_KIND
        {
            EPET_KIND_INVALID = 0x0,
            EPET_KIND_PET = 0x1,
            EPET_KIND_FOOD = 0x2,
            EPET_KIND_EQUIP_ITEM = 0x4,
        };

        enum EPET_EQUIP_ITEM_ATTRIBUTE
        {
            EPET_ATTR_INVALID = 0x0,
            EPET_ATTR_LIGHT = 0x1,
            EPET_ATTR_DARK = 0x2,
            EPET_ATTR_PHYSICAL = 0x4,
            EPET_ATTR_MAGIC = 0x8,
            EPET_ATTR_ICE = 0x10,
            EPET_ATTR_TEMP1 = 0x20,
            EPET_ATTR_TEMP2 = 0x40,
            EPET_ATTR_TEMP3 = 0x80,
        };
    }
}
