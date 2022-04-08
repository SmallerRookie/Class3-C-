using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    public class Pages
    {
        public static HomePage HomePage
        {
            get
            {
                HomePage homePage = new HomePage();
                PageFactory.InitElements(Broswer.Driver, homePage);
                return homePage;
            }

        }
        public static LoginPage LoginPage
        {
            get
            {
                var loginPage = new LoginPage();
                PageFactory.InitElements(Broswer.Driver, loginPage);
                return loginPage;
            }

        }
        public static ListPage ListPage
        {
            get
            {
                var listPage = new ListPage();
                PageFactory.InitElements(Broswer.Driver, listPage);
                return listPage;
            }

        }
    }
}
