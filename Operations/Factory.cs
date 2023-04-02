using DSD601Assessment2.Models;

namespace DSD601Assessment2.Operations
{
    public class Factory
    {
        public static Pizza GetPizza(int SelectedPizzaID)
        {
            if (SelectedPizzaID == 1)
            {
                return new GarlicPrawn();

            }
            if (SelectedPizzaID == 2)
            {
                return new PeriPeriChicken();
            }
            if (SelectedPizzaID == 3)
            {
                return new MegaMeatlovers();
            }
            return new GarlicPrawn();
        }
    }
}
