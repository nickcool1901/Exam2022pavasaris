using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        IWebDriver driver;

        public Form1()
        {
            InitializeComponent();
            var options = new ChromeOptions();
            options.AddExcludedArgument("enable-logging");

            // Šeit bija sintakses kļūda, izlabota norāde uz ChromeDriver ceļu
            driver = new ChromeDriver(@"C:\Users\user\Desktop\chromedriver-win64", options);
            driver.Url = "https://www.ebay.com/";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IWebElement element = driver.FindElement(By.Id("gh-ac"));
            textBox2.Text = textBox1.Text;
            element.SendKeys(textBox1.Text);

            IWebElement searchButton = driver.FindElement(By.Id("gh-btn"));
            searchButton.Click();

            // Pievienots jauns rindiņš, lai meklēšanas rezultātu saite būtu labi pārskatāma
            string currentURL = driver.Url;
            richTextBox1.Text += currentURL + Environment.NewLine;
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void textBox2_TextChanged(object sender, EventArgs e) { }

        private void richTextBox1_TextChanged(object sender, EventArgs e) { }

        private void button3_Click(object sender, EventArgs e)
        {
            driver.Navigate().Back();

            // Iztīra meklēšanas lauku un rezultātu lauku
            textBox2.Text = "";
            richTextBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Aizver pārlūkprogrammu
            driver.Quit();
        }
    }
}
