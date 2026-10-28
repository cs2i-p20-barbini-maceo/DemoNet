namespace ExtensionMethods
{
    public static class IntExtensions
    {
        public static bool IsEven(this int value) 
        {
            return value % 2 ==0;
        }
        public static bool IsOdd(this int value)
        { 
            return value % 2 == 1;
        }

        public static bool IsDivisibleBy(this int value, int divider)
        {
            return value % divider == 0; 
        }
    }

}