﻿using Framework;
using Framework.Pages;
using NUnit.Framework;

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
            //Testą leidžiant pakartotinai, reikia vis atnaujinti
            //valueSlaptazodis, valueEsamasSlaptazodis,valueNaujasSlaptazodis reikšmes
            string valueSlaptazodis = "testavimas18";
            string valueEsamasSlaptazodis = "testavimas18";
            string valueNaujasSlaptazodis = "testavimas19";

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
