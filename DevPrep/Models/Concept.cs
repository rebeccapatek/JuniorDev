using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevPrep.Models
{
    public class Concept

    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SoftwareLanguageId { get; set; }
        public SoftwareLanguage SoftwareLanguage { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public virtual ICollection<Description> Descriptions { get; set; }
        public virtual ICollection<UsefulLink> UsefulLinks { get; set; }

    }
}
