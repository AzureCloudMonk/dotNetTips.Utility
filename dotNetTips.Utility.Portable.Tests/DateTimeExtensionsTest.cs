// <copyright file="DateTimeExtensionsTest.cs" company="dotNetTips.com">David McCarter - dotNetTips.com © 2017</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using dotNetTips.Utility.Portable.Extensions;

namespace dotNetTips.Utility.Portable.Extensions.Tests
{
    [TestClass]
    [PexClass(typeof(DateTimeExtensions))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class DateTimeExtensionsTest
    {

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

        [PexMethod]
        public DateTime Tomorrow(DateTime input)
        {
            DateTime result = DateTimeExtensions.Tomorrow(input);
            return result;
            // TODO: add assertions to method DateTimeExtensionsTest.Tomorrow(DateTime)
        }
    }
}
