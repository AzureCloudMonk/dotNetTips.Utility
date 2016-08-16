// <copyright file="ObjectExtensionsTest.cs" company="dotNetTips.com">Copyright ©  2015</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using dotNetTips.Utility.Portable.Extensions;

namespace dotNetTips.Utility.Portable.Extensions.Tests
{
    [TestClass]
    [PexClass(typeof(ObjectExtensions))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ObjectExtensionsTest
    {

        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public T As<T>(object value)
        {
            T result = ObjectExtensions.As<T>(value);
            return result;
            // TODO: add assertions to method ObjectExtensionsTest.As(Object)
        }

        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public bool In<T>(T source, T[] list)
        {
            bool result = ObjectExtensions.In<T>(source, list);
            return result;
            // TODO: add assertions to method ObjectExtensionsTest.In(!!0, !!0[])
        }

        [PexMethod]
        public bool IsNotNull(object obj)
        {
            bool result = ObjectExtensions.IsNotNull(obj);
            return result;
            // TODO: add assertions to method ObjectExtensionsTest.IsNotNull(Object)
        }

        [PexMethod]
        public bool IsNull(object obj)
        {
            bool result = ObjectExtensions.IsNull(obj);
            return result;
            // TODO: add assertions to method ObjectExtensionsTest.IsNull(Object)
        }

        [PexMethod]
        public void TryDispose(IDisposable obj, bool throwException)
        {
            ObjectExtensions.TryDispose(obj, throwException);
            // TODO: add assertions to method ObjectExtensionsTest.TryDispose(IDisposable, Boolean)
        }

        [PexMethod]
        public void TryDispose(IDisposable obj)
        {
            ObjectExtensions.TryDispose(obj);
            // TODO: add assertions to method ObjectExtensionsTest.TryDispose(IDisposable)
        }

        [PexMethod]
        public bool HasProperty(object instance, string propertyName)
        {
            bool result = ObjectExtensions.HasProperty(instance, propertyName);
            return result;
            // TODO: add assertions to method ObjectExtensionsTest.HasProperty(Object, String)
        }
    }
}
