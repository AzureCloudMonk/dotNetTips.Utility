﻿// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 06-26-2017
//
// Last Modified By : David McCarter
// Last Modified On : 08-06-2017
// ***********************************************************************
// <copyright file="InMemoryCache.cs" company="dotNetTips.com - David McCarter">
//     dotNetTips.com - David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************
using Microsoft.Extensions.Caching.Memory;
using System;

namespace dotNetTips.Utility.Standard.Cache
{

    /// <summary>
    /// Class InMemoryCache.
    /// </summary>
    public class InMemoryCache : ISingleton<InMemoryCache>, IDisposable
    {
        /// <summary>
        /// The cache
        /// </summary>
        private MemoryCache _cache;
        /// <summary>
        /// The instance
        /// </summary>
        private InMemoryCache _instance;

        /// <summary>
        /// Returns the instance.
        /// </summary>
        /// <returns>T.</returns>
        public InMemoryCache Instance()
        {
            if (this._instance == null)
            {
                this._instance = new InMemoryCache();
            }

            return this._instance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InMemoryCache" /> class.
        /// </summary>
        protected InMemoryCache()
        {
            var options = new MemoryCacheOptions() { CompactOnMemoryPressure = true, ExpirationScanFrequency = new System.TimeSpan(0, 5, 0) };
            
            this._cache = new MemoryCache(options);
        }

        /// <summary>
        /// Gets the or create.
        /// </summary>
        /// <param name="key">The key.</param>
        public void GetOrCreate(string key)
        {
            //TODO: NEED TO FIGURE THIS OUT
            //_cache.GetOrCreate(key, new Func<ICacheEntry, TItem>() {  })
        }

        #region IDisposable Implementation

        protected bool disposed;

        protected virtual void Dispose(bool disposing)
        {
            lock (this)
            {
                // Do nothing if the object has already been disposed of.
                if (disposed)
                    return;

                if (disposing)
                {
                    // Release disposable objects used by this instance here.

                    if (_cache != null)
                        _cache.Dispose();
                    if (_instance != null)
                        _instance.Dispose();
                }

                // Release unmanaged resources here. Don't access reference type fields.

                // Remember that the object has been disposed of.
                disposed = true;
            }
        }

        public virtual void Dispose()
        {
            Dispose(true);
            // Unregister object for finalization.
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
