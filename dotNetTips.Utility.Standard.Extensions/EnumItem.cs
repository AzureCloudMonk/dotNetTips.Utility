﻿// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 11-11-2018
// ***********************************************************************
// <copyright file="EnumItem.cs" company="dotNetTips.com - David McCarter">
//     dotNetTips.com - David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

namespace dotNetTips.Utility.Standard.Extensions
{
    /// <summary>
    /// Class EnumItem.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class EnumItem<T>
    {
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        public string Description
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        public T Value
        {
            get; set;
        }
    }
}
