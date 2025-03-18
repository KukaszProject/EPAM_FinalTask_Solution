using FinalAssignmentTask.Interfaces;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;

namespace FinalAssignmentTask.Drivers
{
    public class EdgeDriverFactory : IWebDriverFactory
    {
        public IWebDriver CreateDriver()
        {
            return new EdgeDriver();
        }
    }
}
