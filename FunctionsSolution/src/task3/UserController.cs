using CleanCodeAssignments.FunctionsSolution.Src.Task3.ThirdParty;

namespace CleanCodeAssignments.FunctionsSolution.Src.Task3
{
    public abstract class UserController(UserAuthenticator userAuthenticator) : IController
    {
        private readonly UserAuthenticator userAuthenticator = userAuthenticator ?? throw new ArgumentNullException(nameof(userAuthenticator));

        public void AuthenticateUser(string userName, string password)
        {
            IUser? user = userAuthenticator?.LoginUser(userName, password);
            if (user == null)
                GenerateFailLoginResponse();
            else
                GenerateSuccessLoginResponse(userName);
        }

        public abstract void GenerateSuccessLoginResponse(string user);
        public abstract void GenerateFailLoginResponse();
    }
}
