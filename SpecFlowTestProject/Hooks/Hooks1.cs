using SpecFlowTestProject.Driver;
using TechTalk.SpecFlow;

namespace SpecFlowTestProject.Hooks
{
    [Binding]
    public class Hooks1
    {
        private readonly Browser _browser;
       public Hooks1(Browser browser)
        {
            _browser = browser;
        }

        [AfterScenario]
        public void CloseDriver()
        { 
            _browser.Driver.Quit(); 
        }
    }
}