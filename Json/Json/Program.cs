using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Console;

namespace Json
{
    // <wf>
    public class WeatherForecast
    {
        public DateTimeOffset Date { get; set; }
        public int TemperatureCelsius { get; set; }
        public string Summary { get; set; }
    }
    // </wf>

    public class Program
    {
        public static void Main()
        {
            var weatherForecast = new weatherForecast
            {
                Date = DateTime.Parse("2019-08-01"),
                TemperatureCelsius = 25,
                Summary = "Hot"
            };
            var weatherForecast1 = new weatherForecast
            {
                Date = DateTime.Parse("2019-08-02"),
                TemperatureCelsius = 0,
                Summary = "Cold"
            };

            string jsonString = JsonSerializer.Serialize(weatherForecast);
            string jsonString1 = JsonSerializer.Serialize(weatherForecast1);

            WriteLine(jsonString);
            WriteLine(jsonString1);

            weatherForecast w = JsonSerializer.Deserialize<weatherForecast>(jsonString1);
            ReadKey();
        }
    }
}
