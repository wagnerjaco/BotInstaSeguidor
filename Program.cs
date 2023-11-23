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
            
            driver.LoadPage(TimeSpan.FromSeconds(20), "https://www.google.com");


        }
    }
}