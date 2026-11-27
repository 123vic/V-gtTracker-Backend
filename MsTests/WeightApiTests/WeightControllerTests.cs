using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VaegtApi;
using VægtTracker___Backend.Controllers;

namespace VaegtApi.Tests;

[TestClass]
public class WeightControllerTests
{
    [TestMethod]
    public void AddWeight_GemmerIkkeVaegten()
    {
        // Arrange
        var repo = new WeightRepository();
        var controller = new WeightController(repo);

        // Act
        controller.AddWeight(100);

        // Assert
        Assert.AreEqual(100, repo.Latest);
        Assert.AreEqual(0, repo.GetAll().Count);
    }

    [TestMethod]
    public void SaveWeight_GemmerNyesteVaegt()
    {
        // Arrange
        var repo = new WeightRepository();
        var controller = new WeightController(repo);
        controller.AddWeight(50);
        controller.AddWeight(100);

        // Act
        controller.SaveWeight();

        // Assert
        Assert.AreEqual(1, repo.GetAll().Count);
        Assert.AreEqual(100, repo.GetAll()[0].Gram);
    }

    [TestMethod]
    public void GetWeight_ReturnererGemteVaegte()
    {
        // Arrange
        var repo = new WeightRepository();
        repo.Add(new Weight { Gram = 100 });
        var controller = new WeightController(repo);

        // Act
        var svar = controller.GetWeight() as OkObjectResult;

        // Assert
        Assert.IsNotNull(svar);
        Assert.AreSame(repo.GetAll(), svar.Value);
    }
}