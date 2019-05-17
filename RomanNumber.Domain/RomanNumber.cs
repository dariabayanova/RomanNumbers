namespace RomanNumber.Domain
{
    public class RomanNumberConverter
    {
        public static string Convert(int number)
        {
            var THREE = 3;
            var FIVE = 5;
            var TEN = 10;
            
            if (number <= 0)
            {
                return "";
            }
            
            if (number <= THREE)
            {
                if (number == 1)
                {
                    return "I";
                }
                else
                {
                    return "I" + Convert(number - 1);
                }
            }

      
            if (number < FIVE)
            {
                return Convert(number - THREE) + "V";
            }
            
            if (number >= FIVE && (number <= (TEN - THREE + 1)))
            {
                return "V" + Convert(number - FIVE);
            }


            if (number < TEN)
            {
                return Convert(number - FIVE - THREE) + "X";
            }
            if (number >= TEN)
            {
                return "X" + Convert(number - TEN);
            }

            return "";
        }
    }
}