using CleanCodeAssignments.Functions.Src.Task4.ThirdParty;

namespace CleanCodeAssignments.Functions.Src.Task4
{
    public class Order
    {
        private List<IProduct> products;

        public double GetPriceOfAvailableProducts()
        {
            double orderPrice = 0.0;
            products = products.Where(p => p.IsAvailable()).ToList();
            foreach (var p in products)
                orderPrice += p.GetProductPrice();
            return orderPrice;
        }

        public void SetProducts(List<IProduct> products)
        {
            this.products = products;
        }
    }
}
