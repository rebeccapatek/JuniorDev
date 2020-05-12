using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevPrep.Models.ViewModels
{
    public class ConceptWithDescriptionAndLink
    {
        public int ConceptId { get; set; }
        public string ConceptName { get; set; }

        public int? SoftwareLanguageId { get; set; }
     

        public List<UsefulLink> UsefulLinks { get; set; }

        public List<Description> Descriptions { get; set; }
    }
}
