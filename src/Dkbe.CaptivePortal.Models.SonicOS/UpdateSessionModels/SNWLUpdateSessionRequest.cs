// Copyright (c) David E. Keller. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

namespace Dkbe.CaptivePortal.Models.SonicOS
{
    using System.Collections.Generic;

    /// <summary>
    /// Request model for update client session. Used in HTTP POST request to SNWL.
    /// Note: Parameters are case sensitive to SNWL.
    /// </summary>
    public class SNWLUpdateSessionRequest
    {
        /// <summary>
        /// Session id of client. Required by SonicOS.
        /// </summary>
        public string sessID { get; set; }

        /// <summary>
        /// User name of client. Required by SonicOS.
        /// </summary>
        public string userName { get; set; }

        /// <summary>
        /// New session life time for client in seconds. Required by SonicOS.
        /// </summary>
        public long sessionLifetime { get; set; }

        /// <summary>
        /// Optional idle timeout in seconds.
        /// </summary>
        public long idleTimeout { get; set; }

        public KeyValuePair<string, string>[] GetValues()
        {
            return new[] {
                new KeyValuePair<string, string>(nameof(sessID), sessID),
                new KeyValuePair<string, string>(nameof(userName), userName),
                new KeyValuePair<string, string>(nameof(sessionLifetime), sessionLifetime.ToString()),
                new KeyValuePair<string, string>(nameof(idleTimeout), idleTimeout.ToString())
                };
        }
    }
}
