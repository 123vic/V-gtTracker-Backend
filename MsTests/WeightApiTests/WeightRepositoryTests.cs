using Microsoft.VisualStudio.TestTools.UnitTesting;
using VaegtApi;

namespace VaegtApi.Tests;

[TestClass]
public class WeightRepositoryTests
{
    [TestMethod]
    public void Add_GemmerMaaling()
    {
        var repo = new WeightRepository();

        repo.Add(new Weight { Gram = 100 });

        Assert.AreEqual(1, repo.GetAll().Count);
    }
}