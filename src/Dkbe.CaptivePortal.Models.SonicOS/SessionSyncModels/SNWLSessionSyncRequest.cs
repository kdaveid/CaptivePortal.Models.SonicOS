// Copyright (c) David E. Keller. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

namespace Dkbe.CaptivePortal.Models.SonicOS
{
    using System.Xml.Serialization;

    /// <summary>
    /// Wrapper class for XML deserialization of session sync request <see cref="SNWLSessionSync"/> invoked by SNWL.
    /// </summary>
    [XmlType("SonicWALLAccessGatewayParam")]
    public class SNWLSessionSyncRequest
    {
        [XmlElement("SessionSync")]
        public SNWLSessionSync SessionSync { get; set; }
    }

    /// <summary>
    /// Session sync model as created by SNWL.
    /// </summary>
    [XmlType("SessionSync")]
    public class SNWLSessionSync
    {
        public int SessionCount { get; set; }

        public SNWLSession[] SessionList { get; set; }
    }

    /// <summary>
    /// Session model of session sync request <see cref="SNWLSessionSync"/> .
    /// </summary>
    [XmlType("Session")]
    public class SNWLSession
    {
        public string Ssid { get; set; }

        public string ID { get; set; }

        public string UserName { get; set; }

        public string IP { get; set; }

        public string MAC { get; set; }

        public long Idle { get; set; }

        public long SessionRemaining { get; set; }

        public string BaseMgmtUrl { get; set; }

        public long RxBytes { get; set; }

        public long TxBytes { get; set; }
    }
}
