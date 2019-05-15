using NUnit.Framework;

namespace Tests
{
    public class RomanNumberTests
    {
        [Test]
        public void Convert_1_to_I()
        {
            var result = GetRomanNumber(1);
            
            Assert.AreEqual("I", result);
        }

        private string GetRomanNumber(int i)
        {
            return "I";
        }
    }
}