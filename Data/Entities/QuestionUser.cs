using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class QuestionUser : Entity
    {
        public string UserId { get; set; }
        public Question Question { get; set; }
        public bool IsAnswered { get; set; }
    }
}
