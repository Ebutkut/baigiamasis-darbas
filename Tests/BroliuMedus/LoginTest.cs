using Framework;
using NUnit.Framework;
using Framework.Pages;
using Tests.BaseTests;

namespace Tests.BroliuMedus
{
    internal class LoginTest : BaseTest
    {
        [SetUp]
        public void Open()
        {
            Driver.OpenUrl("https://broliumedus.lt/mano-paskyra/");
        }

        [Test]
        public void LoginFormWithValidData()
        {
            string expectedText = "Sveiki, erika.butkut! (Jūs ne erika.butkut? Atsijunkite)";
            string valueVartotojoVardas = "erika.butkut";
            // Testas UserInformationFormUpdate atnaujina slaptažodį, todėl šiame teste vis 
            // reikia pakeisti slaptažodį pagal UserInformationFormUpdate testo valueNaujasSlaptazodis reikšmę
            string valueSlaptazodis = "testavimas21";
              
            Login.IvestiVartotojoVarda(valueVartotojoVardas);
            Login.IvestiSlaptazodi(valueSlaptazodis);
            Login.SpaustiMygtukaPrisijungti();

            Assert.AreEqual(expectedText, Login.PrisijungimoPatvirtinimas());
        }
    }
}