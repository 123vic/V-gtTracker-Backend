using System;
using System.Collections.Generic;
using System.Text;
using Backend_Classes.Models;
using Backend_Classes.Repositories;

namespace Backend_Classes.Mock;

public class MockIngredientRepository : RepositoryBase<Ingredient>
{
    public MockIngredientRepository() {
        Create(new Ingredient());
    }
}
