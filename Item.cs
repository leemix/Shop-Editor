using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sorted.Src.Utils;
using Sorted.Src.Factory;
using Sorted.Src.Interface;
using System.Windows.Forms;
using System.Globalization;

namespace Sorted.Src
{
    public class Item : IItem
    {
        public int searchType;
        public List<string> searchKey = new List<string>();
        public event Action<string, string> ItemToDataGrid;

        public int dwTotalItem
        {
            get
            {
                int pos = Sort.Position;
                Sort.Position = 0x0;
                int result = ItemReader.ReadInt(0);
                Sort.Position = pos;
                return result;
            }
        }

        public int dwGoodsID
        {
            get
            {
                return ItemReader.ReadInt((int)Sort.Offsets.dwGoodsID);
            }
        }

        public string szItemName
        {
            get
            {
                return ItemReader.ReadUnicodeString((int)Sort.Offsets.szItemName);
            }
        }

        public string szItemDesc
        {
            get
            {
                return ItemReader.ReadUnicodeString((int)Sort.Offsets.szItemDesc);
            }
        }

        enum GCITEM_KIND
        {
            GIK_NORMAL = 0x0,
            GIK_CERTIFICATE = 0x1,
            GIK_MAGIC_PAPER = 0x2,
            GIK_STRONG_ITEM = 0x3,
            GIK_STRONG_ITEM_NOT_STRONG = 0x4,
            GIK_PRINT_UID = 0x5,
            GIK_MISSION_SCROLL = 0x6,
            GIK_PET = 0x7,
            GIK_POINT_ITEM = 0x8,
            GIK_ENCHANT_ASIST_ITEM = 0x9,
            GIK_ENCHANT_ENABLE_ITEM = 0xA,
            GIK_ENCHANT_CORE = 0xB,
            GIK_RECIPE = 0xC,
            GIK_STUFF = 0xD,
            GIK_BOSS_RARE = 0xE,
            GIK_EQUIP = 0xF,
            GIK_EQUIP_RARE = 0x10,
            GIK_MISSION_STUFF = 0x11,
            GIK_SHORTCUT_SLOT = 0x12,
            GIK_TITLE_ITEM = 0x13,
            GIK_COUPLE_ITEM = 0x14,
            GIK_OPEN_UP_ITEM = 0x15,
            GIK_TREASUREBOX_ITEM = 0x16,
            GIK_MONSTER_CARD = 0x17,
            GIK_SELECT_LEVEL_ITEM = 0x18,
            GIK_COORDI_ITEM = 0x19,
            GIK_COORDI_PACKAGE7 = 0x1A,
            GIK_COORDI_PACKAGE15 = 0x1B,
            GIK_COORDIBOX = 0x1C,
            GIK_ITEM_KIND_NUM = 0x1D,
        };

        enum GCGAMEITEM
        {
            GCGI_NOTING = 0x0,
            GCGI_SLOW = 0x1,
            GCGI_HP = 0x2,
            GCGI_MP = 0x3,
            GCGI_HIGHJUMP = 0x4,
            GCGI_TRANSPARENCY = 0x5,
            GCGI_SUPER = 0x6,
            GCGI_REFLECTION = 0x7,
        };

        enum EMONEYTYPE
        {
            EMT_GAMEPOINT = 0x0,
            EMT_CASH = 0x1,
            EMT_CRYSTAL = 0x2,
            EMT_GEM = 0x3,
        };

        enum GCITEM_TYPE
        {
            GCIT_PERIOD = 0x0,
            GCIT_COUNT = 0x1,
        };

        enum EITEMATTRIBUTE
        {
            EIATTR_NONE = 0x0,
            EIATTR_FIRE = 0x1,
            EIATTR_ICE = 0x2,
            EIATTR_LIGHTNING = 0x3,
            EIATTR_DARKNESS = 0x4,
            EIATTR_WIND = 0x5,
            EIATTR_GP_SHOES_SHIELD = 0x6,
            EIATTR_CASH_SHOES_SHIELD = 0x7,
            EIATTR_SHINING = 0x8,
            EIATTR_LOVE = 0x9,
            EIATTR_ROSE = 0xA,
            EIATTR_DEATH = 0xB,
            EIATTR_TIME = 0xC,
            EIATTR_NECK_SIZE = 0x8,
        };

		public void Search()
		{
            this.ToDataGrid();
            switch (this.searchType)
            {
                default:
                    if (this.searchKey.Contains(this.szItemName)) this.ToDataGrid();
                    break;
            }
		}

        public void ToDataGrid()
    	{
            this.ItemToDataGrid(this.dwGoodsID.ToString(), this.szItemName); 
		}		
    }
}
