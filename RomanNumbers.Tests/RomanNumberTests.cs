using NUnit.Framework;
using RomanNumber.Domain;

namespace Tests
{
    public class RomanNumberTests
    {
        [Test]
        public void Convert_00_to_EMPTY()
        {
            Assert.AreEqual("", ToRoman(0));
        }
        
        [Test]
        public void Convert_01_to_I()
        {
            Assert.AreEqual("I", ToRoman(1));
        }

        [Test]
        public void Convert_02_to_II()
        {
            Assert.AreEqual("II", ToRoman(2));
        }

        [Test]
        public void Convert_03_to_III()
        {
            Assert.AreEqual("III", ToRoman(3));
        }

        [Test]
        public void Convert_05_to_V()
        {
            Assert.AreEqual("V", ToRoman(5));
        }

        [Test]
        public void Convert_04_to_IV()
        {
            Assert.AreEqual("IV", ToRoman(4));
        }

        [Test]
        public void Convert_06_to_VI()
        {
            Assert.AreEqual("VI", ToRoman(6));            
        }

        [Test]
        public void Convert_07_to_VII()
        {
            Assert.AreEqual("VII", ToRoman(7));            
        }

        [Test]
        public void Convert_10_to_X()
        {
            Assert.AreEqual("X", ToRoman(10));            
        }
        
        [Test]
        public void Convert_08_to_VIII()
        {
            Assert.AreEqual("VIII", ToRoman(8));            
        }

        [Test]
        public void Convert_09_toIX()
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

        [Test]
        public void Convert_38_to_XXXVIII()
        {
            Assert.AreEqual("XXXVIII", ToRoman(38));
        }
        
        [Test]
        public void Convert_39_to_XXXIX()
        {
            Assert.AreEqual("XXXIX", ToRoman(39));
        }
        
        [Test]
        public void Convert_40_to_XL()
        {
            Assert.AreEqual("XL", ToRoman(40));
        }

        [Test]
        public void Convert_48_to_XLVIII()
        {
            Assert.AreEqual("XLVIII", ToRoman(48));            
        }

        [Test]
        public void Convert_50_to_L()
        {
            Assert.AreEqual("L", ToRoman(50));
        }
        
        [Test]
        public void Convert_89_to_LXXXIX()
        {
            Assert.AreEqual("LXXXIX", ToRoman(89));
        }

        private static string ToRoman(int number)
        {
            return RomanNumberConverter.Convert(number);
        }
    }
}