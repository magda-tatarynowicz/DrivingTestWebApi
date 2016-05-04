using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Question : Entity
    {
        public string QuestionString { get; set; }
        public int Points { get; set; }
        public bool IsVerified { get; set; }

    }
}
