using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;
using Data.Repositories.Interfaces;
using Microsoft.AspNet.Identity.EntityFramework;

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

        public bool AddAdmin()
        {
            Context.Roles.Add(new IdentityRole
            {
                Name = "Administrator"
            });
            Context.SaveChanges();
            var admin = Context.Users.SingleOrDefault(u => u.Email == "admin@admin.com");
            if (admin == null) return false;
            var role = Context.Roles.SingleOrDefault(r => r.Name == "Administrator");
            if (role == null) return false;
            IdentityUserRole userRole = new IdentityUserRole
            {
                RoleId = role.Id,
                UserId = admin.Id
            };
            role.Users.Add(userRole);
            admin.Roles.Add(userRole);
            return true;

        }
    }
}
