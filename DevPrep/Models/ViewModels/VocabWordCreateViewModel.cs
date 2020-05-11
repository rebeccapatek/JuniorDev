using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevPrep.Models.ViewModels
{
    public class VocabWordCreateViewModel
    {
        public int id { get; set; }
        [Required]

        public string Word { get; set; }
        [Required]
        public string Definition { get; set; }
       
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        [Required]
        public int SoftwareLanguageId { get; set; }

        public SoftwareLanguage SoftwareLanguage{ get; set; }

        public List<SelectListItem> SoftwareLanguageOptions { get; set; }

    }
}
