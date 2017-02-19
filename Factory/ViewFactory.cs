using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sorted.Src.Interface;

namespace Sorted.Src.Factory
{
    public class ViewFactory
    {
        public static SortEditor FactoryMethod(int view)
        {
            SortEditor Result;

            switch (view) 
            {            
                case 1:
                     Result = new SortEditor();
                break;
                default:
                     Result = new SortEditor();
                break;
            }

            if (!(Result is IView)) throw new Exception("Factory method have to return a object.");
            return Result;
        }
    }
}
