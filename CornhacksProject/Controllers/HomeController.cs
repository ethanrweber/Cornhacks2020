using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using CornhacksProject.Models;
using Newtonsoft.Json;

namespace CornhacksProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            var x = GetOpenChargeResultAsync(0, 0).Result;
            int i = GetNumEVStations(x, "Lincoln");
            return View();
        }

        public async Task<string> GetAirVisualResultAsync(string city, string state, string country)
        {
            //testing
            city = "Lincoln";
            state = "Nebraska";
            country = "USA";

            if(string.IsNullOrWhiteSpace(city))
                throw new Exception("city is a required field");
            city = "city=" + city;
            if (!string.IsNullOrWhiteSpace(state))
                state = "&state=" + state;
            if (!string.IsNullOrWhiteSpace(country))
                country = "&country=" + country;

            using (var client = new HttpClient())
            {
                string addy = $"https://api.airvisual.com/v2/city?{city}{state}{country}&key={Constants.airVisualApiKey}";
                var response = client.GetStringAsync(new Uri(addy)).Result;
                var x = JsonConvert.DeserializeObject<AirVisualResult>(response);
                return response;
            }
        }

        public async Task<List<OpenChargeResult>> GetOpenChargeResultAsync(double latitude, double longitude, double distance = 20, string distanceUnit = "Miles")
        {
            //testing
            latitude = 40.8136;
            longitude = -96.7026;

            using (var client = new HttpClient())
            {
                string addy = $"https://api.openchargemap.io/v3/poi/?output=json&compact=true&verbose=false&countrycode=US&latitude={latitude}&longitude={longitude}&distance={distance}&distanceunit={distanceUnit}";
                var response = client.GetStringAsync(new Uri(addy)).Result;
                var x = JsonConvert.DeserializeObject<List<OpenChargeResult>>(response);
                
                return x;
            }
        }

        public int GetNumEVStations(List<OpenChargeResult> list, string city)
        {
            int numStations = 0;
            foreach (var v in list)
            {
                if (v.AddressInfo.Town == city)
                {
                    numStations++;
                }
            }

            return numStations;
        }
    }
}