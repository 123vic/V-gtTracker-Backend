using Microsoft.AspNetCore.Mvc;
using Backend_Classes.Interfaces;
using Backend_Classes.Models;
using Backend_Classes.Repositories;
using Microsoft.AspNetCore.Cors;

namespace VaegtTracker_Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
[EnableCors("AllowAll")]
public class IngrediensController : Controller
{
    private readonly IngrediensRepository _repo;

    public IngrediensController(IngrediensRepository repo)
    {
        _repo = repo;
    }
    [HttpGet("barcode/{barcodeId}")]
    public ActionResult<Ingrediens> GetByBarcode(string barcodeId)
    {
        var ingrediens = _repo.GetByBarcode(barcodeId);
        if (ingrediens is null)
            return NotFound();

        return Ok(ingrediens);
    }
}

