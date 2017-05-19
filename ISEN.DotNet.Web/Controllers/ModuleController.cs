using System.Collections.Generic;
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

        public override IActionResult Index(int? id)
        {
            ViewData["Id"] = id;
            IEnumerable<Module> module;
            if (User.IsInRole("Admin"))               
                module = Repository.Find(o => o.AccountUserId == id);
            else
            {
                int idU;
                int.TryParse(UserManager.GetUserId(User), out idU);
                module = Repository.Find(o => o.AccountUserId == idU);
            }
            return View(module);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Create(int id)
        {
            ViewData["Id"] = id;
            return View();
        }

        [Authorize(Roles = "User")]
        public IActionResult Edit(int id)
        {
            var module = Repository.Single(id);
            return View(module.QuestionCollection);
        }
    }
}