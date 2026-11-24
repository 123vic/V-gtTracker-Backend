using System;
using System.Collections.Generic;
using System.Text;

namespace Backend_Classes.Models;

public class Ingrediens
{
    public string Name { get; set; }

    public string Brand { get; set; }

    public int Calories { get; set; }

    public int BarcodeId { get; set; }
}
