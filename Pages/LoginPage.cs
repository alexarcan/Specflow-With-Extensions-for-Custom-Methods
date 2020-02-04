using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using static LoginProject.SeleniumSetMethods;

namespace LoginProject.Pages
{
    class LoginPage : BasePage
    {
        private static IWebElement UsernameInput => Wait.Until(ExpectedConditions.ElementIsVisible(By.Name("UserName")));
        private static IWebElement PasswordInput => Wait.Until(ExpectedConditions.ElementIsVisible(By.Name("Password")));
        private static IWebElement LoginButton => Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[contains(@type, 'submit')]")));


        public void NavigateTo(string url)
        {
            Browser.Navigate().GoToUrl(url);
        }

        public void Login(string userName, string password)
        {
            UsernameInput.EnterText(userName);
            PasswordInput.EnterText(password);
        }

        public void ClickLogin()
        {
            LoginButton.ClickElement();
        }
    }
}
