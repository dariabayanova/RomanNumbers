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
    }
}