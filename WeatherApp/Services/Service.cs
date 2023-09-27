using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp;
using WeatherApp.Moduls;
using WeatherApp.UI;

namespace Project.Service.Services
{
    public class Service
    {
        private readonly HttpClient _client;

        public Service(HttpClient client)
        {
            _client = client;
        }

        public async Task GetWeatherInfo(string location)
        {

            var response = await _client.GetAsync($"https://weather.visualcrossing.com/VisualCrossingWebServices/rest/services/timeline/{location}?unitGroup=metric&key=HKWGXUSMCCB577BPVYRJP9F9H&contentType=json");
            if (response.IsSuccessStatusCode)
            {
                var str = await response.Content.ReadAsStringAsync();
                var content = JsonConvert.DeserializeObject<Weather>(str);
                new Presentation { Content = content }.DisplayWeatherInfo();
            }
            else
            {
                Console.WriteLine($"An error occurred: {response.StatusCode}");
                Console.WriteLine("Not found");
            }
        }
    }
}