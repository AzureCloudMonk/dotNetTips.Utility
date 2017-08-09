﻿// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 01-22-2017
//
// Last Modified By : David McCarter
// Last Modified On : 06-26-2017
// ***********************************************************************
// <copyright file="ArgumentIsReadOnlyException.cs" company="dotNetTips.Utility.Standard">
//     Copyright (c) dotNetTips.com - McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;

namespace dotNetTips.Utility.Standard
{
    /// <summary>
    /// Class ArgumentIsReadOnlyException.
    /// </summary>
    /// <seealso cref="System.ArgumentException" />
    /// <seealso cref="System.Exception" />
    public class ArgumentReadOnlyException : ArgumentException
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ArgumentReadOnlyException" /> class.
        /// </summary>
        public ArgumentReadOnlyException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArgumentReadOnlyException" /> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public ArgumentReadOnlyException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArgumentReadOnlyException"/> class.
        /// </summary>
        /// <param name="parmName">Name of the parm.</param>
        /// <param name="message">The message.</param>
        public ArgumentReadOnlyException(string parmName, string message)
    : base(parmName,  message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArgumentReadOnlyException" /> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in
        /// Visual Basic) if no inner exception is specified.</param>
        public ArgumentReadOnlyException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        #endregion Public Constructors
    }
}