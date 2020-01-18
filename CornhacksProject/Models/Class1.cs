//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace CornhacksProject.Models
//{
//    using System;
//    using System.Collections.Generic;
//    using System.Net;
//    using System.Net.Http;
//    using System.Net.Http.Headers;
//    using System.Threading.Tasks;
//    using Newtonsoft.Json;
//    using CornhacksProject.Models;

//    namespace CornhacksProject.API
//    {
//        public class AirVisual
//        {
//            public static async Task<string> GetResult(string city, string state)
//            {
//                string baseUrl = "api.airvisual.com/v2/city?";
//                string newCity = "city=" + city;
//                string newState = "&state=" + state;
//                string country = "&country=USA";
//                string key = "&key=" + apiKey;
//                string url = baseUrl + newCity + newState + country + key;
//                using (var client = new HttpClient())
//                {
//                    client.BaseAddress = new Uri(url);

//                    HttpResponseMessage response = await client.GetAsync(url);

//                    if (response.IsSuccessStatusCode)
//                    {
//                        string strResult = await response.Content.ReadAsStringAsync();

//                        return strResult;
//                    }

//                    return null;
//                }
//            }

//            public static AirVisualResult ResultToParsedJson(string city, string state)
//            {
//                var result = GetResult(city, state).Result;
//                AirVisualResult av = JsonConvert.DeserializeObject<AirVisualResult>(result);
//                return av;
//            }
//        }
//    }
//}