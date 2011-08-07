// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.7.0.0
//      SpecFlow Generator Version:1.7.0.0
//      Runtime Version:4.0.30319.225
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace ParserTests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.7.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("In order to find out easily what is wrong with a Gherkin file\r\nAs a SpecFlow user" +
        "\r\nI want to get proper error messages when the files are parsed")]
    public partial class ProvidingMeaningfulErrorsForWrongGherkinFilesFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ParsingErrors.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Providing meaningful errors for wrong Gherkin files", "In order to find out easily what is wrong with a Gherkin file\r\nAs a SpecFlow user" +
                    "\r\nI want to get proper error messages when the files are parsed", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Wrongly spelled feature keyword")]
        public virtual void WronglySpelledFeatureKeyword()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Wrongly spelled feature keyword", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 7
 testRunner.Given("there is a Gherkin file as", "\tFeaturX: wrong feature", ((TechTalk.SpecFlow.Table)(null)));
#line 11
 testRunner.When("I parse the file");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "line",
                        "error"});
            table1.AddRow(new string[] {
                        "1",
                        "Parsing error near \'FeaturX"});
#line 12
 testRunner.Then("the the following errors are provided", ((string)(null)), table1);
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Wrongly spelled step keyword")]
        public virtual void WronglySpelledStepKeyword()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Wrongly spelled step keyword", ((string[])(null)));
#line 16
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 17
 testRunner.Given("there is a Gherkin file as", "\tFeature: misspelled step keyword\r\n\r\n\tScenario: misspelled step keyword\r\n\t\tGiven " +
                    "something\r\n\t\tWhenX something is misspelled", ((TechTalk.SpecFlow.Table)(null)));
#line 25
 testRunner.When("I parse the file");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "line",
                        "error"});
            table2.AddRow(new string[] {
                        "5",
                        "Parsing error near \'WhenX"});
#line 26
 testRunner.Then("the the following errors are provided", ((string)(null)), table2);
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Wrongly spelled scenario outline")]
        public virtual void WronglySpelledScenarioOutline()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Wrongly spelled scenario outline", ((string[])(null)));
#line 30
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 31
 testRunner.Given("there is a Gherkin file as", "\tFeature: Wrongly spelled scenario outline\r\n\r\n\t@dummy_tag\r\n\tScenario OutlinX: Wro" +
                    "ngly spelled scenario outline\r\n\t\tGiven something\r\n\r\n\tExamples:\r\n\t\t| something |", ((TechTalk.SpecFlow.Table)(null)));
#line 42
 testRunner.When("I parse the file");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "line",
                        "error"});
            table3.AddRow(new string[] {
                        "4",
                        "Parsing error near \'Scenario OutlinX"});
#line 43
 testRunner.Then("the the following errors are provided", ((string)(null)), table3);
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Table cell count mismatch")]
        public virtual void TableCellCountMismatch()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Table cell count mismatch", ((string[])(null)));
#line 47
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 48
 testRunner.Given("there is a Gherkin file as", "\tFeature: Table cell count mismatch\r\n\r\n\tScenario: Table cell count mismatch\r\n\t\tGi" +
                    "ven a table\r\n\t\t\t| h1 | h2 |\r\n\t\t\t| c1 | c2 | c3 |", ((TechTalk.SpecFlow.Table)(null)));
#line 57
 testRunner.When("I parse the file");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "line",
                        "error"});
            table4.AddRow(new string[] {
                        "6",
                        "Number of cells in the row does not match the number of cells in the header"});
#line 58
 testRunner.Then("the the following errors are provided", ((string)(null)), table4);
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Scenario outline without examples")]
        public virtual void ScenarioOutlineWithoutExamples()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Scenario outline without examples", ((string[])(null)));
#line 62
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 63
 testRunner.Given("there is a Gherkin file as", "\tFeature: Delayed semantic error\r\n\r\n\tScenario Outline: Scenario outline without e" +
                    "xamples\r\n\t\tGiven something\r\n\r\n\tScenario: proper scenario\r\n\t\tGiven something", ((TechTalk.SpecFlow.Table)(null)));
