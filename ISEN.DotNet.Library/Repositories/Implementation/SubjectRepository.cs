using System.Linq;
using Microsoft.Extensions.Logging;
using RaiseMyVoice.Library.Data;
using RaiseMyVoice.Library.Models;
using RaiseMyVoice.Library.Repositories.Interfaces;

namespace RaiseMyVoice.Library.Repositories.Implementation
{
    public class SubjectRepository : BaseContextRepository<Subject>, ISubjectRepository
    {
        public SubjectRepository(
            ILogger<SubjectRepository> logger,
            ApplicationDbContext context) : base(logger, context)
        {
            Logger.LogWarning("SubjectRepository was newed");
        }

        public override IQueryable<Subject> EntityCollection
            => Context.SubjectCollection.AsQueryable();

        public override IQueryable<Subject> Includes(IQueryable<Subject> queryable)
        {
            queryable = base.Includes(queryable);
            return queryable;
        }
    }
}