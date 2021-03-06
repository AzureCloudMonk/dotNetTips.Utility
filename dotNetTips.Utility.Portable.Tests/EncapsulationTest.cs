// <copyright file="EncapsulationTest.cs" company="dotNetTips.com">David McCarter - dotNetTips.com © 2017</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using dotNetTips.Utility.Portable.OOP;

namespace dotNetTips.Utility.Portable.OOP.Tests
{
    [TestClass]
    [PexClass(typeof(Encapsulation))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class EncapsulationTest
    {

        [PexMethod]
        public void TryValidateParam(
            Guid value,
            string paramName,
            string message
        )
        {
            Encapsulation.TryValidateParam(value, paramName, message);
            // TODO: add assertions to method EncapsulationTest.TryValidateParam(Guid, String, String)
        }
    }
}
