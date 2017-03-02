// Copyright (c) David E. Keller. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

namespace Dkbe.CaptivePortal.Models.SonicOS
{
    using System.Xml.Serialization;

    /// <summary>
    /// Wrapper for session sync reply to SNWL <see cref="SessionStateSyncReply"/>.
    /// </summary>
    [XmlRoot("SonicWALLAccessGatewayParam")]
    public class SNWLSessionStateSyncReply
    {
        [XmlElement("SessionSync")]
        public SessionStateSyncReply SessionSync { get; set; }
    }

    /// <summary>
    /// Response model for session sync request <see cref="SNWLSessionSync"/>.
    /// </summary>
    public class SessionStateSyncReply
    {
        /// <summary>
        /// Response Code: Response Meaning
        /// 200 Sync successful
        /// 201 Sync failed
        /// 255 Internal error
        /// </summary>
        public int ResponseCode { get; set; }
    }


}
