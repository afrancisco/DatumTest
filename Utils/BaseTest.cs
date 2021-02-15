using Coypu;
using Coypu.Drivers.Selenium;
using NUnit.Framework;
using System;

namespace DatumProcesso.Utils
{
    public class BaseTest
    {
        protected BrowserSession Browser;
        protected SessionConfiguration Configs;

        [SetUp]
        public void Setup()
        {
            Configs = new SessionConfiguration
            {
                AppHost = "http://automationpractice.com/",
                SSL = false,
                Browser = Coypu.Drivers.Browser.Chrome,
                Driver = typeof(SeleniumWebDriver),
                Timeout = TimeSpan.FromSeconds(20)
            };
            Browser = new BrowserSession(Configs);
            Browser.MaximiseWindow();
            Browser.Visit("/");

        }
        [TearDown]
        public void Dispose()
        {
            Browser.Dispose();
        }
        public void acessar(){
          
        }
    }
}