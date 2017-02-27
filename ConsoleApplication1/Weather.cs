using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Weather
    {
        public List<string> accurateWeather;
        public int dayCounter;
        Random forecastWeather;
        public List<string> weatherOfDay;
        public Weather()
        {
            accurateWeather = new List<string>();
            forecastWeather = new Random();
            weatherOfDay = new List<string>();
        }
        public void DetermineForecast()
        {
        }
        public void DetermineWeather()
        {
        }
    }
}
