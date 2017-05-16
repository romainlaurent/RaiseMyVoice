using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RaiseMyVoice.Library.Models;
using RaiseMyVoice.Library.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace RaiseMyVoice.Web.Controllers
{
    public abstract class BaseController<IRepo, T> : Controller
        where IRepo : IBaseRepository<T>
        where T : BaseEntity
    {
        protected readonly ILogger<BaseController<IRepo, T>> Logger; 
        protected readonly IRepo Repository;
        protected readonly UserManager<AccountUser> UserManager;

        public BaseController(
            IRepo repository,
            ILogger<BaseController<IRepo, T>> logger,
            UserManager<AccountUser> userManager)
        {
            Repository = repository;
            Logger = logger;
            UserManager = userManager;
        }

        [HttpGet]
        public virtual JsonResult All()
        {
            var model = Repository.GetAll();
            return Json(model);
        }

        public virtual IActionResult Index(int? id)
        {
            var model = id == null ? Repository.GetAll() : Repository.Find(o => o.Id == id.Value);
            return View(model);
        }

        public virtual IActionResult Detail(int? id)
        {
            if (id == null) return View();          
            var model = Repository.Single(id.Value);
            return View(model);
        }

        [HttpPost]
        public virtual IActionResult Detail(T entity)
        {
            Repository.Update(entity);
            Repository.Save();
            return RedirectToAction("Index");
        }

        public virtual IActionResult Delete(int? id)
        {
            if (id != null)
            {
                Repository.Delete(id.Value);
                Repository.Save();
            }
            return RedirectToAction("Index");
        }
    }
}
