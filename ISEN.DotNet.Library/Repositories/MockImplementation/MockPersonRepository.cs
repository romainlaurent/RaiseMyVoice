using System;
using System.Linq;
using Microsoft.Extensions.Logging;
using RaiseMyVoice.Library.Models;
using RaiseMyVoice.Library.Repositories.Interfaces;

namespace RaiseMyVoice.Library.Repositories.MockImplementation
{
    public class MockPersonRepository :
        BaseRepository<Person>, IPersonRepository
    {
        public MockPersonRepository(ILogger<MockPersonRepository> logger)
            : base(logger)
        {
            Logger.LogWarning("MockPersonRepository was newed");
        }

        public override IQueryable<Person> EntityCollection
        {
            get
            {
                #region 5 Personnes random
                var p1 = new Person()
                {
                    Id = 1,
                    MacAddress = "00:5D:8C:90:1A:24"
                };
                var p2 = new Person()
                {
                    Id = 2,
                    MacAddress = "00:5D:8C:90:1A:24"
                };
                var p3 = new Person()
                {
                    Id = 3,
                    MacAddress = "00:5D:8C:90:1A:24"
                };
                var p4 = new Person()
                {
                    Id = 4,
                    MacAddress = "00:5D:8C:90:1A:24"
                };
                var p5 = new Person()
                {
                    Id = 5,
                    MacAddress = "00:5D:8C:90:1A:24"
                };
                #endregion
                return (new[] { p1, p2, p3, p4, p5 })
                    .AsQueryable();
            }
        }

        public override void Update(Person entity)
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