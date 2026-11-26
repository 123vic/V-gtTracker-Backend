using Backend_Classes.Interfaces;
using Backend_Classes.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backend_Classes.Repositories;

public class SimpleIngredientRepository : RepositoryBase<SimpleIngredient>, ISimpleIngredientRepository
{
    public SimpleIngredientRepository()
    {
        Create(new SimpleIngredient("Ris", 1000));
    }

    public SimpleIngredient? GetItemByName(string name)
    {
        return Data.Select(x => x.Value).Where(x => x.Navn == name).FirstOrDefault();
    }


    public IEnumerable<SimpleIngredient> GetAll()
    {
        return Data.Select(x => x.Value);   
    }

}
