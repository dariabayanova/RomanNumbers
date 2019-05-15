using NUnit.Framework;
using RomanNumber.Domain;

namespace Tests
{
    public class RomanNumberTests
    {
        [Test]
        public void Convert_1_to_I()
        {
            Assert.AreEqual("I", ToRoman(1));
        }

        [Test]
        public void Convert_2_to_II()
        {
            Assert.AreEqual("II", ToRoman(2));
        }

        [Test]
        public void Convert_3_to_III()
        {
            Assert.AreEqual("III", ToRoman(3));
        }

        [Test]
        public void Convert_5_to_V()
        {
            Assert.AreEqual("V", ToRoman(5));
        }

        private static string ToRoman(int number)
        {
            return RomanNumberConverter.Convert(number);
        }
    }
}