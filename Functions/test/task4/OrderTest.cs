using NUnit.Framework;
using CleanCodeAssignments.Functions.Test.Task4.Stubs;
using CleanCodeAssignments.Functions.Src.Task4.ThirdParty;
using CleanCodeAssignments.Functions.Src.Task4;

namespace CleanCodeAssignments.Functions.Test.Task4
{
    public class OrderTest
    {
        private const double DELTA = 0.0001;
        private readonly Order order = new();

        [Test]
        public void ShouldCalculateZeroIfOrderContainsNoProduct()
        {
            order.SetProducts(new List<IProduct>());
            Assert.That(order.GetPriceOfAvailableProducts(), Is.EqualTo(0.0).Within(DELTA));
        }

        [Test]
        public void ShouldCalculateZeroIfOrderContainsOnlyUnavailableProducts()
        {
            order.SetProducts(GetList(new UnavailableProductStub(), new UnavailableProductStub()));
            Assert.That(order.GetPriceOfAvailableProducts(), Is.EqualTo(0.0).Within(DELTA));
        }

        [Test]
        public void ShouldCalculateTwentyIfOrderContainsTwoAvailable10PriceProducts()
        {
            order.SetProducts(GetList(new AvailableProductStub(), new AvailableProductStub()));
            Assert.That(order.GetPriceOfAvailableProducts(), Is.EqualTo(20.0).Within(DELTA));
        }

        [Test]
        public void ShouldCalculateTwentyIfOrderContainsTwoAvailable10PriceProductsWithOtherUnavailableProducts()
        {
            order.SetProducts(GetList(new UnavailableProductStub(), new AvailableProductStub(),
                new AvailableProductStub(), new UnavailableProductStub()));
            Assert.That(order.GetPriceOfAvailableProducts(), Is.EqualTo(20.0).Within(DELTA));
        }

        private List<IProduct> GetList(params IProduct[] products)
        {
            return [.. products];
        }
    }
}
