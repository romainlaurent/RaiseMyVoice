using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RaiseMyVoice.Library.Models;
using RaiseMyVoice.Library.Repositories.Interfaces;

namespace RaiseMyVoice.Web.Controllers
{
    [Authorize]
    public class ModuleController : BaseController<IModuleRepository, Module>
    {
        public ModuleController(IModuleRepository repository, ILogger<ModuleController> logger) : base(repository, logger)
        {
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Create(int id)
        {
            ViewData["Id"] = id;
            return Detail(id);
        }
    }
}