using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Demo0
{
    public class Tests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://testlogin.onenfinity.com/User/Login?returnUrl=https%3A%2F%2Ftesthrms.onenfinity.com%2F");
            driver.FindElement(By.XPath("//input[contains(@id,'Username')]")).SendKeys("vaibhavc121@demo.com");
            driver.FindElement(By.XPath("//input[contains(@id,'Password')]")).SendKeys("rohitc121");
            driver.FindElement(By.XPath("//span[text()='Sign In']")).Click();
            
        }
    }
}