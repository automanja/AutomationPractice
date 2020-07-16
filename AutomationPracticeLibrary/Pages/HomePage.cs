using AutomationPracticeLibrary.Manager;
using AutomationPracticeLibrary.Repository;
using AutomationPracticeLibrary.Selenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace AutomationPracticeLibrary.Pages
{
    public class HomePage: HomeRepo
    {
        DataManager dataManager = new DataManager();
        public HomePage()
        {
            PageFactory.InitElements(Driver.Instance, this);
        }

        public void GoToSignIn()
        {
            PageUtils.click(signInButton);

        }

        public bool VerifyUserIsLogedIn()
        {
            if (!PageUtils.WaitForElement(signOutButton)) return false;
            return true;
        }

        public int GetNumberOfPopularItems()
        {
            IReadOnlyCollection<IWebElement> listOfItems = Driver.Instance.FindElements(By.XPath("//ul[@id='homefeatured']/li"));
            return listOfItems.Count;
        }

        public int GetNumberOfBestSellerItems()
        {
            IReadOnlyCollection<IWebElement> listOfItems = Driver.Instance.FindElements(By.XPath("//ul[@id='homefeatured']/li"));
            return listOfItems.Count;
        }

        public void SearchForItem(string item)
        {
            PageUtils.enter(searchTextBox, item);
            PageUtils.click(searchButton);
        }

        public void SearchForItemAndWriteResults(string item)
        {
            PageUtils.enter(searchTextBox, item);
            PageUtils.click(searchButton);

            IReadOnlyCollection<IWebElement> listOfDresses= Driver.Instance.FindElements(By.XPath("//*[@itemprop='name']"));
            foreach(IWebElement element in listOfDresses)
            {
                dataManager.WriteResults( element.FindElement(By.XPath("a")).Text);
            }
        }
    }
}
