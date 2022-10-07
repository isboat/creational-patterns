namespace abstract_factory_creational_pattern
{
    public class VegiSupremePizzaFactory : AbstractPizzaFactory
    {
        public override AbstractPizza CreatePizza()
        {
            return new VegiSupremeFeastPizza
            {
                Description = "Onions, green and red peppers, sweetcorn, mushrooms, tomatoes. 202kcal, 848kJ / large slice / classic crust.",
                Toppings = new string[] { "Onions", "green and red peppers", "sweetcorn", "mushrooms", "tomatoes" },
                Name = "Vegi Supreme"
            };
        }
    }
}
