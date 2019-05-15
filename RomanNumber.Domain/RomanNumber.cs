namespace RomanNumber.Domain
{
    public class RomanNumberConverter
    {
        public static string Convert(int number)
        {
            var romanNumbers = new [] {"I", "II", "III"};
            return romanNumbers[number - 1];
        }
    }
}