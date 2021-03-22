using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaTestePadra.Pages
{
    class HomePage_Page
    {

        private IWebDriver driver;
        public HomePage_Page(IWebDriver superDriver)
        {
            driver = superDriver;
        }

        public IWebElement linkItemPresentInSalle()
        {
            return driver.FindElement(By.XPath("//*[@id='homefeatured']/li[1]/div/div[2]/h5/a"));
        }

        public IWebElement linkFormulario()
        {
            return driver.FindElement(By.LinkText("Formulário"));
        }

        public IWebElement linkCriarUsuario()
        {
            return driver.FindElement(By.XPath("//a[text()='Criar Usuários']"));
        }

        public IWebElement txtNome()
        {
            return driver.FindElement(By.Id("user_name"));
        }

        internal object txtnome()
        {
            throw new NotImplementedException();
        }

        public IWebElement txtSobrenome()
        {
            return driver.FindElement(By.Id("user_lastname"));
        }

        public IWebElement txtEmail()
        {
            return driver.FindElement(By.Id("user_email"));
        }

        public IWebElement btnSubmit()
        {
            return driver.FindElement(By.Name("commit"));
        }

    }
}
