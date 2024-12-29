using System.Text;

namespace CleanCodeAssignments.FunctionsSolution.Src.Task2
{
    public class SitePage(string siteGroup, string userGroup)
    {
        private const string HTTP_EDITABLE_DOMAIN_URL = "https://mysite.com/?edit=true";

        private readonly string siteGroup = siteGroup;
        private readonly string userGroup = userGroup;

        public string GetEditablePageUrl(Dictionary<string, string> parameters)
        {
            return HTTP_EDITABLE_DOMAIN_URL + DefineRequestParameters(parameters) + GetAttributes();
        }

        private StringBuilder DefineRequestParameters(Dictionary<string, string> parameters)
        {
            StringBuilder paramsString = new StringBuilder();

            foreach (var parameter in parameters)
            {
                paramsString.Append(GetParamsString(parameter));
            }
            return paramsString;
        }

        private string GetParamsString(KeyValuePair<string, string> parameter)
        {
            return "&" + parameter.Key + "=" + parameter.Value;
        }

        private string GetAttributes()
        {
            return "&siteGrp=" + GetSiteGroup() + "&userGrp=" + GetUserGroup();
        }

        private string GetUserGroup()
        {
            return userGroup;
        }

        private string GetSiteGroup()
        {
            return siteGroup;
        }
    }
}
