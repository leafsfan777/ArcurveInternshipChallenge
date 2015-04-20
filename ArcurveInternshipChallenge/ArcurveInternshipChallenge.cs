using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcurveInternshipChallenge
{
    public class InternshipChallenge
    {
        /// <summary>
        /// Given a date, get values for the first day of the month containing that date and the
        /// first day of next month.
        /// </summary>
        /// <param name="aDate">An arbitrary date, in localtime</param>
        /// <param name="utcMonthStart">Output: First day of the month in which aDate occurs, in UTC</param>
        /// <param name="utcNextMonthStart">Output: First day of the month after aDate, in UTC</param>
        public static void GetMonthRangeInUtc(DateTime aDate, out DateTime utcMonthStart, out DateTime utcNextMonthStart)
        {
            // compute the first day of the month containing aDate and successive months
            DateTime[] monthStart = new DateTime[2];
            int monthModifier;
           
            for (int i = 0; i < monthStart.Length; i++)
            {
                monthModifier = aDate.Month == 12 && i == 1 ? -11 : i;
                monthStart[i] = new DateTime(aDate.Year + ((aDate.Month + i) / 13), aDate.Month + monthModifier, 1);
            }

            utcMonthStart = monthStart[0].ToUniversalTime();
            utcNextMonthStart = monthStart[1].ToUniversalTime();
        }
    }
}
