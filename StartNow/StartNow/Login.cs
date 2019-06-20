using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace StartNow
{
    class Login
    {
        public void UserLogin()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.jd.com/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Close();
        }
    }
}
