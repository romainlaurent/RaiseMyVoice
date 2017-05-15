using System.Linq;
using Microsoft.Extensions.Logging;
using RaiseMyVoice.Library.Data;
using RaiseMyVoice.Library.Models;
using RaiseMyVoice.Library.Repositories.Interfaces;

namespace RaiseMyVoice.Library.Repositories.Implementation
{
    public class PersonRepository : BaseContextRepository<Person>, IPersonRepository
    {
        public PersonRepository(
            ILogger<PersonRepository> logger,
            ApplicationDbContext context) : base(logger, context)
        {
            Logger.LogWarning("PersonRepository was newed");
        }

        public override IQueryable<Person> EntityCollection
            => Context.PersonCollection.AsQueryable();

        public override IQueryable<Person> Includes(IQueryable<Person> queryable)
        {
            queryable = base.Includes(queryable);
            return queryable;
        }
    }
}