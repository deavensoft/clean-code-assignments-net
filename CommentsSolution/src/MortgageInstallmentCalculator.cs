
using CleanCodeAssignments.CommentsSolution.src.thirdparty;

namespace CleanCodeAssignments.CommentsSolution.src
{
    public class MortgageInstallmentCalculator
    {
        private const int COUNT_OF_MONTHS_IN_YEAR = 12;

        public static double CalculateMonthlyPayment(int principalAmount, int mortgageTermInYears, double interestRate)
        {
            DefineValues(principalAmount, mortgageTermInYears, interestRate);
            return DoCalculateMonthlyPayment(principalAmount, mortgageTermInYears, interestRate);
        }

        private static double DoCalculateMonthlyPayment(int principalAmount, int mortgageTermInYears, double interestRate)
        {
            double mortgageTermInMonth = ConvertYearsTermInMonth(mortgageTermInYears);
            if (RateValueZero(interestRate))
            {
                return principalAmount / mortgageTermInMonth;
            }

            interestRate = ConvertIntoDecimal(interestRate);
            double monthlyRate = ConvertIntoMonthlyRate(interestRate);
            return CalculateMonthlyPayment(principalAmount, mortgageTermInMonth, monthlyRate);
        }

        private static void DefineValues(int principalAmount, int mortgageTermInYears, double interestRate)
        {
            if (principalAmount < 0 || mortgageTermInYears <= 0 || interestRate < 0)
            {
                throw new InvalidInputException("Negative values are not allowed");
            }
        }

        private static double ConvertIntoDecimal(double interestRate)
        {
            return interestRate / 100.0;
        }

        private static double ConvertYearsTermInMonth(int mortgageTermInYears)
        {
            return mortgageTermInYears * COUNT_OF_MONTHS_IN_YEAR;
        }

        private static bool RateValueZero(double interestRate)
        {
            return interestRate == 0;
        }

        private static double ConvertIntoMonthlyRate(double interestRate)
        {
            return interestRate / 12.0;
        }

        private static double CalculateMonthlyPayment(int principalAmount, double mortgageTermInMonth, double monthlyRate)
        {
            return (principalAmount * monthlyRate) / (1 - Math.Pow(1 + monthlyRate, -mortgageTermInMonth));
        }
    }
}
