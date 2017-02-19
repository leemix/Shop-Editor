using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted.Src.Interface
{
    public interface IItem
    {
        event Action<string, string> ItemToDataGrid;
        void Search();
        int dwTotalItem { get; }
        int dwGoodsID { get; }
        string szItemName { get; }
        string szItemDesc { get; }
    }
}
