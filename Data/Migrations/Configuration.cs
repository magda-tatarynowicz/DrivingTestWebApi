using System.Collections.Generic;
using Data.Entities;

namespace Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Data.DrivingTestContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Data.DrivingTestContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        //    context.Questions.AddBasicQuestion(new BasicQuestion
        //    {
        //        IsVerified = true,
        //        IsCorrect = true,
        //        Points = 1,
        //        QuestionString = "Testowe pytanie podstawowe"
        //    });

        //    context.Questions.AddBasicQuestion(new BasicQuestion
        //    {
        //        IsVerified = true,
        //        IsCorrect = false,
        //        Points = 1,
        //        QuestionString = "Testowe pytanie podstawowe niepoprawne"
        //    });

        //    context.Questions.AddAdvancedQuestion(new AdvancedQuestion
        //    {
        //        IsVerified = true,
        //        QuestionString = "Pytanie zaawansowane",
        //        Points = 2,
        //        CorrectAnswer = 1,
        //        Answers = new List<Entities.AdvancedQuestionAnswer>
        //        {
        //            new Entities.AdvancedQuestionAnswer
        //            {
        //                Answer = "Poprawna",
        //                IsCorrect = true
        //            },
        //            new Entities.AdvancedQuestionAnswer
        //            {
        //                Answer = "Niepoprawna",
        //                IsCorrect = false
        //            },
        //            new Entities.AdvancedQuestionAnswer
        //            {
        //                Answer = "Znowu niepoprawna",
        //                IsCorrect = false
        //            }
        //        }
        //    });
        //    context.SaveChanges();
        }
    }
}

