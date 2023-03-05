using Framework.Pages;
using System;

namespace Framework
{
    public class ProductsMenu
    {
        public static void IdetiIKrepseli()
        {
            Common.ScrollByPixels(0, 200);
            Common.WaitForElementToBeVisible(Locators.ProductsMenu.buttonIdetiIKrepseli);
            Common.ClickElement(Locators.ProductsMenu.buttonIdetiIKrepseli);
        }

        public static void IsjungtiSlapukus()
        {
            Common.WaitForElementToBeVisible(Locators.ProductsMenu.buttonOKSlapukuIsjungimas);
            Common.ClickElement(Locators.ProductsMenu.buttonOKSlapukuIsjungimas);
        }

        public static void Medus()
        {
            Common.ScrollByPixels(0, 200);
            Common.ClickElement(Locators.ProductsMenu.buttonMedus);
        }

        public static string PirkiniuKrepselisSuIdetiProduktu()
        {
            Common.WaitForElementToBeVisible(Locators.ProductsMenu.PirkiniuKrepselisSuIdetuPoduktu);
            return Common.GetElementText(Locators.ProductsMenu.PirkiniuKrepselisSuIdetuPoduktu);
        }
    }
}
