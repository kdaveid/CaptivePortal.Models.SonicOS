// Copyright (c) David E. Keller. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

namespace Dkbe.CaptivePortal.Models.SonicOS
{
    using System.Xml.Serialization;

    /// <summary>
    /// XML wrapper class for <see cref="SNWLExternalAuthenticationReply"/>. Used at sign in endpoint in CaptivePortal.
    /// </summary>
#if NET462
    [Serializable]
#endif
    [XmlRoot("SonicWALLAccessGatewayParam")]
    [XmlType(AnonymousType = true, Namespace = "")]
    public class SNWLExternalAuthenticationXMLResponse
    {
        public SNWLExternalAuthenticationReply AuthenticationReply { get; set; }
    }


    /// <summary>
    /// Reponse model for SNWL reponse message. Used in sign in (external auth) request.
    /// </summary>
#if NET462
    [Serializable]
#endif
    [XmlType(AnonymousType = true)]
    public class SNWLExternalAuthenticationReply
    {
        /// <summary>
        /// 50  Login succeeded
        /// 51  Session limit exceeded
        /// 100 Login failed -- access reject
        /// 251 Msg. Auth failed -- Invalid HMAC
        /// 253 Invalid session ID
        /// 254 Invalid or missing CGI parameter
        /// 255 Internal error
        /// </summary>
        public int ResponseCode { get; set; }

        /// <summary>
        /// Repsonse message with detailed information.
        /// </summary>
        public string ReplyMessage { get; set; }

        /// <summary>
        /// Indicator of authentication success.
        /// </summary>
        public bool Succeeded { get { return ResponseCode == 50; } }
    }
}



