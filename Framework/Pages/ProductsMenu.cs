﻿using Framework.Pages;
using System;

namespace Framework
{
    public class ProductsMenu
    {
        public static void SpaustiMygtukaIdetiIKrepseli()
        {
            Common.WaitForElementToBeVisible(Locators.ProductsMenu.buttonIdetiIKrepseli);
            Common.ClickElement(Locators.ProductsMenu.buttonIdetiIKrepseli);
        }

        public static string IPirkiniuKrepseliIdetasProduktas()
        {
            Common.WaitForElementToBeVisible(Locators.ProductsMenu.IPirkiniuKrepseliIdetasProduktas);
            return Common.GetElementText(Locators.ProductsMenu.IPirkiniuKrepseliIdetasProduktas);
        }

        public static void IsjungtiSlapukus()
        {
            Common.WaitForElementToBeVisible(Locators.ProductsMenu.buttonOKSlapukuIsjungimas);
            Common.ClickElement(Locators.ProductsMenu.buttonOKSlapukuIsjungimas);
        }

        public static void SpaustiMygtukaMedus()
        {
            Common.ScrollByPixels(0, 200);
            Common.WaitForElementToBeVisible(Locators.ProductsMenu.buttonMedus);
            Common.ClickElement(Locators.ProductsMenu.buttonMedus);
        }

        public static void SpaustiMygtukaPerziuretiKrepseli()
        {
            Common.WaitForElementToBeVisible(Locators.ProductsMenu.buttonPerziuretiKrepseli);
            Common.ClickElement(Locators.ProductsMenu.buttonPerziuretiKrepseli);
        }

        public static void SpaustiProduktaVaisiuSulčiuGuminukaiBroliaiLokiai()
        {
            Common.WaitForElementToBeVisible(Locators.ProductsMenu.ProduktasVaisiuSulčiuGuminukaiBroliaiLokiai);
            Common.ClickElement(Locators.ProductsMenu.ProduktasVaisiuSulčiuGuminukaiBroliaiLokiai);
        }
    }
}