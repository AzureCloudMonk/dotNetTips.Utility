using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ObjectExtensionsTest.HasProperty.g.cs" company="dotNetTips.com">Copyright ©  2015</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace dotNetTips.Utility.Portable.Extensions.Tests
{
    public partial class ObjectExtensionsTest
    {

[TestMethod]
[PexGeneratedBy(typeof(ObjectExtensionsTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void HasPropertyThrowsArgumentNullException79()
{
    bool b;
    b = this.HasProperty((object)null, "");
}

[TestMethod]
[PexGeneratedBy(typeof(ObjectExtensionsTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void HasPropertyThrowsArgumentNullException873()
{
    bool b;
    b = this.HasProperty((object)null, (string)null);
}
    }
}
