using Backend_Classes.Models;
using Backend_Classes.Repositories;

namespace Backend_Test
{
    public class UnitTest1
    {
        [Fact]
        public async Task CanGetProduct()
        {
            var http = new HttpClient
            {
                BaseAddress = new Uri("https://dk.openfoodfacts.org/")
            };
            http.DefaultRequestHeaders.UserAgent.ParseAdd("VaegtTracker/1.0 (Lucas4e12345@gmail.com)");

             var response = await http.GetAsync("api/v2/product/3017620422003.json");
             var json = await response.Content.ReadAsStringAsync();

             Console.WriteLine(json);

             Assert.True(response.IsSuccessStatusCode);
             Assert.True(json.Contains("\"status\":1"));
        }

        [Fact]
        public async Task CantFindProduct()
        {
            var http = new HttpClient
            {
                BaseAddress = new Uri("https://dk.openfoodfacts.org/")
            };
            http.DefaultRequestHeaders.UserAgent.ParseAdd("VaegtTracker/1.0 (Lucas4e12345@gmail.com)");

            var response = await http.GetAsync("api/v2/product/0000000000000.json");
            var json = await response.Content.ReadAsStringAsync();

            Assert.Contains("\"status\":0", json);
        }

    }
}
