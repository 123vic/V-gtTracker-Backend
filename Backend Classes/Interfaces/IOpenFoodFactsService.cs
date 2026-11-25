using System;
using System.Collections.Generic;
using System.Text;
using Backend_Classes.Models;

namespace Backend_Classes.Interfaces;

public interface IOpenFoodFactsService
{
    Task<Ingrediens?> GetByBarcodeAsync(string barcode);
}
