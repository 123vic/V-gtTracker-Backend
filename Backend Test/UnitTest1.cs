using Backend_Classes.Models;
using Backend_Classes.Repositories;

namespace Backend_Test
{
    public class UnitTest1
    {
        [Fact]
        public void GetByBarcode()
        {
            //Arrange
            var repo = new IngrediensRepository();
            repo.Create(new Ingrediens { Name = "Havregryn", BarcodeId = "123456789" });
            //Act
            var result = repo.GetByBarcode("123456789");

            //Assert
            Assert.NotNull(result);
            Assert.Equal("Havregryn", result.Name);
        }

        [Fact]
        public void GetByBarcode_FindesIkke_ReturnererNull()
        {
            //Arrange
            var repo = new IngrediensRepository();

            //Act
            var resultat = repo.GetByBarcode("0000000000000");

            //Assert
            Assert.Null(resultat);
        }

        [Fact]
        public async Task KanHenteProduktFraOpenFoodFacts()
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
    }
}
