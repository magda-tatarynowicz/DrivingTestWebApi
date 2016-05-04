using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;
using Data.Repositories.Interfaces;

namespace Data.Repositories
{
    class QuestionUsersRepository : BaseRepository, IQuestionUsersRepository
    {
        public QuestionUsersRepository(DrivingTestContext context) : base(context)
        {
        }

        public IList<Question> GetAnsweredQuestionsOfUser(string userId)
        {
            return Context.QuestionsUsersDbSet.Where(q => q.IsAnswered && q.UserId == userId).Select(q => q.Question).ToList();
        }

        public IList<Question> GetNotAnsweredQuestionsOfUser(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
