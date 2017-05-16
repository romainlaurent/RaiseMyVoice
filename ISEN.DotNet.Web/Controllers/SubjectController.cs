using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using RaiseMyVoice.Library.Models;
using RaiseMyVoice.Library.Repositories.Interfaces;

namespace RaiseMyVoice.Web.Controllers
{
    public class SubjectController : BaseController<ISubjectRepository, Subject>
    {
        public SubjectController(ISubjectRepository repository, ILogger<SubjectController> logger, UserManager<AccountUser> userManager) : base(repository, logger, userManager)
        {
        }
    }
}