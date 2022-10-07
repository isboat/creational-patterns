using Newtonsoft.Json;

namespace builder_creational_pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            ProcessDailyOrders();
        }

        static void ProcessDailyOrders()
        {
            var builderDirector = new OrderBuilderDirector();
            OrderBuilder builder;

            //1. Web order
            builder = new WebOrderBuilder();
            builderDirector.Construct(builder);
            var webOrder = builder.GetOrder();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("WEB ORDER");
            PrintOrder(webOrder);

            // 2. Android order
            builder = new AndroidOrderBuilder();
            builderDirector.Construct(builder);
            var andOrder = builder.GetOrder();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("ANDROID ORDER");
            PrintOrder(andOrder);







            Console.ForegroundColor = ConsoleColor.White;
        }

        static void PrintOrder(Order order)
        {
            Console.WriteLine($"OrderId: {order.Id}");
            Console.WriteLine($"OrderNumber: {order.OrderNumber}");
            Console.WriteLine($"Order datetime: {order.OrderDateTime}");
            Console.WriteLine($"Delivery address: {order.DeliveryAddress.DoorNumber} {order.DeliveryAddress.Street}, {order.DeliveryAddress.Postcode}");
            Console.WriteLine($"User: {order.UserDetails.Name}");
            Console.WriteLine("----- Ordered items : BEGIN  -----");
            foreach (var item in order.Items)
            {
                Console.WriteLine($"{item.Id} - {item.PackageCode}");
            }
            Console.WriteLine("----- Ordered items : END  -----");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}