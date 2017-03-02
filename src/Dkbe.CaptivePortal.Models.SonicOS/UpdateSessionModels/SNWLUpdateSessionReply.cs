// Copyright (c) David E. Keller. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

namespace Dkbe.CaptivePortal.Models.SonicOS
{
    using System.Xml.Serialization;

    /// <summary>
    /// Wrapper class for XML response from SNWL <see cref="UpdateSessionReply"/> upon update session request. 
    /// For request use <seealso cref="SNWLUpdateSessionRequest"/>.
    /// </summary>
#if NET462
    [Serializable]
#endif
    [XmlRoot("SonicWALLAccessGatewayParam")]
    [XmlType(AnonymousType = true, Namespace = "")]
    public class SNWLUpdateSessionReplyXMLResponse
    {
        public UpdateSessionReply UpdateSessionReply { get; set; }
    }

    /// <summary>
    /// Response model for update session request.
    /// </summary>
#if NET462
    [Serializable]
#endif
    [XmlType(AnonymousType = true)]
    public class UpdateSessionReply
    {
        /// <summary>
        /// 210     Session Update succeeded
        /// 211     Session Update failed
        /// 251     Msg. Auth failed -- Invalid HMAC
        /// 254     Invalid or missing CGI parameter
        /// 255     Internal error
        /// </summary>
        public int ResponseCode { get; set;}

        /// <summary>
        /// Repsonse message with detailed information.
        /// </summary>
        public string ReplyMessage { get; set; }

        /// <summary>
        /// Indicator of update session success.
        /// </summary>
        public bool Succeeded { get { return ResponseCode == 210; } }
    }



}
