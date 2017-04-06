using System;
using Ravitej.Automation.Common.PageObjects.Session;
using Valtech.Website.PageObjects.Components;

namespace Valtech.Website.PageObjects.Pages
{
    public class CasesPage : ValtechBasePage
    {
        public CasesPage(ISession session) : base(session)
        {
            Name = "Cases";
        }

        public override bool IsDisplayed(bool throwWhenNotDisplayed = false)
        {
            throw new NotImplementedException();
        }
    }
}
