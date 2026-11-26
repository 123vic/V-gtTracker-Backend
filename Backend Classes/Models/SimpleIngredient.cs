using Backend_Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backend_Classes.Models;

public class SimpleIngredient : IHasId
{
    public int Id { get; set; }
    public string Navn { get; set; }
    public int BarcodeId { get; set; }


    public SimpleIngredient(string navn, int barcodeId) {
        Navn = navn;
        BarcodeId = barcodeId;
    }

}
