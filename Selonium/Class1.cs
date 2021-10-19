using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Selonium
{
    [TestFixture]
    public class Class1
    {
        IWebDriver webDriver = new ChromeDriver();
        //Actions action = new Actions(driver);
        [TestCase]
        public void mainTatle()
        {
            //webDriver.Url = "";
            //Thread.Sleep(2000);
            //IWebElement market = webDriver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[3]/div/div[2]/nav/div/ul/li[1]/a/div[1]"));
            //market.Click();


            //webDriver.Url = "";
            //Thread.Sleep(2000);
            //IWebElement robot = webDriver.FindElement(By.XPath("/html/body/div[1]/div/div/div[3]/div/form/div/div[1]/input"));
            //robot.Click();
            //Thread.Sleep(2000);
            //webDriver.FindElement(By.CssSelector("body")).SendKeys(Keys.Control + Keys.NumberPad1);
            //webDriver.Url = "market.yandex.ru/?clid=505&utm_source=main_stripe_big&src_pof=505&icookie=NvxfaZbQpp%2F2rmXBUdZCZoaNVjpnGyIp1jDX4L9Z2XoRtMUKMqoBowkQlav5LrxUN96MB%2Fkmhl2iycqp4HXcINFxU0A%3D&utm_source_service=morda";
            //IWebElement robot = webDriver.FindElement(By.XPath("/html/body/div[1]/div/div/div[3]/div/form/div/div[1]/input"));
            //robot.Click();
            //Actions action = new Actions(driver);
            //action.MoveByOffset(500, 500).ContextClick().Build().Perform();
            
        }
    }
}
