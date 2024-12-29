using CleanCodeAssignments.Functions.Src.Task4.ThirdParty;

namespace CleanCodeAssignments.Functions.Test.Task4.Stubs
{
    public abstract class AbstractProductStub : IProduct
    {
        public double GetProductPrice()
        {
            return 10;
        }

        public abstract bool IsAvailable();
    }
}
