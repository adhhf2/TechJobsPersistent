using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage = "Employer Name is a required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Employer Location is a required.")]
        public string Location { get; set; }

        public AddEmployerViewModel()
        {

        }
    }
}
