using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RaiseMyVoice.Library.Models;
using RaiseMyVoice.Library.Repositories.Interfaces;

namespace RaiseMyVoice.Web.Controllers
{
    public class AnswerController : BaseController<IAnswerRepository, Answer>
    {
        public AnswerController(IAnswerRepository repository, ILogger<AnswerController> logger, UserManager<AccountUser> userManager) : base(repository, logger, userManager)
        {
        }

        public override IActionResult Index(int? id)
        {
            if (id != null)
            {
                int Yes = 0;
                int No = 0;

                var answers = Repository.Find(o => o.QuestionId == id.Value);
                foreach (var item in answers)
                {
                    if (item.Value)
                        Yes++;
                    else
                        No++;
                }
                ViewData["Yes"] = Yes;
                ViewData["No"] = No;
                return View();
            }
            else
                return View("Error");
        }

    }
}