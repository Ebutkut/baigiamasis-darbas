using Framework;
using Framework.Pages;
using NUnit.Framework;

namespace Tests
{
    internal class RegisterTest : BaseTest
    {
        [SetUp]
        public void Open()
        {
            Driver.OpenUrl("https://broliumedus.lt/mano-paskyra/");
        }

        [Test]
        public void RegisterFormWithValidData()
        {
            string expectedText = "Sveiki, test35! (Jūs ne test35? Atsijunkite)";

            string valueEmail = "test35@tester.com";

            Register.IsjungtiSlapukusSpaustiOK();
            Register.IvestiElPasta(valueEmail);
            Register.SpaustiMygtukaRegistruotis();

            Assert.AreEqual(expectedText, Register.RegistracijosPatvirtinimas());
        }
    }
}
