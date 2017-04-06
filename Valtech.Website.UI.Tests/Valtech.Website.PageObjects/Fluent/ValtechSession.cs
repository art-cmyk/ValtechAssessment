using Ravitej.Automation.Common.Drivers;
using Ravitej.Automation.Common.PageObjects.Session;

namespace Valtech.Website.PageObjects.Fluent
{
    public class ValtechSession : Session, IValtechSession
    {
        public new ValtechSessionNavigatorGoTo GoTo { get; private set; }
        public new ValtechSessionNavigatorOnPage OnPage { get; private set; }

        public ValtechSession(IDriverSession driverSession)
            : base(driverSession)
        {
            OnPage = new ValtechSessionNavigatorOnPage(driverSession);
            GoTo = new ValtechSessionNavigatorGoTo(driverSession);
        }
    }
}