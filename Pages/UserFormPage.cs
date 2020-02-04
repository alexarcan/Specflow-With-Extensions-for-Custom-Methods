using System;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using static LoginProject.SeleniumGetMethods;
using static LoginProject.SeleniumSetMethods;

namespace LoginProject.Pages
{
    public class UserFormPage : BasePage
    {
        private static IWebElement TitleSelector => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("TitleId")));
        private static IWebElement InitialInput => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("Initial")));
        private static IWebElement FirstNameInput => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("FirstName")));
        
        public void EnterUserDetails(string title, string firstName, string initial)
        {
            TitleSelector.SelectDropdown(title);
            InitialInput.EnterText(initial);
            FirstNameInput.EnterText(firstName);
        }

        public void CheckTitle()
        {
            Console.WriteLine("Title = " + TitleSelector.GetTextFromDropdown());
            Console.WriteLine("Initial = " + InitialInput.GetValue());
        }
    }
}
