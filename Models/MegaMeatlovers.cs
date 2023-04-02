namespace DSD601Assessment2.Models
{
    public class MegaMeatlovers : Pizza
    {
        //Constructor
        public MegaMeatlovers()
        {
            Flavor = "MEGA Meat Lovers Pizza";
            Description = "This Pizza is NOT for the faint of heart. It makes normal Meatlovers look vegan friendly by comparison, 1 Whole cow went into the creation of each Pizza!";
            Ingredients = new List<string>
            {
                "Ground Beef",
                "Italian Sausage",
                "Rasher Bacon",
                "Chicken",
                "Smokey Manuka Ham",
                "Pepperoni",
                "Barbeque Sauce"
            };
            Prices = new List<string>
            {
                "Small: $12.00",
                "Medium: $16.00",
                "Large: $18.00"
            };
            ImageAddress = "MegaMeatlovers.png";
            IsPescetarian = false;
            IsGlutenFree = true;
            PizzaChefName();
        }

        public override void PizzaChefName()
        {
            Chef = "Chef Butch";
        }
    }
}
