using DesafioAeC.Domain.Entities;
using DesafioAeC.Domain.Iterfaces;
using DesafioAeC.Services.Util;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace DesafioAeC.Services
{
    public class AluraServices : WebDriverBase, IAluraServices
    {
        private readonly ICoursesRepository _coursesRepository;

        public AluraServices(ICoursesRepository coursesRepository)
        {
            _coursesRepository = coursesRepository;
        }

        public async void NavigateDomainAlura()
        {

            _driver.Navigate().GoToUrl("https://www.alura.com.br/");
            _driver.FindElement(By.Id("header-barraBusca-form-campoBusca")).SendKeys("RPA");
            _driver.FindElement(By.XPath("/html/body/main/section[1]/header/div/nav/div[2]/form/button")).Click();
            _driver.FindElement(By.XPath("//*[@id=\"busca-resultados\"]/ul/li[4]/a")).Click();

            Courses courses = SetElements();

            if (ValidateCourses(courses))
                if (await Save(courses)) Console.WriteLine("Curso salvo com sucesso!");

            Console.Read();
        }

        private Courses SetElements()
        {
            Courses courses = new Courses();

            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            IWebElement title = wait.Until<IWebElement>((d) =>
            {
                return d.FindElement(By.ClassName("formacao-headline-titulo"));
            });

            IWebElement teacher = wait.Until<IWebElement>((d) =>
            {
                return d.FindElement(By.XPath("//*[@id=\"instrutores\"]/div/ul/li[2]/div/h3"));
            });

            courses.Title = title.Text;
            courses.Teacher = teacher.Text;
            courses.WorkLoad = _driver.FindElement(By.XPath("/html/body/main/section[1]/article[2]/div/div[1]/div[2]/div")).Text;
            courses.Description = _driver.FindElement(By.ClassName("formacao-sobre-descricao")).Text.Replace("'", "");
            return courses;
        }

        private bool ValidateCourses(Courses courses)
        {

            if (string.IsNullOrEmpty(courses.Title))
            {
                Console.WriteLine("Título está nulo.");
                return false;
            }
            else if (string.IsNullOrEmpty(courses.Description))
            {
                Console.WriteLine("Descrição está nulo.");
                return false;
            }
            else if (string.IsNullOrEmpty(courses.WorkLoad))
            {
                Console.WriteLine("Carga horária está nulo.");
                return false;
            }
            else if (string.IsNullOrEmpty(courses.Teacher))
            {
                Console.WriteLine("Professor está nulo.");
                return false;
            }

            return true;
        }

        public async Task<bool> Save(Courses courses)
        {

            var save = await _coursesRepository.CreateAsync(courses);
            return save;
        }


    }
}