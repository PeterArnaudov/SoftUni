namespace DefiningClasses
{
    using System;
    using System.Globalization;

    public class DateModifier
    {
        public double Difference { get; set; }

        public DateModifier(string dateOne, string dateTwo)
        {
            DateTime firstDate = DateTime.ParseExact(dateOne, "yyyy MM dd", CultureInfo.InvariantCulture);
            DateTime secondDate = DateTime.ParseExact(dateTwo, "yyyy MM dd", CultureInfo.InvariantCulture);

            Difference = Math.Abs((firstDate - secondDate).TotalDays);
        }
    }
}
