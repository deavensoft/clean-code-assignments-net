
using System.Numerics;

namespace CleanCodeAssignments.DRYSolution.src
{
    public class InterestCalculator
    {
        private const int AGE = 60;
        private const double INTEREST_PERCENT_RATE = 4.5;
        private const double SENIOR_PERCENT_RATE = 5.5;
        private const int BONUS_AGE = 13;

        public BigInteger CalculateInterest(AccountDetails accountDetails)
        {
            if (IsAccountStartedAfterBonusAge(accountDetails))
            {
                return DoCalculateInterest(accountDetails);
            }

            return BigInteger.Zero;
        }

        private bool IsAccountStartedAfterBonusAge(AccountDetails accountDetails)
        {
            return DurationBetweenDatesInYears(accountDetails.Birth, accountDetails.StartDate) > BONUS_AGE;
        }

        private BigInteger DoCalculateInterest(AccountDetails accountDetails)
        {
            return new BigInteger(CalculateResult(accountDetails));
        }

        private double CalculateResult(AccountDetails accountDetails)
        {
            double interestRate = DetermineRate(accountDetails);

            return accountDetails.Balance
                * DurationSinceStartDateInYears(accountDetails.StartDate) * interestRate / 100;
        }

        private double DetermineRate(AccountDetails accountDetails)
        {
            return AGE <= accountDetails.Age ? SENIOR_PERCENT_RATE : INTEREST_PERCENT_RATE;
        }

        private int DurationBetweenDatesInYears(DateTime from, DateTime to)
        {
            return CalculateYearDifference(from, to);
        }

        private int DurationSinceStartDateInYears(DateTime startDate)
        {
            return CalculateYearDifference(startDate, DateTime.Now);
        }

        private int CalculateYearDifference(DateTime startDate, DateTime endDate)
        {
            return endDate.Year - startDate.Year;
        }
    }
}
