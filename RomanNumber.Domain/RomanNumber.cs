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
            
            if (number < ONE)
            {
                return "";
            }
            if (number >= ONE && number <= THREE * ONE)
            {
                return "I" + Convert(number - ONE);
            }
      
            if (number < FIVE)
            {
                return Convert(number - THREE) + "V";
            }
            if (number >= FIVE && (number <= FIVE + THREE * ONE))
            {
                return "V" + Convert(number - FIVE);
            }

            if (number < TEN)
            {
                return Convert(number - FIVE - THREE) + "X";
            }
            if (number >= TEN && number < TEN + THREE * TEN)
            {
                return "X" + Convert(number - TEN);
            }

            if (number < FIFTY)
            {
                return "XL" + Convert(number - 40);
            }
            if (number >= FIFTY)
            {
                return "L" + Convert(number - FIFTY);
            }

            return "";
        }
    }
}