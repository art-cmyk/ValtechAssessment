using Ravitej.Automation.Common.Drivers;
using Ravitej.Automation.Common.PageObjects.Session.Navigators;
using Valtech.Website.PageObjects.Pages;

namespace Valtech.Website.PageObjects.Fluent
{
    public class ValtechSessionNavigatorGoTo : GoTo
    {
        private readonly string url;
        public ValtechSessionNavigatorGoTo(IDriverSession driverSession)
            : base(driverSession)
        {
            url = DriverSession.SuiteSettings.ApplicationUnderTestSettings.Url;
        }

        public HomePage Home => GoToPageAndCheck<HomePage>(
                    new System.Uri(string.Format("{0}/", url)));

        public ContactPage Contact => GoToPageAndCheck<ContactPage>(
                    new System.Uri(string.Format("{0}/about/contact-us/", url)));
    }
}