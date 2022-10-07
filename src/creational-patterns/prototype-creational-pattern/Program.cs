using Newtonsoft.Json;

namespace prototype_creational_pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var x5Model = new Product
            {
                Name = "BMW X5",
                Type = ProductType.XRange
            };
                        
            var x6Model = x5Model.Clone();
            x6Model.Name = "BMW X6";


            Console.WriteLine($"x5: {JsonConvert.SerializeObject(x5Model)}");
            Console.WriteLine("");
            Console.WriteLine(""); 
            Console.WriteLine($"x6: {JsonConvert.SerializeObject(x6Model)}");
        }
    }
}