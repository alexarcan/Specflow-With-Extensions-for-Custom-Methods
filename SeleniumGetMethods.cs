using System.Linq;
using LoginProject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace LoginProject
{
    public static class SeleniumGetMethods
    {
        /**
         * Only if you have an Element with InnerText you can use directly Text property to get text!
         */
        public static string GetValue(this IWebElement element)
        {
            return element.GetAttribute("value");
        }

        public static string GetTextFromDropdown(this IWebElement element)
        {
            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
        }
    }
}
