﻿// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 06-05-2018
//
// Last Modified By : David McCarter
// Last Modified On : 06-06-2018
// ***********************************************************************
// <copyright file="Singleton.cs" company="dotNetTips.com - David McCarter">
//     dotNetTips.com - David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace dotNetTips.Utility.Standard
{
    /// <summary>
    /// Class Singleton.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Singleton<T> where T : Singleton<T>, new()
    {
        /// <summary>
        /// The instance
        /// </summary>
        private static T _instance = new T();
        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>The instance.</value>
        public static T Instance
        {
            get
            {
                return _instance;
            }
        }

        /// <summary>
        /// ts this instance.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>LoadData.</returns>
        protected static void LoadData(T data)
        {
            if (data != null)
            {
                _instance = data;
            }
        }
    }
}