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
            Driver.OpenUrl("https://broliumedus.lt/");
            HomePage.IsjungtiSlapukusSpaustiOK();
        }

        [Test]
        public void RegisterFormWithValidData()
        {
            string expectedText = "Sveiki, tester10! (Jūs ne tester10? Atsijunkite)";
            string valueEmail = "tester10@test.com";

            Register.SpaustiMygtukaVartotojoPiktograma();
            Register.IvestiElPasta(valueEmail);
            Register.SpaustiMygtukaRegistruotis();
            Register.SpaustiMygtukaVartotojoPiktograma();

            Assert.AreEqual(expectedText, Register.RegistracijosPatvirtinimas());

        }
    }
}
