using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder_creational_pattern
{
    internal class AndroidAppService
    {
        internal static User GetCurrentUser()
        {
            return new User { Id = Guid.NewGuid(), Name = "John Doe"};
        }

        internal static Address GetCurrentUserAddress()
        {
            return new Address {  Id = "200101", DoorNumber = 15, Postcode = "WC23 2WD", Street = "Thomas street"};
        }

        internal static IEnumerable<OrderItem> GetCurrentUserOrders()
        {
            var orders = new List<OrderItem>
            {
                new OrderItem { Id = Guid.NewGuid(), PackageCode = "android-package-sku--001"},
                new OrderItem { Id = Guid.NewGuid(), PackageCode = "android-package-sku--002"}
            };
            return orders;
        }
    }
}
