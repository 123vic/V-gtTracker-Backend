using Backend_Classes.Models;
using Backend_Classes.Repositories;
using VægtTracker___Backend.Controllers;

namespace Backend_Test
{
    public class SimpleIngredientAPI_Tests

    {
        [Fact]
        public void API_GET_Succes()
        {
            var controller = new SimpleIngredientController(new SimpelIngredientRepository());

            IEnumerable<SimpelIngredient> simpelIngredients = controller.Get();

            Assert.NotEmpty(simpelIngredients);
        }
    }
}
