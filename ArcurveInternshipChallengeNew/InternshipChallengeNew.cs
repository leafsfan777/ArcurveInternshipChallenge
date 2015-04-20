using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArcurveInternshipChallengeNew.Dates;

namespace ArcurveInternshipChallengeNew
{
    public class InternshipChallengeNew
    {
        /// <summary>
        /// Given a date, get values for the first day of the month containing that date and the
        /// first day of next month as a DateSpan.
        /// </summary>
        /// <param name="aDate">An arbitrary date, in localtime</param>
        public static DateSpan GetMonthRangeInUtc(DateTime aDate)
        {
            DateSpan range;

            // compute the first day of the month containing aDate and successive months
            DateTime[] monthStart = new DateTime[2];
            int monthModifier;
           
            for (int i = 0; i < monthStart.Length; i++)
            {
                monthModifier = aDate.Month == 12 && i == 1 ? -11 : i;
                monthStart[i] = new DateTime(aDate.Year + ((aDate.Month + i) / 13), aDate.Month + monthModifier, 1);
            }

            range = new DateSpan(monthStart[0].ToUniversalTime(), monthStart[1].ToUniversalTime());
            return range;
        }
    }
}
