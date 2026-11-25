using System.Net.Http.Json;
using System.Text.Json.Serialization;
using Backend_Classes.Interfaces;
using Backend_Classes.Models;
using System;


namespace Backend_Classes.Services;

public class OpenFoodFactsService : IOpenFoodFactsService
{
    private readonly HttpClient _http;

    public OpenFoodFactsService(HttpClient http)
    {
        _http = http;
    }

    public async Task<Ingrediens?> GetByBarcodeAsync(string barcode)
    {
        var response = await _http.GetAsync($"api/v2/product/{barcode}.json");
        if (!response.IsSuccessStatusCode)
            return null;

        var result = await response.Content.ReadFromJsonAsync<OffResponse>();
        if (result is null || result.Status != 1 || result.Product is null)
            return null;

        var n = result.Product.Nutriments;

        return new Ingrediens
        {
            BarcodeId = barcode,
            Name = result.Product.ProductName ?? "Ukendt produkt",
            Brand = result.Product.Brands ?? "",
            Calories = (int)Math.Round(n?.KcalPer100g ?? 0),
            ProteinPer100g = n?.ProteinPer100g,
            KulhydratPer100g = n?.KulhydratPer100g,
            FedtPer100g = n?.FedtPer100g
        };
    }
}