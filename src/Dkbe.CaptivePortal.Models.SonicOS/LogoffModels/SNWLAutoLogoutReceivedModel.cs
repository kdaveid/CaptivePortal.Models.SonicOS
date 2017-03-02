// Copyright (c) David E. Keller. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

namespace Dkbe.CaptivePortal.Models.SonicOS
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    /// <summary>
    /// Auto logout model for serialization of SNWL invoked HTTP POST logout request.
    /// </summary>
#if NET462
    [Serializable]
#endif
    [XmlRoot("SonicWALLAccessGatewayParam")]
    [XmlType(AnonymousType = true, Namespace = "")]
    public class SNWLAutoLogoutReceivedModel
    {
        /// <summary>
        /// WLAN SSID if user is connected via SonicPoint
        /// </summary>
        public string ssid { get; set;}

        /// <summary>
        /// SNWL generated session id
        /// </summary>
        public string sessId { get; set; }

        /// <summary>
        /// Event type. Possible values <see cref="SNWLLogoffRequest"/>
        /// </summary>
        public int eventId { get; set; }

        /// <summary>
        /// SNWL sends final received bytes of session
        /// </summary>
        public int rxBytes { get; set; }


        /// <summary>
        /// SNWL sends final transmitted bytes of session
        /// </summary>
        public int txBytes { get; set; }

        /// <summary>
        /// Get KeyValuePairs of properties to build x-www-form-encoded requests. Used by MockServer.
        /// </summary>
        /// <returns></returns>
        public KeyValuePair<string, string>[] GetValues()
        {
            return new[] {
                new KeyValuePair<string, string>(nameof(sessId), sessId),
                new KeyValuePair<string, string>(nameof(ssid), ssid),
                new KeyValuePair<string, string>(nameof(eventId), eventId.ToString())
                };
        }

        public override string ToString()
        {
            return $"SessionId: {this.sessId}, EventId: {this.eventId}, SSID: {this.ssid}, RxBytes: {this.rxBytes}, TxBytes: {this.txBytes}";
        }
    }
}
