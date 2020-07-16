using System;
using AutomationPracticeLibrary;
using AutomationPracticeLibrary.Pages;
using AutomationPracticeLibrary.Sections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationPracticeTests
{
    [TestClass]
    public class BaseTest
    {
        public HomePage HomePage;
        public AuthenticationSection AuthenticationSection;

        [TestInitialize]
        public void SetUp()
        {
            Driver.Initialize();
            HomePage = new HomePage();
            AuthenticationSection = new AuthenticationSection();          
            Driver.OpenUrl();
        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Instance.Quit();
        }

        public TestContext TestContext {get;set;}
    }
}
