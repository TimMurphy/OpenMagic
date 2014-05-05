﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.34014
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace OpenMagic.Tests.Extensions
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class TimeSpanExtensions_WarnWhenGreaterThanFeature : Xunit.IUseFixture<TimeSpanExtensions_WarnWhenGreaterThanFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "TimeSpanExtensions_WarnWhenGreaterThan.feature"
#line hidden
        
        public TimeSpanExtensions_WarnWhenGreaterThanFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "TimeSpanExtensions - WarnWhenGreaterThan", "", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
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
        
        public virtual void SetFixture(TimeSpanExtensions_WarnWhenGreaterThanFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "TimeSpanExtensions - WarnWhenGreaterThan")]
        [Xunit.TraitAttribute("Description", "Elapsed time is less than maximum")]
        public virtual void ElapsedTimeIsLessThanMaximum()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Elapsed time is less than maximum", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line 4
 testRunner.Given("elapsed time is \'100\' milliseconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 5
 testRunner.And("maximum is \'200\' milliseconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 6
 testRunner.And("warning message template is \'fake method took {milliseconds}ms.\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 7
 testRunner.When("WarnWhenGreaterThan(stopwatch, message) is called", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 8
 testRunner.Then("a warning is not logged", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "TimeSpanExtensions - WarnWhenGreaterThan")]
        [Xunit.TraitAttribute("Description", "Elapsed time is equal to maximum")]
        public virtual void ElapsedTimeIsEqualToMaximum()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Elapsed time is equal to maximum", ((string[])(null)));
#line 10
this.ScenarioSetup(scenarioInfo);
#line 11
 testRunner.Given("elapsed time is \'100\' milliseconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 12
 testRunner.And("maximum is \'200\' milliseconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.And("warning message template is \'fake method took {milliseconds}ms.\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.When("WarnWhenGreaterThan(stopwatch, message) is called", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
 testRunner.Then("a warning is not logged", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "TimeSpanExtensions - WarnWhenGreaterThan")]
        [Xunit.TraitAttribute("Description", "Elapsed time is greater than maximum and warning message template uses {milliseco" +
            "nds}")]
        public virtual void ElapsedTimeIsGreaterThanMaximumAndWarningMessageTemplateUsesMilliseconds()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Elapsed time is greater than maximum and warning message template uses {milliseco" +
                    "nds}", ((string[])(null)));
#line 17
this.ScenarioSetup(scenarioInfo);
#line 18
 testRunner.Given("elapsed time is \'300\' milliseconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 19
 testRunner.And("maximum is \'200\' milliseconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.And("warning message template is \'fake method took {milliseconds}ms.\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
 testRunner.When("WarnWhenGreaterThan(stopwatch, message) is called", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
 testRunner.Then("\'fake method took 300ms.\' is added to the log", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "TimeSpanExtensions - WarnWhenGreaterThan")]
        [Xunit.TraitAttribute("Description", "Elapsed time is greater than maximum and warning message template uses {0}")]
        public virtual void ElapsedTimeIsGreaterThanMaximumAndWarningMessageTemplateUses0()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Elapsed time is greater than maximum and warning message template uses {0}", ((string[])(null)));
#line 24
this.ScenarioSetup(scenarioInfo);
#line 25
 testRunner.Given("elapsed time is \'300\' milliseconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 26
 testRunner.And("maximum is \'200\' milliseconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.And("warning message template is \'fake method took {0}.\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.When("WarnWhenGreaterThan(stopwatch, message) is called", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
 testRunner.Then("\'fake method took 00:00:00.3000000.\' is added to the log", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                TimeSpanExtensions_WarnWhenGreaterThanFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                TimeSpanExtensions_WarnWhenGreaterThanFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
