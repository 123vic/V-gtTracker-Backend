using Backend_Classes.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VaegtApi.Tests;

[TestClass]
public class NutritionCalculatorTests
{
    [TestMethod]
    public void Beregn_150Gram_Giver135()
    {
        var resultat = NutritionCalculator.Beregn(90, 150);

        Assert.AreEqual(135.0, resultat);
    }

    [TestMethod]
    public void Beregn_UkendtVaerdi_GiverNull()
    {
        var resultat = NutritionCalculator.Beregn(null, 150);

        Assert.IsNull(resultat);
    }

    [TestMethod]
    public void Beregn_NulVaerdi_GiverNull()
    {
        var resultat = NutritionCalculator.Beregn(0, 150);

        Assert.AreEqual(0.0, resultat);
    }
}
