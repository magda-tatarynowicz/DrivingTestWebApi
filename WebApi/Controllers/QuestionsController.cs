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
    // todo - cały kontroler na authorize
    public class QuestionsController : BaseApiController
    {
        public QuestionsController() :base()
        {
            
        }
        public QuestionsController(IDrivingTestContext context) : base(context)
        {

        }

        public IHttpActionResult Get()
        {

            return Ok(Context.Questions.GetAllVerifiedQuestions());
        }

        //todo - weryfikacja dodawania 
        //todo - przy dodawaniu atrybut IsVerified zawsze na false
        [Route("AddBasicQuestion")]
        public IHttpActionResult Post([FromBody] BasicQuestion basicQuestion)
        {
            Context.Questions.AddBasicQuestion(basicQuestion);
            Context.SaveChanges();
            return Created(string.Empty, basicQuestion);
        }

        [Route("AddAdvancedQuestion")]
        public IHttpActionResult Post([FromBody] AdvancedQuestion advancedQuestion)
        {
            Context.Questions.AddAdvancedQuestion(advancedQuestion);
            Context.SaveChanges();
            return Created(string.Empty, advancedQuestion);
        }
    }
}