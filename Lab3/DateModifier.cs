using System.Globalization;

namespace Lab3 {
    public class DateModifier {
        public int GetDifferenceInDays(string date1, string date2) {
            DateTime dateTime1 = DateTime.ParseExact(date1, "yyyy MM dd", CultureInfo.InvariantCulture);
            DateTime dateTime2 = DateTime.ParseExact(date2, "yyyy MM dd", CultureInfo.InvariantCulture);

            TimeSpan difference = dateTime2 - dateTime1;
            int days = (int)difference.TotalDays;

            return days;
        }
    }
}
