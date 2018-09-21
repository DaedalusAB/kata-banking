namespace Banking
{
    public static class IntExtensions
    {
        public static string ToStringWithSign(this int number)
        {
            return number >= 0
                ? $"+{number}"
                : $"{number}";
        }
    }
}
