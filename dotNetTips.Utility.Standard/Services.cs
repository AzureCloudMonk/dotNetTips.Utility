﻿// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 06-26-2017
//
// Last Modified By : David McCarter
// Last Modified On : 07-05-2018
// ***********************************************************************
// <copyright file="Services.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using dotNetTips.Utility.Standard.OOP;
using dotNetTips.Utility.Standard.Properties;
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;

namespace dotNetTips.Utility.Standard
{
    /// <summary>
    /// Class Services.
    /// </summary>
    public static class Services
    {
        /// <summary>
        /// Loads the service.
        /// </summary>
        /// <param name="serviceName">Name of the service.</param>
        /// <returns>ServiceController.</returns>
        private static ServiceController LoadService(string serviceName) => ServiceController.GetServices()
            .FirstOrDefault(p => p.ServiceName == serviceName);

        /// <summary>
        /// Alls the services.
        /// </summary>
        /// <returns>IEnumerable&lt;System.String&gt;.</returns>
        public static IEnumerable<string> AllServices() => ServiceController.GetServices()
            .Select(p => p.ServiceName)
            .AsEnumerable();

        /// <summary>
        /// Services the exists.
        /// </summary>
        /// <param name="serviceName">Name of the service.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool ServiceExists(string serviceName)
        {
            var service = LoadService(serviceName);

            return service != null ? true : false;
        }

        /// <summary>
        /// Services the status.
        /// </summary>
        /// <param name="serviceName">Name of the service.</param>
        /// <returns>ServiceControllerStatus.</returns>
        /// <exception cref="InvalidOperationException">Service not found.</exception>
        public static ServiceControllerStatus ServiceStatus(string serviceName)
        {
            var service = LoadService(serviceName);

            return service != null ? service.Status : throw new InvalidOperationException(Resources.ServiceNotFound);
        }

        /// <summary>
        /// Starts the service.
        /// </summary>
        /// <param name="serviceName">Name of the service.</param>
        /// <returns>ServiceActionResult.</returns>
        public static ServiceActionResult StartService(string serviceName)
        {
            var statusResult = ServiceActionResult.Error;

            if(ServiceExists(serviceName) == false)
            {
                return ServiceActionResult.NotFound;
            }

            var service = LoadService(serviceName);

            if((service != null && service.Status == ServiceControllerStatus.Stopped))
            {
                service.Start();
                statusResult = ServiceActionResult.Running;
            }

            return statusResult;
        }

        /// <summary>
        /// Starts the services.
        /// </summary>
        /// <param name="requests">The requests.</param>
        public static void StartServices(IEnumerable<ServiceAction> requests)
        {
            Encapsulation.TryValidateParam(requests, nameof(requests));

            foreach(var request in requests)
            {
                request.ServiceActionResult = StartService(request.ServiceName);
            }
        }

        /// <summary>
        /// Starts the stop services.
        /// </summary>
        /// <param name="requests">The requests.</param>
        public static void StartStopServices(IEnumerable<ServiceAction> requests)
        {
            Encapsulation.TryValidateParam(requests, nameof(requests));

            foreach(var request in requests)
            {
                if(request.ServiceActionRequest == ServiceActionRequest.Start)
                {
                    request.ServiceActionResult = StartService(request.ServiceName);
                } else if(request.ServiceActionRequest == ServiceActionRequest.Stop)
                {
                    request.ServiceActionResult = StopService(request.ServiceName);
                }
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

            if(ServiceExists(serviceName) == false)
            {
                return statusResult;
            }

            var service = LoadService(serviceName);

            if((service != null && service.Status == ServiceControllerStatus.Running))
            {
                service.Stop();
                statusResult = ServiceActionResult.Stopped;
            }

            return statusResult;
        }

        /// <summary>
        /// Stops the services.
        /// </summary>
        /// <param name="requests">The requests.</param>
        public static void StopServices(IEnumerable<ServiceAction> requests)
        {
            Encapsulation.TryValidateParam(requests, nameof(requests));

            foreach(var request in requests)
            {
                request.ServiceActionResult = StopService(request.ServiceName);
            }
        }
    }
}
