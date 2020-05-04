using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevPrep.Models
{
    public class Description
    {
        public  int Id { get; set; }
        public int ConceptId { get; set; }
        public int UserId { get; set; }
        public string Paragraph { get; set; }
    }
}
