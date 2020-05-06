using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevPrep.Models.ViewModels
{
    public class EditConceptViewModel
    {
        public string ConceptName { get; set; }
        public List<Description> Descriptions { get; set; }
    }
}
