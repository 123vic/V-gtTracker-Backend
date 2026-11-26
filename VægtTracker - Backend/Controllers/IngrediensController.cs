using Microsoft.AspNetCore.Mvc;
using Backend_Classes.Interfaces;
using Backend_Classes.Models;
using Microsoft.AspNetCore.Cors;

namespace VaegtTracker_Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class IngrediensController : ControllerBase
{
    private readonly IOpenFoodFactsService _openFoodFacts;

    public IngrediensController(IOpenFoodFactsService openFoodFacts)
    {
        _openFoodFacts = openFoodFacts;
    }

    [HttpGet("barcode/{barcodeId}")]
    public async Task<ActionResult<Ingrediens>> GetByBarcode(string barcodeId)
    {
        Console.WriteLine($"Controller ramt: {barcodeId}");

        var ingrediens = await _openFoodFacts.GetByBarcodeAsync(barcodeId);
        if (ingrediens is null)
            return NotFound();

        return Ok(ingrediens);
    }
}
