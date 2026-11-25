using Backend_Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backend_Classes.Models;

public class Ingrediens : IHarId
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Brand { get; set; }

    public int Calories { get; set; }

    public string BarcodeId { get; set; }
    public double? ProteinPer100g { get; set; }
    public double? KulhydratPer100g { get; set; }
    public double? FedtPer100g { get; set; }
}
