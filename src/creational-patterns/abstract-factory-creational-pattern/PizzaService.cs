namespace abstract_factory_creational_pattern
{
    /// <summary>
    /// The 'Client' class 
    /// </summary>
    public class PizzaService
    {
        private readonly AbstractPizza _pizza;
        private readonly AbstractPizzaFactory _factory;

        // Constructor
        public PizzaService(AbstractPizzaFactory factory)
        {
            _factory = factory;
            _pizza = _factory.CreatePizza();
        }

        public void Process()
        {
            Console.WriteLine($"Preparing {_pizza.Name} pizza");

            for (int i = 5; i >= 1; i--)
            {
                Console.WriteLine($"Time remaining: {i}mins");
                Thread.Sleep(1000);
            }

            Console.WriteLine($"{_pizza.Name} pizza is ready");
        }
    }
}