using Backend_Classes.Interfaces;
using Backend_Classes.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backend_Classes.Repositories;

public class SimpelIngrediensRepository : RepositoryBase<SimpelIngrediens>, ISimpelIngrediensRepository
{
    public SimpelIngrediensRepository()
    {
        Create(new SimpelIngrediens("Ris", 1000));
    }

    public SimpelIngrediens? GetItemByName(string name)
    {
        return Data.Select(x => x.Value).Where(x => x.Navn == name).FirstOrDefault();
    }


    public IEnumerable<SimpelIngrediens> GetAll()
    {
        return Data.Select(x => x.Value);   
    }

}
