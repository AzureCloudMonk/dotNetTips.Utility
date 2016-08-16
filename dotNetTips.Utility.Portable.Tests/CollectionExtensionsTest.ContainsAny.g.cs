using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="CollectionExtensionsTest.ContainsAny.g.cs" company="dotNetTips.com">Copyright ©  2015</copyright>
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
    public partial class CollectionExtensionsTest
    {

[TestMethod]
[PexGeneratedBy(typeof(CollectionExtensionsTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void ContainsAnyThrowsArgumentNullException239()
{
    bool b;
    b = this.ContainsAny((string)null, (string[])null);
}

[TestMethod]
[PexGeneratedBy(typeof(CollectionExtensionsTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void ContainsAnyThrowsArgumentNullException369()
{
    bool b;
    b = this.ContainsAny("", (string[])null);
}

[TestMethod]
[PexGeneratedBy(typeof(CollectionExtensionsTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void ContainsAnyThrowsArgumentNullException408()
{
    bool b;
    string[] ss = new string[0];
    b = this.ContainsAny("\0", ss);
}

[TestMethod]
[PexGeneratedBy(typeof(CollectionExtensionsTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void ContainsAnyThrowsArgumentNullException384()
{
    bool b;
    b = this.ContainsAny("", (string[])null);
}

[TestMethod]
[PexGeneratedBy(typeof(CollectionExtensionsTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void ContainsAnyThrowsArgumentNullException414()
{
    bool b;
    b = this.ContainsAny("Ā", (string[])null);
}

[TestMethod]
[PexGeneratedBy(typeof(CollectionExtensionsTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void ContainsAnyThrowsArgumentNullException390()
{
    bool b;
    b = this.ContainsAny("\0\0", (string[])null);
}

[TestMethod]
[PexGeneratedBy(typeof(CollectionExtensionsTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void ContainsAnyThrowsArgumentNullException964()
{
    bool b;
    string[] ss = new string[1];
    b = this.ContainsAny("Ā", ss);
}

[TestMethod]
[PexGeneratedBy(typeof(CollectionExtensionsTest))]
public void ContainsAny646()
{
    bool b;
    string[] ss = new string[1];
    ss[0] = "Ā";
    b = this.ContainsAny("Ā", ss);
    Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(CollectionExtensionsTest))]
public void ContainsAny680()
{
    bool b;
    string[] ss = new string[1];
    ss[0] = "\0";
    b = this.ContainsAny("Ā", ss);
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(CollectionExtensionsTest))]
public void ContainsAny93()
{
    bool b;
    string[] ss = new string[1];
    ss[0] = "Ā\0";
    b = this.ContainsAny("Ā", ss);
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(CollectionExtensionsTest))]
public void ContainsAny383()
{
    bool b;
    string[] ss = new string[2];
    ss[0] = "Ā\0";
    ss[1] = "Ā\0";
    b = this.ContainsAny("Ā", ss);
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(CollectionExtensionsTest))]
public void ContainsAny356()
{
    bool b;
    string[] ss = new string[2];
    ss[0] = "\0";
    ss[1] = "\0";
    b = this.ContainsAny("Ā", ss);
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(CollectionExtensionsTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void ContainsAnyThrowsArgumentNullException431()
{
    bool b;
    b = this.ContainsAny("\0ĀĀ", (string[])null);
}
    }
}
