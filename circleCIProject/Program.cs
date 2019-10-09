using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleCIProject
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://cloud.google.com");
            Thread.Sleep(3000);
            Console.WriteLine("the page is opened");
            driver.Quit();
            Console.WriteLine("the page is closed");
        }
    }
}
