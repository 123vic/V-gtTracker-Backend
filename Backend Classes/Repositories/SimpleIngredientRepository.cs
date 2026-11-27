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
        Create(new SimpleIngredient("Jasminris", "7340011352198"));
        Create(new SimpleIngredient("Hakket oksekød", "4704310825600"));
        Create(new SimpleIngredient("Hakket Tomat", "5700002404053"));
        Create(new SimpleIngredient("Mezze penne rigate", "8001120721310("));
        Create(new SimpleIngredient("Brown onions", "20175863"));
        Create(new SimpleIngredient("Økologiske Hvidløg", "3000007029575"));


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
