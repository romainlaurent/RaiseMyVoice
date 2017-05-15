using Microsoft.Extensions.Logging;
using RaiseMyVoice.Library.Models;
using RaiseMyVoice.Library.Repositories.Interfaces;

namespace RaiseMyVoice.Web.Controllers
{
    public class ModuleController : BaseController<IModuleRepository, Module>
    {
        public ModuleController(IModuleRepository repository, ILogger<ModuleController> logger) : base(repository, logger)
        {
        }
    }
}