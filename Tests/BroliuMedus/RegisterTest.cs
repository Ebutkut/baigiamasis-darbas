using Framework.Pages;
using NUnit.Framework;
using Tests.BaseTests;

namespace Tests.BroliuMedus
{
    internal class RegisterTest : BaseTest
    {

        [Test]
        public void RegisterFormWithValidData()
        {
            string userName = Register.GenerateRandomUserName();
            string expectedText = $"Sveiki, {userName}! (Jūs ne {userName}? Atsijunkite)";
            string valueEmail = $"{userName}@test.com";

            Register.SpaustiMygtukaVartotojoPiktograma();
            Register.IvestiElPasta(valueEmail);
            Register.SpaustiMygtukaRegistruotis();
            Register.SpaustiMygtukaVartotojoPiktograma();

            Assert.AreEqual(expectedText, Register.RegistracijosPatvirtinimas());
        }
    }
}
