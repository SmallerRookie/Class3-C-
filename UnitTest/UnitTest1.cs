using System;
using Lesson3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Pages.HomePage.GoTo();
            Pages.HomePage.SelectLogin();
            Pages.LoginPage.Login("test001", "Test1234");
            Pages.HomePage.SelectLoadMore();
            Pages.ListPage.SelectProduct();
        }
    }
}
