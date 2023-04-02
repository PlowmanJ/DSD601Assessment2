using DSD601Assessment2.Interfaces;

namespace DSD601Assessment2.Models
{
    public class Pizza : IPizza
    {

        //strings
        public string Flavor { get; set; }
        public string Description { get; set; }
        public string ImageAddress { get; set; }
        public string Chef { get; set; }

        //bools
        public bool IsPescetarian { get; set; }
        public bool IsGlutenFree { get; set; }

        //lists
        public List<string> Ingredients { get; set; }
        public List<string> Prices { get; set; }

        //vitrual Method
        public virtual void PizzaChefName()
        {
            Chef = "Chef Name Here";
        }


    }
}
