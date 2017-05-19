using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using RaiseMyVoice.Library.Models;
using RaiseMyVoice.Library.Repositories.Interfaces;

namespace RaiseMyVoice.Web.Controllers
{
    [Authorize]
    public class QuestionController : BaseController<IQuestionRepository, Question>
    {
        public QuestionController(IQuestionRepository repository, ILogger<QuestionController> logger,
            UserManager<AccountUser> userManager) : base(repository, logger, userManager)
        {
        }

        public override IActionResult Index(int? id)
        {
            ViewData["Id"] = id;
            var question = Repository.Find(o => o.ModuleId == id.Value);
            return View(question);
        }

        [Authorize(Roles = "User")]
        public IActionResult Create(int id)
        {
            ViewData["Id"] = id;
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "User")]
        public IActionResult Create(Question q)
        {
            Repository.Update(q);
            Repository.Save();
            return RedirectToAction("Index", new {id = q.ModuleId});
        }

        [Authorize(Roles = "User")]
        public IActionResult Resultats(int idQuestion)
        {
            ViewData["Id"] = idQuestion;
            return Detail(idQuestion);
        }
    }
}