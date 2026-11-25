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
    }
}
