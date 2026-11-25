using Backend_Classes.Interfaces;
using Backend_Classes.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backend_Classes.Repositories;

public class IngrediensRepository : RepositoryBase<Ingrediens>
{
    public Ingrediens? GetByBarcode(string barcodeId)
    {
        return Data.Values.FirstOrDefault(i => i.BarcodeId == barcodeId);
    }

}