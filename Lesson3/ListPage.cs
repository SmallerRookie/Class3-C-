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
    public class ListPage
    {
        [FindsBy(How = How.LinkText, Using = "产品介绍")]
        private IWebElement products;
        public void SelectProduct()
        {
            WebDriverWait wait = new WebDriverWait(Broswer.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("产品介绍")));
            products.Click();
        }
    }
}
