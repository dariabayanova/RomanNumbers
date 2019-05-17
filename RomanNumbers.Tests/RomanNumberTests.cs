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

        [Test]
        public void Convert_4_to_IV()
        {
            Assert.AreEqual("IV", ToRoman(4));
        }

        [Test]
        public void Convert_6_to_VI()
        {
            Assert.AreEqual("VI", ToRoman(6));            
        }

        [Test]
        public void Convert_7_to_VII()
        {
            Assert.AreEqual("VII", ToRoman(7));            
        }

        [Test]
        public void Convert_10_to_X()
        {
            Assert.AreEqual("X", ToRoman(10));            
        }
        
        [Test]
        public void Convert_8_to_VIII()
        {
            Assert.AreEqual("VIII", ToRoman(8));            
        }

        [Test]
        public void Convert_9_toIX()
        {
            Assert.AreEqual("IX", ToRoman(9));
        }
        
        [Test]
        public void Convert_13_to_XIII()
        {
            Assert.AreEqual("XIII", ToRoman(13));
        }

        [Test]
        public void Convert_14_to_XIV()
        {
            Assert.AreEqual("XIV", ToRoman(14));
        }

        [Test]
        public void Convert_17_to_XVII()
        {
            Assert.AreEqual("XVII", ToRoman(17));
        }

        [Test]
        public void Convert_19_to_XIX()
        {
            Assert.AreEqual("XIX", ToRoman(19));
        }

        private static string ToRoman(int number)
        {
            return RomanNumberConverter.Convert(number);
        }
    }
}