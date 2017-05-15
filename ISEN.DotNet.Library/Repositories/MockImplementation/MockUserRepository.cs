using System;
using System.Linq;
using Microsoft.Extensions.Logging;
using RaiseMyVoice.Library.Repositories.Interfaces;
using RaiseMyVoice.Library.Models;

namespace RaiseMyVoice.Library.Repositories.MockImplementation
{
    public class MockUserRepository :
        BaseRepository<User>, IUserRepository
    {        
        public MockUserRepository(ILogger<MockUserRepository> logger) 
            : base(logger)
        {
           Logger.LogWarning("MockUserRepository was newed");
        }

        public override IQueryable<User> EntityCollection
        {
            get
            {
#region 5 Users random
                var u1 = new User()
                {
                    Id = 1,
                    LastName = "GUQUET",
                    FirstName = "Calendau"
                };    
                var u2 = new User()
                {
                    Id = 2,
                    LastName = "SNOW",
                    FirstName = "Jon"
                };
                var u3 = new User()
                {
                    Id = 3,
                    LastName = "FAKE",
                    FirstName = "Jon"
                };
                var u4 = new User()
                {
                    Id = 4,
                    LastName = "FOO",
                    FirstName = "Jack"
                };
                var u5 = new User()
                {
                    Id = 5,
                    LastName = "BAR",
                    FirstName = "James"
                };
#endregion
                return (new [] {u1, u2, u3, u4, u5})
                    .AsQueryable();
            }
        } 

        public override void Update(User entity)
        {
            throw new Exception("U and D of CRUD are not supported in Mock implementation");
        }

        public override void Delete(int id)
        {
            throw new Exception("U and D of CRUD are not supported in Mock implementation");
        }

        public override void Save()
        {
            throw new Exception("U and D of CRUD are not supported in Mock implementation");
        }      
    }
}