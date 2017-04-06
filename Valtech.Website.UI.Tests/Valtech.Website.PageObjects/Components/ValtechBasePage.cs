using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Ravitej.Automation.Common.PageObjects.Components.BasePage.Selenium;
using Ravitej.Automation.Common.PageObjects.Session;

namespace Valtech.Website.PageObjects.Components
{
    public abstract class ValtechBasePage : BasePage
    {
        public Menu Menu { get { return new Menu(Driver); } }
        //public Footer Footer { get { return new Footer(Driver); } }

        public ValtechBasePage(ISession session) : base(session)
        {
        }

        public string GetPageHeader()
        {
            if(IsPageHeaderDisplayed)
            {
                return GetText(HeaderH1By, "H1 Header");
            }
            return string.Empty;
        }

        protected static By HeaderH1By
        {
            get
            {
                return new ByChained(PageHeaderBy, By.CssSelector("h1"));
            }
        }

        protected static By PageHeaderBy
        {
            get
            {
                return By.CssSelector(".page-header");
            }
        }

        public bool IsPageHeaderDisplayed
        {
            get
            {
                return IsElementDisplayed(PageHeaderBy, "page header");
            }
        }
    }
}
