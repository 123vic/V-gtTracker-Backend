

using Backend_Classes.Models;
using Backend_Classes.Repositories;

namespace Backend_Test;

public class SimpleRepository_Test
{
    [Fact]
    public void GetFoodItemByFullName_Succes()
    {
        //Arrange 
        SimpleIngredientRepository repo = new SimpleIngredientRepository();

        //Act
        SimpleIngredient ingrediens = repo.GetItemByName("Jasminris");

        //Assert
        Assert.Equal("Jasminris",ingrediens.Navn);
    }


    [Fact]
    public void GetAllFoodItems_Succes()
    {
        //Arrange 
        SimpleIngredientRepository repo = new SimpleIngredientRepository();


        //Act
        IEnumerable<SimpleIngredient> ingrediens = repo.GetAll();

        //Assert
        Assert.NotEmpty(ingrediens);
    }
}
