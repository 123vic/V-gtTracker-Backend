using Backend_Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backend_Classes.Models;

public class Meal : IHasId
{
    public int Id { get; set; }
    public string Måltidstype { get; set; }
    public List<Ingredient> Ingredienser { get; set; }
}
