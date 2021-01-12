using System;

namespace PROJECT.Infrastructure.Extensions
{
    public static class DateTimeExtension
    {
        public static string ToTimestamp(this DateTime dateTime)
        {
            return dateTime.ToString("yyyy-MM-ddTHH:mm:ss.fff");
        }
    }
}
