using Framework.Pages;
using NUnit.Framework;

namespace Tests
{
    internal class EducationFormTest : BaseTest
    {

        [Test]
        public void EducationFormWithValidData()
        {
            string expectedText = "Ačiū už Jūsų žinutę. Žinutė sėkmingai išsiųsta.";

            string valueVardas = "Tester";
            string valueEmail = "test@tester.com";
            string valueZinute = "Noriu";

            EducationForm.SpaustiMygtukaEdukacijos();
            EducationForm.SpaustiMygtukaUzsisakytiEdukacija();
            EducationForm.IvestiVarda(valueVardas);
            EducationForm.IvestiElPasta(valueEmail);
            EducationForm.ParasytiZinute(valueZinute);
            EducationForm.SpaustiMygtukaSiusti();

            Assert.AreEqual(expectedText, EducationForm.ZinutesIssiuntimoPatvirtinimas());
        }
    }
}
