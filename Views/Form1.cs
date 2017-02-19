using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Sorted.Src;
using Sorted.Src.Interface;
using Sorted.Src.Factory;
using System.Threading;
using System.Diagnostics;

namespace Sorted
{
    public partial class SortEditor : Form, IView
    {
        private IItem item;

        public SortEditor()
        {
            InitializeComponent();
            item = ItemFactory.FactoryMethod();
            item.ItemToDataGrid += ItemListAdd;
        }

        private void ItemListAdd(string id, string title)
        {
            this.BeginInvoke((Action)(() =>
            {
                ItemList.Rows.Add(id, title);
            }));   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Sort.reader = new BinaryReader(File.Open("..\\..\\Src\\Assets\\Sort.stg", FileMode.Open), Encoding.ASCII);
            SearchTypeBox.SelectedIndex = 1;
            CharacterSearchBox.SelectedIndex = 0;
        }

        private void Start(object sender, EventArgs e)
        {
            Thread Iterator = new Thread(() => Sort.Iterator(this.item));
            Iterator.Start();
        }		
    }
}
