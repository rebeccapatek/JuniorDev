﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevPrep.Models.ViewModels
{
    public class ConceptViewModel
    {
        
        public int? SoftwareLanguageId;
        public SoftwareLanguage SoftwareLanguage;
        public List<ConceptWithDescriptionAndLink> ConceptsWithStuff { get; set; }

        public ApplicationUser LoggedInUser { get; set; }

    }
}
