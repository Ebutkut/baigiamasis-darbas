using System;

namespace Framework.Pages
{
    public class Login
    {
        public static void IsjungtiSlapukus()
        {
            Common.WaitForElementToBeVisible(Locators.Login.buttonOKSlapukuIsjungimas);
            Common.ClickElement(Locators.Login.buttonOKSlapukuIsjungimas);
        }

        public static void IvestiSlaptazodi(string valueSlaptazodis)
        {
            Common.SendKeys(Locators.Login.inputSlaptazodis, valueSlaptazodis);
        }

        public static void IvestiVartotojoVarda(string valueVartotojoVardas)
        {
            Common.SendKeys(Locators.Login.inputVartotojoVardas, valueVartotojoVardas);
        }

        public static void SpaustiMygtukaPrisijungti()
        {
            Common.ClickElement(Locators.Login.buttonPrisijungti);
        }

        public static void SpaustiPrisijunimoMygtuka()
        {
            Common.ClickElement(Locators.Login.buttonPrisijungti);
        }

        public static string PrisijungimoPatvirtinimas()
        {
            return Common.GetElementText(Locators.Login.zinutePrisijungus);
        }

    }
}
