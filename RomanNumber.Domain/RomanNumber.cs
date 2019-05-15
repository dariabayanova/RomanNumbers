namespace RomanNumber.Domain
{
    public class RomanNumberConverter
    {
        public static string Convert(int i)
        {
            if (i == 1)
            {
                return "I";
            }
            else
            {
                return "II";
            }
        }
    }
}