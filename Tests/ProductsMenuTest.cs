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
            HomePage.IsjungtiSlapukusSpaustiOK();
        }

        [Test]
        public void AddProductToCart()
        {
            string expectedResult = "Vaisių sulčių guminukai „Broliai lokiai“";

            ProductsMenu.SpaustiMygtukaMedus();
            ProductsMenu.SpaustiProduktaVaisiuSulčiuGuminukaiBroliaiLokiai();
            ProductsMenu.SpaustiMygtukaIdetiIKrepseli();
            ProductsMenu.SpaustiMygtukaPerziuretiKrepseli();

            Assert.AreEqual(expectedResult, ProductsMenu.IPirkiniuKrepseliIdetasProduktas());
        }
    }
}
