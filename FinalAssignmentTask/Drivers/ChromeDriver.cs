using FinalAssignmentTask.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FinalAssignmentTask.Drivers
{
    public class ChromeDriverFactory : IWebDriverFactory
    {
        public IWebDriver CreateDriver()
        {
            return new ChromeDriver();
        }
    }
}
