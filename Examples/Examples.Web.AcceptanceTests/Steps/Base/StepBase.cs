using Examples.Web.AcceptanceTests.Pages;
using Examples.Web.AcceptanceTests.Pages.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Examples.Web.AcceptanceTests.Steps.Base
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
            ScenarioContext.ScenarioContainer.RegisterInstanceAs<T>(item);
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
