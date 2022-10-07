using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder_creational_pattern
{
    public class Order
    {
        public Guid Id { get; set; }

        public DateTime OrderDateTime { get; set; }

        public int OrderNumber { get; set; }

        public IEnumerable<OrderItem> Items { get; set; }

        public Address DeliveryAddress { get; set; }

        public User UserDetails { get; set; }
    }

    public class Address
    {
        public int DoorNumber { get; set; }
        public string Street { get; set; }
        public string Postcode { get; set; }
        public string Id { get; internal set; }
    }

    public class User
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }

    public class OrderItem
    {
        public Guid Id { get; set; }

        public string PackageCode { get; set; }
    }
}
