using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;

namespace AutomationPracticeLibrary
{
    public class Driver
    {
        public static IWebDriver Instance;

        public static void Initialize()
        {
            Instance = new ChromeDriver(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName);
            Instance.Manage().Window.Maximize();
        }
            public static void OpenUrl()
        {
            Instance.Navigate().GoToUrl("http://automationpractice.com");
        }
    }
}
