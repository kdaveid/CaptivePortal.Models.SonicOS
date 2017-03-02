// Copyright (c) David E. Keller. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

namespace Dkbe.CaptivePortal.Models.SonicOS
{
    using System.Collections.Generic;

    /// <summary>
    /// Requests a logoff. Important: SNWL is very sensitive in property capitalization. Leave sessId
    /// </summary>
    public class SNWLLogoffRequest
    {
        /// <summary>
        /// SNWL session id of client. Required by SonicOS.
        /// </summary>
        public string sessId { get; set; }

        /// <summary>
        /// Logoff type. Required by SonicOS.
        /// 1 Guest logged out manually
        /// 2 Admin logged off the specified guest
        /// 3 Guest session expired
        /// 4 Guest idle timeout expired
        /// </summary>
        public int eventId { get; set; }

        public KeyValuePair<string, string>[] GetValues()
        {
            return new[] {
                new KeyValuePair<string, string>(nameof(sessId), sessId),
                new KeyValuePair<string, string>(nameof(eventId), eventId.ToString())
                };
        }
    }
}
