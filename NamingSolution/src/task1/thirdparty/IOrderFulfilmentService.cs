using System.Collections.Generic;

namespace CleanCodeAssignments.NamingSolution.src.task1.thirdparty
{
    public interface IOrderFulfilmentService
    {
        void FulfilProducts(List<IProduct> products);
    }
}
