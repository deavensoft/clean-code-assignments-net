using CleanCodeAssignments.Functions.Src.Task1.ThirdParty;

namespace CleanCodeAssignments.Functions.Src.Task1
{
    public class RegisterAccountAction
    {
        private IPasswordChecker passwordChecker;
        private IAccountManager accountManager;

        public void Register(IAccount account)
        {
            if (account.GetName().Length <= 5)
            {
                throw new WrongAccountNameException();
            }

            string password = account.GetPassword();
            if (password.Length <= 8)
            {
                if (passwordChecker.Validate(password) != CheckStatus.OK)
                {
                    throw new WrongPasswordException();
                }
            }

            account.SetCreatedDate(DateTime.Now);
            List<IAddress> addresses = new List<IAddress>
            {
                account.GetHomeAddress(),
                account.GetWorkAddress(),
                account.GetAdditionalAddress()
            };
            account.SetAddresses(addresses);
            
            accountManager.Create(account);
        }

        public void SetAccountManager(IAccountManager accountManager)
        {
            this.accountManager = accountManager;
        }

        public void SetPasswordChecker(IPasswordChecker passwordChecker)
        {
            this.passwordChecker = passwordChecker;
        }
    }
}
