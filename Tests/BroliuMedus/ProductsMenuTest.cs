using Framework.Pages;
using NUnit.Framework;
using Tests.BaseTests;

namespace Tests.BroliuMedus
{
    internal class ProductsMenuTest : BaseTest
    {

        [Test]
        public void AddProductToCart()
        {
            string expectedResult = "Vaisių sulčių guminukai „Broliai lokiai“";

            ProductsMenu.SpaustiMygtukaMedus();
            ProductsMenu.SpaustiProduktaVaisiuSulciuGuminukaiBroliaiLokiai();
            ProductsMenu.SpaustiMygtukaIdetiIKrepseli();
            ProductsMenu.SpaustiMygtukaPerziuretiKrepseli();

            Assert.AreEqual(expectedResult, ProductsMenu.IPirkiniuKrepseliIdetasProduktas());
        }
    }
}
