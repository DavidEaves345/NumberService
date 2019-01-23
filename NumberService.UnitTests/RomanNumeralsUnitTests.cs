using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace NumberService.UnitTests
{
    [TestClass]
    public class RomanNumeralsUnitTests
    {
        private readonly NumberService _testee = new NumberService();

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void GivenZero_ShouldThrowindexOutOfRangeException()
        {
            _testee.ConvertToRomanNumeral(0);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void GivenMinusOne_ShouldThrowOutOfRangeException()
        {
            _testee.ConvertToRomanNumeral(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void GivenFiveThousandAndOne_ShouldThrowOutOfRangeException()
        {
            _testee.ConvertToRomanNumeral(5001);
        }

        [TestMethod]
        public void Given1_ShouldReturnI()
        {
            var result = _testee.ConvertToRomanNumeral(1);
            result.ShouldBe("I");
        }

        [TestMethod]
        public void Given5_ShouldReturnV()
        {
            var result = _testee.ConvertToRomanNumeral(5);
            result.ShouldBe("V");
        }

        [TestMethod]
        public void Given10_ShouldReturnX()
        {
            var result = _testee.ConvertToRomanNumeral(10);
            result.ShouldBe("X");
        }
    }
}