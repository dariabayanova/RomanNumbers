namespace RomanNumber.Domain
{
    public class RomanNumberConverter
    {
        public static string Convert(int number)
        {
            var five = 5;
            
            if (number <= 3)
            {
                return OneThreeFunc(number);
            }

      
            if (number < five)
            {
                return OneThreeFunc(number - 3) + "V";
            }
            
            if (number >= five && (number <= (10 - 3 + 1)))
            {
                return "V" + OneThreeFunc(number - five);
            }


            if (number < 10)
            {
                return OneThreeFunc(number - five - 3) + "X";
            }
            if (number >= 10)
            {
                return "X" + OneThreeFunc(number - 10);
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