using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RaiseMyVoice.Library.Models;
using RaiseMyVoice.Library.Repositories.Interfaces;

namespace RaiseMyVoice.Web.Controllers
{
    [Authorize]
    public class ModuleController : BaseController<IModuleRepository, Module>
    {
        public ModuleController(IModuleRepository repository, ILogger<ModuleController> logger, UserManager<AccountUser> userManager) : base(repository, logger, userManager)
        {
        }

        public override IActionResult Index(int? a)
        {
            var idStr = UserManager.GetUserId(User);
            int id;
            int.TryParse(idStr, out id);
            var module = Repository.Find(o => o.AccountUserId == id);
            return View(module);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Create(int id)
        {
            ViewData["Id"] = id;
            return Detail(id);
        }

        [Authorize(Roles = "User")]
        public IActionResult Edit(int id)
        {
            var module = Repository.Single(id);
            return View(module.QuestionCollection);
        }
    }
}