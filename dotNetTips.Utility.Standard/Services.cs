﻿// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 06-26-2017
//
// Last Modified By : David McCarter
// Last Modified On : 07-21-2017
// ***********************************************************************
// <copyright file="Services.cs" company="dotNetTips.com - David McCarter">
//     dotNetTips.com - David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using dotNetTips.Utility.Standard.OOP;

namespace dotNetTips.Utility.Standard
{
    /// <summary>
    /// Class Services.
    /// </summary>
    public static class Services
    {
        //TODO: BLOG POST
        /// <summary>
        /// Services the status.
        /// </summary>
        /// <param name="serviceName">Name of the service.</param>
        /// <returns>ServiceControllerStatus.</returns>
        /// <exception cref="InvalidOperationException">Service not found.</exception>
        public static ServiceControllerStatus ServiceStatus(string serviceName)
        {
            var service = LoadService(serviceName);

            if (service != null)
            {
                return service.Status;
            }
            else
            {
                throw new InvalidOperationException("Service not found.");
            }
        }

        /// <summary>
        /// Services the exists.
        /// </summary>
        /// <param name="serviceName">Name of the service.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool ServiceExists(string serviceName)
        {
            var service = LoadService(serviceName);

            if (service != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Stops the service.
        /// </summary>
        /// <param name="serviceName">Name of the service.</param>
        /// <returns>ServiceActionResult.</returns>
        public static ServiceActionResult StopService(string serviceName)
        {
            var statusResult = ServiceActionResult.NotFound;

            if (ServiceExists(serviceName) == false)
            {
                return statusResult;
            }

            var service = LoadService(serviceName);

            if ((service != null && service.Status == ServiceControllerStatus.Running))
            {
                service.Stop();
                statusResult = ServiceActionResult.Stopped;
            }

            return statusResult;
        }

        /// <summary>
        /// Starts the service.
        /// </summary>
        /// <param name="serviceName">Name of the service.</param>
        /// <returns>ServiceActionResult.</returns>
        public static ServiceActionResult StartService(string serviceName)
        {
            var statusResult = ServiceActionResult.NotFound;

            if (ServiceExists(serviceName) == false)
            {
                return statusResult;
            }

            var service = LoadService(serviceName);

            if ((service != null && service.Status == ServiceControllerStatus.Stopped))
            {
                service.Start();
                statusResult = ServiceActionResult.Running;
            }

            return statusResult;
        }

        /// <summary>
        /// Alls the services.
        /// </summary>
        /// <returns>IEnumerable&lt;System.String&gt;.</returns>
        public static IEnumerable<string> AllServices()
        {
            return ServiceController.GetServices().Select(p => p.ServiceName).AsEnumerable();
        }

        /// <summary>
        /// Loads the service.
        /// </summary>
        /// <param name="serviceName">Name of the service.</param>
        /// <returns>ServiceController.</returns>
        private static ServiceController LoadService(string serviceName)
        {
            return ServiceController.GetServices().Where(p => p.ServiceName == serviceName).FirstOrDefault();
        }

        /// <summary>
        /// Starts the stop services.
        /// </summary>
        /// <param name="requests">The requests.</param>
        public static void StartStopServices(IEnumerable<ServiceAction> requests)
        {
            Encapsulation.TryValidateParam(requests, nameof(requests));

            foreach (var request in requests)
            {
                if (request.ServiceActionRequest == ServiceActionRequest.Start)
                {
                    request.ServiceActionResult = StartService(request.ServiceName);
                }
                else if (request.ServiceActionRequest == ServiceActionRequest.Stop)
                {
                    request.ServiceActionResult = StopService(request.ServiceName);
                }
            }
        }
    }
}
