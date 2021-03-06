﻿// ***********************************************************************
// Assembly         : dotNetTips.Utility.Portable
// Author           : David McCarter
// Created          : 02-28-2017
//
// Last Modified By : David McCarter
// Last Modified On : 05-19-2017
// ***********************************************************************
// <copyright file="StringExtensions.cs" company="dotNetTips.com">
//     David McCarter - dotNetTips.com © 2017
// </copyright>
// <summary></summary>
// ***********************************************************************

using dotNetTips.Utility.Portable.OOP;
using System;
using System.Text;
using System.Linq;
using System.Globalization;

namespace dotNetTips.Utility.Portable.Extensions
{
    /// <summary>
    /// Class StringExtensions.
    /// </summary>
    public static class StringExtensions
    {

        /// <summary>
        /// Determines whether [is valid credit card number] [the specified number].
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns><c>true</c> if [is valid credit card number] [the specified number]; otherwise, <c>false</c>.</returns>
        public static bool IsValidCreditCardNumber(this string number)
        {
            if(string.IsNullOrEmpty(number))
            {
                return false;
            }

            var deltas = new int[] { 0, 1, 2, 3, 4, -4, -3, -2, -1, 0 };
            var checksum = 0;
            var chars = number.ToCharArray();

            for (var i = chars.Length - 1; i > -1; i--)
            {
                var j = ((int)chars[i]) - 48;
                checksum += j;
                if (((i - chars.Length) % 2) == 0)
                {
                    checksum += deltas[j];
                }
            }

            return ((checksum % 10) == 0);
        }

        /// <summary>
        /// Determines whether the specified the string contains any of the characters.
        /// </summary>
        /// <param name="input">The string.</param>
        /// <param name="characters">The characters.</param>
        /// <returns><c>true</c> if the specified characters contains any; otherwise, <c>false</c>.</returns>
        /// <exception cref="System.ArgumentNullException">Null character.</exception>
        /// <exception cref="ArgumentNullException">Null character.</exception>
        public static bool ContainsAny(this string input, params string[] characters)
        {
            Encapsulation.TryValidateParam<ArgumentNullException>(characters != null && characters.Length > 0);
   
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            foreach (var character in characters)
            {
                if (string.IsNullOrEmpty(character))
                {
                    throw new ArgumentNullException("Null character.");
                }

                if (input.Contains(character))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Defaults if null.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns>System.String.</returns>
        public static string DefaultIfNull(this string s)
        {
            return s ?? string.Empty;
        }

        /// <summary>
        /// Defaults if null.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.String.</returns>
        public static string DefaultIfNull(this string s, string defaultValue)
        {
            return s ?? (defaultValue ?? string.Empty);
        }

        /// <summary>
        /// Defaults if null or empty.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.String.</returns>
        public static string DefaultIfNullOrEmpty(this string value, string defaultValue)
        {
            return string.IsNullOrEmpty(value) ? value : defaultValue;
        }

        /// <summary>
        /// Formats the size of the file.
        /// </summary>
        /// <param name="fileSize">Size of the file.</param>
        /// <returns>System.String.</returns>
        public static string FormatFileSize(this long fileSize)
        {
            Encapsulation.TryValidateParam<ArgumentOutOfRangeException>(fileSize >= 0 && fileSize >= long.MinValue && fileSize <= long.MaxValue);

            var size = 0L;

            while (fileSize > 1024 && size < 4)
            {
                fileSize = Convert.ToInt64(fileSize / 1024);
                size += 1;
            }

            return (($"{fileSize} ") + (new string[] {
            "bytes",
            "KB",
            "MB",
            "GB"
            })[Convert.ToInt32(size)]);
        }

        /// <summary>
        /// Indents the specified length.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <param name="length">The length.</param>
        /// <param name="indentationCharacter">The indentation character.</param>
        /// <returns>System.String.</returns>
        public static string Indent(this string str, int length, char indentationCharacter = ControlChars.Space)
        {
            Encapsulation.TryValidateParam<ArgumentOutOfRangeException>(length > 0);

            var sb = new StringBuilder();

            if (length < 0)
            {
                sb.Append(str);
            }
            int i;

            for (i = 1; i <= Math.Abs(length); i++)
            {
                sb.Append(indentationCharacter);
            }

            if (length > 0)
            {
                sb.Append(str);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Adds the URL slash.
        /// </summary>
        /// <param name="inputPath">The input path.</param>
        /// <returns>System.String.</returns>
        public static string AddUrlSlash(this string inputPath)
        {
            //add the ending slash to a path if it isn't already there
            var inputPathResult = inputPath.Trim();

            if (inputPathResult.Length - 1 < 0)
            {
                return inputPathResult;
            }
            else if (inputPathResult[inputPathResult.Length - 1] == Convert.ToChar("/", CultureInfo.InvariantCulture))
            {
                return (inputPathResult);
            }
            else
            {
                return ($"{inputPathResult}/");
            }

        }

        /// <summary>
        /// Combines the URL paths.
        /// </summary>
        /// <param name="basePath">The base path.</param>
        /// <param name="pagePath">The page path.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static string CombineUrlPaths(string basePath, string pagePath)
        {
            if ((basePath == null) || (pagePath == null))
            {
                throw new ArgumentNullException((basePath == null) ? nameof(basePath) : nameof(pagePath));
            }

            if (pagePath.Length == 0)
            {
                return basePath;
            }

            if (pagePath[0] == Convert.ToChar("/", CultureInfo.InvariantCulture))
            {
                pagePath = pagePath.Substring(1, pagePath.Length - 1);
            }

            if (basePath[basePath.Length - 1] !=Convert.ToChar("/", CultureInfo.InvariantCulture))
            {
                return ($"{basePath}/{pagePath}");
            }
            else
            {
                return (basePath + pagePath);
            }
        }

    }
}