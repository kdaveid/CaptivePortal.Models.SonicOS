// Copyright (c) David E. Keller. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

namespace Dkbe.CaptivePortal.Models.SonicOS
{
    using System.Xml.Serialization;

    /// <summary>
    /// Wrapper for XML model for SNWL logoff response <see cref="LogoffReply"/>. See <seealso cref="SNWLLogoffRequest"/> for request model.
    /// </summary>
#if NET462
    [Serializable]
#endif
    [XmlRoot("SonicWALLAccessGatewayParam")]
    [XmlType(AnonymousType = true, Namespace = "")]
    public class SNWLLogoffReplyXMLResponse
    {
        public SNWLLogoffReply LogoffReply { get; set; }
    }

    /// <summary>
    /// Reply model for logoff request as created by SNWL.
    /// </summary>
#if NET462
    [Serializable]
#endif
    [XmlType(AnonymousType = true)]
    public class SNWLLogoffReply
    {
        /// <summary>
        /// 150     Logoff succeeded
        /// 251     Msg. Auth failed -- Invalid HMAC
        /// 253     Invalid session ID
        /// 254     Invalid or missing CGI parameter
        /// 255     Internal error
        /// </summary>
        public int ResponseCode { get; set; }

        /// <summary>
        /// Repsonse message with detailed information.
        /// </summary>
        public string ReplyMessage { get; set; }

        /// <summary>
        /// Indicator of session logoff success.
        /// </summary>
        public bool Succeeded { get { return ResponseCode == 150; } }
    }

}
