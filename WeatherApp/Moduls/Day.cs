using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Moduls
{
    public class Day
    {
        public string Datetime { get; set; }
        public double Temp { get; set; }
        public double Tempmax { get; set; }
        public double Tempmin { get; set; }
        public double Humidity { get; set; }
        public string Sunrise { get; set; }
        public string Sunset { get; set; }
        public Hours[] hours { get; set; }
    }
}
