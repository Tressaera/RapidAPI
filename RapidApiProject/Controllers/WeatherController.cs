using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiProject.Models;

namespace RapidApiProject.Controllers
{
    public class WeatherController : Controller
    {
        public async Task<IActionResult> Index(string city)
        {
            if (!string.IsNullOrEmpty(city))
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://yahoo-weather5.p.rapidapi.com/weather?location={city}&format=json&u=c"),
                    Headers =
    {
        { "X-RapidAPI-Key", "51fbf2c665mshdce8d8b72638de3p16d4ecjsnf297c9c1fd0b" },
        { "X-RapidAPI-Host", "yahoo-weather5.p.rapidapi.com" },
    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<WeatherViewModel>(body);
                    return View(values);
                }
            }
            else
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://yahoo-weather5.p.rapidapi.com/weather?location=bursa&format=json&u=c"),
                    Headers =
    {
        { "X-RapidAPI-Key", "51fbf2c665mshdce8d8b72638de3p16d4ecjsnf297c9c1fd0b" },
        { "X-RapidAPI-Host", "yahoo-weather5.p.rapidapi.com" },
    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<WeatherViewModel>(body);
                    return View(values);
                }
            }
        }
    }
}
