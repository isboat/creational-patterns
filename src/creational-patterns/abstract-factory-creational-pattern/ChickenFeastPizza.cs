using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_factory_creational_pattern
{
    public class ChickenFeastPizza : AbstractPizza
    {
        public override string Name { get; set; }

        public override string Description { get; set; }

        public override string[] Toppings { get; set; }
    }
}
