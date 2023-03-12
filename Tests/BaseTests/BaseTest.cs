using Framework;
using Framework.Pages;
using NUnit.Framework;

namespace Tests.BaseTests
{
    internal class BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Driver.SetupDriver();
            Driver.OpenUrl("https://broliumedus.lt/");
            HomePage.IsjungtiSlapukusSpaustiOK();
        }

        [TearDown]
        public void Teardown()
        {
            Driver.QuitDriver();
        }
    }
}
