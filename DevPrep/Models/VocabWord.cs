using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevPrep.Models
{
    public class VocabWord
    {
        public int id { get; set; }
        public string Word { get; set; }
        public string Definition { get; set; }
        public int SoftwareLanguageId { get; set; }
        public SoftwareLanguage SoftwareLanguage { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
