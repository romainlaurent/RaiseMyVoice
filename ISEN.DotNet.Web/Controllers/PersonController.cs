using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using RaiseMyVoice.Library.Models;
using RaiseMyVoice.Library.Repositories.Interfaces;

namespace RaiseMyVoice.Web.Controllers
{
    public class PersonController : BaseController<IPersonRepository, Person>
    {
        public PersonController(IPersonRepository repository, ILogger<PersonController> logger, UserManager<AccountUser> userManager) : base(repository, logger, userManager)
        {
        }
    }
}