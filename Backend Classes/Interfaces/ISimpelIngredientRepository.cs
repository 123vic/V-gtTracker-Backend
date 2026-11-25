using Backend_Classes.Models;

namespace Backend_Classes.Interfaces
{
    public interface ISimpelIngredientRepository
    {
        SimpelIngredient? GetItemByName(string name);

        IEnumerable<SimpelIngredient> GetAll();
    }
}