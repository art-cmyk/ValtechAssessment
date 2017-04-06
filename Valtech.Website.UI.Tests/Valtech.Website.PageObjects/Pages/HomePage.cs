using OpenQA.Selenium;
using Ravitej.Automation.Common.PageObjects.Session;
using Valtech.Website.PageObjects.Components;
using Ravitej.Automation.Common.PageObjects.Services;

namespace Valtech.Website.PageObjects.Pages
{
    public class HomePage : ValtechBasePage
    {
        public HomePage(ISession session) : base(session)
        {
            Name = "Home";
        }

        public override bool IsDisplayed(bool throwWhenNotDisplayed = false)
        {
            using (var checker = new OnPageChecker(Driver, Name))
            {
                return checker.AllElementsExistOnPage(
                    By.CssSelector(".startpage__headblock.customarticlepage"),
                    By.CssSelector(".startpage__highlighted-text"),
                    By.CssSelector(".startpage__service-link")).Confirm(throwWhenNotDisplayed);
            }
        }

        public bool IsNewsSectionDisplayed()
        {
            var newsHeaderDisplayed = IsElementDisplayed(By.CssSelector(".news-post__listing-header"), "Latest News header");
            var newsBodyDisplayed = IsElementDisplayed(By.CssSelector(".bloglisting.news-post__listing"), "Latest News body");
            //var allNewsLinkDisplayed = IsElementDisplayed(By.CssSelector(".news-item__listing-link.button"), "All News link");
            return newsHeaderDisplayed && newsBodyDisplayed;
        }
    }
}
