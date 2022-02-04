﻿using System.Runtime.Serialization;
using GogoKit.Models.Response;

namespace GogoKit.Models.Request
{
    [DataContract]
    public class NewRequestedEventSellerListing : NewSellerListing
    {
        [DataMember(Name = "notes")]
        public string Notes { get; set; }

        [DataMember(Name = "event")]
        public EmbeddedEvent Event { get; set; }

        [DataMember(Name = "venue")]
        public EmbeddedVenue Venue { get; set; }

        [DataMember(Name = "country")]
        public Country Country { get; set; }
        
        [DataMember(Name = "external_event_information")]
        public SellerListingExternalEventInformation[] ExternalEventInformation { get; set; }
    }
}
