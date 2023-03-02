using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumTestsWithoutPOM
{
    internal class BroliuMedus
    {
        [Test]
        public void LoginFormWithValidData()
        {
           string expectedResult = "Sveiki, erika.butkut! (Jūs ne erika.butkut? Atsijunkite)";

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://broliumedus.lt/mano-paskyra/";

            string valueVartotojoVardas = "erika.butkut";
            string valueSlaptazodis = "testavimas11";

            IWebElement inputVartotojoVardas = driver.FindElement(By.XPath("//*[@id='username']"));
            IWebElement inputSlaptazodis = driver.FindElement(By.XPath("//*[@id='password']"));
            IWebElement buttonPrisijungti = driver.FindElement(By.XPath("//*[@id='customer_login']/div[1]/div/form/p[3]/button"));

            inputVartotojoVardas.SendKeys(valueVartotojoVardas);
            inputSlaptazodis.SendKeys(valueSlaptazodis);

            buttonPrisijungti.Click();

            IWebElement PrisijungimoZinute = driver.FindElement(By.XPath("//*[@id='content']/div/div/div/div/div/p[1]"));
            string actualResult = PrisijungimoZinute.Text;

            driver.Quit();

           Assert.AreEqual(expectedResult, actualResult);

        }

        [Test]
        public void RegisterFormWithValidData()
        {
            string expectedResult = "Sveiki, test11! (Jūs ne test11? Atsijunkite)";

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://broliumedus.lt/mano-paskyra/";

            string valueEmail = "test11@tester.com";

            IWebElement inputEmail = driver.FindElement(By.XPath("//*[@id='reg_email']"));
            IWebElement buttonRegistruotis = driver.FindElement(By.XPath("//*[@id='customer_login']/div[2]/div/form/p[4]/button"));

            inputEmail.SendKeys(valueEmail);

            buttonRegistruotis.Click();

            IWebElement PrisijungimoZinute = driver.FindElement(By.XPath("//*[@id='content']/div/div/div/div/div/p[1]"));
            string actualResult = PrisijungimoZinute.Text;

            driver.Quit();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void UserInformationFormUpdate()
        {
            string expectedResult = "Paskyros duomenys sėkmingai pakeisti.";

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://broliumedus.lt/mano-paskyra/";

            string valueVartotojoVardas = "erika.butkut";
            string valueSlaptazodis = "testavimas11";

            IWebElement inputVartotojoVardas = driver.FindElement(By.XPath("//*[@id='username']"));
            IWebElement inputSlaptazodis = driver.FindElement(By.XPath("//*[@id='password']"));
            IWebElement buttonPrisijungti = driver.FindElement(By.XPath("//*[@id='customer_login']/div[1]/div/form/p[3]/button"));

            inputVartotojoVardas.SendKeys(valueVartotojoVardas);
            inputSlaptazodis.SendKeys(valueSlaptazodis);

            buttonPrisijungti.Click();

            IWebElement buttonVartotojoInformacija = driver.FindElement(By.XPath("//*[@id='content']/div/div/div/div/div/ul/li[5]"));
            buttonVartotojoInformacija.Click();

            string valueEsamasSlaptazodis = "testavimas11";
            string valueNaujasSlaptazodis = "testavimas12";

            IWebElement inputEsamasSlaptazodis = driver.FindElement(By.XPath("//*[@id='password_current']"));
            IWebElement inputNaujasSlaptazodis = driver.FindElement(By.XPath("//*[@id='password_1']"));
            IWebElement inputPatvirtintiSlaptazodi = driver.FindElement(By.XPath("//*[@id='password_2']"));
            IWebElement buttonIssaugotiPakeitimus = driver.FindElement(By.XPath("//*[@id='content']/div/div/div/div/div/form/p[5]/button"));

            inputEsamasSlaptazodis.SendKeys(valueEsamasSlaptazodis);
            inputNaujasSlaptazodis.SendKeys(valueNaujasSlaptazodis);
            inputPatvirtintiSlaptazodi.SendKeys(valueNaujasSlaptazodis);

            driver.ExecuteJavaScript("window.scrollBy(0, 400)");

            buttonIssaugotiPakeitimus.Click();

            IWebElement ZinuteDuomenysPakeisti = driver.FindElement(By.XPath("//*[@id='wrapper']/div[1]"));
            string actualResult = ZinuteDuomenysPakeisti.Text;

            driver.Quit();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void AddProductToCart()
        {
            // Ar gali būti taip apibrėžtas expectedResult? Taip testas pass'ina.
            // Test case: patikrinu ar paspaudus buttonIdetiIKrepseli,
            // atsiranda Krepselio "langas" ir matomas kažkoks tekstas.
            // Nežinau, kaip apibrėžti expextedResult, jei tikrinu,
            // ar paspaudus mygtuką įdeti į krepšelį produktą atsidaro krepselio langas.
            string expectedResult = "";
           
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://broliumedus.lt/";

            driver.ExecuteJavaScript("window.scrollBy(0, 400)");

            IWebElement buttonMedus = driver.FindElement(By.XPath("//*[@id='menu-item-638']"));
            buttonMedus.Click();

            driver.ExecuteJavaScript("window.scrollBy(0, 200)");

            IWebElement buttonIdetiIKrepseli = driver.FindElement(By.XPath("//*[@id='main']/div/div/div/div[2]/div[1]/div/div[2]/div[2]/div[3]"));
            buttonIdetiIKrepseli.Click();

            IWebElement KrepselioLangasIdejusPodukta = driver.FindElement(By.XPath("//*[@id='cart-popup']"));
                                                                                    
            string actualResult = KrepselioLangasIdejusPodukta.Text;

            driver.Quit();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void EducationFormWithValidData()
        {
            //string expectedResult = "Ačiū už Jūsų žinutę. Žinutė sėkmingai išsiųsta.";

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://broliumedus.lt/";

            driver.ExecuteJavaScript("window.scrollBy(0, 400)");

            IWebElement buttonEdukacijos = driver.FindElement(By.XPath("//*[@id='menu-item-4009']/a"));
            buttonEdukacijos.Click();

            driver.ExecuteJavaScript("window.scrollBy(0, 1300)");



            // Error Message:  no such element: Unable to locate element:
            // {"method":"xpath","selector":"//*[@id=\"col-1789862094\"]/div/p/a"}
            //Kaip apsirašyti buttonUzsisakytiEdukacija XPath, jeigu @id='col-1789862094',
            //kiekvieną kartą perkrovus svetainę, pasikeičia?????????

            IWebElement buttonUzsisakytiEdukacija = driver.FindElement(By.XPath("//*[@id=\"col-1789862094\"]/div/p/a"));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            buttonUzsisakytiEdukacija.Click();






            //string valueVardas = "Tester";
            //string valueEmail = "test@tester.com";
            //string valueZinute = "Noriu";

            //IWebElement inputVardas = driver.FindElement(By.XPath("//*[@id=\"wpcf7-f7-p87-o1\"]/form/div[2]/span/input"));
            //IWebElement inputEmail = driver.FindElement(By.XPath("//*[@id=\"wpcf7-f7-p87-o1\"]/form/div[2]/p[2]/span/input"));
            //IWebElement inputZinute = driver.FindElement(By.XPath("//*[@id=\"wpcf7-f7-p87-o1\"]/form/div[2]/p[3]/span/textarea"));
            //IWebElement buttonSiusti = driver.FindElement(By.XPath("//*[@id=\"wpcf7-f7-p87-o1\"]/form/div[2]/p[4]/input"));

            //inputVardas.SendKeys(valueVardas);
            //inputEmail.SendKeys(valueEmail);
            //inputZinute.SendKeys(valueZinute);

            //IWebElement ZinuteIssiustaSekmingai = driver.FindElement(By.XPath("//*[@id="wpcf7-f7-p87-o1"]/form/div[3]"));
            //string actualResult = ZinuteIssiustaSekmnigai.Text;

            buttonSiusti.Click();

            driver.Quit();

            // Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
