using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;
using Data.Repositories;
using Data.Repositories.Interfaces;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Data
{
    public class DrivingTestContext : IdentityDbContext<ApplicationUser>, IDrivingTestContext
    {
        private readonly Lazy<QuestionsRepository> _questionsRepository;

        private readonly Lazy<QuestionUsersRepository> _questionUsersRepository;

        public IQuestionsRepository Questions => _questionsRepository.Value;
        public IQuestionUsersRepository QuestionUsers => _questionUsersRepository.Value;

        public DrivingTestContext() : base("DrivingTestContext")
        {
            _questionsRepository = new Lazy<QuestionsRepository>(() => new QuestionsRepository(this));
            _questionUsersRepository = new Lazy<QuestionUsersRepository>(() => new QuestionUsersRepository(this));

        }

        public IDbSet<AdvancedQuestion> AdvancedQuestionsDbSet { get; set; }
        public IDbSet<BasicQuestion> BasicQuestionsDbSet { get; set; }
        public IDbSet<QuestionUser> QuestionsUsersDbSet { get; set; }

        public static DrivingTestContext Create()
        {
            return new DrivingTestContext();
        }

    }
}
