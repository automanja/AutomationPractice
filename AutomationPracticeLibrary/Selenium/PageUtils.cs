using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomationPracticeLibrary.Selenium
{
    public class PageUtils
    {
        public static bool click(IWebElement obj, int seconds)
        {
            if (checkIfClickable(obj, seconds))
            {
                try
                {
                    obj.Click();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
            else return false;
        }

        public static bool click(IWebElement obj)
        {
            return click(obj, 20);
        }

        public static bool enter(IWebElement obj, string text)
        {
            return enter(obj, text, 20);
        }

        public static bool enter(IWebElement obj, string text, int seconds)
        {
            try
            {
                if (checkIfClickable(obj, seconds))
                {
                    obj.Clear();
                    obj.SendKeys(text);
                    return true;
                }
                else return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool selectByText(IWebElement obj, string value)
        {
            try
            {
                SelectElement dropdown = new SelectElement(obj);
                dropdown.SelectByText(value);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool selectByValue(IWebElement obj, string value)
        {
            try
            {
                SelectElement dropdown = new SelectElement(obj);
                dropdown.SelectByValue(value);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool checkIfClickable(IWebElement obj, int seconds)
        {
            var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(seconds));
            try
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(obj));
                return true;
            }
            catch { return false; }
        }

        public static bool WaitForElement(IWebElement obj, int seconds)
        {
            try
            {
                return new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(seconds)).Until(d => obj.Displayed);
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public static bool WaitForElement(IWebElement obj)
        {
            return WaitForElement(obj, 15);
        }
    }
}
