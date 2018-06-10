﻿// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 06-06-2018
//
// Last Modified By : David McCarter
// Last Modified On : 06-10-2018
// ***********************************************************************
// <copyright file="LoggableException.cs" company="dotNetTips.com - David McCarter">
//     dotNetTips.com - David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using dotNetTips.Utility.Standard.Logging;

namespace dotNetTips.Utility.Standard
{
    /// <summary>
    /// Class LoggableException.
    /// </summary>
    /// <seealso cref="System.Exception" />
    /// <seealso cref="System.Xml.Serialization.IXmlSerializable" />
    [Serializable]
    public class LoggableException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoggableException" /> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="ex">The ex.</param>
        /// <param name="userMessage">The user message.</param>
        public LoggableException(string message, Exception ex, string userMessage) : base(message, ex)
        {
            this.UserMessage = userMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoggableException" /> class.
        /// </summary>
        public LoggableException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoggableException" /> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public LoggableException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoggableException" /> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
        public LoggableException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoggableException" /> class.
        /// </summary>
        /// <param name="serializationInfo">The serialization information.</param>
        /// <param name="streamingContext">The streaming context.</param>
        /// <exception cref="NotImplementedException"></exception>
        protected LoggableException(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the messages.
        /// </summary>
        /// <value>The messages.</value>
        public virtual IEnumerable<string> Messages
        {
            get
            {
                var exceptions = LoggingHelper.RetrieveAllExceptions(this);
                var errorMessages = new List<string>();

                var enumerator = exceptions.GetEnumerator();

                foreach (var current in exceptions)
                {
                    errorMessages.Add(current.GetType().FullName);
                    errorMessages.Add(ReflectException(current));

                    if (current.StackTrace != null)
                    {
                        errorMessages.Add(current.StackTrace);
                    }
                }

                return errorMessages;
            }
        }

        /// <summary>
        /// Gets or sets the user message.
        /// </summary>
        /// <value>The user message.</value>
        public virtual string UserMessage { get; private set; }

        /// <summary>
        /// When overridden in a derived class, sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with information about the exception.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <PermissionSet>
        ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" />
        ///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="SerializationFormatter" />
        /// </PermissionSet>
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);

            info.AddValue(nameof(this.UserMessage), this.UserMessage);
        }

        /// <summary>
        /// Reflects the exception.
        /// </summary>
        /// <param name="ex">The ex.</param>
        /// <returns>System.String.</returns>
        private static string ReflectException(Exception ex)
        {
            var sb = new StringBuilder();

            foreach (var current in ex.GetType().GetRuntimeProperties())
            {
                object objectValue = null;

                try
                {
                    objectValue = RuntimeHelpers.GetObjectValue(current.GetValue(ex, null));
                }
                catch (SecurityException securityEx)
                {
                    Trace.WriteLine(securityEx);
                }

                if ((objectValue != null) && (objectValue.ToString() != objectValue.GetType().FullName))
                    sb.AppendLine(string.Format(CultureInfo.CurrentCulture, "{0}: {1}", new object[] { current.Name, RuntimeHelpers.GetObjectValue(current) }));
            }

            return sb.ToString();
        }
    }

}