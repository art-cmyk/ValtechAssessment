using OpenQA.Selenium;

namespace Valtech.Website.PageObjects.Components
{
    public class Menu
    {
        IWebDriver _driver;

        public Menu(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Click(string menuitem)
        {
            _driver.FindElement(By.CssSelector(string.Format("a[href*='{0}']", menuitem.ToLower()))).Click();
        }

        public void ClickContact()
        {
            _driver.FindElement(By.CssSelector("a.icons-container[href=\"/contact-us/\"]")).Click();
        }

        public void ClickLogo()
        {
            _driver.FindElement(By.CssSelector("a.header__logo")).Click();
        }
        
    }
}
