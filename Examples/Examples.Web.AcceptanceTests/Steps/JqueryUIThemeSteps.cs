using Examples.Web.AcceptanceTests.Steps.Base;
using Examples.Web.AcceptanceTests.Support;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Examples.Web.AcceptanceTests.Steps
{
    [Binding]
    public class JqueryUIThemeSteps : StepBase
    {
        [Given(@"I have been take to jquery theme page")]
        public void GivenIHaveBeenTakeToJqueryThemePage()
        {
            JqueryUIThemePage.GoTo();
        }

        [Then(@"the page title should be ""(.*)""")]
        public void ThenThePageTitleShouldBe(string exectedTitle)
        {
            Assert.AreEqual(exectedTitle, JqueryUIThemePage.TitleContent.Text);
        }

        [When(@"I input the text ""(.*)"" into autocomplete input")]
        public void WhenIInputTheTextIntoAutocompleteInput(string text)
        {
            JqueryUIThemePage.EnterTextToAutoComplete(text);
        }

        [Then(@"I should see auto optional items in autocomplete tip panel contains text ""(.*)""")]
        public void ThenIShouldSeeAutoOptionalItemsInAutocompleteTipPanel(string text)
        {
            Assert.IsTrue(JqueryUIThemePage.AutoCompleteTip.Displayed);
            Assert.IsTrue(JqueryUIThemePage.AutoCompleteContains(text));
        }
    }
}
