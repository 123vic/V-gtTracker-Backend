namespace Backend_Classes.Models;

public static class NutritionCalculator
{
    public static double? Beregn(double? pr100g, double gram)
    {
        return pr100g * gram / 100;
    }
}