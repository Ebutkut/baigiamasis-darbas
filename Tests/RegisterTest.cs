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
            //Leidžiant testą pakartotinai, reikia vis atnaujinti valueEmail ir pagal jį 
            //pakoreguoti expectedText 
            string expectedText = "Sveiki, tester15! (Jūs ne tester15? Atsijunkite)";
            string valueEmail = "tester15@test.com";

            Register.SpaustiMygtukaVartotojoPiktograma();
            Register.IvestiElPasta(valueEmail);
            Register.SpaustiMygtukaRegistruotis();
            Register.SpaustiMygtukaVartotojoPiktograma();

            Assert.AreEqual(expectedText, Register.RegistracijosPatvirtinimas());

        }
    }
}
