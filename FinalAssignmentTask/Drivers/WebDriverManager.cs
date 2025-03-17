using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

public interface IWebDriverFactory
{
    IWebDriver CreateDriver();
}

public class ChromeDriverFactory : IWebDriverFactory
{
    public IWebDriver CreateDriver()
    {
        return new ChromeDriver();
    }
}

public class FirefoxDriverFactory : IWebDriverFactory
{
    public IWebDriver CreateDriver()
    {
        return new FirefoxDriver();
    }
}

public class EdgeDriverFactory : IWebDriverFactory
{
    public IWebDriver CreateDriver()
    {
        return new EdgeDriver();
    }
}
