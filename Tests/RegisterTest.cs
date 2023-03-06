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
        }

        [Test]
        public void RegisterFormWithValidData()
        {
            string expectedText = "Sveiki, tester70! (Jūs ne tester70? Atsijunkite)";

            string valueEmail = "tester70@test.com";

            Register.IsjungtiSlapukusSpaustiOK();
            Register.SpaustiMygtukaVartotojoPiktograma();
            Register.IvestiElPasta(valueEmail);
            Register.SpaustiMygtukaRegistruotis();
            Register.SpaustiMygtukaVartotojoPiktograma();

            Assert.AreEqual(expectedText, Register.RegistracijosPatvirtinimas());
        }
    }
}
