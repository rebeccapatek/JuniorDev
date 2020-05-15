using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevPrep.Models.ViewModels
{
    public class ConceptViewModel
    {
<<<<<<< HEAD
        public int? SoftwareLanguageId { get; set; }
        public SoftwareLanguage SoftwareLanguage { get; set; }
=======
        
        public int? SoftwareLanguageId;
        public SoftwareLanguage SoftwareLanguage;
>>>>>>> master
        public List<ConceptWithDescriptionAndLink> ConceptsWithStuff { get; set; }

        public ApplicationUser LoggedInUser { get; set; }

    }
}
