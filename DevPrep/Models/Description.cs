using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevPrep.Models
{
    public class Description
    {
        public  int id { get; set; }
        public int? ConceptId { get; set; }
        public Concept Concept { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public string Paragraph { get; set; }
    }
}
