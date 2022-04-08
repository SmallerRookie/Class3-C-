using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    public class HomePage
    {
        static string Url = "https://lyratesting2.co.nz/";

        [FindsBy(How = How.LinkText, Using = "登录")]
        private IWebElement login;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section[4]/div/div[3]/a")]
        private IWebElement loadMore;

        public void SelectLogin()
        {
            WebDriverWait wait = new WebDriverWait(Broswer.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("登录")));
            login.Click();
        }
       public void SelectLoadMore()
        {
            WebDriverWait wait = new WebDriverWait(Broswer.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/section[4]/div/div[3]/a")));
            loadMore.Click();
        }

        public void GoTo()
        {
            Broswer.Goto(Url);
        }
    }
}

