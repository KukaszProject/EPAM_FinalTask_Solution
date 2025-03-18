using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

public sealed class WebDriverManager
{
    private static IWebDriver? driver;
    private static readonly object padlock = new object();

    private WebDriverManager() { }

    public static IWebDriver GetDriver(string browser)
    {
        if (driver == null)
        {
            lock (padlock)
            {
                switch (browser.ToLower())
                {
                    case "chrome":
                        driver = new ChromeDriver();
                        break;
                    case "edge":
                        driver = new EdgeDriver();
                        break;
                    case "firefox":
                        driver = new FirefoxDriver();
                        break;
                    default:
                        throw new ArgumentException("Unsupported browser!");
                }

                driver.Manage().Window.Maximize();
            }
        }

        return driver;
    }

    public static void QuitDriver()
    {
        if (driver != null)
        {
            driver.Quit();
            driver = null;
        }
    }
}
