using CleanCodeAssignments.FunctionsSolution.Src.Task4.ThirdParty;

namespace CleanCodeAssignments.FunctionsSolution.Src.Task4
{
    public class Order
    {
        private List<IProduct> products = [];

        public double GetPriceOfAvailableProducts()
        {
            double orderPrice = 0.0;

            foreach (var product in products)
            {
                orderPrice = GetOrderPrice(orderPrice, product);
            }

            return orderPrice;
        }

        private double GetOrderPrice(double orderPrice, IProduct product)
        {
            if (RemoveNotAvailableProducts(product))
            {
                orderPrice += product.GetProductPrice();
            }

            return orderPrice;
        }

        private bool RemoveNotAvailableProducts(IProduct product)
        {
            return product.IsAvailable();
        }

        public void SetProducts(List<IProduct> products)
        {
            this.products = products;
        }
    }
}
