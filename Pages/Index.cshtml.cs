using DSD601Assessment2.DTO;
using DSD601Assessment2.Operations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DSD601Assessment1.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        public Instances instances { get; set; } = new Instances();



        public void OnGet()
        {
            instances.OptionIsSelected = false;
        }
        public void OnPost()
        {
            instances.OptionIsSelected = true;
            instances.Pizza = Factory.GetPizza(instances.SelectedPizza);



        }
    }
}