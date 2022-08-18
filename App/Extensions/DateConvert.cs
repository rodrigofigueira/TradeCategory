using System.Globalization;

namespace App.Extensions
{
    public static class DateConvert
    {
        public static DateTime ConvertStringToDate(this string value, string dateFormat = "MM/dd/yyyy")
        {
            DateTime date;
            Boolean _date = DateTime.TryParseExact(value, dateFormat,
                                                  CultureInfo.InvariantCulture,
                                                  DateTimeStyles.AdjustToUniversal,
                                                  out date);

            if (_date == false)
            {
                throw new Exception("Date input was wrong");
            }

            return date;
        }
    }
}
