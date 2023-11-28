using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WeatherApp.Models;
namespace WeatherApp.Services
{
    public static class ApiService 
    {
        public static async Task<Root>GetWeather(double latitude, double longitude)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(string.Format("https://api.openweathermap.org/data/2.5/forecast?lat={0}&lon={1}&units=metric&lang=zh_tw&appid=e9e42de887e574d902c60e17917046d1"));
            return JsonConvert.DeserializeObject<Root>(response);
        }
        public static async Task<Root> GetWeatherByCity(string city)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(string.Format("https://api.openweathermap.org/data/2.5/forecast?q={0}&units=metric&lang=zh_tw&appid=e9e42de887e574d902c60e17917046d1"));
            return JsonConvert.DeserializeObject<Root>(response);
        }
    }
}

