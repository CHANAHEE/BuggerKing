using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Threading;

namespace BuggerKingEvent_Macro
{
    public partial class MacroMain : Form
    {
        public MacroMain()
        {
            InitializeComponent();
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://burgerkingevent.com/");

            IWebElement button = driver.FindElement(By.XPath("//*[@id=\"main\"]/section[2]/div/img[2]"));

            button.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            Thread.Sleep(5000);

            IWebElement elementWithDataWord_블 = driver.FindElement(By.CssSelector("[data-word='블']"));
            IWebElement elementWithDataWord_양 = driver.FindElement(By.CssSelector("[data-word='양']"));
            IWebElement elementWithDataWord_화 = driver.FindElement(By.CssSelector("[data-word='화']"));
            IWebElement elementWithDataWord_와 = driver.FindElement(By.CssSelector("[data-word='와']"));
            IWebElement elementWithDataWord_피 = driver.FindElement(By.CssSelector("[data-word='피']"));

            elementWithDataWord_블.Click();
            elementWithDataWord_양.Click();
            elementWithDataWord_양.Click();
            elementWithDataWord_블.Click();
            elementWithDataWord_피.Click();
            elementWithDataWord_화.Click();
            elementWithDataWord_와.Click();
            elementWithDataWord_와.Click();
            elementWithDataWord_화.Click();
            elementWithDataWord_와.Click();
            elementWithDataWord_와.Click();
            elementWithDataWord_화.Click();
            elementWithDataWord_블.Click();

        }


    }
}
