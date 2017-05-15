using System.Linq;
using Microsoft.Extensions.Logging;
using RaiseMyVoice.Library.Data;
using RaiseMyVoice.Library.Models;
using RaiseMyVoice.Library.Repositories.Interfaces;

namespace RaiseMyVoice.Library.Repositories.Implementation
{
    public class UserRepository : BaseContextRepository<User>, IUserRepository
    {        
        public UserRepository(
            ILogger<UserRepository> logger,
            ApplicationDbContext context) : base(logger, context)
        {
            Logger.LogWarning("UserRepository was newed");
        }

        public override IQueryable<User> EntityCollection
            => Context.UserCollection.AsQueryable();

        public override IQueryable<User> Includes(IQueryable<User> queryable)
        {
            queryable = base.Includes(queryable);
            return queryable;
        }
    }
}