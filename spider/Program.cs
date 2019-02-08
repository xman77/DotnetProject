using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace spider
{
    class Program
    {
        static void Main(string[] args)
        {
            //var driver = new ChromeDriver("./");
            //driver.Url = "http://www.google.com";
            //driver.Manage().Window.Maximize();
            //Thread.Sleep(2000);
            //IWebElement inputAccount = driver.FindElementByXPath("//*[@id=\"tsf\"]/div[2]/div/div[1]/div/div[1]/input");
            //inputAccount.Clear();
            //Thread.Sleep(2000);
            //inputAccount.SendKeys("selenium");
            //inputAccount.Submit();
            //Thread.Sleep(2000);
            //driver.Quit();
            var driver = new ChromeDriver("./");
            //開啟網頁
            driver.Navigate().GoToUrl("https://louislinebot.azurewebsites.net/Login");
            //隱式等待 - 直到畫面跑出資料才往下執行
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10000);

            //輸入帳號
            IWebElement inputAccount = driver.FindElement(By.Name("Account"));
            Thread.Sleep(2000);
            //清除按鈕
            inputAccount.Clear();
            Thread.Sleep(2000);
            inputAccount.SendKeys("20180513");
            Thread.Sleep(2000);

            //輸入密碼
            IWebElement inputPassword = driver.FindElement(By.Name("Passwrod"));

            inputPassword.Clear();
            Thread.Sleep(2000);
            inputPassword.SendKeys("123456");
            Thread.Sleep(2000);

            //點擊執行
            IWebElement submitButton = driver.FindElement(By.XPath("/html/body/div[2]/form/table/tbody/tr[4]/td[2]/input"));
            Thread.Sleep(2000);
            submitButton.Click();
            Thread.Sleep(2000);

            driver.Quit();
        }
    }
}
