using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    public static class Broswer
    {
        static IWebDriver webDriver = new FirefoxDriver();

        public static string Title
        {
            get { return webDriver.Title; }
        }
        public static ISearchContext Driver
        {
            get { return webDriver; }
        }
        public static IWebDriver Driver2
        {
            get { return webDriver; }
        }
        public static void Goto(string url)
        {
            webDriver.Url = url;
        }
        public static void Close()
        {
            webDriver.Quit();
        }
    }
}
