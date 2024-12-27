using NUnit.Framework;
using CleanCodeAssignments.Comments.src;
using CleanCodeAssignments.Comments.src.thirdparty;

namespace CleanCodeAssignments.Comments.test
{
    [TestFixture]
    public class MortgageInstallmentCalculatorTest
    {
        [Test]
        public void ShouldCalculateMonthlyPaymentWhenAmountsAreSmall()
        {
            double monthlyPaymentAmount = MortgageInstallmentCalculator.CalculateMonthlyPayment(1000, 1, 12);
            Assert.That(monthlyPaymentAmount, Is.EqualTo(88.84).Within(0.01));
        }

        [Test]
        public void ShouldCalculateMonthlyPaymentWhenAmountIsLarge()
        {
            double monthlyPaymentAmount = MortgageInstallmentCalculator.CalculateMonthlyPayment(10000000, 1, 12);
            Assert.That(monthlyPaymentAmount, Is.EqualTo(888487.88d).Within(0.01d));
        }

        [Test]
        public void ShouldCalculateMonthlyPaymentWhenPrincipalIsZero()
        {
            double monthlyPaymentAmount = MortgageInstallmentCalculator.CalculateMonthlyPayment(0, 1, 12);
            Assert.That(monthlyPaymentAmount, Is.EqualTo(0).Within(0.01d));
        }

        [Test]
        public void ShouldCalculateMonthlyPaymentWhenInterestRateIsZero()
        {
            double monthlyPaymentAmount = MortgageInstallmentCalculator.CalculateMonthlyPayment(1000, 1, 0);
            Assert.That(monthlyPaymentAmount, Is.EqualTo(83.33).Within(0.01d));
        }

        [Test]
        public void ShouldThrowInvalidInputExceptionOnNegativeTenure()
        {
            Assert.Throws<InvalidInputException>(() => MortgageInstallmentCalculator.CalculateMonthlyPayment(20, -10, 14.5));
        }

        [Test]
        public void ShouldThrowInvalidInputExceptionOnNegativeInterestRate()
        {
            Assert.Throws<InvalidInputException>(() => MortgageInstallmentCalculator.CalculateMonthlyPayment(20, 1, -12));
        }

        [Test]
        public void ShouldThrowInvalidInputExceptionOnNegativePrincipalAmount()
        {
            Assert.Throws<InvalidInputException>(() => MortgageInstallmentCalculator.CalculateMonthlyPayment(-20, 10, 14.5));
        }
    }
}
