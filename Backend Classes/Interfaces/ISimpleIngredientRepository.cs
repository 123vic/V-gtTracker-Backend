using Backend_Classes.Models;

namespace Backend_Classes.Interfaces
{
    public interface ISimpleIngredientRepository
    {
        SimpleIngredient? GetItemByName(string name);

        IEnumerable<SimpleIngredient> GetAll();
    }
}