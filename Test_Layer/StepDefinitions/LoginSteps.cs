using TechTalk.SpecFlow;
using PageObjects.Login;
using Utilities.WebUtilities;

namespace Test_Layer.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private LoginPage_Actions _loginPageActions;

        public LoginSteps(WebUtilities webUtilities)
        {
            _loginPageActions = new LoginPage_Actions(webUtilities);
        }

        [Given("I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            // Implementation to navigate to login page
        }

        [When("I enter valid credentials")]
        [When("I enter invalid credentials")]
        public void WhenIEnterCredentials()
        {
            // Implementation to enter credentials
        }

        [When("I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            _loginPageActions.ClickLoginButton();
        }

        [Then("I should be redirected to the product page")]
        public void ThenIShouldBeRedirectedToTheProductPage()
        {
            // Implementation for assertion
        }

        [Then("I should see an error message")]
        public void ThenIShouldSeeAnErrorMessage()
        {
            // Implementation for assertion
        }
    }
}