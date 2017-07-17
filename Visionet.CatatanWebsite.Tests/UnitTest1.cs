using System;
using Visionet.CatatanWebsite.Controllers;
using Xunit.Abstractions;
using Xunit;
using System.Web.Mvc;

namespace Visionet.CatatanWebsite.Tests
{
    public class UnitTest1
    {
        private ITestOutputHelper o;

        public UnitTest1(ITestOutputHelper output)
        {
            o = output;
        }

        [Fact]
        public void CatatanController_GetCatatanByUserId_BilaDiberiIdBenar_KembalikanList()
        {
            var x = new CatatanController();

            var list = x.GetCatatanByUserId(2);
            var json = x.GetCatatanJsonByUserId(2);
            var jsonString = ((JsonResult)json).ToString();

            Assert.NotEmpty(x.GetCatatanByUserId(2));
        }
    }
}
