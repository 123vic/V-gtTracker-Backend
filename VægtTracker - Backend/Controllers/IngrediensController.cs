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

    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [HttpGet("barcode/{barcodeId}")]
    public async Task<ActionResult<Ingredient>> GetByBarcode(string barcodeId)
    { 
        var ingrediens = await _openFoodFacts.GetByBarcodeAsync(barcodeId);
        if (ingrediens is null)
            return NotFound();

        return Ok(ingrediens);
    }
}
