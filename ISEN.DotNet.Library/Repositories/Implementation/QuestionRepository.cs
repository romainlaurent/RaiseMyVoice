using System.Linq;
using Microsoft.Extensions.Logging;
using RaiseMyVoice.Library.Data;
using RaiseMyVoice.Library.Models;
using RaiseMyVoice.Library.Repositories.Interfaces;

namespace RaiseMyVoice.Library.Repositories.Implementation
{
    public class QuestionRepository : BaseContextRepository<Question>, IQuestionRepository
    {
        public QuestionRepository(
            ILogger<QuestionRepository> logger,
            ApplicationDbContext context) : base(logger, context)
        {
            Logger.LogWarning("QuestionRepository was newed");
        }

        public override IQueryable<Question> EntityCollection
            => Context.QuestionCollection.AsQueryable();

        public override IQueryable<Question> Includes(IQueryable<Question> queryable)
        {
            queryable = base.Includes(queryable);
            return queryable;
        }
    }
}