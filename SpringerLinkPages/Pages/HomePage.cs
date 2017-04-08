using OpenQA.Selenium;
using System;
using System.Linq;

namespace SpringerLinkPages
{
    public class HomePage
    {
        public static IWebDriver CurrentDriver { get { return Driver.Instance; } }

        public static IWebElement SearchButton { get { return CurrentDriver.FindElement(By.Id("search")); } }

        public static IWebElement SearchTextbox { get { return CurrentDriver.FindElement(By.Id("query")); } }

        public static IWebElement DivDiscipline { get { return CurrentDriver.FindElement(By.Id("Discipline")); } }

        public static IWebElement DivIntro { get { return CurrentDriver.FindElement(By.Id("intro")); } }

        public static IWebElement ResultsList { get { return CurrentDriver.FindElement(By.Id("results-list")); } }

        public static string GetSideMenuTitle()
        {
            return DivDiscipline.Text;
        }

        public static string GetIntroText()
        {
            return DivIntro.Text;
        }

        public static bool IntroTextDisplayed()
        {
            return DivIntro.Displayed;
        }

        public static bool DisciplineTextDisplayed()
        {
            return DivDiscipline.Displayed;
        }

        public static void TypeAndSearch(string searchText)
        {
            SearchTextbox.Clear();
            SearchTextbox.SendKeys(searchText);
            SearchButton.Click();
            CurrentDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public static bool ResultListPopulated()
        {
            return ResultsList.FindElements(By.ClassName("no-access")).Any();
        }
    }
}
