namespace ExtensionMethods
{
    public static class DateTimeExtensions
    {
        public static string ToIso8601(this DateTime date)
        {
            return date.ToString("yyyy-MM-dd");
        }

        public static bool IsBetween(this DateTime date, DateTime date1, DateTime date2)
        {
            return date >= date1 && date <= date2;
        }

        public static bool IsWeekDay(this DateTime date)
        {
            return date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday;
        }

        public static bool IsWeekEnd(this DateTime date)
        {
            return date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
        }

        public static bool IsLeapYear(this DateTime date)
        {
            int year = date.Year;
            return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
        }
    }
}