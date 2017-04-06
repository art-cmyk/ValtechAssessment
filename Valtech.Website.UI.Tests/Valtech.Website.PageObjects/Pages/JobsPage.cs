using System;
using Ravitej.Automation.Common.PageObjects.Session;
using Valtech.Website.PageObjects.Components;

namespace Valtech.Website.PageObjects.Pages
{
    public class JobsPage : ValtechBasePage
    {
        public JobsPage(ISession session) : base(session)
        {
            Name = "Jobs";
        }

        public override bool IsDisplayed(bool throwWhenNotDisplayed = false)
        {
            throw new NotImplementedException();
        }
    }
}
