using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted.Src.Interface
{
    public interface IFactory
    {
        T FactoryMethod<T>();
    }
}
