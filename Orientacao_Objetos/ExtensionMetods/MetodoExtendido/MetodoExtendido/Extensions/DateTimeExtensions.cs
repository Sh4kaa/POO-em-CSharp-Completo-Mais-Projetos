using System;
using System.Globalization;

namespace MetodoExtendido.Extensions
{
    static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObj) // metódo referenciando o próprio datetime
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);
            if(duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("f1", CultureInfo.InvariantCulture) + " hours";
            } else
            {
                return duration.TotalDays.ToString("f1", CultureInfo.InvariantCulture) + " days";
            }
        }
    }
}
