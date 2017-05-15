using Microsoft.Extensions.Logging;
using RaiseMyVoice.Library.Models;
using RaiseMyVoice.Library.Repositories.Interfaces;

namespace RaiseMyVoice.Web.Controllers
{
    public class AnwerController : BaseController<IAnswerRepository, Answer>
    {
        public AnwerController(IAnswerRepository repository, ILogger<AnwerController> logger) : base(repository, logger)
        {
        }
    }
}