using CleanCodeAssignments.NamingSolution.src.task1.thirdparty;

namespace CleanCodeAssignments.NamingSolution.src.task1
{
    public class CollectOrderService(ICollectionService collectionService, INotificationManager notificationManager) : IOrderService
    {
        private ICollectionService collectionService = collectionService ?? throw new ArgumentNullException(nameof(collectionService));
        private INotificationManager notificationManager = notificationManager ?? throw new ArgumentNullException(nameof(notificationManager));

        public void Submit(IOrder order)
        {
            if (collectionService.IsEligibleForCollection(order))
                notificationManager.NotifyCustomer(Message.ReadyForCollect, 4); // 4 - info notification level
            else
                notificationManager.NotifyCustomer(Message.ImpossibleToCollect, 1); // 1 - critical notification level
        }

        public void SetSer1(ICollectionService ser1)
        {
            collectionService = ser1;
        }

        public void SetSer2(INotificationManager ser2)
        {
            notificationManager = ser2;
        }
    }
}
