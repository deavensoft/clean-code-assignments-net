using System.Collections.Generic;

namespace CleanCodeAssignments.Naming.src.task1.thirdparty
{
    public interface IOrderFulfilmentService
    {
        void FulfilProducts(List<IProduct> products);
    }
}
