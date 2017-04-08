using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpringerLinkPages;
using TechTalk.SpecFlow;

namespace SearchTest
{
    [Binding]
    public class SpringerLinkSearchSteps : Start
    {
        [Given(@"I am on Springer Link page")]
        public void GivenIAmOnSpringerLinkPage()
        {
            Assert.IsTrue(HomePage.IntroTextDisplayed());
            Assert.IsTrue(HomePage.DisciplineTextDisplayed());
        }

        [When(@"I enter searchText into Search")]
        public void WhenIEnterSearchTextIntoSearch(Table table)
        {
            foreach (var row in table.Rows)
            {
                HomePage.TypeAndSearch(row["searchText"]);
            }
        }

        [Then(@"the result shows all content")]
        public void ThenTheResultShowsAllContent()
        {
            Assert.IsTrue(HomePage.ResultListPopulated());
        }

        [Then(@"the result shows no content")]
        public void ThenTheResultShowsNoContent()
        {
            Assert.IsFalse(HomePage.ResultListPopulated());
        }

    }
}
