using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OrangeProject.WebDriver;
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
        private int name;
        private string text;

        public IWebElement UserManu => driver.FindElement(By.Name("oxd-userdropdown-name"));
        public void SelectOptions()
        {
            SelectElement element = new SelectElement(driver.FindElement(By.ClassName("oxd-userdropdown-name")));
            element.SelectByText(text);
        }
    }
}
