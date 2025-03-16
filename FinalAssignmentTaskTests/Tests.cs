using OpenQA.Selenium;
using FluentAssertions;
using FinalAssignmentTask.Utilities;

public class SauceDemoLoginTests
{

    private IWebDriver? driver;
    [Theory]
    [InlineData("chrome", "test", "password")]
    [InlineData("firefox", "test", "password")]
    [InlineData("edge", "test", "password")]
    public void UC1_TestLoginWithEmptyCredentials(string browser, string testUsername, string testPassword)
    {
        driver = WebDriverManager.GetDriver(browser);
        driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        var loginPage = new LoginPage(driver);
        LoggerHelper.StartTestCase("UC1_TestLoginWithEmptyCredentials");

        loginPage.EnterUsername(testUsername);
        loginPage.EnterPassword(testPassword);

        loginPage.ClearUsername(); // Clear username
        loginPage.ClearPassword(); // Clear password
        loginPage.ClickLogin();

        // Verify error message
        loginPage.GetErrorMessage().Should().Contain("Username is required");

        WebDriverManager.QuitDriver();
    }

    [Theory]
    [InlineData("chrome", "test", "password")]
    [InlineData("firefox", "test", "password")]
    [InlineData("edge", "test", "password")]
    public void UC2_TestLoginWithOnlyUsername(string browser, string testUsername, string testPassword)
    {
        driver = WebDriverManager.GetDriver(browser);
        driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        var loginPage = new LoginPage(driver);

        loginPage.EnterUsername(testUsername);
        loginPage.EnterPassword(testPassword);
        
        loginPage.ClearPassword(); // Clear password

        loginPage.ClickLogin();

        // Verify error message
        loginPage.GetErrorMessage().Should().Contain("Password is required");

        WebDriverManager.QuitDriver();
    }

    [Theory]
    [InlineData("chrome", "standard_user", "secret_sauce")]
    [InlineData("firefox", "standard_user", "secret_sauce")]
    [InlineData("edge", "standard_user", "secret_sauce")]
    public void UC3_TestLoginWithValidCredentials(string browser, string username, string password)
    {
        driver = WebDriverManager.GetDriver(browser);
        driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        var loginPage = new LoginPage(driver);

        loginPage.EnterUsername(username);
        loginPage.EnterPassword(password);
        loginPage.ClickLogin();

        // Validate Swag Labs title
        driver.Title.Should().Be("Swag Labs");

        WebDriverManager.QuitDriver();
    }
}
