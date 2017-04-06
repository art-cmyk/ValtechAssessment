using NUnit.Framework;
using System;
using Valtech.Website.PageObjects.Pages;
using Valtech.Website.UI.Tests.Settings;

namespace Valtech.Website.UI.Tests
{
    [TestFixture]
    public class ValtechTests : ValtechTestBase<ValtechPersistableSettings>
    {
        private HomePage _page;

        [OneTimeSetUp]
        public void FixtureSetUp()
        {
            _page = ValtechSession.OnPage.Home;
        }

        [OneTimeTearDown]
        public void FixtureTearDown()
        {
        }

        [TearDown]
        public void TearDown()
        {
            _page = ValtechSession.GoTo.Home;
        }

        [Test]
        public void HomePageShouldContainNewsSection()
        {
            //Arrange
            _page.Menu.ClickLogo();
            //Act
            var newsSectionDisplayed = _page.IsNewsSectionDisplayed();
            //Assert
            Assert.That(newsSectionDisplayed, Is.True, "Expected Latest News section to be displayed on the home page");
        }

        [Test]
        [TestCase("Cases", "Work")]
        [TestCase("Services", "Services")]
        [TestCase("About", "About")]
        public void PageShouldHaveCorrectHeader(string pageName, string expectedHeader)
        {
            //Arrange
            _page.Menu.Click(pageName);
            //Act
            var actualPageHeader = _page.GetPageHeader();
            //Assert
            Assert.That(actualPageHeader, Is.EqualTo(expectedHeader), "Incorrect page header");
        }

        [Test]
        public void OutputNumberOfOfficesInContactPage()
        {
            //Arrange
            var contactPage = ValtechSession.GoTo.Contact;
            //Act
            var actualOfficesCount = contactPage.GetOfficesCount();
            //Assert
            Console.WriteLine("Offices count: {0}", actualOfficesCount);
        }
    }
}
