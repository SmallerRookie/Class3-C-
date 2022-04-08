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
    public class LoginPage
    {
        [FindsBy(How = How.Id, Using = "login_username")]
        private IWebElement userName;

        [FindsBy(How = How.Id, Using = "login_password")]
        private IWebElement passWord;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/div/div[2]/form/div[4]/button")]
        private IWebElement button;

        public void Login (string name, string password)
        {
            WebDriverWait wait = new WebDriverWait(Broswer.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("login_username")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("login_password")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div[1]/div/div[2]/form/div[4]/button")));

            userName.Click();
            userName.SendKeys(name);
            passWord.Click();
            passWord.SendKeys(password);
            button.Click();
        }
    }
}