#line 73
 testRunner.When("I parse the file");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "line",
                        "error"});
            table5.AddRow(new string[] {
                        "3",
                        "There are no examples defined for the scenario outline"});
#line 74
 testRunner.Then("the the following errors are provided", ((string)(null)), table5);
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Empty example set")]
        public virtual void EmptyExampleSet()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Empty example set", ((string[])(null)));
#line 78
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 79
 testRunner.Given("there is a Gherkin file as", "\tFeature: Empty example set\r\n\r\n\tScenario Outline: Scenario outline without exampl" +
                    "es\r\n\t\tGiven <something>\r\n\r\n\tExamples: ", ((TechTalk.SpecFlow.Table)(null)));
#line 88
 testRunner.When("I parse the file");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "line",
                        "error"});
            table6.AddRow(new string[] {
                        "7",
                        "Parsing error"});
#line 89
 testRunner.Then("the the following errors are provided", ((string)(null)), table6);
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Language not supported")]
        public virtual void LanguageNotSupported()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Language not supported", ((string[])(null)));
#line 93
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 94
 testRunner.Given("there is a Gherkin file as", "\t#language: invalid-lang\r\n\tFeature: Invalid language", ((TechTalk.SpecFlow.Table)(null)));
#line 99
 testRunner.When("I parse the file");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "line",
                        "error"});
            table7.AddRow(new string[] {
                        "1",
                        "The specified feature file language (\'invalid\') is not supported."});
#line 100
 testRunner.Then("the the following errors are provided", ((string)(null)), table7);
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Duplicated scenario name")]
        public virtual void DuplicatedScenarioName()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Duplicated scenario name", ((string[])(null)));
#line 104
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 105
 testRunner.Given("there is a Gherkin file as", "\tFeature: Duplicated scenario name\r\n\r\n\tScenario: Duplicated scenario\r\n\t\tGiven som" +
                    "ething\r\n\r\n\tScenario: Duplicated scenario \r\n\t\tGiven something", ((TechTalk.SpecFlow.Table)(null)));
#line 115
 testRunner.When("I parse the file");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "line",
                        "error"});
            table8.AddRow(new string[] {
                        "6",
                        "Feature file already contains a scenario with name \'Duplicated scenario\'"});
#line 116
 testRunner.Then("the the following errors are provided", ((string)(null)), table8);
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Duplicated example set name")]
        public virtual void DuplicatedExampleSetName()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Duplicated example set name", ((string[])(null)));
#line 120
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 121
 testRunner.Given("there is a Gherkin file as", "\tFeature: Duplicated example set name\r\n\r\n\tScenario Outline: Scenario outline\r\n\t\tG" +
                    "iven <something>\r\n\r\n\tExamples: duplicated example set\r\n\t\t| something |\r\n\r\n\tExamp" +
                    "les: duplicated example set\r\n\t\t| something |", ((TechTalk.SpecFlow.Table)(null)));
#line 134
 testRunner.When("I parse the file");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "line",
                        "error"});
            table9.AddRow(new string[] {
                        "9",
                        "Scenario outline already contains an example set name \'duplicated example set\'"});
#line 135
 testRunner.Then("the the following errors are provided", ((string)(null)), table9);
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Duplicated background")]
        public virtual void DuplicatedBackground()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Duplicated background", ((string[])(null)));
#line 139
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 140
 testRunner.Given("there is a Gherkin file as", "\tFeature: Duplicated background\r\n\r\n\tBackground: \r\n\t\tGiven something\r\n\r\n\tBackgroun" +
                    "d: \r\n\t\tGiven something else", ((TechTalk.SpecFlow.Table)(null)));
#line 150
 testRunner.When("I parse the file");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "line",
                        "error"});
            table10.AddRow(new string[] {
                        "6",
                        "Feature file already contains a background section."});
#line 151
 testRunner.Then("the the following errors are provided", ((string)(null)), table10);
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#endregion
