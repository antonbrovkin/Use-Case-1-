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
        public async Task<IActionResult> GetCountries(string commonNamePartial, long? populationThreshold, string order, int? amount)
        {
            List<Country> countries = await GetCountriesAsync();

            if (!string.IsNullOrWhiteSpace(commonNamePartial))
            {
                countries = FilterCountriesByCommonName(countries, commonNamePartial).ToList();
            }

            if (populationThreshold.HasValue)
            {
                countries = FilterCountriesByPopulation(countries, populationThreshold.Value).ToList();
            }

            if (!string.IsNullOrWhiteSpace(order))
            {
                countries = SortCountries(countries, order).ToList();
            }

            if (amount.HasValue)
            {
                countries = PaginateCountries(countries, amount.Value).ToList();
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

        public static IEnumerable<Country> SortCountries(List<Country> countries, string order)
        {
            if (order.ToLower() == "ascend")
            {
                return countries.OrderBy(c => c.Name.Common);
            }
            else if (order.ToLower() == "descend")
            {
                return countries.OrderByDescending(c => c.Name.Common);
            }
            else
            {
                throw new ArgumentException("Invalid order parameter. Use 'ascend' or 'descend'.");
            }
        }

        public static IEnumerable<Country> PaginateCountries(List<Country> countries, int amount)
        {
            return countries.Take(amount);
        }
    }
}
