// <copyright file="DateTimeExtensionsTest.cs" company="dotNetTips.com">Copyright ©  2015</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using dotNetTips.Utility.Portable;

namespace dotNetTips.Utility.Portable.Tests
{
    [TestClass]
    [PexClass(typeof(DateTimeExtensions))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class DateTimeExtensionsTest
    {

        [PexMethod]
        public DateTime GetLast(DateTime input, DayOfWeek dayOfWeek)
        {
            DateTime result = DateTimeExtensions.GetLast(input, dayOfWeek);
            return result;
            // TODO: add assertions to method DateTimeExtensionsTest.GetLast(DateTime, DayOfWeek)
        }

        [PexMethod]
        public DateTime GetNext(DateTime input, DayOfWeek dayOfWeek)
        {
            DateTime result = DateTimeExtensions.GetNext(input, dayOfWeek);
            return result;
            // TODO: add assertions to method DateTimeExtensionsTest.GetNext(DateTime, DayOfWeek)
        }

        [PexMethod]
        public bool Intersects(
            DateTime startDate,
            DateTime endDate,
            DateTime intersectingStartDate,
            DateTime intersectingEndDate
        )
        {
            bool result
               = DateTimeExtensions.Intersects(startDate, endDate, intersectingStartDate, intersectingEndDate);
            return result;
            // TODO: add assertions to method DateTimeExtensionsTest.Intersects(DateTime, DateTime, DateTime, DateTime)
        }

        [PexMethod]
        public string ToFriendlyDateString(DateTime input)
        {
            string result = DateTimeExtensions.ToFriendlyDateString(input);
            return result;
            // TODO: add assertions to method DateTimeExtensionsTest.ToFriendlyDateString(DateTime)
        }
    }
}
