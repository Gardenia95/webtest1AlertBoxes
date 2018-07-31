using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


    class Program
    {

    static IWebDriver driver = new ChromeDriver();
    static IAlert alert;
    static IWebElement image;

        static void Main()
        {
        string url = "http://testing.todvachev.com/special-elements/alert-box/";

        driver.Navigate().GoToUrl(url);
        alert = driver.SwitchTo().Alert();
        Console.WriteLine(alert.Text);

        alert.Accept();

        image=driver.FindElement(By.CssSelector("#post-119 > div > figure > img"));
        try
        {
            if (image.Displayed)
            {
                Console.WriteLine("Se puede ver la imagen");
            }
        }
        catch(NoSuchElementException)
        {
            Console.WriteLine(" No se puede ver la imagen");
        }


        Thread.Sleep(3000);
        driver.Quit();
        }
    }

