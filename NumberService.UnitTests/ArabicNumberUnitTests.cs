using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace NumberService.UnitTests
{
    [TestClass]
    public class ArabicNumberUnitTests
    {
        private readonly NumberService _testee = new NumberService();

        [TestMethod]
        public void GivenI_ShouldReturn1()
        {
            var result = _testee.ConvertToArabicNumber("I");
            result.ShouldBe(1);
        }

        [TestMethod]
        public void GivenV_ShouldReturn5()
        {
            var result = _testee.ConvertToArabicNumber("V");
            result.ShouldBe(5);
        }

        [TestMethod]
        public void GivenX_Shouldreturn10()
        {
            var result = _testee.ConvertToArabicNumber("X");
            result.ShouldBe(10);
        }
    }
}