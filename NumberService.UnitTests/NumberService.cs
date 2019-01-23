using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberService.UnitTests
{
    public class NumberService
    {
        public int ConvertToArabicNumber(string input)
        {
            var result = 0;
            var romanNumeralAndArabicNumbers = GetRomanNumeralAndArabicNumbers();

            foreach (var item in romanNumeralAndArabicNumbers)
            {
                if (input == item.RomanValue)
                {
                    result = item.ArabicValue;
                }
            }
            return result;
        }

        public string ConvertToRomanNumeral(int input)
        {
            if (input < 1 || input > 5000)
            {
                throw new IndexOutOfRangeException("Input is invalid. Please use a number between 1 and 5000.");
            }

            var result = string.Empty;
            var romanNumeralAndArabicNumbers = GetRomanNumeralAndArabicNumbers();

            foreach (var romanNumeralAndArabicNumber in romanNumeralAndArabicNumbers)
            {
                if (input == romanNumeralAndArabicNumber.ArabicValue)
                {
                    result += result + romanNumeralAndArabicNumber.RomanValue;
                }
                if (input < romanNumeralAndArabicNumber.ArabicValue)
                {
                    break;
                }
            }
            return result;
        }

        private static List<RomanNumeralAndArabicNumber> GetRomanNumeralAndArabicNumbers()
        {
            var romanNumeralAndArabicNumberList = new List<RomanNumeralAndArabicNumber>
            {
                new RomanNumeralAndArabicNumber
                {
                    RomanValue = "I",
                    ArabicValue = 1
                },
                new RomanNumeralAndArabicNumber
                {
                    RomanValue = "V",
                    ArabicValue = 5
                },
                new RomanNumeralAndArabicNumber
                {
                    RomanValue = "X",
                    ArabicValue = 10
                },
                new RomanNumeralAndArabicNumber
                {
                    RomanValue = "L",
                    ArabicValue = 50
                },
                new RomanNumeralAndArabicNumber
                {
                    RomanValue = "C",
                    ArabicValue = 100
                },
                new RomanNumeralAndArabicNumber
                {
                    RomanValue = "D",
                    ArabicValue = 500
                },
                new RomanNumeralAndArabicNumber
                {
                    RomanValue = "M",
                    ArabicValue = 1000
                }
            };
            return romanNumeralAndArabicNumberList;
        }

        class RomanNumeralAndArabicNumber
        {
            public string RomanValue { get; set; }
            public int ArabicValue { get; set; }
        }

    }
}