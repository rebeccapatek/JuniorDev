using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevPrep.Models.ViewModels
{
    public class AddNewConceptwithDescriptionViewModel
    {
        public int SoftwareLanguageId { get; set; }
        public SoftwareLanguage SoftwareLanguage { get; set; }
        public string ConceptName { get; set; }
        public string ConceptDescription { get; set; }
    }
}
