using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace LoginProject.Pages
{
    public class BasePage
    {
        protected static readonly IWebDriver Browser = new ChromeDriver();
        protected static readonly WebDriverWait Wait = new WebDriverWait(Browser, TimeSpan.FromSeconds(2));
    }
}
