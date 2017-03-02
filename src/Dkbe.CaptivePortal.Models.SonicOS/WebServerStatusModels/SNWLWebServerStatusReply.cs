// Copyright (c) David E. Keller. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

namespace Dkbe.CaptivePortal.Models.SonicOS
{
    using System.Xml.Serialization;

    /// <summary>
    /// XML wrapper model to use as response to SNWL invoked web server status check.
    /// </summary>
#if NET462
    [Serializable]
#endif
    [XmlRoot("SonicWALLAccessGatewayParam")]
    [XmlType(AnonymousType = true, Namespace = "")]
    public class SNWLWebServerStatusReply
    {
        /// <summary>
        /// 0   Server Up
        /// 1   DB down
        /// 2   Configuration error
        /// 255 Internal error
        /// </summary>
        public int ServerStatus { get; set; }
    }
}
