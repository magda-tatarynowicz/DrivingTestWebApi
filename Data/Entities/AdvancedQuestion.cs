using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class AdvancedQuestion : Question
    {
        public virtual List<AdvancedQuestionAnswer> Answers { get; set; }
        public int CorrectAnswer { get; set; }
    }
}
