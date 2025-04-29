using System;
using System.Collections.Generic;

namespace Shared
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        public string Summary { get; set; }

        public static List<WeatherForecast> GenerateRandomForecasts(int count)
        {
            var rng = new Random();
            var forecasts = new List<WeatherForecast>();

            for (int i = 0; i < count; i++)
            {
                forecasts.Add(new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(i),
                    TemperatureC = rng.Next(-20, 55),
                    Summary = Summaries[rng.Next(Summaries.Length)]
                });
            }

            return forecasts;
        }

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public static List<WeatherForecast> GetForecasts()
        {
            return GenerateRandomForecasts(5);
        }
    }
}
