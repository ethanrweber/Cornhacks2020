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
            var z = SustainabilityScore("Lincoln", "Nebraska", "USA");
            return View();
        }

        public ActionResult References()
        {
            return View();
        }

        public async Task<AirVisualResult> GetAirVisualResultAsync(string city, string state, string country)
        {
            //testing
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
                return x;
            }
        }

        public async Task<List<OpenChargeResult>> GetOpenChargeResultAsync(double latitude, double longitude, double distance = 20, string distanceUnit = "Miles")
        {
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

        public async Task<EnergyConsumption> GetEnergyConsumptionsResultsAsync(string city, string state, string country)
        {
            //testing
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
                return x;
            }
        }

        public async Task<CityPopulation> GetPopulationAsync(string city, string state, string country)
        {
            //testing
            string query = "";
            if (string.IsNullOrWhiteSpace(city))
                throw new Exception("city is a required field");
            query = "q=" + city;
            if (!string.IsNullOrWhiteSpace(state))
            {
                string stateAbrev = "";
                if (Constants.states.ContainsKey(state.ToLower()))
                {
                    stateAbrev = Constants.states[state.ToLower()];
                }
                query = query + " " + stateAbrev + "&";
            }
            if (!string.IsNullOrWhiteSpace(country))
                country = "&country=" + country;

            using (var client = new HttpClient())
            {
                string addy = $"https://public.opendatasoft.com/api/records/1.0/search/?dataset=worldcitiespop&{query}rows=1&sort=population&facet=country&refine.country=us";
                var response = client.GetStringAsync(new Uri(addy)).Result;
                var x = JsonConvert.DeserializeObject<CityPopulation>(response);
                return x;
            }
        }

        public double SustainabilityScore(string city, string state, string country)
        {
            var p = GetPopulationAsync(city, state, country).Result;
            List<double> coordinates = p.records[0].geometry.coordinates;
            var z = GetOpenChargeResultAsync(coordinates[1], coordinates[0]).Result;
            int numEVStations = GetNumEVStations(z, city);

            int population = p.records.FirstOrDefault().fields.population;


            var energyStats = GetEnergyConsumptionsResultsAsync(city, state, country).Result;
            int industrialGasUse = energyStats.table.industrial_gas_use.avg;
            int industrialElectricUse = energyStats.table.industrial_electric_use.avg;
            int commercialGasUse = energyStats.table.commercial_gas_use.avg;
            int commercialElectricUse = energyStats.table.commercial_electric_use.avg;
            int residentialGasUse = energyStats.table.residential_gas_use.avg;
            int residentialElectricUse = energyStats.table.residential_electric_use.avg;
            int cityGasUse = energyStats.table.city_fuel_use_gas.avg;

            var airResult = GetAirVisualResultAsync(city, state, country).Result;
            //the lower, the better:
            int airQuality = airResult.data.current.pollution.aqius;

            double energyScore = (double) (industrialElectricUse + industrialGasUse + commercialGasUse + commercialElectricUse + residentialElectricUse + residentialGasUse + cityGasUse) / population;
            double airScore = (double) airQuality / population;

            //TODO: figure out a better system for scores
            var finalScore = energyScore * 0.25 + airQuality * 0.75;

            return finalScore;
        }
    }
}