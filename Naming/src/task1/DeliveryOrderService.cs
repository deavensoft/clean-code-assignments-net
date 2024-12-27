using CleanCodeAssignments.Naming.src.task1.thirdparty;
using System.Collections.Generic;

namespace CleanCodeAssignments.Naming.src.task1
{
    public class DeliveryOrderService(IDeliveryService deliveryService, IOrderFulfilmentService orderFulfilmentService) : IOrderService
    {
        private IDeliveryService mDeliveryService = deliveryService ?? throw new ArgumentNullException(nameof(deliveryService));
        private IOrderFulfilmentService mOrderFulfilmentService = orderFulfilmentService ?? throw new ArgumentNullException(nameof(orderFulfilmentService));

        public void SubmitOrder(IOrder pOrder)
        {
            if (mDeliveryService.IsDeliverable())
            {
                List<IProduct> products = pOrder.GetProducts();
                mOrderFulfilmentService.FulfilProducts(products);
            }
            else
            {
                throw new NotDeliverableOrderException();
            }
        }

        public void SetDeliveryService(IDeliveryService pDeliveryService)
        {
            mDeliveryService = pDeliveryService;
        }

        public void SetOrderFulfilmentService(IOrderFulfilmentService pOrderFulfilmentService)
        {
            mOrderFulfilmentService = pOrderFulfilmentService;
        }
    }
}
