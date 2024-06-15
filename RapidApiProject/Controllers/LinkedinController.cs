using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiProject.Models;
using System.Net.Http;

namespace RapidApiProject.Controllers
{
    public class LinkedinController : Controller
    {
        public async Task<IActionResult> Index(string Username)
        {
            if (!string.IsNullOrEmpty(Username))
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://linkedin-api8.p.rapidapi.com/?username={Username}"),
                    Headers =
    {
        { "X-RapidAPI-Key", "51fbf2c665mshdce8d8b72638de3p16d4ecjsnf297c9c1fd0b" },
        { "X-RapidAPI-Host", "linkedin-api8.p.rapidapi.com" },
    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<LinkedinViewModel>(body);
                    return View(values);
                }
            }
            else
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://linkedin-api8.p.rapidapi.com/?username=mrtylmz99"),
                    Headers =
    {
        { "X-RapidAPI-Key", "51fbf2c665mshdce8d8b72638de3p16d4ecjsnf297c9c1fd0b" },
        { "X-RapidAPI-Host", "linkedin-api8.p.rapidapi.com" },
    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<LinkedinViewModel>(body);
                    return View(values);
                }
            }
        }
    }
}
