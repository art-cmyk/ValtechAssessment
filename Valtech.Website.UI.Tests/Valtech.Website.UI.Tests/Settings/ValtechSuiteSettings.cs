using System;
using Ravitej.Automation.Common.Config.SuiteSettings;

namespace Valtech.Website.UI.Tests.Settings
{
    public class ValtechSuiteSettings : SuiteSettings
    {
        public override string GetLaunchPage(int targetPage)
        {
            return base.ApplicationUnderTestSettings.Url;
        }

        public override string GetLaunchPage(int targetPage, ILaunchPageHandler launchPageHandler)
        {
            return GetLaunchPage(targetPage);
        }

        public override void HydrateWithDefaults()
        {
            base.HydrateWithDefaults();
        }
    }
}
