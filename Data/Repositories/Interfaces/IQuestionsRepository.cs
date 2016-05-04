﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;

namespace Data.Repositories.Interfaces
{
    public interface IQuestionsRepository
    {
        void AddAdvancedQuestion(AdvancedQuestion question);
        void AddBasicQuestion(BasicQuestion quuestion);
        IList<AdvancedQuestion> GetAllVerifiedAdvancedQuestions();
        IList<BasicQuestion> GetAllVerifiedBasicQuestions();
        IList<Question> GetAllVerifiedQuestions();
    }
}
