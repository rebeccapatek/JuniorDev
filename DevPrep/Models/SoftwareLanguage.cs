using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevPrep.Models
{
    public class SoftwareLanguage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Concept> Concepts { get; set; }

    }
}
