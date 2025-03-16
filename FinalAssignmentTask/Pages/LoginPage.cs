using log4net.Config;
using OpenQA.Selenium;

public class LoginPage
{
    private IWebDriver driver;

    public LoginPage(IWebDriver driver)
    {
        this.driver = driver;
    }

    // Page elements
    private IWebElement UsernameField => driver.FindElement(By.CssSelector("#user-name"));
    private IWebElement PasswordField => driver.FindElement(By.CssSelector("#password"));
    private IWebElement LoginButton => driver.FindElement(By.CssSelector("#login-button"));
    private IWebElement ErrorMessage => driver.FindElement(By.CssSelector("h3[data-test='error']"));

    // Page actions
    public void EnterUsername(string username) => UsernameField.SendKeys(username);
    public void EnterPassword(string password) => PasswordField.SendKeys(password);
    public void ClearUsername()
    {
        int usernameLength = UsernameField.GetAttribute("value").Length;
        for (int i = 0; i < usernameLength; i++)
        {
            UsernameField.SendKeys(Keys.Backspace);
        }
    }
    public void ClearPassword()
    {
        int passwordLength = PasswordField.GetAttribute("value").Length;
        for (int i = 0; i < passwordLength; i++)
        {
            PasswordField.SendKeys(Keys.Backspace);
        }
    }
    public void ClickLogin() => LoginButton.Click();
    public string GetErrorMessage() => ErrorMessage.Text;
}

