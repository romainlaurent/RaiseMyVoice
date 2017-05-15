using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RaiseMyVoice.Library.Models;
using RaiseMyVoice.Library.Repositories.Interfaces;

namespace RaiseMyVoice.Web.Controllers
{
    public class QuestionController : BaseController<IQuestionRepository, Question>
    {
        public QuestionController(IQuestionRepository repository, ILogger<QuestionController> logger) : base(repository, logger)
        {
        }

        [Authorize(Roles = "User")]
        public IActionResult Create(int id)
        {
            ViewData["Id"] = id;
            return Detail(id);
        }
    }
}