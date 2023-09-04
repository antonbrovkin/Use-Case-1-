using C1.Country;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace UC1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountryController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<Country> countries = await GetCountriesAsync();
            return Ok(countries);
        }

        public async Task<List<Country>> GetCountriesAsync()
        {
            using HttpClient client = new HttpClient();
            string url = "https://restcountries.com/v3.1/all";
            string jsonResponse = await client.GetStringAsync(url);

            return JsonSerializer.Deserialize<List<Country>>(jsonResponse, Converter.Settings);
        }
    }
}
