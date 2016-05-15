using Example.WebAutomationTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Example.WebAutomationTests.Steps.Base
{
    public class StepBase : TechTalk.SpecFlow.Steps
    {
        public T Get<T>()
        {
            return ScenarioContext.ScenarioContainer.Resolve<T>();
        }

        public void Set<T>(T item)
            where T : class
        {
            ScenarioContext.ScenarioContainer.RegisterInstanceAs(item);
        }

        public JqueryUIThemePage JqueryUIThemePage
        {
            get
            {
                return this.Get<JqueryUIThemePage>();
            }
        }
    }
}
