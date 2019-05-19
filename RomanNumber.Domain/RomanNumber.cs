namespace RomanNumber.Domain
{
    public class RomanNumberConverter
    {
        public static string Convert(int number)
        {
            var ONE = 1;
            var THREE = 3;
            var FIVE = 5;
            var TEN = 10;
            var FIFTY = 50;


            if (number >= 40 && number <= 49)
            {
                return "XL" + Convert(number - 40);
            }
            if (number >= FIFTY)
            {
                return "L" + Convert(number - FIFTY);
            }

            if (number >= TEN - ONE)
            {
                return Convert(TEN - number) + "X" + Convert(number - TEN);
            }
            
            if (number >= FIVE - ONE)
            {
                return Convert(FIVE - number) + "V" + Convert(number - FIVE);
            }
            if (number >= ONE)
            {
                return "I" + Convert(number - ONE);
            }
            
            return "";
        }
    }
}