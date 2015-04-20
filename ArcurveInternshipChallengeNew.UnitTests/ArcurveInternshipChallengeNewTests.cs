using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ArcurveInternshipChallengeNew.Dates;

namespace ArcurveInternshipChallengeNew.UnitTests
{
    [TestFixture]
    public class ArcurveInternshipChallengeNewTests
    {
        [Test]
        public void GetMonthRangeInUTCTestNow()
        {
            //Setup

            DateTime testADate = DateTime.Now;
            DateTime expectedUTCMonthStart = new DateTime(2015, 4, 1).ToUniversalTime();
            DateTime expectedUTCNextMonthStart = new DateTime(2015, 5, 1).ToUniversalTime();
            DateSpan expectedDateSpan = new DateSpan(expectedUTCMonthStart, expectedUTCNextMonthStart);

            //Act
            DateSpan result = InternshipChallengeNew.GetMonthRangeInUtc(testADate);

            //Perform
            Assert.True(result.Equals(expectedDateSpan));
        }
        [Test]
        public void GetMonthRangeInUTCTestJanuary()
        {
            //Setup

            DateTime testADate = new DateTime(2015, 1, 15);
            DateTime expectedUTCMonthStart = new DateTime(2015, 1, 1).ToUniversalTime();
            DateTime expectedUTCNextMonthStart = new DateTime(2015, 2, 1).ToUniversalTime();
            DateSpan expectedDateSpan = new DateSpan(expectedUTCMonthStart, expectedUTCNextMonthStart);

            //Act
            DateSpan result = InternshipChallengeNew.GetMonthRangeInUtc(testADate);

            //Perform
            Assert.True(result.Equals(expectedDateSpan));
        }
        [Test]
        public void GetMonthRangeInUTCTestFebruary()
        {
            //Setup

            DateTime testADate = new DateTime(2015, 2, 14);
            DateTime expectedUTCMonthStart = new DateTime(2015, 2, 1).ToUniversalTime();
            DateTime expectedUTCNextMonthStart = new DateTime(2015, 3, 1).ToUniversalTime();
            DateSpan expectedDateSpan = new DateSpan(expectedUTCMonthStart, expectedUTCNextMonthStart);

            //Act
            DateSpan result = InternshipChallengeNew.GetMonthRangeInUtc(testADate);

            //Perform
            Assert.True(result.Equals(expectedDateSpan));
        }
        [Test]
        public void GetMonthRangeInUTCTestMarch()
        {
            //Setup

            DateTime testADate = new DateTime(2015, 3, 13);
            DateTime expectedUTCMonthStart = new DateTime(2015, 3, 1).ToUniversalTime();
            DateTime expectedUTCNextMonthStart = new DateTime(2015, 4, 1).ToUniversalTime();
            DateSpan expectedDateSpan = new DateSpan(expectedUTCMonthStart, expectedUTCNextMonthStart);

            //Act
            DateSpan result = InternshipChallengeNew.GetMonthRangeInUtc(testADate);

            //Perform
            Assert.True(result.Equals(expectedDateSpan));
        }
        [Test]
        public void GetMonthRangeInUTCTestApril()
        {
            //Setup

            DateTime testADate = new DateTime(2015, 4, 12);
            DateTime expectedUTCMonthStart = new DateTime(2015, 4, 1).ToUniversalTime();
            DateTime expectedUTCNextMonthStart = new DateTime(2015, 5, 1).ToUniversalTime();
            DateSpan expectedDateSpan = new DateSpan(expectedUTCMonthStart, expectedUTCNextMonthStart);

            //Act
            DateSpan result = InternshipChallengeNew.GetMonthRangeInUtc(testADate);

            //Perform
            Assert.True(result.Equals(expectedDateSpan));
        }
        [Test]
        public void GetMonthRangeInUTCTestMay()
        {
            //Setup

            DateTime testADate = new DateTime(2015, 5, 18);
            DateTime expectedUTCMonthStart = new DateTime(2015, 5, 1).ToUniversalTime();
            DateTime expectedUTCNextMonthStart = new DateTime(2015, 6, 1).ToUniversalTime();
            DateSpan expectedDateSpan = new DateSpan(expectedUTCMonthStart, expectedUTCNextMonthStart);

            //Act
            DateSpan result = InternshipChallengeNew.GetMonthRangeInUtc(testADate);

            //Perform
            Assert.True(result.Equals(expectedDateSpan));
        }
        [Test]
        public void GetMonthRangeInUTCTestJune()
        {
            //Setup

            DateTime testADate = new DateTime(2015, 6, 30);
            DateTime expectedUTCMonthStart = new DateTime(2015, 6, 1).ToUniversalTime();
            DateTime expectedUTCNextMonthStart = new DateTime(2015, 7, 1).ToUniversalTime();
            DateSpan expectedDateSpan = new DateSpan(expectedUTCMonthStart, expectedUTCNextMonthStart);

            //Act
            DateSpan result = InternshipChallengeNew.GetMonthRangeInUtc(testADate);

            //Perform
            Assert.True(result.Equals(expectedDateSpan));
        }
        [Test]
        public void GetMonthRangeInUTCTestJuly()
        {
            //Setup

            DateTime testADate = new DateTime(2015, 7, 7);
            DateTime expectedUTCMonthStart = new DateTime(2015, 7, 1).ToUniversalTime();
            DateTime expectedUTCNextMonthStart = new DateTime(2015, 8, 1).ToUniversalTime();
            DateSpan expectedDateSpan = new DateSpan(expectedUTCMonthStart, expectedUTCNextMonthStart);

            //Act
            DateSpan result = InternshipChallengeNew.GetMonthRangeInUtc(testADate);

            //Perform
            Assert.True(result.Equals(expectedDateSpan));
        }
        [Test]
        public void GetMonthRangeInUTCTestAugust()
        {
            //Setup

            DateTime testADate = new DateTime(2015, 8, 16);
            DateTime expectedUTCMonthStart = new DateTime(2015, 8, 1).ToUniversalTime();
            DateTime expectedUTCNextMonthStart = new DateTime(2015, 9, 1).ToUniversalTime();
            DateSpan expectedDateSpan = new DateSpan(expectedUTCMonthStart, expectedUTCNextMonthStart);

            //Act
            DateSpan result = InternshipChallengeNew.GetMonthRangeInUtc(testADate);

            //Perform
            Assert.True(result.Equals(expectedDateSpan));
        }
        [Test]
        public void GetMonthRangeInUTCTestSeptember()
        {
            //Setup

            DateTime testADate = new DateTime(2015, 9, 25);
            DateTime expectedUTCMonthStart = new DateTime(2015, 9, 1).ToUniversalTime();
            DateTime expectedUTCNextMonthStart = new DateTime(2015, 10, 1).ToUniversalTime();
            DateSpan expectedDateSpan = new DateSpan(expectedUTCMonthStart, expectedUTCNextMonthStart);

            //Act
            DateSpan result = InternshipChallengeNew.GetMonthRangeInUtc(testADate);

            //Perform
            Assert.True(result.Equals(expectedDateSpan));
        }
        [Test]
        public void GetMonthRangeInUTCTestOctober()
        {
            //Setup

            DateTime testADate = new DateTime(2015, 10, 31);
            DateTime expectedUTCMonthStart = new DateTime(2015, 10, 1).ToUniversalTime();
            DateTime expectedUTCNextMonthStart = new DateTime(2015, 11, 1).ToUniversalTime();
            DateSpan expectedDateSpan = new DateSpan(expectedUTCMonthStart, expectedUTCNextMonthStart);

            //Act
            DateSpan result = InternshipChallengeNew.GetMonthRangeInUtc(testADate);

            //Perform
            Assert.True(result.Equals(expectedDateSpan));
        }
        [Test]
        public void GetMonthRangeInUTCTestNovember()
        {
            //Setup

            DateTime testADate = new DateTime(2015, 11, 28);
            DateTime expectedUTCMonthStart = new DateTime(2015, 11, 1).ToUniversalTime();
            DateTime expectedUTCNextMonthStart = new DateTime(2015, 12, 1).ToUniversalTime();
            DateSpan expectedDateSpan = new DateSpan(expectedUTCMonthStart, expectedUTCNextMonthStart);

            //Act
            DateSpan result = InternshipChallengeNew.GetMonthRangeInUtc(testADate);

            //Perform
            Assert.True(result.Equals(expectedDateSpan));
        }
        [Test]
        public void GetMonthRangeInUTCTestDecember()
        {
            //Setup

            DateTime testADate = new DateTime(2015, 12, 25);
            DateTime expectedUTCMonthStart = new DateTime(2015, 12, 1).ToUniversalTime();
            DateTime expectedUTCNextMonthStart = new DateTime(2016, 1, 1).ToUniversalTime();
            DateSpan expectedDateSpan = new DateSpan(expectedUTCMonthStart, expectedUTCNextMonthStart);

            //Act
            DateSpan result = InternshipChallengeNew.GetMonthRangeInUtc(testADate);

            //Perform
            Assert.True(result.Equals(expectedDateSpan));
        }
    }
}
