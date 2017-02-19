using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Sorted.Src.Interface
{
    public interface IDataBase
    {
        void LoadSettings(XmlReader xml);
        void SaveItem(DataGridView ItemList);
        void Connect();
        void Save(IDictionary data, string[] values);
        void Update(string table, IList list);
    }
}
