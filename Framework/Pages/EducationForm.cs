using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using SeleniumExtras.WaitHelpers;

namespace Framework.Pages
{
    public class EducationForm
    {
        public static void IsjungtiSlapukus()
        {
            Common.WaitForElementToBeVisible(Locators.EducationForm.buttonOKSlapukuIsjungimas);
            Common.ClickElement(Locators.EducationForm.buttonOKSlapukuIsjungimas);
        }

        public static void IvestiElPasta(string valueEmail)
        {
            Common.SendKeys(Locators.EducationForm.inputEmail, valueEmail);
        }

        public static void IvestiVarda(string valueVardas)
        {
            Common.SendKeys(Locators.EducationForm.inputVardas, valueVardas);
        }

        public static void MygtukasEdukacijos()
        {
            Common.ScrollByPixels(0, 200);
            Common.WaitForElementToBeVisible(Locators.EducationForm.buttonEdukacijos);
            Common.ClickElement(Locators.EducationForm.buttonEdukacijos);
        }

        public static void MygtukasSiusti()
        {
            Common.ScrollByPixels(0, 300);
            Common.WaitForElementToBeVisible(Locators.EducationForm.buttonSiusti);
            Common.ClickElement(Locators.EducationForm.buttonSiusti);
        }

        public static void MygtukasUzsisakytiEdukacija()
        {
            Common.ScrollByPixels(0, 1300);
            Common.WaitForElementToBeVisible(Locators.EducationForm.buttonUzsisakytiEdukacija);
            Common.ClickElement(Locators.EducationForm.buttonUzsisakytiEdukacija);
        }

        public static void ParasytiZinute(string valueZinute)
        {
            Common.SendKeys(Locators.EducationForm.inputZinute, valueZinute);
        }

        public static string ZinutesIssiuntimoPatvirtinimas()
        {
            Common.WaitForElementToBeVisible(Locators.EducationForm.zinuteUzsisakiusEdukacija);
            return Common.GetElementText(Locators.EducationForm.zinuteUzsisakiusEdukacija);
        }
    }
}
