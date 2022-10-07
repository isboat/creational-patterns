using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype_creational_pattern
{
    public interface IPrototype<TType>
    {
        TType Clone();
    }
}
