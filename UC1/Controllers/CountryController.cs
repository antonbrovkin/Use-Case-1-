using C1.Country;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace UC1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountryController : Controller
    {
        public async Task<List<Country>> GetCountriesAsync()
        {
            using HttpClient client = new HttpClient();
            string url = "https://restcountries.com/v3.1/all";
            string jsonResponse = await client.GetStringAsync(url);

            return JsonSerializer.Deserialize<List<Country>>(jsonResponse, Converter.Settings);
        }

        [HttpGet]
        public async Task<IActionResult> Get(int? population, string commonCountryName = "")
        {
            List<Country> countries = await GetCountriesAsync();

            if (!string.IsNullOrWhiteSpace(commonCountryName))
            {
                countries = FilterCountriesByCommonName(countries, commonCountryName).ToList();
            }

            if(population.HasValue)
            {
                countries = FilterCountriesByPopulation(countries, population.Value * 1000000).ToList();
            }

            return Ok(countries);
        }

        public static IEnumerable<Country> FilterCountriesByCommonName(List<Country> countries, string commonNamePartial)
        {
            return countries.Where(c => c.Name.Common.IndexOf(commonNamePartial, StringComparison.OrdinalIgnoreCase) != -1);
        }

        public static IEnumerable<Country> FilterCountriesByPopulation(List<Country> countries, long threshold)
        {
            return countries.Where(c => c.Population < threshold);
        }
    }
}
