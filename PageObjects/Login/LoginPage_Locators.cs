using OpenQA.Selenium;

namespace PageObjects.Login
{
    public static class LoginPage_Locators
    {
        public static readonly By UsernameField = By.Id("user-name");
        public static readonly By PasswordField = By.Id("password");
        public static readonly By LoginButton = By.Id("login-button");
        public static readonly By ErrorMessage = By.CssSelector(".error-message-container");
        public static readonly By ProductPageTitle = By.ClassName("title");
    }
}