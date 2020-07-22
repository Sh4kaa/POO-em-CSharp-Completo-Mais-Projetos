using System;
using System.Globalization;

namespace MetodoExtendido.Extensions
{
    static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObj) // metódo referenciando o próprio datetime(obs: primeiro vem o"this" + "tipo"+ "apelidodoobjeto" + "parametro" se tiver parametro)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj); // subtraindoa  hora do próprio objeto com base no instante da hora atual
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
