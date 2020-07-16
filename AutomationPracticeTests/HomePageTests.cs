using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationPracticeTests
{
    [TestClass]
    public class HomePageTests : BaseTest
    {
        [DeploymentItem("TestData\\TestData.csv"), DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "TestData.csv",
            "TestData#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void CreateAccount()
        {
            HomePage.GoToSignIn();
            AuthenticationSection.CreateAccount(TestContext.DataRow["email"].ToString());
            AuthenticationSection.SelectTitle(TestContext.DataRow["title"].ToString())
                .EnterFirstName(TestContext.DataRow["firstName"].ToString())
                .EnterLastName(TestContext.DataRow["lastName"].ToString())
                .EnterEmail(TestContext.DataRow["email"].ToString())
                .EnterPassword(TestContext.DataRow["password"].ToString())
                .SelectDateOfBirth(TestContext.DataRow["day"].ToString(), TestContext.DataRow["month"].ToString(), TestContext.DataRow["year"].ToString());

            AuthenticationSection.EnterAddressFirstName(TestContext.DataRow["addressFirstName"].ToString())
                .EnterAddressLastName(TestContext.DataRow["addressLastName"].ToString())
                .EnterAddressCompany(TestContext.DataRow["company"].ToString())
                .EnterAddressFirstLine(TestContext.DataRow["addressLine1"].ToString())
                .EnterAddressSecondLine(TestContext.DataRow["addressLine2"].ToString())
                .EnterAddressCity(TestContext.DataRow["city"].ToString())
                .SelectState(TestContext.DataRow["state"].ToString())
                .EnterZipCode(TestContext.DataRow["zip"].ToString())
                .SelectCountry(TestContext.DataRow["country"].ToString())
                .ProvideAdditionalInformation(TestContext.DataRow["additionalInfo"].ToString())
                .EnterHomePhone(TestContext.DataRow["homePhone"].ToString())
                .EnterMobilePhone(TestContext.DataRow["mobilePhone"].ToString())
                .AssignAlias(TestContext.DataRow["alias"].ToString())
                .Submit();

            Assert.IsTrue(HomePage.VerifyUserIsLogedIn(), "Sign out button is not visible. User is not logged in");
        }

        [TestMethod]
        public void CheckNumberOfProducts()
        {
            Assert.AreEqual(7, HomePage.GetNumberOfPopularItems(), "Number of popular items isn't 7. Expected is 7, but actual is: " + HomePage.GetNumberOfPopularItems());
            Assert.AreEqual(7, HomePage.GetNumberOfBestSellerItems(), "Number of best seller items isn't 7. Expected is 7, but actual is: " + HomePage.GetNumberOfBestSellerItems());
        }


        [DeploymentItem("TestData\\TestData.csv"), DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "TestData.csv",
            "TestData#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void SearchForProduct()
        {
            HomePage.SearchForItemAndWriteResults(TestContext.DataRow["searchItem"].ToString());
        }
    }
}
