using Microsoft.AspNetCore.Identity;
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
    }
}