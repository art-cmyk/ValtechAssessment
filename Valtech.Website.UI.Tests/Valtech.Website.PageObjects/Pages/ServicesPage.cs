using System;
using Valtech.Website.PageObjects.Components;
using Ravitej.Automation.Common.PageObjects.Session;

namespace Valtech.Website.PageObjects.Pages
{
    public class ServicesPage : ValtechBasePage
    {
        public ServicesPage(ISession session) : base(session)
        {
            Name = "Services";
        }

        public override bool IsDisplayed(bool throwWhenNotDisplayed = false)
        {
            throw new NotImplementedException();
        }
    }
}
