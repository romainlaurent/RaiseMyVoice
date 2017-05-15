using System.Linq;
using Microsoft.Extensions.Logging;
using RaiseMyVoice.Library.Data;
using RaiseMyVoice.Library.Models;
using RaiseMyVoice.Library.Repositories.Interfaces;

namespace RaiseMyVoice.Library.Repositories.Implementation
{
    public class AnswerRepository : BaseContextRepository<Answer>, IAnswerRepository
    {
        public AnswerRepository(
            ILogger<AnswerRepository> logger,
            ApplicationDbContext context) : base(logger, context)
        {
            Logger.LogWarning("AnswerRepository was newed");
        }

        public override IQueryable<Answer> EntityCollection
            => Context.AnswerCollection.AsQueryable();

        public override IQueryable<Answer> Includes(IQueryable<Answer> queryable)
        {
            queryable = base.Includes(queryable);
            return queryable;
        }
    }
}