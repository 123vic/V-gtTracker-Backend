using Backend_Classes.Models;
using Backend_Classes.Repositories;
using Microsoft.AspNetCore.Mvc;
using VægtTracker___Backend.Controllers;

namespace Backend_Test
{
    public class SimpleIngredientAPI_Tests

    {
        [Fact]
        public void API_GET_Succes()
        {
            var controller = new SimpleIngredientController(new SimpleIngredientRepository());

            ActionResult<IEnumerable<SimpleIngredient>> simpelIngredients = controller.Get();

            Assert.NotEmpty(simpelIngredients.Value);
        }
    }
}
