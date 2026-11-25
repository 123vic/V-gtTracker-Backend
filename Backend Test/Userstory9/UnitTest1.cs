

using Backend_Classes.Models;
using Backend_Classes.Repositories;

namespace Backend_Test;

public class GetFoodItemByFullName
{
    [Fact]
    public void GetFoodItemByFullName_Succes()
    {
        //Arrange 
        SimpelIngrediensRepository repo = new SimpelIngrediensRepository();

        //Act
        //SimpelIngrediens ingrediens = repo.GetItemByName("Ris");

        //Assert
        //Assert.Equal("Ris",ingrediens);
    }
}
