using Ravitej.Automation.Common.PageObjects.Session;

namespace Valtech.Website.PageObjects.Fluent
{
    public interface IValtechSession : ISession
    {
        new ValtechSessionNavigatorGoTo GoTo { get; }
        new ValtechSessionNavigatorOnPage OnPage { get; }
    }
}