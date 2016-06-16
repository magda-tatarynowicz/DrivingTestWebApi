using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Web.Http;
using Data;
using Data.Entities;

namespace WebApi.Controllers
{
    [Authorize]
    public class QuestionsController : BaseApiController
    {
        public QuestionsController() :base()
        {
            
        }
        public QuestionsController(IDrivingTestContext context) : base(context)
        {

        }

        public IHttpActionResult Get(bool verified=true)
        {
            return Ok(!verified ? Context.Questions.GetAllNotVerifiedQuestions() : Context.Questions.GetAllVerifiedQuestions());
        }


        [Route("api/AddBasicQuestion")]
        public IHttpActionResult Post([FromBody] BasicQuestion basicQuestion)
        {
            basicQuestion.IsVerified = false;
            Context.Questions.AddBasicQuestion(basicQuestion);
            Context.SaveChanges();
            return Created(string.Empty, basicQuestion);
        }

        [Route("api/AddAdvancedQuestion")]
        public IHttpActionResult Post([FromBody] AdvancedQuestion advancedQuestion)
        {
            advancedQuestion.IsVerified = false;
            Context.Questions.AddAdvancedQuestion(advancedQuestion);
            Context.SaveChanges();
            //Context.Questions.AddSampleQuestions();
            //Context.SaveChanges();
            return Created(string.Empty, advancedQuestion);
        }

        [Route("api/DeleteQuestion")]
        [HttpPost]
        public IHttpActionResult DeleteQuestion(int id)
        {
            Context.Questions.RemoveQuestion(id);
            Context.SaveChanges();
            return Ok();
        }
  
        [Route("api/VerifyQuestion")]
        [HttpPost]
        public IHttpActionResult VerifyQuestion(int id)
        {
            Context.Questions.VerifyQuestion(id);
            Context.SaveChanges();
            return Ok();
        }

        [Route("api/AddSample")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            Context.Questions.AddQuestionsWithPicture();
            Context.SaveChanges();
            return Ok();
        }

        [AllowAnonymous]
        [Route("api/AddAdmin")]
        [HttpGet]
        public IHttpActionResult AddAdmin()
        {
            if(Context.QuestionUsers.AddAdmin()) return Ok();
            return BadRequest("Coś poszlo nie tak");
        }
    }
}