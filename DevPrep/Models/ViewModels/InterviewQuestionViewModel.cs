using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevPrep.Models.ViewModels
{
    public class InterviewQuestionViewModel
    {
        public List<InterviewQuestion> InterviewQuestions { get; set; }
        public ApplicationUser LoggedInUser { get; set; }
    }
}
