namespace abstract_factory_creational_pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to STC pizza service!");
            Console.WriteLine();
            Console.WriteLine("Select a pizza");
            Console.WriteLine("1 for chicken feast");
            Console.WriteLine("2 for vegi supreme");
            Console.WriteLine("Any other key to exist service");

            // Abstract factory #1
            AbstractPizzaFactory chickenFeastfactory = new ChickenFeastPizzaFactory();

            // Abstract factory #2
            AbstractPizzaFactory vegiSupremefactory = new VegiSupremePizzaFactory();

            while (true)
            {
                PizzaService pizzaService = null;

                var key = Console.ReadLine();
                if (key == "1")
                {
                    pizzaService = new PizzaService(chickenFeastfactory);
                }
                else if (key == "2")
                {
                    pizzaService = new PizzaService(vegiSupremefactory);
                }
                else
                {
                    break;
                }

                pizzaService.Process();
            }
        }
    }
}