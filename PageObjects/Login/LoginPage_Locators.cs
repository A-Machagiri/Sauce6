using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects.Login
{
    public partial class LoginPage
    {
        private By _username = By.Id("user-name");
        private By _password = By.Id("password");
        private By _loginButton = By.Id("login-button");
    }
}
