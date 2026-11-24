using Backend_Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backend_Classes.Models;

public class Måltid : IHarId
{
    public int Id { get; set; }
    public string Måltidstype { get; set; }
    public List<Ingrediens> Ingredienser { get; set; }
}
