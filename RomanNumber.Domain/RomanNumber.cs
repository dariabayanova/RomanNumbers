namespace RomanNumber.Domain
{
    public class RomanNumberConverter
    {
        public static string Convert(int number)
        {
            var THREE = 3;
            var FIVE = 5;
            var TEN = 10;
            
            if (number <= THREE)
            {
                return OneThreeFunc(number);
            }

      
            if (number < FIVE)
            {
                return OneThreeFunc(number - THREE) + "V";
            }
            
            if (number >= FIVE && (number <= (TEN - THREE + 1)))
            {
                return "V" + OneThreeFunc(number - FIVE);
            }


            if (number < TEN)
            {
                return OneThreeFunc(number - FIVE - THREE) + "X";
            }
            if (number >= TEN)
            {
                return "X" + OneThreeFunc(number - TEN);
            }

            return "";
        }

        private static string OneThreeFunc(int number)
        {
            var res = "";
            
            for (var i = 0; i < number; i++)
            {
                res += "I";
            }

            return res;
        }
    }
}