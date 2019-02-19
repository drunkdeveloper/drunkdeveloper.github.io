namespace EasyBrew
{
    public enum Unit
    {
        Grams,
        Kilograms,
        Liters,
        Pack
    }

    public class Ingredient
    {
        public bool AffectsWaterCalculation { get; set; }
        public string Name { get; set; }
        public Unit Unit { get; set; }
        public float Amount { get; set; }
    }
}