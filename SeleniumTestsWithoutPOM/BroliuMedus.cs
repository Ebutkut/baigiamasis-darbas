using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using System;
using SeleniumExtras.WaitHelpers;

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

            new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement buttonSlapukuIsjungimas = driver.FindElement(By.XPath("//button[.='OK']"));
            buttonSlapukuIsjungimas.Click();

            string valueVartotojoVardas = "erika.butkut";
            string valueSlaptazodis = "testavimas13";

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
            string expectedResult = "Sveiki, test25! (Jūs ne test25? Atsijunkite)";

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://broliumedus.lt/mano-paskyra/";

            new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement buttonSlapukuIsjungimas = driver.FindElement(By.XPath("//button[.='OK']"));
            buttonSlapukuIsjungimas.Click();

            string valueEmail = "test25@tester.com";

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

            new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement buttonSlapukuIsjungimas = driver.FindElement(By.XPath("//button[.='OK']"));
            buttonSlapukuIsjungimas.Click();

            string valueVartotojoVardas = "erika.butkut";
            string valueSlaptazodis = "testavimas13";

            IWebElement inputVartotojoVardas = driver.FindElement(By.XPath("//*[@id='username']"));
            IWebElement inputSlaptazodis = driver.FindElement(By.XPath("//*[@id='password']"));
            IWebElement buttonPrisijungti = driver.FindElement(By.XPath("//*[@id='customer_login']/div[1]/div/form/p[3]/button"));

            inputVartotojoVardas.SendKeys(valueVartotojoVardas);
            inputSlaptazodis.SendKeys(valueSlaptazodis);

            buttonPrisijungti.Click();

            IWebElement buttonVartotojoInformacija = driver.FindElement(By.XPath("//*[@id='content']/div/div/div/div/div/ul/li[5]"));
            buttonVartotojoInformacija.Click();

            string valueEsamasSlaptazodis = "testavimas13";
            string valueNaujasSlaptazodis = "testavimas14";

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
            string expectedResult = "Vaisių sulčių guminukai „Broliai lokiai“";

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://broliumedus.lt/";

            new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement buttonSlapukuIsjungimas = driver.FindElement(By.XPath("//button[.='OK']"));
            buttonSlapukuIsjungimas.Click();

            driver.ExecuteJavaScript("window.scrollBy(0, 400)");

            IWebElement buttonMedus = driver.FindElement(By.XPath("//*[@id='menu-item-638']"));
            buttonMedus.Click();

            driver.ExecuteJavaScript("window.scrollBy(0, 200)");
            new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            IWebElement buttonIdetiIKrepseli = driver.FindElement(By.XPath("//a[text()='Į krepšelį']"));
            buttonIdetiIKrepseli.Click();

            new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            IWebElement KrepselioLangasIdejusPodukta = driver.FindElement(By.XPath("//a[text()='Vaisių sulčių guminukai „Broliai lokiai“']"));

            string actualResult = KrepselioLangasIdejusPodukta.Text;

            driver.Quit();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void EducationFormWithValidData()
        {
            string expectedResult = "Ačiū už Jūsų žinutę. Žinutė sėkmingai išsiųsta.";

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://broliumedus.lt/";

            new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement buttonSlapukuIsjungimas = driver.FindElement(By.XPath("//button[.='OK']"));
            buttonSlapukuIsjungimas.Click();

            driver.ExecuteJavaScript("window.scrollBy(0, 300)");

            new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement buttonEdukacijos = driver.FindElement(By.XPath("//*[@id='menu-item-4009']"));
            buttonEdukacijos.Click();

            driver.ExecuteJavaScript("window.scrollBy(0, 1300)");
 
            new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement buttonUzsisakytiEdukacija = driver.FindElement(By.XPath("//a[text()='UŽSISAKYTI EDUKACIJĄ']"));
           
            buttonUzsisakytiEdukacija.Click();

            string valueVardas = "Tester";
            string valueEmail = "test@tester.com";
            string valueZinute = "Noriu";

            IWebElement inputVardas = driver.FindElement(By.XPath("//*[@id='wpcf7-f7-p87-o1']/form/div[2]/span/input"));
            IWebElement inputEmail = driver.FindElement(By.XPath("//*[@id='wpcf7-f7-p87-o1']/form/div[2]/p[2]/span/input"));
            IWebElement inputZinute = driver.FindElement(By.XPath("//*[@id='wpcf7-f7-p87-o1']/form/div[2]/p[3]/span/textarea"));
           
            new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement buttonSiusti = driver.FindElement(By.XPath("//*[@id='wpcf7-f7-p87-o1']/form/div[2]/p[4]/input"));

            inputVardas.SendKeys(valueVardas);
            inputEmail.SendKeys(valueEmail);
            inputZinute.SendKeys(valueZinute);

            driver.ExecuteJavaScript("window.scrollBy(0, 300)");

            new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            buttonSiusti.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class='wpcf7-response-output'][text()='Ačiū už Jūsų žinutę. Žinutė sėkmingai išsiųsta.']")));
            string actualResult = element.Text;

            driver.Quit();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
