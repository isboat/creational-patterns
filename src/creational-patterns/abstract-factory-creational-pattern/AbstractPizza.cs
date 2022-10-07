using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_factory_creational_pattern
{
    public abstract class AbstractPizza
    {
        public abstract string Name { get; set; }
        public abstract string Description { get; set; }

        public abstract string[] Toppings { get; set; }

    }
}
