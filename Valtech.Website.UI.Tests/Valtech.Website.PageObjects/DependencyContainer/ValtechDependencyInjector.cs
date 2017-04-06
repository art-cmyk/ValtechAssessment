using Ravitej.Automation.Common.Dependency;
using Valtech.Website.PageObjects.Components;
using Valtech.Website.PageObjects.Pages;

namespace Valtech.Website.PageObjects.DependencyContainer
{
    public class ValtechDependencyInjector : DependencyInjector
    {
        /// <summary>
        /// Entry point to perform all page object registrations
        /// </summary>
        protected override void RegisterPageObjects()
        {
            RegisterBasePages();
            AppWide.Instance.RegisterType<HomePage>(typeof(HomePage));
            AppWide.Instance.RegisterType<ServicesPage>(typeof(ServicesPage));
            AppWide.Instance.RegisterType<JobsPage>(typeof(JobsPage));
            AppWide.Instance.RegisterType<ContactPage>(typeof(ContactPage));
            AppWide.Instance.RegisterType<CasesPage>(typeof(CasesPage));

        }

        private void RegisterBasePages()
        {
            AppWide.Instance.RegisterType<ValtechBasePage>(typeof(ValtechBasePage));
        }

        /// <summary>
        /// Entry point to register any explicit site components, such as the BusyIndicator etc.
        /// </summary>
        protected override void RegisterSiteComponents()
        {
            AppWide.Instance.RegisterType<Menu>(typeof(Menu));

        }
    }
}
