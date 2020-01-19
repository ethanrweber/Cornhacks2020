using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CornhacksProject.Models
{
    public class Constants
    {
        public const string ApplicationName = "CityScore";

        public static readonly string googleMapsApiKey = "AIzaSyD_0RvglWdwS3ICkEjP9BzlmeherfKZv6Q";
        public static readonly string airVisualApiKey = "fb354654-e77f-4fc7-8fb0-5d7e30cfac70";
        public static readonly string energyConsumptionApiKey = "8aACX8BJAnC0n5iiUd0QtbXX7FcR5P63ujfPFMz5";
        public static readonly Dictionary<string, string> states = new Dictionary<string, string>()
        {
            { "alabama", "AL" },
            { "alaska", "AK" },
            { "arizona", "AZ" },
            { "arkansas", "AR" },
            { "california", "CA" },
            { "colorado", "CO" },
            { "connecticut", "CT" },
            { "delaware", "DE" },
            { "florida", "FL" },
            { "georgia", "GA" },
            { "hawaii", "HI" },
            { "idaho", "ID" },
            { "illinois", "IL" },
            { "indiana", "IN" },
            { "iowa", "IA" },
            { "kansas", "KS" },
            { "kentucky", "KY" },
            { "louisiana", "LA" },
            { "maine", "ME" },
            { "maryland", "MD" },
            { "massachusetts", "MA" },
            { "michigan", "MI" },
            { "minnesota", "MN" },
            { "mississippi", "MS" },
            { "missouri", "MO" },
            { "montana", "MT" },
            { "nebraska", "NE" },
            { "nevada", "NV" },
            { "new hampshire", "NH" },
            { "new jersey", "NJ" },
            { "new mexico", "NM" },
            { "new york", "NY" },
            { "north carolina", "NC" },
            { "north dakota", "ND" },
            { "ohio", "OH" },
            { "oklahoma", "OK" },
            { "oregon", "OR" },
            { "pennsylvania", "PA" },
            { "rhode island", "RI" },
            { "south carolina", "SC" },
            { "south dakota", "SD" },
            { "tennessee", "TN" },
            { "texas", "TX" },
            { "utah", "UT" },
            { "vermont", "VT" },
            { "virginia", "VA" },
            { "washington", "WA" },
            { "west virginia", "WV" },
            { "wisconsin", "WI" },
            { "wyoming", "WY" }
        };
    }
}