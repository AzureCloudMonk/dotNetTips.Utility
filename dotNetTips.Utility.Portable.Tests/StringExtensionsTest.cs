// <copyright file="StringExtensionsTest.cs" company="dotNetTips.com">Copyright ©  2015</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using dotNetTips.Utility.Portable.Extensions;

namespace dotNetTips.Utility.Portable.Extensions.Tests
{
    [TestClass]
    [PexClass(typeof(StringExtensions))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class StringExtensionsTest
    {

        [PexMethod]
        public string DefaultIfNull(string s)
        {
            string result = StringExtensions.DefaultIfNull(s);
            return result;
            // TODO: add assertions to method StringExtensionsTest.DefaultIfNull(String)
        }

        [PexMethod]
        public string DefaultIfNull(string s, string defaultValue)
        {
            string result = StringExtensions.DefaultIfNull(s, defaultValue);
            return result;
            // TODO: add assertions to method StringExtensionsTest.DefaultIfNull(String, String)
        }

        [PexMethod]
        public string DefaultIfNullOrEmpty(string value, string defaultValue)
        {
            string result = StringExtensions.DefaultIfNullOrEmpty(value, defaultValue);
            return result;
            // TODO: add assertions to method StringExtensionsTest.DefaultIfNullOrEmpty(String, String)
        }

        [PexMethod]
        public string FormatFileSize(long fileSize)
        {
            string result = StringExtensions.FormatFileSize(fileSize);
            return result;
            // TODO: add assertions to method StringExtensionsTest.FormatFileSize(Int64)
        }

        [PexMethod]
        public string Indent(
            string str,
            int length,
            char indentationCharacter
        )
        {
            string result = StringExtensions.Indent(str, length, indentationCharacter);
            return result;
            // TODO: add assertions to method StringExtensionsTest.Indent(String, Int32, Char)
        }
    }
}
