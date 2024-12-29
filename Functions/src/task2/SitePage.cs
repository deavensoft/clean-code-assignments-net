namespace CleanCodeAssignments.Functions.Src.Task2
{
    public class SitePage
    {
        private const string HTTP = "https://";
        private const string EDITABLE = "/?edit=true";
        private const string DOMAIN = "mysite.com";

        private string siteGroup;
        private string userGroup;

        public SitePage(string siteGroup, string userGroup)
        {
            this.siteGroup = siteGroup;
            this.userGroup = userGroup;
        }

        public string GetEditablePageUrl(Dictionary<string, string> parameters)
        {
            string paramsString = "";
            foreach (var param in parameters)
                paramsString += "&" + param.Key + "=" + param.Value;
            return HTTP + DOMAIN + EDITABLE + paramsString + GetAttributes();
        }

        private string GetAttributes()
        {
            return "&siteGrp=" + GetSiteGroup() + "&userGrp=" + GetUserGroup();
        }

        public string GetUserGroup()
        {
            return userGroup;
        }

        public string GetSiteGroup()
        {
            return siteGroup;
        }
    }
}
