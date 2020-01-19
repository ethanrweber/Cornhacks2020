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
            var x = GetAirVisualResultAsync("", "", "").Result;
            var y = GetEnergyConsumptionsResultsAsync("", "", "").Result;

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
        public async Task<string> GetEnergyConsumptionsResultsAsync(string city, string state, string country)
        {
            //testing
            city = "Lincoln";
            state = "Nebraska";
            country = "USA";

            if (string.IsNullOrWhiteSpace(city))
                throw new Exception("city is a required field");
                city = "city=" + city;
            if (!string.IsNullOrWhiteSpace(state))
            {
                string stateAbrev = "";
                if (Constants.states.ContainsKey(state.ToLower()))
                {
                    stateAbrev = Constants.states[state.ToLower()];
                }
                state = "&state_abbr=" + stateAbrev;
            }
            if (!string.IsNullOrWhiteSpace(country))
                country = "&country=" + country;

            using (var client = new HttpClient())
            {
                string addy = $"https://developer.nrel.gov/api/cleap/v1/energy_cohort_data?{city}{state}&api_key={Constants.energyConsumptionApiKey}";
                var response = client.GetStringAsync(new Uri(addy)).Result;
                string s = response.Substring(response.IndexOf("\"table\""));
                s = "{" + s.Substring(0, s.Length-3);
                var x = JsonConvert.DeserializeObject<EnergyConsumption>(s);
                return s;
            }
        }
    }
}