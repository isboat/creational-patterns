using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder_creational_pattern
{
    internal abstract class OrderBuilder
    {
        protected Order order;

        public Order GetOrder()
        {
            return order;
        }

        // Abstract build methods
        public abstract void BuildOrders();
        public abstract void BuildUser();
        public abstract void BuildDeliveryAddress();
    }
}
