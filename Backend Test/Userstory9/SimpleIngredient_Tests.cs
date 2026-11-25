

using Backend_Classes.Models;
using Backend_Classes.Repositories;

namespace Backend_Test;

public class SimpleRepository_Test
{
    [Fact]
    public void GetFoodItemByFullName_Succes()
    {
        //Arrange 
        SimpelIngredientRepository repo = new SimpelIngredientRepository();

        //Act
        SimpelIngredient ingrediens = repo.GetItemByName("Ris");

        //Assert
        Assert.Equal("Ris",ingrediens.Navn);
    }


    [Fact]
    public void GetAllFoodItems_Succes()
    {
        //Arrange 
        SimpelIngredientRepository repo = new SimpelIngredientRepository();


        //Act
        IEnumerable<SimpelIngredient> ingrediens = repo.GetAll();

        //Assert
        Assert.NotEmpty(ingrediens);
    }
}
