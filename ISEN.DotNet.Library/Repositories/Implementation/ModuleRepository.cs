using System.Linq;
using Microsoft.Extensions.Logging;
using RaiseMyVoice.Library.Data;
using RaiseMyVoice.Library.Models;
using RaiseMyVoice.Library.Repositories.Interfaces;

namespace RaiseMyVoice.Library.Repositories.Implementation
{
    public class ModuleRepository : BaseContextRepository<Module>, IModuleRepository
    {
        public ModuleRepository(
            ILogger<ModuleRepository> logger,
            ApplicationDbContext context) : base(logger, context)
        {
            Logger.LogWarning("ModuleRepository was newed");
        }

        public override IQueryable<Module> EntityCollection
            => Context.ModuleCollection.AsQueryable();

        public override IQueryable<Module> Includes(IQueryable<Module> queryable)
        {
            queryable = base.Includes(queryable);
            return queryable;
        }
    }
}