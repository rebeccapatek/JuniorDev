using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevPrep.Models.ViewModels
{
    public class VocabWordViewModel
    {
        public List<VocabWord> VocabWords{ get; set; }
        public ApplicationUser LoggedInUser { get; set; }

    }
}
