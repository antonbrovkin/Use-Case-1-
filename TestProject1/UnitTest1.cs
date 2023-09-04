using C1.Country;
using UC1.Controllers;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_FilterCountriesByCommonName()
        {
            var countries = new List<Country>
        {
            new Country { Name = new Name { Common = "India" }, Population = 1300000000 },
            new Country { Name = new Name { Common = "Indonesia" }, Population = 270000000 }
        };

            var service = new CountryController();
            var result = service.FilterCountriesByCommonName(countries, "ind");

            Assert.AreEqual(2, result.Count());
        }

        [TestMethod]
        public void Test_FilterCountriesByPopulation()
        {
            var countries = new List<Country>
        {
            new Country { Name = new Name { Common = "India" }, Population = 1300000000 },
            new Country { Name = new Name { Common = "Indonesia" }, Population = 270000000 }
        };

            var service = new CountryController();
            var result = service.FilterCountriesByPopulation(countries, 300000000);

            Assert.AreEqual(1, result.Count());
        }

        [TestMethod]
        public void Test_SortCountries()
        {
            var countries = new List<Country>
        {
            new Country { Name = new Name { Common = "India" }, Population = 1300000000 },
            new Country { Name = new Name { Common = "Australia" }, Population = 25000000 }
        };

            var service = new CountryController();
            var result = service.SortCountries(countries, "descend");

            Assert.AreEqual("India", result.First().Name.Common);
        }

        [TestMethod]
        public void Test_PaginateCountries()
        {
            var countries = new List<Country>
        {
            new Country { Name = new Name { Common = "India" }, Population = 1300000000 },
            new Country { Name = new Name { Common = "Australia" }, Population = 25000000 },
            new Country { Name = new Name { Common = "USA" }, Population = 330000000 }
        };

            var service = new CountryController();
            var result = service.PaginateCountries(countries, 2);

            Assert.AreEqual(2, result.Count());
        }
    }
}