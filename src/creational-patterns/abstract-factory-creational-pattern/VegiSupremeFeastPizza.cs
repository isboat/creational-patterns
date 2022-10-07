namespace abstract_factory_creational_pattern
{
    public class VegiSupremeFeastPizza : AbstractPizza
    {
        public override string Name { get; set; }

        public override string Description { get; set; }

        public override string[] Toppings { get; set; }
    }
}
