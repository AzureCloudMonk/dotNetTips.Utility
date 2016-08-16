// <copyright file="ExceptionExtensionTest.cs" company="dotNetTips.com">Copyright ©  2015</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using dotNetTips.Utility.Portable.Extensions;

namespace dotNetTips.Utility.Portable.Extensions.Tests
{
    [TestClass]
    [PexClass(typeof(ExceptionExtension))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ExceptionExtensionTest
    {

        [PexGenericArguments(typeof(object))]
        [PexMethod]
        public T TraverseFor<T>(Exception ex)
            where T : class
        {
            T result = ExceptionExtension.TraverseFor<T>(ex);
            return result;
            // TODO: add assertions to method ExceptionExtensionTest.TraverseFor(Exception)
        }
    }
}
