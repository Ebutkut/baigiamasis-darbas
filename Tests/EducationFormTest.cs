using Framework;
using Framework.Pages;
using NUnit.Framework;
using System;

namespace Tests
{
    internal class EducationFormTest : BaseTest
    {
        [SetUp]
        public void Open()
        {
            Driver.OpenUrl("https://broliumedus.lt/");
        }

        [Test]
        public void EducationFormWithValidData()
        {
            string expectedText = "Ačiū už Jūsų žinutę. Žinutė sėkmingai išsiųsta.";

            string valueVardas = "Tester";
            string valueEmail = "test@tester.com";
            string valueZinute = "Noriu";

            EducationForm.IsjungtiSlapukus();
            EducationForm.MygtukasEdukacijos();
            EducationForm.MygtukasUzsisakytiEdukacija();
            EducationForm.IvestiVarda(valueVardas);
            EducationForm.IvestiElPasta(valueEmail);
            EducationForm.ParasytiZinute(valueZinute);
            EducationForm.MygtukasSiusti();

            Assert.AreEqual(expectedText, EducationForm.ZinutesIssiuntimoPatvirtinimas());
        }
    }
}
