using Backend_Classes.Models;

namespace Backend_Classes.Interfaces
{
    public interface ISimpelIngrediensRepository
    {
        SimpelIngrediens? GetItemByName(string name);
    }
}