using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevPrep.Models
{
    public class InterviewQuestion
    {
        public int id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
