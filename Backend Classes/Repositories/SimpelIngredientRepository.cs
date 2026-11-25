using Backend_Classes.Interfaces;
using Backend_Classes.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backend_Classes.Repositories;

public class SimpelIngredientRepository : RepositoryBase<SimpelIngredient>, ISimpelIngrediensRepository
{
    public SimpelIngredientRepository()
    {
        Create(new SimpelIngredient("Ris", 1000));
    }

    public SimpelIngredient? GetItemByName(string name)
    {
        return Data.Select(x => x.Value).Where(x => x.Navn == name).FirstOrDefault();
    }


    public IEnumerable<SimpelIngredient> GetAll()
    {
        return Data.Select(x => x.Value);   
    }

}
