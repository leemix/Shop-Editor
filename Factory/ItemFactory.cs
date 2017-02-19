using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sorted.Src.Interface;
using Sorted.Src;

namespace Sorted.Src.Factory
{
    public class ItemFactory
    {
        public static IItem FactoryMethod()
        {
            IItem Result = new Item();

            if (!(Result is IItem)) throw new Exception("Factory method have to return a object.");
            return Result;
        }
    }
}
