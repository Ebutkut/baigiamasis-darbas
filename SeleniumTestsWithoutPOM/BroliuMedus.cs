using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;

namespace SeleniumTestsWithoutPOM
{
    internal class BroliuMedus
    {
        [Test]
        public void LoginFormWithValidData()
        {
           string expectedResult = "Sveiki, erika.butkut!";

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://broliumedus.lt/mano-paskyra/";

            string valueVartotojoVardas = "erika.butkut";
            string valueSlaptazodis = "testavimas6";

            IWebElement inputVartotojoVardas = driver.FindElement(By.XPath("//*[@id='username']"));
            IWebElement inputSlaptazodis = driver.FindElement(By.XPath("//*[@id='password']"));

            // Kai pakeičiau psl. į "https://broliumedus.lt/mano-paskyra/".
            // Kodėl nebemato buttonPrisijungti?
            //Error Message: no such element: Unable to locate element:
            //{"method":"xpath","selector":"//*[@id='customer_login']/div[1]/div/form/a/p[3]/button"}
            IWebElement buttonPrisijungti = driver.FindElement(By.XPath("//*[@id='customer_login']/div[1]/div/form/a/p[3]/button"));

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
            string expectedResult = "Sveiki, test10! (Jūs ne test10? Atsijunkite)";

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://broliumedus.lt/mano-paskyra/";

            string valueEmail = "test10@tester.com";

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
            driver.Url = "https://broliumedus.lt/";

            driver.ExecuteJavaScript("window.scrollBy(0, 200)");

            IWebElement buttonIconUser = driver.FindElement(By.XPath("//*[@id='masthead']/div[1]/div[4]/ul/li[3]/div/a/i"));
            buttonIconUser.Click();

            string valueVartotojoVardas = "erika.butkut";
            string valueSlaptazodis = "testavimas6";

            IWebElement inputVartotojoVardas = driver.FindElement(By.XPath("//*[@id='username']"));
            IWebElement inputSlaptazodis = driver.FindElement(By.XPath("//*[@id='password']"));
            IWebElement buttonPrisijungti = driver.FindElement(By.XPath("//*[@id='customer_login']/div[1]/div/form/a/p[3]/button"));

            inputVartotojoVardas.SendKeys(valueVartotojoVardas);
            inputSlaptazodis.SendKeys(valueSlaptazodis);

            buttonPrisijungti.Click();

            driver.ExecuteJavaScript("window.scrollBy(0, 100)");

            IWebElement buttonPaskyra = driver.FindElement(By.XPath("//*[@id='masthead']/div[1]/div[4]/ul/li[3]/div/a/i"));
            buttonPaskyra.Click();

            IWebElement buttonVartotojoInformacija = driver.FindElement(By.XPath("//*[@id='content']/div/div/div/div/div/ul/li[5]"));
            buttonVartotojoInformacija.Click();

            string valueEsamasSlaptazodis = "testavimas6";
            string valueNaujasSlaptazodis = "testavimas7";

            IWebElement inputEsamasSlaptazodis = driver.FindElement(By.XPath("//*[@id='password_current']"));
            IWebElement inputNaujasSlaptazodis = driver.FindElement(By.XPath("//*[@id='password_1']"));
            IWebElement inputPatvirtintiSlaptazodi = driver.FindElement(By.XPath("//*[@id='password_2']"));
            IWebElement buttonIssaugotiPakeitimus = driver.FindElement(By.XPath("//*[@id='content']/div/div/div/div/div/form/p[5]/button"));

            inputEsamasSlaptazodis.SendKeys(valueEsamasSlaptazodis);
            inputNaujasSlaptazodis.SendKeys(valueNaujasSlaptazodis);
            inputPatvirtintiSlaptazodi.SendKeys(valueNaujasSlaptazodis);

            driver.ExecuteJavaScript("window.scrollBy(0, 400)");

            buttonIssaugotiPakeitimus.Click();

            //Error Message: Expected string length 37 but was 0. Strings differ ar index 0.
            //Netinkamas ZinuteDuomenysPakeisti XPath?
            IWebElement ZinuteDuomenysPakeisti = driver.FindElement(By.XPath("//*[@id='wrapper']/div/div/i"));
            string actualResult = ZinuteDuomenysPakeisti.Text;

            driver.Quit();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void AddProductToCart()
        {
            string expectedResult = "Vaisiu sulciu guminukai 'Broliai lokiai'";

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://broliumedus.lt/";

            driver.ExecuteJavaScript("window.scrollBy(0, 400)");

            IWebElement buttonMedus = driver.FindElement(By.XPath("//*[@id='menu-item-638']"));
            buttonMedus.Click();

            driver.ExecuteJavaScript("window.scrollBy(0, 200)");

            IWebElement buttonIdetiIKrepseli = driver.FindElement(By.XPath("//*[@id='main']/div/div/div/div[2]/div[1]/div/div[2]/div[2]/div[3]"));
            buttonIdetiIKrepseli.Click();

            // Error Message: no such element: Unable to locate element:
            // {"method":"xpath","selector":"//*[@id="cart-popup"]/div/div[2]/ul/li"}
            //Netinkamas IdetoIKrepseliPoduktoPavadinimas XPath?
            IWebElement IdetoIKrepseliPoduktoPavadinimas = driver.FindElement(By.XPath("//*[@id=\"cart-popup\"]/div/div[2]/ul/li"));
            string actualResult = IdetoIKrepseliPoduktoPavadinimas.Text;

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

            driver.ExecuteJavaScript("window.scrollBy(0, 1200)");


            // Error Message:  no such element: Unable to locate element:
            // {"method":"xpath","selector":"//*[@id='col-1729804244']/div/p/a"}
            //Netinkamas buttonUzsisakytiEdukacija XPath?
            IWebElement buttonUzsisakytiEdukacija = driver.FindElement(By.XPath("//*[@id='col-1729804244']/div/p/a"));
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

            //buttonSiusti.Click();

            driver.Quit();

            // Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
