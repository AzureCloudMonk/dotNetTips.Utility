﻿// ***********************************************************************
// Assembly         : dotNetTips.Tips.Utility.Standard.Tests
// Author           : David McCarter
// Created          : 06-15-2018
//
// Last Modified By : David McCarter
// Last Modified On : 06-16-2018
// ***********************************************************************
// <copyright file="RegistryHelperUnitTest.cs" company="McCarter Consulting">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Text;
using dotNetTips.Utility.Standard.Win32;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Tips.Utility.Standard.Tests.Win32
{
    /// <summary>
    /// Class RegistryHelperUnitTest.
    /// </summary>
    [TestClass]
    public class RegistryHelperUnitTest
    {
        /// <summary>
        /// Lookups the user one drive key.
        /// </summary>
        [TestMethod]
        public void LookupUserOneDriveKey()
        {
            var key = RegistryHelper.GetCurrentUserRegistryKey(RegistryHelper.KeyCurrentUserOneDrive);

            Assert.IsNotNull(key);
        }
    }
}
