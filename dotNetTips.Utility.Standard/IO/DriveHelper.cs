﻿// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 06-26-2017
//
// Last Modified By : David McCarter
// Last Modified On : 11-11-2018
// ***********************************************************************
// <copyright file="DriveHelper.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using dotNetTips.Utility.Standard.Extensions;

namespace dotNetTips.Utility.Standard.IO
{
    /// <summary>
    /// Class DriveHelper.
    /// </summary>
    public static class DriveHelper
	{
        /// <summary>
        /// Gets the fixed drives.
        /// </summary>
        /// <returns>IImmutableList&lt;DirectoryInfo&gt;.</returns>
        public static IImmutableList<DriveInfo> GetFixedDrives()
        {
            var drives = System.IO.DriveInfo.GetDrives().Where(p => p.DriveType == DriveType.Fixed & p.IsReady).Distinct().ToList();

           return drives.ToImmutable();
        }
	}
}
