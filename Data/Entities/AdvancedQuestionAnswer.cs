using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class AdvancedQuestionAnswer : Entity
    {
        public string Answer { get; set; }
        public bool IsCorrect { get; set; }
    }
}
