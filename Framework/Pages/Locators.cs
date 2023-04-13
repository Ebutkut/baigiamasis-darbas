using OpenQA.Selenium;
using System;

namespace Framework.Pages
{
    internal class Locators
    {
        internal static class Login
        {
            internal static string inputVartotojoVardas = "//*[@id='username']";
            internal static string inputSlaptazodis = "//*[@id='password']";
            internal static string buttonPrisijungti = "//*[@id='customer_login']/div[1]/div/form/p[3]/button";
            internal static string zinutePrisijungus = "//*[@id='content']/div/div/div/div/div/p[1]";
        }

        internal static class Register
        {
            internal static string inputEmail = "//*[@id='reg_email']";
            internal static string buttonRegistruotis = "//*[@id='customer_login']/div[2]/div/form/p[4]/button";
            internal static string zinutePrisiregistravus = "//*[@id='content']/div/div/div/div/div/p[1]";
            internal static string buttonVartotojoPiktograma = "//*[@id='masthead']/div[1]/div[4]/ul/li[3]/div/a/i";
        }

        internal static class UserInformationForm
        {
            internal static string inputVartotojoVardas = "//*[@id='username']";
            internal static string inputSlaptazodis = "//*[@id='password']";
            internal static string buttonPrisijungti = "//*[@id='customer_login']/div[1]/div/form/p[3]/button";
            internal static string buttonVartotojoInformacija = "//*[@id='content']/div/div/div/div/div/ul/li[5]";
            internal static string inputEsamasSlaptazodis = "//*[@id='password_current']";
            internal static string inputNaujasSlaptazodis = "//*[@id='password_1']";
            internal static string inputPatvirtintiSlaptazodi = "//*[@id='password_2']";
            internal static string buttonIssaugotiPakeitimus = "//*[@id='content']/div/div/div/div/div/form/p[5]/button";
            internal static string zinuteDuomenysPakeisti = "//*[@id='wrapper']/div[1]";
           
        }

        internal static class ProductsMenu
        {
            internal static string buttonMedus = "//*[@id='menu-item-638']";
            internal static string buttonIdetiIKrepseli = "//*[@id='product-8350']/div/div[1]/div/div[2]/form/button";
            internal static string buttonPerziuretiKrepseli = "//a[text()='Peržiūrėti krepšelį']";
            internal static string IPirkiniuKrepseliIdetasProduktas = "//a[text()='Vaisių sulčių guminukai „Broliai lokiai“']";
            internal static string ProduktasVaisiuSulčiuGuminukaiBroliaiLokiai = "//a[@href='https://broliumedus.lt/produktas/vaisiu-sulciu-guminukai-broliai-lokiai/']";
        }

        internal static class EducationForm
        {
            internal static string buttonEdukacijos = "//*[@id='menu-item-4009']";
            internal static string buttonUzsisakytiEdukacija = "//a[text()='UŽSISAKYTI EDUKACIJĄ']";
            internal static string inputVardas = "//*[@id='wpcf7-f7-p87-o1']/form/div[2]/span/input";
            internal static string inputEmail = "//*[@id='wpcf7-f7-p87-o1']/form/div[2]/p[2]/span/input";
            internal static string inputZinute = "//*[@id='wpcf7-f7-p87-o1']/form/div[2]/p[3]/span/textarea";
            internal static string buttonSiusti = "//*[@id='wpcf7-f7-p87-o1']/form/div[2]/p[4]/input";
            internal static string zinuteUzsisakiusEdukacija = "//*[@class='wpcf7-response-output'][text()='Ačiū už Jūsų žinutę. Žinutė sėkmingai išsiųsta.']";
        }

        internal static class HomePage
        {
            internal static string buttonOKSlapukuIsjungimas = "//button[.='OK']";
        }

    }
}
