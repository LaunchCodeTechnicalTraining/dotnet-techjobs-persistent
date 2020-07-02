using System;
using System.ComponentModel.DataAnnotations;

namespace TechJobsPersistent.ViewModels
{
    public class AddSkillViewModel
    {
        [Required(ErrorMessage = "Name is required!")]
        public string Name { get; set; }

        [StringLength(250, MinimumLength = 3, ErrorMessage = "Description has to be between 3 and 250 characters!")]
        public string Description { get; set; }
    }
}
