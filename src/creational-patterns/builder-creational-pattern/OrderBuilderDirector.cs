using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder_creational_pattern
{
    internal class OrderBuilderDirector
    {
        // Builder uses a complex series of steps
        public void Construct(OrderBuilder orderBuilder)
        {
            orderBuilder.BuildUser();
            orderBuilder.BuildOrders();
            orderBuilder.BuildDeliveryAddress();
        }
    }
}
