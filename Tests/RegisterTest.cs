using Framework.Pages;
using NUnit.Framework;

namespace Tests
{
    internal class RegisterTest : BaseTest
    {

        [Test]
        public void RegisterFormWithValidData()
        {
            //Leidžiant testą pakartotinai, reikia vis atnaujinti valueEmail ir pagal jį 
            //pakoreguoti expectedText 
            string expectedText = "Sveiki, tester20! (Jūs ne tester19? Atsijunkite)";
            string valueEmail = "tester20@test.com";

            Register.SpaustiMygtukaVartotojoPiktograma();
            Register.IvestiElPasta(valueEmail);
            Register.SpaustiMygtukaRegistruotis();
            Register.SpaustiMygtukaVartotojoPiktograma();

            Assert.AreEqual(expectedText, Register.RegistracijosPatvirtinimas());
        }
    }
}
