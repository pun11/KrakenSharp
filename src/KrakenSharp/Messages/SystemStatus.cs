﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace KrakenSharp.Messages
{
    /// <summary>
    /// System status.
    /// </summary>
    public class SystemStatusResponse : KrakenMessage
    {
        /// <summary>
        /// The name of the event.
        /// </summary>
        public const string EventName = "systemStatus";

        public SystemStatusResponse() : base(EventName)
        { }

        [JsonProperty("connectionID")]
        public decimal ConnectionId { get; internal set; }

        [JsonProperty("status")]
        public string Status { get; internal set; }

        [JsonProperty("version")]
        public string Version { get; internal set; }
    }
}
