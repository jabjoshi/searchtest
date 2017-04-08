using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SpringerLinkPages
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static string BaseAddress
        {
            get { return ConstantUtils.Url; }
        }

        public static void Intitialize()
        {
            Instance = new ChromeDriver();
            TurnOnWait();
            Instance.Manage().Window.Maximize();
        }

        public static void Navigate()
        {
            Instance.Navigate().GoToUrl(BaseAddress);
        }

        public static void Close()
        {
            Instance.Close();
        }

        private static void TurnOnWait()
        {
            Instance.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(5));
        }
    }
}
