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


            
            if (number >= FIFTY)
            {
                return "L" + Convert(number - FIFTY);
            }

            if (number >= TEN)
            {
                return "X" + Convert(number - TEN);
            }
            
            if (number >= FIVE)
            {
                return  "V" + Convert(number - FIVE);
            }
            if (number >= ONE)
            {
                return "I" + Convert(number - ONE);
            }
            
            return "";
        }
    }
}