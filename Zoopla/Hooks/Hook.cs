using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Zoopla.Commons;

namespace Zoopla.Hooks
{
    [Binding]
    public sealed class Hook :Browser
    {
      

        [BeforeScenario]
        public void BeforeScenario()
        {
            LaunchBrowser("Chrome");

      
        }

        [AfterScenario]
        public void AfterScenario()
        {
            CloseBrower();
        }
    }
}
