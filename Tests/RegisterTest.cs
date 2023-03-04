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
            string expectedText = "Sveiki, test30! (Jūs ne test30? Atsijunkite)";

            string valueEmail = "test30@tester.com";

            Register.IsjungtiSlapukus();
            Register.IvestiElPasta(valueEmail);
            Register.SpaustiMygtukaRegistruotis();

            Assert.AreEqual(expectedText, Register.RegistracijosPatvirtinimas());
        }
    }
}
