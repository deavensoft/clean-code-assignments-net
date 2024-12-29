using CleanCodeAssignments.Functions.Src.Task3.ThirdParty;

namespace CleanCodeAssignments.Functions.Src.Task3
{
    public abstract class UserController : IController
    {
        private UserAuthenticator userAuthenticator;

        public void AuthenticateUser(string userName, string password)
        {
            IUser user = userAuthenticator.Login(userName, password);
            if (user == null)
                GenerateFailLoginResponse();
            else
                GenerateSuccessLoginResponse(userName);
        }

        public abstract void GenerateSuccessLoginResponse(string user);
        public abstract void GenerateFailLoginResponse();
    }
}
