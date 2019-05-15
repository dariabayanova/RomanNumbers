namespace RomanNumber.Domain
{
    public class RomanNumberConverter
    {
        public static string Convert(int number)
        {
            if (number == 10)
            {
                return "X";                
            }
            
            if (number <= 3)
            {
                return OneThreeFunc(number);
            }

            if (number >= 5)
            {
                return "V" + OneThreeFunc(number - 5);
            }

            return OneThreeFunc(number - 3) + "V";
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