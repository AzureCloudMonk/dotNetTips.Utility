// <copyright file="MathExtensionsTest.cs" company="dotNetTips.com">Copyright ©  2015</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using dotNetTips.Utility.Portable.Extensions;

namespace dotNetTips.Utility.Portable.Extensions.Tests
{
    [TestClass]
    [PexClass(typeof(MathExtensions))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class MathExtensionsTest
    {

        [PexMethod]
        public int Round(double value)
        {
            int result = MathExtensions.Round(value);
            return result;
            // TODO: add assertions to method MathExtensionsTest.Round(Double)
        }

        [PexMethod]
        public int Round(double value, int digits)
        {
            int result = MathExtensions.Round(value, digits);
            return result;
            // TODO: add assertions to method MathExtensionsTest.Round(Double, Int32)
        }

        [PexMethod]
        public int Round(double value, MidpointRounding mode)
        {
            int result = MathExtensions.Round(value, mode);
            return result;
            // TODO: add assertions to method MathExtensionsTest.Round(Double, MidpointRounding)
        }

        [PexMethod]
        public int Round(
            double value,
            int digits,
            MidpointRounding mode
        )
        {
            int result = MathExtensions.Round(value, digits, mode);
            return result;
            // TODO: add assertions to method MathExtensionsTest.Round(Double, Int32, MidpointRounding)
        }

        [PexMethod]
        public int Round(decimal value)
        {
            int result = MathExtensions.Round(value);
            return result;
            // TODO: add assertions to method MathExtensionsTest.Round(Decimal)
        }
    }
}
