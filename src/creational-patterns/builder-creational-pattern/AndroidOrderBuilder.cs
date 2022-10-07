namespace builder_creational_pattern
{
    internal class AndroidOrderBuilder : OrderBuilder
    {
        public AndroidOrderBuilder()
        {
            this.order = new Order { Id = Guid.NewGuid(), OrderDateTime = DateTime.UtcNow, OrderNumber = 23 };
        }

        public override void BuildDeliveryAddress()
        {
            var androidAddress = AndroidAppService.GetCurrentUserAddress();
            order.DeliveryAddress = androidAddress;
        }

        public override void BuildOrders()
        {
            var androidOrders = AndroidAppService.GetCurrentUserOrders();
            this.order.Items = androidOrders;
        }

        public override void BuildUser()
        {
            this.order.UserDetails = AndroidAppService.GetCurrentUser();
        }
    }
}
