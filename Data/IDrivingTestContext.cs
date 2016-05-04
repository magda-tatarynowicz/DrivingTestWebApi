using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Repositories.Interfaces;

namespace Data
{
    public interface IDrivingTestContext : IDisposable
    {
        IQuestionsRepository Questions { get; }
        IQuestionUsersRepository QuestionUsers { get; }
        int SaveChanges();
    }
}
