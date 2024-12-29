using NUnit.Framework;
using CleanCodeAssignments.FunctionsSolution.Src.Task2;

namespace CleanCodeAssignments.FunctionsSolution.Test.Task2
{
    public class SitePageTest
    {
        [Test]
        public void ShouldGenerateUrlWithEmptyParams()
        {
            Assert.That(new SitePage("default", "admin").GetEditablePageUrl(new Dictionary<string, string>()), 
                Is.EqualTo("https://mysite.com/?edit=true&siteGrp=default&userGrp=admin"));
        }

        [Test]
        public void ShouldGenerateUrlWithSeveralParams()
        {
            var parameters = new Dictionary<string, string>
            {
                { "id", "1234" },
                { "user", "Alex" },
                { "redirect", "true" }
            };

            Assert.That(new SitePage("mySite", "std").GetEditablePageUrl(parameters), 
                Is.EqualTo("https://mysite.com/?edit=true&id=1234&user=Alex&redirect=true&siteGrp=mySite&userGrp=std"));
        }
    }
}
