using Microsoft.Extensions.Logging;
using RaiseMyVoice.Library.Models;
using RaiseMyVoice.Library.Repositories.Interfaces;

namespace RaiseMyVoice.Web.Controllers
{
    public class PersonController : BaseController<IPersonRepository, Person>
    {
        public PersonController(IPersonRepository repository, ILogger<PersonController> logger) : base(repository, logger)
        {
        }
    }
}