using OpenQA.Selenium;
using Utilities.WebUtilities;

namespace PageObjects.Login
{
    public class LoginPage_Actions
    {
        private WebUtilities _webUtilities;

        public LoginPage_Actions(WebUtilities webUtilities)
        {
            _webUtilities = webUtilities;
        }

        public void EnterCredentials(string username, string password)
        {
            _webUtilities.SendKeys(LoginPage_Locators.UsernameField, username);
            _webUtilities.SendKeys(LoginPage_Locators.PasswordField, password);
        }

        public void ClickLoginButton()
        {
            _webUtilities.Click(LoginPage_Locators.LoginButton);
        }

        public bool IsProductPageDisplayed()
        {
            return _webUtilities.FindElement(LoginPage_Locators.ProductPageTitle).Displayed;
        }
    }
}