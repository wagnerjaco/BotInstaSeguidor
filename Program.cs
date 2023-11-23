using OpenQA.Selenium;
using prmToolkit.Selenium;
using System;
using OpenQA.Selenium.Chrome;

namespace BotInstaSeguidor
{
    class Program
    {
        static void Main(string[] args) 
        {
            var driver = new ChromeDriver();

            try
            {
                driver.LoadPage(TimeSpan.FromSeconds(20), "https://www.google.com");
                driver.SetText(By.Name("username"), "wagner.jaco");
                driver.SetText(By.Name("password"), "131995Wa");
            }
            catch (Exception err)
            {

                Console.WriteLine(err.ToString());
            }
            driver.LoadPage(TimeSpan.FromSeconds(20), "https://www.google.com");


        }
    }
}