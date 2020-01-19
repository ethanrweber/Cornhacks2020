using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CornhacksProject.Models
{
    public class OperatorInfo
    {
        public string WebsiteURL { get; set; }
        public string Title { get; set; }

        public OperatorInfo(string websiteURL, string title)
        {
            WebsiteURL = websiteURL;
            Title = title;
        }
    }

    public class Country
    {
        public string ISOCode { get; set; }
        public string ContinentCode { get; set; }
        public int ID { get; set; }
        public string Title { get; set; }

        public Country(string iSOCode, string continentCode, int iD, string title)
        {
            ISOCode = iSOCode;
            ContinentCode = continentCode;
            ID = iD;
            Title = title;
        }
    }

    public class AddressInfo
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string AddressLine1 { get; set; }
        public object AddressLine2 { get; set; }
        public string Town { get; set; }
        public string StateOrProvince { get; set; }
        public string Postcode { get; set; }
        public int CountryID { get; set; }
        public Country Country { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public object Distance { get; set; }
        public int DistanceUnit { get; set; }

        public AddressInfo(int iD, string title, string addressLine1, object addressLine2, string town, string stateOrProvince, string postcode, int countryID, Country country, double latitude, double longitude, object distance, int distanceUnit)
        {
            ID = iD;
            Title = title;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            Town = town;
            StateOrProvince = stateOrProvince;
            Postcode = postcode;
            CountryID = countryID;
            Country = country;
            Latitude = latitude;
            Longitude = longitude;
            Distance = distance;
            DistanceUnit = distanceUnit;
        }
    }

    public class OpenChargeResult
    {
        public OperatorInfo OperatorInfo { get; set; }
        public AddressInfo AddressInfo { get; set; }
        public int NumberOfPoints { get; set; }
        public string GeneralComments { get; set; }

        public OpenChargeResult(OperatorInfo operatorInfo, AddressInfo addressInfo, int numberOfPoints, string generalComments)
        {
            OperatorInfo = operatorInfo;
            AddressInfo = addressInfo;
            NumberOfPoints = numberOfPoints;
            GeneralComments = generalComments;
        }
    }
}
