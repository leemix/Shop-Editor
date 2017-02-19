using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sorted.Src.Interface;

namespace Sorted.Src.Factory
{
    public class DBFactory
    {
        public DataBase FactoryMethod()
        {
            DataBase Result = new DataBase();

            if (!(Result is IDataBase)) throw new Exception("Factory method have to return a object.");
            return Result;
        }
    }
}
