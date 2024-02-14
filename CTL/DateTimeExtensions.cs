namespace CTL
{
    public static class DateTimeExtensions
    {
        public static bool IsWorkTime(this DateTime dateTime)
        {
            return dateTime.Hour >= 9 && dateTime.Hour <= 17;
        }
    }
}
