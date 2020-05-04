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
        public int UserId { get; set; }
    }
}
