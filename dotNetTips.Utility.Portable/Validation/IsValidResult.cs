﻿// ***********************************************************************
// Assembly         : dotNetTips.Utility.Portable
// Author           : David McCarter
// Created          : 06-26-2017
//
// Last Modified By : David McCarter
// Last Modified On : 07-21-2017
// ***********************************************************************
// <copyright file="IsValidResult.cs" company="dotNetTips.com">
//     David McCarter - dotNetTips.com © 2017
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;

namespace dotNetTips.Utility.Standard.Validation
{
    /// <summary>
    /// Class IsValidResult.
    /// </summary>
    public class IsValidResult
    {
        /// <summary>
        /// Returns true if ... is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public bool IsValid { get; private set; }

        /// <summary>
        /// Gets the errors.
        /// </summary>
        /// <value>The errors.</value>
        public IEnumerable<string> Errors { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="IsValidResult" /> class.
        /// </summary>
        /// <param name="valid">if set to <c>true</c> [valid].</param>
        /// <param name="errors">The errors.</param>
        public IsValidResult(bool valid, IEnumerable<string> errors)
        {
            this.IsValid = valid;
            this.Errors = errors;
        }
    }
}
