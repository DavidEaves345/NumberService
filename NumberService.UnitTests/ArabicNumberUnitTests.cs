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
    }
}