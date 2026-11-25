

using Backend_Classes.Models;
using Backend_Classes.Repositories;

namespace Backend_Test;

public class GetFoodItemByFullName
{
    [Fact]
    public void GetFoodItemByFullName_Succes()
    {
        //Arrange 
        SimpelIngrediensRepository<SimpelIngrediens> repo = new SimpelIngrediensRepository<SimpelIngrediens>();

        //Act
        //SimpelIngrediens ingrediens = repo.GetItemByName("Ris");

        //Assert
        //Assert.Equal("Ris",ingrediens);
    }
}
