using SpringerLinkPages;
using TechTalk.SpecFlow;

namespace SearchTest
{
    public class Start : Driver
    {
        [BeforeScenario]
        public void Setup()
        {
            Intitialize();
            Instance.Navigate().GoToUrl(BaseAddress);
        }

        [AfterScenario]
        public void TearDown()
        {
            Close();
        }
    }
}