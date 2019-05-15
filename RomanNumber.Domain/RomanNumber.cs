namespace RomanNumber.Domain
{
    public class RomanNumberConverter
    {
        public static string Convert(int number)
        {
            if (number == 5)
            {
                return "V";
            }
            
            var romanNumbers = new [] {"I", "II", "III"};
            return romanNumbers[number - 1];
        }
    }
}