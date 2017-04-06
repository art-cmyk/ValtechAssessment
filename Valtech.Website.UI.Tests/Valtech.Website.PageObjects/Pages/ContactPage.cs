using OpenQA.Selenium;
using System.Linq;
using Valtech.Website.PageObjects.Components;
using System;
using Ravitej.Automation.Common.PageObjects.Session;
using Ravitej.Automation.Common.PageObjects.Services;

namespace Valtech.Website.PageObjects.Pages
{
    public class ContactPage : ValtechBasePage
    {
        public ContactPage(ISession session) : base(session)
        {
            Name = "Contact";
        }

        public int GetOfficesCount()
        {
            var offices = GetElements(By.CssSelector("li.office"), "offices list");
            return offices.Count();
        }

        public override bool IsDisplayed(bool throwWhenNotDisplayed = false)
        {
            using (var checker = new OnPageChecker(Driver, Name))
            {
                return checker.CustomCheckOnPage(() =>
                                GetPageHeader().Equals("Contact"))
                              .CustomCheckOnPage(() => 
                                Driver.Url.EndsWith("contact-us/"))
                              .Confirm(throwWhenNotDisplayed);
            }
        }
    }
}
