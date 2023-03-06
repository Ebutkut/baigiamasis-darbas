using System;

namespace Framework.Pages
{
    public class Register
    {
        public static void IsjungtiSlapukusSpaustiOK()
        {
            Common.WaitForElementToBeVisible(Locators.Register.buttonOKSlapukuIsjungimas);
            Common.ClickElement(Locators.Register.buttonOKSlapukuIsjungimas);
        }

        public static void IvestiElPasta(string valueEmail)
        {
            Common.SendKeys(Locators.Register.inputEmail, valueEmail);
        }

        public static string RegistracijosPatvirtinimas()
        {
            return Common.GetElementText(Locators.Register.zinutePrisiregistravus);
        }

        public static void SpaustiMygtukaRegistruotis()
        {
            Common.ClickElement(Locators.Register.buttonRegistruotis);
        }

        public static void SpaustiMygtukaVartotojoPiktograma()
        {
            Common.ScrollByPixels(0, 100);
            Common.WaitForElementToBeVisible(Locators.Register.buttonVartotojoPiktograma);
            Common.ClickElement(Locators.Register.buttonVartotojoPiktograma);
        }
    }
}
