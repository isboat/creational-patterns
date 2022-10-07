namespace builder_creational_pattern
{
    internal class WebService
    {
        internal static User GetHttpCurrentUser()
        {
            return new User {  Id = Guid.NewGuid(), Name = "Smith Stevens"};
        }

        internal static Address RetrieveUserAddress()
        {
            return new Address {  DoorNumber = 2, Id = "2003459", Street = "Prowend Road"};
        }

        internal static IEnumerable<OrderItem> RetrieveExistingOrders()
        {
            var orders = new List<OrderItem>
            {
                new OrderItem { Id = Guid.NewGuid(), PackageCode = "webproduct-001-sku"}
            };
            return orders;
        }

        internal static string GetUserPostcode(string id)
        {
            return "GL2 TR4";
        }
    }
}
