using DSD601Assessment2.DTO;
using DSD601Assessment2.Operations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DSD601Assessment1.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        public string error { get; set; }
        public Instances instances { get; set; } = new Instances();



        public void OnGet()
        {
            instances.OptionIsSelected = false;
            error = "";
        }
        public void OnPost()
        {
            if (instances.SelectedPizza >= 1)
            {
                instances.OptionIsSelected = true;
                error = "";
                instances.Pizza = Factory.GetPizza(instances.SelectedPizza);
            }
            else
            {
                error = "Please Select an Option";
            }


        }
    }
}