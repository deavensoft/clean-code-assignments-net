using CleanCodeAssignments.FunctionsSolution.Src.Task3.ThirdParty;

namespace CleanCodeAssignments.FunctionsSolution.Src.Task3
{
    public abstract class UserAuthenticator(ISessionManager sessionManager) : IUserService
    {
        private readonly ISessionManager sessionManager = sessionManager ?? throw new ArgumentNullException(nameof(sessionManager));

        public IUser? LoginUser(string userName, string password)
        {
            IUser user = GetUserByName(userName);
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
