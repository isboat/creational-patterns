using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_factory_creational_pattern
{
    public class ChickenFeastPizzaFactory : AbstractPizzaFactory
    {
        public override AbstractPizza CreatePizza()
        {
            return new ChickenFeastPizza
            {
                Description = "Chicken, mushrooms, sweetcorn. 210kcal, 883kJ / large slice / classic crust.",
                Toppings = new string[] { "Chicken", "mushrooms", "sweetcorn" },
                Name = "Chicken Feast"
            };
        }
    }
}
