using OpenQA.Selenium;

namespace Framework.Pages
{
    internal class Locators
    {
        internal static class Login
        {
            internal static string inputVartotojoVardas = "//*[@id='username']";
            internal static string inputSlaptazodis = "//*[@id='password']";
            internal static string buttonPrisijungti = "//*[@id='customer_login']/div[1]/div/form/p[3]/button";
            internal static string buttonOKSlapukuIsjungimas = "//button[.='OK']";
            internal static string zinutePrisijungus = "//*[@id='content']/div/div/div/div/div/p[1]";
        }

        internal static class Register
        {
            internal static string inputEmail = "//*[@id='reg_email']";
            internal static string buttonRegistruotis = "//*[@id='customer_login']/div[2]/div/form/p[4]/button";
            internal static string buttonOKSlapukuIsjungimas = "//button[.='OK']";
            internal static string zinutePrisiregistravus = "//*[@id='content']/div/div/div/div/div/p[1]";
        }


    }
}
