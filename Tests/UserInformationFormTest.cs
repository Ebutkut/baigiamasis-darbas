using Framework;
using Framework.Pages;
using NUnit.Framework;
using System;

namespace Tests
{
    internal class UserInformationFormTest : BaseTest
    {
        [SetUp]
        public void Open()
        {
            Driver.OpenUrl("https://broliumedus.lt/mano-paskyra/");
            HomePage.IsjungtiSlapukusSpaustiOK();
        }

        [Test]
        public void UserInformationFormUpdate()
        {
            string expectedText = "Paskyros duomenys sėkmingai pakeisti.";

            string valueVartotojoVardas = "erika.butkut";
            string valueSlaptazodis = "testavimas17";
            string valueEsamasSlaptazodis = "testavimas17";
            string valueNaujasSlaptazodis = "testavimas18";

            UserInformationForm.IvestiVartotojoVarda(valueVartotojoVardas);
            UserInformationForm.IvestiSlaptazodi(valueSlaptazodis);
            UserInformationForm.SpaustiMygtukaPrisijungti();
            UserInformationForm.SpaustiMygtukaVartotojoInformacija();
            UserInformationForm.IvestiEsamaSlaptazodi(valueEsamasSlaptazodis);
            UserInformationForm.IvestiNaujaSlaptazodi(valueNaujasSlaptazodis);
            UserInformationForm.PatvirtintiNaujaSlaptazodi(valueNaujasSlaptazodis);
            UserInformationForm.SpaustiMygtukaIssaugotiPakeitimus();

            Assert.AreEqual(expectedText, UserInformationForm.DuomenuPakeitimoPatvirtinimas());
        }
    }
}
