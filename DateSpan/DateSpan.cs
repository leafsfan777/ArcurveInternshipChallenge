using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcurveInternshipChallengeNew.Dates
{
    public class DateSpan
    {
        private DateTime Start;
        private DateTime End;

        public DateSpan(DateTime start, DateTime end)
        {
            Start = start;
            End = end;
        }

        public void SetStart(DateTime start)
        {
            Start = start;
        }

        public void SetEnd(DateTime end)
        {
            End = end;
        }

        public DateTime GetStart()
        {
            return Start;
        }

        public DateTime GetEnd()
        {
            return End;
        }

        public Boolean Equals(DateSpan aDateSpan)
        {
            if (aDateSpan.GetStart().Equals(Start) && aDateSpan.GetEnd().Equals(End))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
