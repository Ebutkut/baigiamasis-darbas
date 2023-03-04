using System;

namespace Framework.Pages
{
    public class UserInformationForm
    {
        
        public static string DuomenuPakeitimoPatvirtinimas()
        {
            return Common.GetElementText(Locators.UserInformationForm.zinuteDuomenysPakeisti);
        }

        public static void IsjungtiSlapukus()
        {
            Common.WaitForElementToBeVisible(Locators.UserInformationForm.buttonOKSlapukuIsjungimas);
            Common.ClickElement(Locators.UserInformationForm.buttonOKSlapukuIsjungimas);
        }

        public static void IvestiEsamaSlaptazodi(string valueEsamasSlaptazodis)
        {
            Common.SendKeys(Locators.UserInformationForm.inputEsamasSlaptazodis, valueEsamasSlaptazodis);
        }

        public static void IvestiNaujaSlaptazodi(string valueNaujasSlaptazodis)
        {
            Common.SendKeys(Locators.UserInformationForm.inputNaujasSlaptazodis, valueNaujasSlaptazodis);
        }

        public static void IvestiSlaptazodi(string valueSlaptazodis)
        {
            Common.SendKeys(Locators.UserInformationForm.inputSlaptazodis, valueSlaptazodis);
        }

        public static void IvestiVartotojoVarda(string valueVartotojoVardas)
        {
            Common.SendKeys(Locators.UserInformationForm.inputVartotojoVardas, valueVartotojoVardas);
        }

        public static void MygtukasIssaugotiPakeitimus()
        {
            Common.ScrollByPixels(0,400);
            Common.ClickElement(Locators.UserInformationForm.buttonIssaugotiPakeitimus);
        }

        public static void MygtukasPrisijungti()
        {
            Common.ClickElement(Locators.UserInformationForm.buttonPrisijungti);
        }

        public static void MygtukasVartotojoInformacija()
        {
            Common.ClickElement(Locators.UserInformationForm.buttonVartotojoInformacija);
        }

        public static void PatvirtintiNaujaSlaptazodi(string valueNaujasSlaptazodis)
        {
            Common.SendKeys(Locators.UserInformationForm.inputPatvirtintiSlaptazodi, valueNaujasSlaptazodis);
        }
    }
}
