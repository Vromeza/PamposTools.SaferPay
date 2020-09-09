using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PamposTools.SaferPay.Models
{
    public class SaferPaySettings
    {
        [JsonProperty("baseUri")]
        public Uri BaseUri { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("customerId")]
        public string CustomerId { get; set; }

        [JsonProperty("terminalId")]
        public string TerminalId { get; set; }
    }
}
