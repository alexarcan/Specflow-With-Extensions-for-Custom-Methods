using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace LoginProject
{
    [Binding]
    public class GeneralHook
    {
        private readonly FeatureContext _featureContext;
        private readonly ScenarioContext _scenarioContext;
        public GeneralHook(FeatureContext featureContext, ScenarioContext scenarioContext)
        {
            _featureContext = featureContext;
            _scenarioContext = scenarioContext;
        }
        [AfterStep]
        public void AfterScenario()
        {
            var featureTitle = _featureContext.FeatureInfo.Title;
            var scenarioTitle = _scenarioContext.ScenarioInfo.Title;
            var scenarioTag = _scenarioContext.ScenarioInfo.Tags;

            var stepInfo = _scenarioContext.StepContext.StepInfo.Text;

           // Console.WriteLine($"FeatureTitle : {featureTitle} and ScenarioTitle = {scenarioTitle} with scenarioTag {scenarioTag.First()}");
            Console.WriteLine($"Step : {stepInfo}");
        }

    }
}
