using CleanCodeAssignments.FunctionsSolution.Src.Task1.ThirdParty;

namespace CleanCodeAssignments.FunctionsSolution.Src.Task1
{
    public class RegisterAccountAction(IPasswordChecker passwordChecker, IAccountManager accountManager)
    {
        private IPasswordChecker passwordChecker = passwordChecker ?? throw new ArgumentNullException(nameof(passwordChecker));
        private IAccountManager accountManager = accountManager ?? throw new ArgumentNullException(nameof(accountManager));

        public void Register(IAccount account)
        {
            Validate(account);
            FillAccount(account);
            accountManager.Create(account);
        }

        private void FillAccount(IAccount account)
        {
            account.SetCreatedDate(DateTime.Now);
            account.SetAddresses(GetAddresses(account));
        }

        private void Validate(IAccount account)
        {
            ValidateAccountName(account);
            ValidateAccountPassword(account);
        }

        private void ValidateAccountName(IAccount account)
        {
            if (account.GetName().Length <= 5)
            {
                throw new WrongAccountNameException();
            }
        }

        private void ValidateAccountPassword(IAccount account)
        {
            string password = account.GetPassword();

            if (password.Length <= 8 && IsNotValidPassword(password))
            {
                throw new WrongPasswordException();
            }
        }

        private bool IsNotValidPassword(string password)
        {
            return passwordChecker.Validate(password) != CheckStatus.OK;
        }

        private List<IAddress> GetAddresses(IAccount account)
        {
            List<IAddress> addresses = new List<IAddress>
            {
                account.GetHomeAddress(),
                account.GetWorkAddress(),
                account.GetAdditionalAddress()
            };
            return addresses;
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
