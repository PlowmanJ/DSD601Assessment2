namespace DSD601Assessment2.Models
{
    public class GarlicPrawn : Pizza
    {
        //Constructor
        public GarlicPrawn()
        {
            Flavor = "Cheesy Garlic Prawn Pizza";
            Description = "Fresh out of the ocean and straight into the fryer with these prawns! And enough garlic to prove you aren't a vampire with 1 bite. Both factors make a yummy pizza.";
            Ingredients = new List<string>
            {
                "Prawns",
                "Baby Spinach",
                "Tomato",
                "Oregano",
                "Creme Fraiche Sauce",
                "Garlic Sauce"
            };
            Prices = new List<string>
            {
                "Small: $15.00",
                "Medium: $18.00",
                "Large: $21.00"
            };
            ImageAddress = "GarlicPrawn.png";
            Chef = "Chef Jarlic Drawn";
            IsGlutenFree = true;
            IsPescetarian = true;
        }
    }
}
