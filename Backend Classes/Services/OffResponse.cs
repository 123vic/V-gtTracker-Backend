using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backend_Classes.Services;

public class OffResponse
{
    [JsonPropertyName("status")]
    public int Status { get; set; }

    [JsonPropertyName("product")]
    public OffProduct? Product { get; set; }
}
public class OffProduct
{
    [JsonPropertyName("product_name")]
    public string? ProductName { get; set; }

    [JsonPropertyName("brands")]
    public string? Brands { get; set; }

    [JsonPropertyName("nutriments")]
    public OffNutriments? Nutriments { get; set; }
}

public class OffNutriments
{
    [JsonPropertyName("energy-kcal_100g")]
    public double? KcalPer100g { get; set; }

    [JsonPropertyName("proteins_100g")]
    public double? ProteinPer100g { get; set; }

    [JsonPropertyName("carbohydrates_100g")]
    public double? KulhydratPer100g { get; set; }

    [JsonPropertyName("fat_100g")]
    public double? FedtPer100g { get; set; }
}