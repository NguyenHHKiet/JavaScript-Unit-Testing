using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Chromium;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, ketqua;
            a = int.Parse(txt_1.Text);
            b = int.Parse(txt_2.Text);
            Calculation c = new Calculation(a, b);
            ketqua = c.Execute("+");
            txt_kq.Text = ketqua.ToString();
        }

        private void btPower_Click(object sender, EventArgs e)
        {
            int n;
            double x, ketQua;
            x = int.Parse(txt_1.Text);
            n=int.Parse(txt_2.Text);

            ketQua = Calculation.Power(x,n);
            txt_kq.Text = ketQua.ToString();
        }

        private void btBrowser_Click(object sender, EventArgs e)
        {
            // dien huong trinh duyet
            IWebDriver driver = new ChromeDriver();
            // driver.Navigate().GoToUrl("https://vnexpress.net/");
            driver.Url = "https://vnexpress.net/";
            driver.Navigate();
        }

        //so 9 Hoang Kiet
        private void btURL_Click(object sender, EventArgs e)
        {
            // tat man hinh den
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;
            // dien huong trinh duyet
            IWebDriver driver = new ChromeDriver(chrome);
            if (txt_URL.Text == "")
            {
                //driver.Navigate().GoToUrl("https://vnexpress.net/");
                driver.Url = "https://vnexpress.net/";
            }
            else
            {
                driver.Url = txt_URL.Text;
            }

            // get link
            String link_Hientai = driver.Url;
            Console.WriteLine("get link: \n" + link_Hientai);
            txt_URL.Text = link_Hientai.ToString();

            // get title
            String urlTitle = driver.Title;
            Console.WriteLine("get title: \n" + urlTitle);
            txtTitle.Text = urlTitle;

            // get Page Source
            String pageSource = driver.PageSource;
            Console.WriteLine("get page source: \n" + pageSource);

            // backForward
            driver.Navigate().Forward();
            Thread.Sleep(3000); // 3s
            driver.Navigate().Refresh();

            //so 9 Hoang Kiet

            //driver.Close();
            // dong moi cua so lien ket
            //driver.Quit();
        }

        //so 9 Hoang Kiet
        private void Search_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com.vn/?hl=vi";
            IWebElement element = driver.FindElement(By.Name("q"));
            element.SendKeys(txt_keyword.Text);
        }

        //so 9 Hoang Kiet
        private void btLogin_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://id.ou.edu.vn/auth/login";
            // email
            IWebElement e_email = driver.FindElement(By.Name("form-username"));
            e_email.SendKeys("1851050073");

            // password
            IWebElement e_password = driver.FindElement(By.Name("form-password"));
            e_password.SendKeys("285776547");

            IWebElement login_button = driver.FindElement(By.XPath("//button[text()='Đăng nhập']"));
            login_button.Click();
        }
    }
}
