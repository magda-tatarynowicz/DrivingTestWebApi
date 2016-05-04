using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;
using Data.Repositories.Interfaces;

namespace Data.Repositories
{
    public class QuestionsRepository : BaseRepository, IQuestionsRepository
    {
        public QuestionsRepository(DrivingTestContext context) : base(context)
        {
        }

        public void AddAdvancedQuestion(AdvancedQuestion question)
        {
            Context.AdvancedQuestionsDbSet.Add(question);
        }

        public void AddBasicQuestion(BasicQuestion question)
        {
            Context.BasicQuestionsDbSet.Add(question);
        }

        public IList<AdvancedQuestion> GetAllVerifiedAdvancedQuestions()
        {
            return Context.AdvancedQuestionsDbSet.Where(q => q.IsVerified).ToList();
        }

        public IList<BasicQuestion> GetAllVerifiedBasicQuestions()
        {
            return Context.BasicQuestionsDbSet.Where(q => q.IsVerified).ToList();
        }

        public IList<Question> GetAllVerifiedQuestions()
        {
            //return GetAllVerifiedAdvancedQuestions().Concat((IList<Question>)GetAllVerifiedBasicQuestions()).ToList();
           // IList<Question> questions = new List<Question>();
           
            return GetAllVerifiedBasicQuestions().Cast<Question>().Concat(GetAllVerifiedAdvancedQuestions().Cast<Question>()).ToList();

        }
    }
}
