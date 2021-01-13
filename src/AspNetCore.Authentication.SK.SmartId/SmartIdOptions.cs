using System.Collections.Generic;
using AspNetCore.Authentication.SK.SmartId.SmartId;
using Microsoft.AspNetCore.Authentication;

namespace AspNetCore.Authentication.SK.SmartId
{
    public class SmartIdOptions : AuthenticationSchemeOptions
    {
        // ReSharper disable once InconsistentNaming
        public string RelyingPartyUUID { get; private set; }

        public string RelyingPartyName { get; private set; }

        public string HostUrl { get; private set; } = SmartIdDefaults.LiveHostUrl;

        public List<AllowedInteraction> AllowedInteractions { get; } = new List<AllowedInteraction>();

        public SmartIdOptions UseDemo()
        {
            RelyingPartyUUID = SmartIdDefaults.DemoRelyingPartyUuid;
            RelyingPartyName = SmartIdDefaults.DemoRelyingPartyName;
            HostUrl = SmartIdDefaults.DemoHostUrl;

            return this;
        }
    }
}