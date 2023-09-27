using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Moduls;

namespace WeatherApp.UI
{
    public class Presentation
    {
        public Weather Content { get; set; }

        public void DisplayWeatherInfo()
        {

            //Current weather forecast
            Console.WriteLine($"Location: {Content.Address}");
            Console.WriteLine($"Region: {Content.Timezone}");
            Console.WriteLine($"Description: {Content.Description}");
            Console.WriteLine($"Sunrise: {Content.Days[0].Sunrise}");
            Console.WriteLine($"Sunset: {Content.Days[0].Sunset}");
            Console.WriteLine($"Temperature: {Content.Days[0].Temp}°C");
            Console.WriteLine($"Max Temperature: {Content.Days[0].Tempmax}°C");
            Console.WriteLine($"Min Temperature: {Content.Days[0].Tempmin}°C");
            Console.WriteLine($"Humidity: {Content.Days[0].Humidity}%\n");
            Console.WriteLine("1:Get information about today's weather");
            Console.WriteLine("2:Get 14 days weather forecast");
            Console.WriteLine("3:Finish");
            var weatherday = int.Parse(Console.ReadLine());

            switch (weatherday)
            {
                case 1:
                    Console.WriteLine("Time                Temperature                Humidity");
                    foreach (var day in Content.Days[0].hours)
                    {
                        Console.WriteLine("---------------------------------------------------------------");
                        Console.WriteLine($"{day.datetime}       |        {(int)day.temp}°C         |          {day.humidity}%");
                    }
                    break;
                case 2:
                    Console.WriteLine("\r Date   \t\tMax Temperature  \t\t Min Temperature\t\t\t Humidity");
                    foreach (var day in Content.Days.Skip(1))
                    {
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine($"\r {day.Datetime} \t\t{(int)day.Tempmax}°C \t\t\t\t {(int)day.Tempmin}°C    \t\t\t\t {day.Humidity}%");
                    }
                    break;
                case 3:
                    Console.WriteLine("Thank you for using our information");
                    break;
            }
        }
    }
}
