using CleanCodeAssignments.FunctionsSolution.Src.Task4.ThirdParty;

namespace CleanCodeAssignments.FunctionsSolution.Test.Task4.Stubs
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
