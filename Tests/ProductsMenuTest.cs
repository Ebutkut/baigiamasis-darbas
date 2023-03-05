using Framework;
using Framework.Pages;
using NUnit.Framework;

namespace Tests
{
    internal class ProductsMenuTest : BaseTest
    {
        [SetUp]
        public void Open()
        {
            Driver.OpenUrl("https://broliumedus.lt/");
        }

        [Test]
        public void AddProductToCart()
        {
            string expectedResult = "Vaisių sulčių guminukai „Broliai lokiai“";

            ProductsMenu.IsjungtiSlapukus();
            ProductsMenu.Medus();
            ProductsMenu.IdetiIKrepseli();
            ProductsMenu.PirkiniuKrepselisSuIdetiProduktu();

            Assert.AreEqual(expectedResult, ProductsMenu.PirkiniuKrepselisSuIdetiProduktu());
        }
    }
}
