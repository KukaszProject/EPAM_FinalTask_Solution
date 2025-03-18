using FinalAssignmentTask.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace FinalAssignmentTask.Drivers
{
    public class FirefoxDriverFactory : IWebDriverFactory
    {
        public IWebDriver CreateDriver()
        {
            return new FirefoxDriver();
        }
    }
}
