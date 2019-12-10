using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace reg.Models
{
    public class UserProjects
    {

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Need to input name")]
        public string name { get; set; }

        [Display(Name = "Short Description")]
        [Required(ErrorMessage = "Need to input Short Description")]
        public string small_description { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Need to input Description")]
        public string full_description { get; set; }

        [Display(Name = "Short Description")]
        [Required(ErrorMessage = "Need to input Short Description")]
        public string owner { get; set; }
    }
}