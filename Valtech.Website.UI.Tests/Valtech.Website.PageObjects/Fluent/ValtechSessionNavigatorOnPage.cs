using Ravitej.Automation.Common.Drivers;
using Ravitej.Automation.Common.PageObjects.Session.Navigators;
using Valtech.Website.PageObjects.Pages;

namespace Valtech.Website.PageObjects.Fluent
{
    public class ValtechSessionNavigatorOnPage : OnPage
    {
        public ValtechSessionNavigatorOnPage(IDriverSession driverSession)
            : base(driverSession)
        {
        }

        public HomePage Home => ResolvePageObjectAndCheck<HomePage>();

        public ServicesPage Services => ResolvePageObjectAndCheck<ServicesPage>();

        public ContactPage Contact => ResolvePageObjectAndCheck<ContactPage>();

        public JobsPage Jobs => ResolvePageObjectAndCheck<JobsPage>();
    }
}