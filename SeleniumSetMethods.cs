using LoginProject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace LoginProject
{
    public static class SeleniumSetMethods
    {
        /**
         * Extensions for custom methods
         */
        public static void EnterText(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        public static void ClickElement(this IWebElement element)
        {
            element.Click();
        }

        public static void SelectDropdown(this IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }
    }
}
