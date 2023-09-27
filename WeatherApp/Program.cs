using Newtonsoft.Json;
using Project.Service.Services;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WeatherApp.Moduls;

namespace WeatherApp
{
    class Program
    {
        static async Task Main (string[] args)
        {
            try
            {
                var service = new Service(new HttpClient());
                Console.WriteLine("Enter location: ");
                string location = Console.ReadLine();
                await service.GetWeatherInfo(location);   
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");

            }
        }
    }
}
