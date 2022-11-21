using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeProject.Page
{
    public class DashboardPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement UserMenu => driver.FindElement(By.ClassName("oxd-userdropdown-tab"));

        public void SelectOption()
        {
            SelectElement element = new SelectElement
        }
    }
}
