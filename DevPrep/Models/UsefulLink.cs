using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevPrep.Models
{
    public class UsefulLink
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public int? ConceptId { get; set; }
        public Concept Concept { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public int? InterviewQuestionId { get; set; }
        public InterviewQuestion InterviewQuestion { get; set; }

    }
}
