namespace ExtensionMethods
{
    public static class StringExtensions
    {
        public static string Left(this string s, int x)
        {
            if (x < 0 || x >= s.Length) return s;
            return s.Substring(0, x);
        }

        public static string Right(this string s, int x)
        {
            if (x < 0 || x >= s.Length) return s;
            return s.Substring(s.Length - x);
        }

        public static string Ellipsis(this string s, int size, string ellipsis = "...")
        {
            if (size >= s.Length) return s;
            return s.Substring(0, size) + ellipsis;
        }

        public static string FillLeft(this string s, int size, char c = ' ')
        {
            if (s.Length >= size) return s.Substring(0, size);
            while (s.Length < size)
            {
                s = c + s;
            }
            return s;
        }
    }
}