using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAeC.Services.Util
{
    public class WebDriverBase : IDisposable
    {
        protected readonly IWebDriver _driver;
        protected TimeSpan timeoutDriver = TimeSpan.FromSeconds(10);
        public WebDriverBase()
        {
            _driver = new ChromeDriver();

            
        }
        public void Dispose()
        {
            _driver.Quit();
            _driver.Dispose();
        }        
    }
}
