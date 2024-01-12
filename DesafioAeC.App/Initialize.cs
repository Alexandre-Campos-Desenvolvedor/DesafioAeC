using DesafioAeC.Services;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAeC.App
{
    internal class Initialize
    {
        private readonly IAluraServices _aluraServices;

        public Initialize(IAluraServices aluraServices)
        {
            _aluraServices = aluraServices;            
        }

        public void Run()
        {
            _aluraServices.NavigateDomainAlura();
        }
    }
}
