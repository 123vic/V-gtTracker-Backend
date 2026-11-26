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
    }
}