using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="DateTimeExtensionsTest.GetNext.g.cs" company="dotNetTips.com">Copyright ©  2015</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace dotNetTips.Utility.Portable.Tests
{
    public partial class DateTimeExtensionsTest
    {

[TestMethod]
[PexGeneratedBy(typeof(DateTimeExtensionsTest))]
[PexRaisedException(typeof(InvalidOperationException))]
public void GetNextThrowsInvalidOperationException609()
{
    DateTime dt;
    dt = this.GetNext(default(DateTime), DayOfWeek.Sunday);
}
    }
}
