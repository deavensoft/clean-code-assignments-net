using CleanCodeAssignments.Functions.Src.Task3.ThirdParty;

namespace CleanCodeAssignments.Functions.Src.Task3
{
    public abstract class UserAuthenticator : IUserService
    {
        private ISessionManager sessionManager;

        public IUser Login(string userName, string password)
        {
            return LoginUser(GetUserByName(userName), password);
        }

        private IUser LoginUser(IUser user, string password)
        {
            if (IsPasswordCorrect(user, password))
            {
                sessionManager.SetCurrentUser(user);
                return user;
            }
            return null;
        }

        public abstract bool IsPasswordCorrect(IUser user, string password);
        public abstract IUser GetUserByName(string userName);
       
    }
}
