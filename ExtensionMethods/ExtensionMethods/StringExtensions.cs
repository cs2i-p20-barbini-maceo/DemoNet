
namespace ExtensionMethods
{
    public static class StringExtensions
    {
        private static object s;

        public static string Left(this string s, int x)
        {
            if (x >= s.Length) return s;
            return s.Substring(0, x);
        }

        public static string Right(this string s, int x)
        {
            if (x >= s.Length) return s;
            return s.Substring(s.Length - x);
        }
    }
}
