using CleanCodeAssignments.NamingSolution.src.task1.thirdparty;

namespace CleanCodeAssignments.NamingSolution.src.task1
{
    public class DeliveryOrderService(IDeliveryService deliveryService, IOrderFulfilmentService orderFulfilmentService) : IOrderService
    {
        private IDeliveryService deliveryService = deliveryService ?? throw new ArgumentNullException(nameof(deliveryService));
        private IOrderFulfilmentService orderFulfilmentService = orderFulfilmentService ?? throw new ArgumentNullException(nameof(orderFulfilmentService));

        public void Submit(IOrder order)
        {
            if (deliveryService.IsDeliverable())
            {
                List<IProduct> products = order.GetProducts();
                orderFulfilmentService.FulfilProducts(products);
            }
            else
            {
                throw new NotDeliverableOrderException();
            }
        }

        public void SetDeliveryService(IDeliveryService pDeliveryService)
        {
            deliveryService = pDeliveryService;
        }

        public void SetOrderFulfilmentService(IOrderFulfilmentService pOrderFulfilmentService)
        {
            orderFulfilmentService = pOrderFulfilmentService;
        }
    }
}
