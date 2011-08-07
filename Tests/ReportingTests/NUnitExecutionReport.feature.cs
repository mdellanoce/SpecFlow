// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.3.2.0
//      Runtime Version:4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace ReportingTests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Generating HTML report from NUnit execution result")]
    public partial class GeneratingHTMLReportFromNUnitExecutionResultFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "NUnitExecutionReport.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Generating HTML report from NUnit execution result", "In order to present the test results in a nice form\r\nAs a test manager\r\nI want to" +
                    " be able to generate an HTML report from the NUnit execution result", ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void SummaryIsIncludedInTheHTMLResult(string unittest)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Summary is included in the HTML result", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
testRunner.Given(string.Format("there are {0} test execution results for the ReportingTest.SampleProject project", unittest));
#line 8
testRunner.When(string.Format("I generate SpecFlow {0} execution report", unittest));
#line hidden
#line 9
testRunner.Then("a report generated containing", "\tSummary \r\n\tFeatures\tSuccess rate\tScenarios\tSuccess\t\tFailed\tPending\t\tIgnored \r\n\t2" +
                    " features\t40%\t\t\t\t5\t\t\t2\t\t\t1\t\t1\t\t\t1 ", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Summary is included in the HTML result")]
        public virtual void SummaryIsIncludedInTheHTMLResult_NUnit()
        {
            this.SummaryIsIncludedInTheHTMLResult("NUnit");
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Summary is included in the HTML result (MsTest)")]
        public virtual void SummaryIsIncludedInTheHTMLResultMsTest()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Summary is included in the HTML result (MsTest)", ((string[])(null)));
#line 20
this.ScenarioSetup(scenarioInfo);
#line 21
testRunner.Given("there are MsTest test execution results for the ReportingTest.SampleProject proje" +
                    "ct");
#line 22
testRunner.When("I generate SpecFlow MsTest execution report");
#line hidden
#line 23
testRunner.Then("a report generated containing", "\tSummary \r\n\tFeatures\tSuccess rate\tScenarios\tSuccess\t\tFailed\tPending\t\tIgnored \r\n\t2" +
                    " features\t50%\t\t\t\t4\t\t\t2\t\t\t1\t\t1\t\t\t0 ", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureSummaryIsIncludedInTheHTMLResult(string unittest)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Feature summary is included in the HTML result", ((string[])(null)));
#line 30
this.ScenarioSetup(scenarioInfo);
#line 31
testRunner.Given(string.Format("there are {0} test execution results for the ReportingTest.SampleProject project", unittest));
#line 32
testRunner.When(string.Format("I generate SpecFlow {0} execution report", unittest));
#line hidden
#line 33
testRunner.Then("a report generated containing", "\tFeature Summary\r\n\tFeature\t\t\t\t\t\t\t\tSuccess rate\tScenarios\tSuccess\t\tFailed\tPending\t" +
                    "\tIgnored\t\t\r\n\tFeature with failing scenarios\t\t0%\t\t\t\t3\t\t\t0\t\t\t1\t\t1\t\t\t1\r\n\tFeature wi" +
                    "th successful scenarios\t100%\t\t\t2\t\t\t2\t\t\t0\t\t0\t\t\t0", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Feature summary is included in the HTML result")]
        public virtual void FeatureSummaryIsIncludedInTheHTMLResult_NUnit()
        {
            this.FeatureSummaryIsIncludedInTheHTMLResult("NUnit");
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Feature summary is included in the HTML result (MsTest)")]
        public virtual void FeatureSummaryIsIncludedInTheHTMLResultMsTest()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Feature summary is included in the HTML result (MsTest)", ((string[])(null)));
#line 45
this.ScenarioSetup(scenarioInfo);
#line 46
testRunner.Given("there are MsTest test execution results for the ReportingTest.SampleProject proje" +
                    "ct");
#line 47
testRunner.When("I generate SpecFlow MsTest execution report");
#line hidden
#line 48
testRunner.Then("a report generated containing", "\tFeature Summary\r\n\tFeature\t\t\t\t\t\t\t\tSuccess rate\tScenarios\tSuccess\t\tFailed\tPending\t" +
                    "\tIgnored\t\t\r\n\tFeature with failing scenarios\t\t0%\t\t\t\t2\t\t\t0\t\t\t1\t\t1\t\t\t0\r\n\tFeature wi" +
                    "th successful scenarios\t100%\t\t\t2\t\t\t2\t\t\t0\t\t0\t\t\t0", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void SuccessfulTestOutputIsIncludedInTheHTMLResult(string unittest)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Successful test output is included in the HTML result", ((string[])(null)));
#line 56
this.ScenarioSetup(scenarioInfo);
#line 57
testRunner.Given(string.Format("there are {0} test execution results for the ReportingTest.SampleProject project", unittest));
#line 58
testRunner.When(string.Format("I generate SpecFlow {0} execution report", unittest));
#line hidden
#line 59
testRunner.Then("a report generated containing", @"	Given I have a precondition that is successful
	-> done: StepDefinitions.GivenIHaveAPreconditionThatIs(""successful"") (0,0s)
	When I do something that works
	-> done: StepDefinitions.GivenIHaveAPreconditionThatIs(""works"") (0,0s)
	Then I have a postcondition that is successful
	-> done: StepDefinitions.GivenIHaveAPreconditionThatIs(""successful"") (0,0s)", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Successful test output is included in the HTML result")]
        public virtual void SuccessfulTestOutputIsIncludedInTheHTMLResult_NUnit()
        {
            this.SuccessfulTestOutputIsIncludedInTheHTMLResult("NUnit");
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Successful test output is included in the HTML result")]
        public virtual void SuccessfulTestOutputIsIncludedInTheHTMLResult_MsTest()
        {
            this.SuccessfulTestOutputIsIncludedInTheHTMLResult("MsTest");
        }
        
        public virtual void PendingTestOutputIsIncludedInTheHTMLResult(string unittest)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Pending test output is included in the HTML result", ((string[])(null)));
#line 73
this.ScenarioSetup(scenarioInfo);
#line 74
testRunner.Given(string.Format("there are {0} test execution results for the ReportingTest.SampleProject project", unittest));
#line 75
testRunner.When(string.Format("I generate SpecFlow {0} execution report", unittest));
#line hidden
#line 76
testRunner.Then("a report generated containing", @"	Given I have a pending precondition
	-> No matching step definition found for the step. Use the following code to create one:
		[Binding]
		public class StepDefinitions
		{
			[Given(@""I have a pending precondition"")]
			public void GivenIHaveAPendingPrecondition()
			{
				ScenarioContext.Current.Pending();
			}
		}", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Pending test output is included in the HTML result")]
        public virtual void PendingTestOutputIsIncludedInTheHTMLResult_NUnit()
        {
            this.PendingTestOutputIsIncludedInTheHTMLResult("NUnit");
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Pending test output is included in the HTML result")]
        public virtual void PendingTestOutputIsIncludedInTheHTMLResult_MsTest()
        {
            this.PendingTestOutputIsIncludedInTheHTMLResult("MsTest");
        }
        
        public virtual void FailingTestOutputIsIncludedInTheHTMLResult(string unittest)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Failing test output is included in the HTML result", ((string[])(null)));
#line 95
this.ScenarioSetup(scenarioInfo);
#line 96
testRunner.Given(string.Format("there are {0} test execution results for the ReportingTest.SampleProject project", unittest));
#line 97
testRunner.When(string.Format("I generate SpecFlow {0} execution report", unittest));
#line hidden
#line 98
testRunner.Then("a report generated containing", "\tGiven I have a precondition that is failing\r\n\t-> error:", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
#line 103
testRunner.And("a report generated containing", "\tsimulated failure", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Failing test output is included in the HTML result")]
        public virtual void FailingTestOutputIsIncludedInTheHTMLResult_NUnit()
        {
            this.FailingTestOutputIsIncludedInTheHTMLResult("NUnit");
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Failing test output is included in the HTML result")]
        public virtual void FailingTestOutputIsIncludedInTheHTMLResult_MsTest()
        {
            this.FailingTestOutputIsIncludedInTheHTMLResult("MsTest");
        }
        
        public virtual void FailingTestExceptionIsIncludedInTheHTMLResult(string unittest)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Failing test exception is included in the HTML result", ((string[])(null)));
#line 112
this.ScenarioSetup(scenarioInfo);
#line 113
testRunner.Given(string.Format("there are {0} test execution results for the ReportingTest.SampleProject project", unittest));
#line 114
testRunner.When(string.Format("I generate SpecFlow {0} execution report", unittest));
#line hidden
#line 115
testRunner.Then("a report generated containing", "simulated failure\r\nat ReportingTest.SampleProject.StepDefinitions.GivenIHaveAPrec" +
                    "onditionThatIs(String result) in ", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Failing test exception is included in the HTML result")]
        public virtual void FailingTestExceptionIsIncludedInTheHTMLResult_NUnit()
        {
            this.FailingTestExceptionIsIncludedInTheHTMLResult("NUnit");
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Failing test exception is included in the HTML result")]
        public virtual void FailingTestExceptionIsIncludedInTheHTMLResult_MsTest()
        {
            this.FailingTestExceptionIsIncludedInTheHTMLResult("MsTest");
        }
    }
}
#endregion
