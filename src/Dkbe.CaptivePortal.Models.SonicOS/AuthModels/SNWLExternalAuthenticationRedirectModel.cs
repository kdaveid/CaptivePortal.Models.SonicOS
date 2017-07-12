﻿// Copyright (c) David E. Keller. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

namespace Dkbe.CaptivePortal.Models.SonicOS
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Model of HTTP GET redirect from SNWL. This model can be used to parse SNWL request.
    /// </summary>
    public class SNWLExternalAuthenticationRedirectModel
    {
        /// <summary>
        /// MAC address of device. Required by SonicOS.
        /// </summary>
        [Required]
        public string MAC { get; set; }

        /// <summary>
        /// IP address of device. Required by SonicOS.
        /// </summary>
        [Required]
        public string IP { get; set; }

        /// <summary>
        /// SNWL generated session id. Required by SonicOS. 
        /// Spec: A 32 byte hex representation of a 16 byte MD5 hash value generated by the SonicWALL,
        /// which will be used by the SonicWALL and the WS for indexing clients(e.g.
        /// "11aa3e2f5da3e12ef978ba120d2300ff").
        /// </summary>
        [Required]
        public string SessionId { get; set; }

        /// <summary>
        /// SSID if user is connected via SonicPoint.
        /// Spec: The ESSID (wireless network name) of the wireless network to which the redirected client was associated
        /// </summary>
        public string SSID { get; set; }

        /// <summary>
        /// The SonicWALL Unique Firewall Identifier. To be used for site identification, if desired.
        /// </summary>
        public string Ufi { get; set; }

        /// <summary>
        /// The protocol, IP address, and port on the SonicWALL with which the IP will subsequently communicate.
        /// </summary>
        public string MgmtBaseUrl { get; set; }

        /// <summary>
        /// The protocol, IP address (and optionally port) on the SonicWALL that the ABE will use for client redirection.
        /// </summary>
        public string ClientRedirectUrl { get; set; }

        /// <summary>
        /// Prettyfied property of <see cref="req"/>
        /// </summary>
        public string ClientRequestedUrl { get { return req; } }

        /// <summary>
        /// The originally requested web-site is passed as an argument to the authentication server)
        /// </summary>
        public string req { get; set; }

    }
}
