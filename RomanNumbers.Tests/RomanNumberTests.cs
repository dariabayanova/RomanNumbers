using NUnit.Framework;
using RomanNumber.Domain;

namespace Tests
{
    public class RomanNumberTests
    {
        [Test]
        public void Convert_1_to_I()
        {
            var result = RomanNumberConverter.Convert(1);
            
            Assert.AreEqual("I", result);
        }

        [Test]
        public void Convert_2_to_II()
        {
            var result = RomanNumberConverter.Convert(2);
            
            Assert.AreEqual("II", result);
        }
    }
}