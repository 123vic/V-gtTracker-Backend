using Microsoft.VisualStudio.TestTools.UnitTesting;
using VaegtApi;

namespace VaegtApi.Tests;

[TestClass]
public class WeightRepositoryTests
{
    [TestMethod]
    public void Add_GemmerMaaling()
    {
        // Arrange
        var repo = new WeightRepository();

        // Act
        repo.Add(new Weight { Gram = 100 });

        // Assert
        Assert.AreEqual(1, repo.GetAll().Count);
        Assert.AreEqual(100, repo.GetAll()[0].Gram);
    }

    [TestMethod]
    public void GetAll_NytRepository_ErTomt()
    {
        // Arrange
        var repo = new WeightRepository();

        // Act
        var alle = repo.GetAll();

        // Assert
        Assert.AreEqual(0, alle.Count);
    }
}