using OpenQA.Selenium;
using prmToolkit.Selenium;
using System;
using OpenQA.Selenium.Chrome;
using System.Configuration.Assemblies;
using prmToolkit.Configuration;


namespace BotInstaSeguidor
{
    class Program
    {
        static void Main(string[] args) 
        {
            var driver = new ChromeDriver();
            var passuser = Configuration.GetKeyAppSettings("senhainsta");
            var username = Configuration.GetKeyAppSettings("usuarioinsta");
            var perfilseg = Configuration.GetKeyAppSettings("pagusuario");
            try
            {
                driver.LoadPage(TimeSpan.FromSeconds(5), "https://www.instagram.com/");
                Thread.Sleep(TimeSpan.FromSeconds(2));
                driver.SetText(By.Name("username"), username);
                Thread.Sleep(TimeSpan.FromSeconds(2));
                driver.SetText(By.Name("password"), passuser);
                Thread.Sleep(TimeSpan.FromSeconds(2));
                driver.Submit(By.TagName("button"));
                Thread.Sleep(TimeSpan.FromSeconds(3));
                driver.LoadPage(TimeSpan.FromSeconds(5), perfilseg );
                driver.FindElement(By.XPath("//button[contains(text(), 'Seguir')]")).Click();

            }
            catch (Exception err)
            {

                Console.WriteLine(err.ToString());
            }
            finally
            {
                driver.Close(); 
                driver.Dispose();
            }



        }
    }
}