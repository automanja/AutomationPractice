using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPracticeLibrary.Repository
{
    public class HomeRepo
    {
        [FindsBy(How = How.ClassName, Using = "login")]
        protected IWebElement signInButton { get; set; }

        [FindsBy(How = How.ClassName, Using = "logout")]
        protected IWebElement signOutButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@id='homefeatured']//div[@class='product - image - container']")]
        protected IWebElement popularItem { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@id='homefeatured']//div[@class='product - image - container']")]
        protected IWebElement bestSellerItem { get; set; }

        [FindsBy(How = How.Name, Using = "submit_search")]
        protected IWebElement searchButton { get; set; }

        [FindsBy(How = How.Id, Using = "search_query_top")]
        protected IWebElement searchTextBox{ get; set; }

    }
}
