using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;

namespace Data.Repositories.Interfaces
{
    public interface IQuestionUsersRepository
    {
        IList<Question> GetAnsweredQuestionsOfUser (string UserId);
        IList<Question> GetNotAnsweredQuestionsOfUser(string UserId);

        bool AddAdmin();
    }
}
