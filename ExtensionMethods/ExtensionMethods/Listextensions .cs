using System.Collections.Generic;

namespace ExtensionMethods
{
    public static class ListExtensions
    {
        public static List<string> ToUpper(this List<string> list)
        {
            var result = new List<string>();
            foreach (string s in list)
            {
                result.Add(s.ToUpper());
            }
            return result;
        }

        public static List<string> ToLower(this List<string> list)
        {
            var result = new List<string>();
            foreach (string s in list)
            {
                result.Add(s.ToLower());
            }
            return result;
        }
        public static string LonguestString(this List<string> list)
        {
            if (list.Count == 0) return "";
            string longest = list[0];
            foreach (string s in list)
            {
                if (s.Length > longest.Length) longest = s;
            }
            return longest;
        }

        public static string ShortestString(this List<string> list)
        {
            if (list.Count == 0) return "";
            string shortest = list[0];
            foreach (string s in list)
            {
                if (s.Length < shortest.Length) shortest = s;
            }
            return shortest;
        }


        public static int MaxValue(this List<int> list)
        {
            if (list.Count == 0) return 0;
            int max = list[0];
            foreach (int n in list)
            {
                if (n > max) max = n;
            }
            return max;
        }

        public static int MinValue(this List<int> list)
        {
            if (list.Count == 0) return 0;
            int min = list[0];
            foreach (int n in list)
            {
                if (n < min) min = n;
            }
            return min;
        }
        public static int ListTotal(this List<int> list)
        {
            int total = 0;
            foreach (int n in list)
            {
                total += n;
            }
            return total;
        }

        public static double ListAverage(this List<int> list)
        {
            if (list.Count == 0) return 0;
            return (double)list.ListTotal() / list.Count;
        }

    }
}
