//==============================================================================
//
//  This file was auto-generated by a tool using the PayPal REST API schema.
//  More information: https://developer.paypal.com/docs/api/
//
//==============================================================================
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PayPal.Api
{
    public class WebhookList : PayPalSerializableObject
    {
        /// <summary>
        /// A list of Webhooks
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "webhooks")]
        public List<Webhook> webhooks { get; set; }
    }
}
