namespace Framework.Pages
{
    public class HomePage
    {
        public static void IsjungtiSlapukusSpaustiOK()
        {
            Common.WaitForElementToBeVisible(Locators.HomePage.buttonOKSlapukuIsjungimas);
            Common.ClickElement(Locators.HomePage.buttonOKSlapukuIsjungimas);
            Common.ScrollByPixels(0, 200);
        }
    }
}
