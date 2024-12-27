

namespace CleanCodeAssignments.DRY.src
{
    public class InterestCalculator
    {
        private const int AGE = 60;
        private const double INTEREST_PERCENT = 4.5;
        private const double SENIOR_PERCENT = 5.5;
        private const int BONUS_AGE = 13;

        public decimal CalculateInterest(AccountDetails accountDetails)
        {
            if (IsAccountStartedAfterBonusAge(accountDetails))
            {
                return Interest(accountDetails);
            }
            else
            {
                return 0;
            }
        }

        private bool IsAccountStartedAfterBonusAge(AccountDetails accountDetails)
        {
            return DurationBetweenDatesInYears(accountDetails.Birth, accountDetails.StartDate) > BONUS_AGE;
        }

        private int DurationBetweenDatesInYears(DateTime from, DateTime to)
        {
            return to.Year - from.Year;
        }

        private decimal Interest(AccountDetails accountDetails)
        {
            double interest = 0;
            if (IsAccountStartedAfterBonusAge(accountDetails))
            {
                if (AGE <= accountDetails.Age)
                {
                    interest = (double)accountDetails.Balance
                        * DurationSinceStartDateInYears(accountDetails.StartDate) * SENIOR_PERCENT / 100;
                }
                else
                {
                    interest = (double)accountDetails.Balance
                        * DurationSinceStartDateInYears(accountDetails.StartDate) * INTEREST_PERCENT / 100;
                }
            }
            return (decimal)interest;
        }

        private int DurationSinceStartDateInYears(DateTime startDate)
        {
            DateTime now = DateTime.Now;
            return now.Year - startDate.Year;
        }
    }
}
