using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Moduls
{
    public class Weather
    {
        public string Address { get; set; }
        public string Timezone { get; set; }
        public string Description { get; set; }
        public Day[] Days { get; set; }
    }
}
