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
        }

        [Test]
        public void UserInformationFormUpdate()
        {
            string expectedText = "Paskyros duomenys sėkmingai pakeisti.";

            string valueVartotojoVardas = "erika.butkut";
            string valueSlaptazodis = "testavimas14";
            string valueEsamasSlaptazodis = "testavimas14";
            string valueNaujasSlaptazodis = "testavimas15";

            UserInformationForm.IsjungtiSlapukus();
            UserInformationForm.IvestiVartotojoVarda(valueVartotojoVardas);
            UserInformationForm.IvestiSlaptazodi(valueSlaptazodis);
            UserInformationForm.MygtukasPrisijungti();
            UserInformationForm.MygtukasVartotojoInformacija();
            UserInformationForm.IvestiEsamaSlaptazodi(valueEsamasSlaptazodis);
            UserInformationForm.IvestiNaujaSlaptazodi(valueNaujasSlaptazodis);
            UserInformationForm.PatvirtintiNaujaSlaptazodi(valueNaujasSlaptazodis);
            UserInformationForm.MygtukasIssaugotiPakeitimus();

            Assert.AreEqual(expectedText, UserInformationForm.DuomenuPakeitimoPatvirtinimas());
        }
    }
}
