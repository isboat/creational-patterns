namespace builder_creational_pattern
{
    internal class WebOrderBuilder : OrderBuilder
    {
        public WebOrderBuilder()
        {
            this.order = new Order { Id = Guid.NewGuid(), OrderDateTime = DateTime.Now, OrderNumber = 12 };
        }
        public override void BuildDeliveryAddress()
        {
            var userAddress = WebService.RetrieveUserAddress();
            userAddress.Postcode = WebService.GetUserPostcode(userAddress.Id);

            order.DeliveryAddress = userAddress;
        }

        public override void BuildOrders()
        {
            var androidOrders = WebService.RetrieveExistingOrders();
            this.order.Items = androidOrders;
        }

        public override void BuildUser()
        {
            this.order.UserDetails = WebService.GetHttpCurrentUser();
        }
    }
}
