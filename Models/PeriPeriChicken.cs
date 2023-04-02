namespace DSD601Assessment2.Models
{
    public class PeriPeriChicken : Pizza
    {
        //Constructor
        public PeriPeriChicken()
        {
            Flavor = "Peri-Peri Chicken Pizza";
            Description = "Oh, you want spicy eh? You got it! With Pizza's like these being made, its a wonder our kitchens haven't burned down from the ammount of hot-ness going into our secret Peri-Peri sauce!(its tobasco and mayonnaise)";
            Ingredients = new List<string>
            {
                "Chicken",
                "Baby Spinach",
                "Tomato",
                "Red Onion",
                "Peri-Peri Sauce"
            };
            Prices = new List<string>
            {
                "Small: $16.00",
                "Medium: $20.00",
                "Large: $23.00"
            };
            ImageAddress = "PeriPeriChicken.png";
            IsPescetarian = false;
            IsGlutenFree = false;
            PizzaChefName();
        }
        public override void PizzaChefName()
        {
            Chef = "Chef Shi-Kan Wengs";
        }
    }
}
