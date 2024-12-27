using CleanCodeAssignments.Naming.src.task1.thirdparty;

namespace CleanCodeAssignments.Naming.src.task1
{
    public class CollectOrderService(ICollectionService ser1, INotificationManager ser2) : IOrderService
    {
        private ICollectionService ser1 = ser1 ?? throw new ArgumentNullException(nameof(ser1));
        private INotificationManager ser2 = ser2 ?? throw new ArgumentNullException(nameof(ser2));

        public void SubmitOrder(IOrder pOrder)
        {
            if (ser1.IsEligibleForCollection(pOrder))
                ser2.NotifyCustomer(Message.ReadyForCollect, 4); // 4 - info notification level
            else
                ser2.NotifyCustomer(Message.ImpossibleToCollect, 1); // 1 - critical notification level
        }

        public void SetSer1(ICollectionService ser1)
        {
            this.ser1 = ser1;
        }

        public void SetSer2(INotificationManager ser2)
        {
            this.ser2 = ser2;
        }
    }
}
