// Copyright (c) David E. Keller. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

namespace Dkbe.CaptivePortal.Models.SonicOS
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Auth request model for HTTP POST external auth model to SNWL.
    /// Response type will be <see cref="SNWLExternalAuthenticationReply"/>. Use XML wrapper class <seealso cref="SNWLExternalAuthenticationXMLResponse"/>.
    /// Note: Parameters are case sensitive to SNWL.
    /// </summary>
    public class SNWLExternalAuthenticationRequest
    {
        public SNWLExternalAuthenticationRequest() { }

        /// <summary>
        /// Creates a request model with all possible parameters. 
        /// </summary>
        /// <param name="SessionId">Required.</param>
        /// <param name="UserName">Required.</param>
        /// <param name="SessionLifeTime">Optional. If obmitted, user has unlimited session.</param>
        /// <param name="IdleTimeout">Optional.</param>
        public SNWLExternalAuthenticationRequest(string SessionId, string UserName, long SessionLifeTime, int IdleTimeout)
        {
            if (string.IsNullOrEmpty(SessionId)) throw new ArgumentNullException(nameof(SessionId));
            if (string.IsNullOrEmpty(UserName)) throw new ArgumentNullException(nameof(UserName));

            this.sessId = SessionId;
            this.userName = UserName;
            this.sessionLifetime = SessionLifeTime;
            this.idleTimeout = IdleTimeout;
        }

        /// <summary>
        /// Required by SonicOS.
        /// </summary>
        public string sessId { get; set; }

        /// <summary>
        /// Required by SonicOS.
        /// </summary>
        public string userName { get; set; }

        /// <summary>
        /// Optional parameter. If obmitted, user has unlimited session.
        /// </summary>
        public long sessionLifetime { get; set; }

        /// <summary>
        /// Optional parameter.
        /// </summary>
        public int idleTimeout { get; set; }

        public KeyValuePair<string, string>[] GetValues()
        {
            return new[] {
                new KeyValuePair<string, string>(nameof(sessId), sessId),
                new KeyValuePair<string, string>(nameof(userName), userName),
                new KeyValuePair<string, string>(nameof(sessionLifetime), sessionLifetime.ToString()),
                new KeyValuePair<string, string>(nameof(idleTimeout), idleTimeout.ToString())
                };
        }
    }
}
