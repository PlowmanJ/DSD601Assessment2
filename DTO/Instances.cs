using DSD601Assessment2.Models;
using System.ComponentModel.DataAnnotations;

namespace DSD601Assessment2.DTO
{
    public class Instances
    {
        //Front End Selection
        [Display(Name = "Select a Pizza!")]
        public int SelectedPizza { get; set; }
        public bool OptionIsSelected { get; set; }


        //Back End Variables
        public Pizza Pizza { get; set; }




    }
}
