using NUnit.Framework;
using Ravitej.Automation.Common.Config;
using Ravitej.Automation.Common.Dependency;
using Ravitej.Automation.Common.PageObjects.Session;

using Ravitej.Automation.UI.Tests;
using Valtech.Website.PageObjects.DependencyContainer;
using Valtech.Website.PageObjects.Fluent;
using Valtech.Website.UI.Tests.Settings;

namespace Valtech.Website.UI.Tests
{
    public class ValtechTestBase<TSettings> : UiTestBase<ValtechSuiteSettings> where TSettings : IPersistableSettings, new()
    {
        private readonly SettingsType _settingsType;

        protected ValtechTestBase(SettingsType settingsType = SettingsType.ProjectBound) : base(1)
        {
            TestBaseNamespace = "Valtech.Website.UI.Tests";
            TestResultsBaseFolder = "";
            _settingsType = settingsType;
        }

        protected IValtechSession ValtechSession { get; private set; }

        protected TSettings TestSettings { get; set; }

        [OneTimeSetUp]
        protected void ValtechTestBaseFixtureSetUp()
        {
            new ValtechDependencyInjector().InjectRegistrations(); //registers types with the container
            ValtechSession = new ValtechSession(Session.DriverSession);
            AppWide.Instance.SetInstance(ValtechSession);
            AppWide.Instance.SetInstance<ISession>(ValtechSession);
            TestSettings = GetTestSettingsAndPersistIfDefault<TSettings>(_settingsType);
        }

        [SetUp]
        protected void ValtechTestBaseSetUp()
        {

        }
        [TearDown]
        protected void ValtechTestBaseTearDown()
        {

        }

        [OneTimeTearDown]
        protected void ValtechTestBaseFixtureTearDown()
        {

        }
    }
}
