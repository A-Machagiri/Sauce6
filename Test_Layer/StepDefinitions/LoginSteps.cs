using TechTalk.SpecFlow;
using PageObjects.Login;
using Utilities.WebUtilities;

[Binding]
public class LoginSteps
{
    private LoginPage _loginPage;
    private WebUtilities _webUtilities;

    public LoginSteps(WebUtilities webUtilities)
    {
        _webUtilities = webUtilities;
        _loginPage = new LoginPage(_webUtilities);
    }

    [Given("I am on the login page")]
    public void GivenIAmOnTheLoginPage()
    {
        _webUtilities.NavigateToUrl("https://www.saucedemo.com/");
    }

    [When("I enter valid credentials")]
    public void WhenIEnterValidCredentials()
    {
        _loginPage.EnterCredentials("standard_user", "secret_sauce");
    }

    [When("I enter invalid credentials")]
    public void WhenIEnterInvalidCredentials()
    {
        _loginPage.EnterCredentials("invalid_user", "wrong_sauce");
    }

    [When("I click the login button")]
    public void WhenIClickTheLoginButton()
    {
        _loginPage.ClickLoginButton();
    }

    [Then("I should be redirected to the product page")]
    public void ThenIShouldBeRedirectedToTheProductPage()
    {
        Assert.IsTrue(_loginPage.IsProductPageDisplayed());
    }

    [Then("I should see an error message")]
    public void ThenIShouldSeeAnErrorMessage()
    {
        Assert.IsTrue(_loginPage.ErrorMessage.Displayed);
    }
}