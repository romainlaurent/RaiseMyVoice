using System;
using System.Linq;
using Microsoft.Extensions.Logging;
using RaiseMyVoice.Library.Models;
using RaiseMyVoice.Library.Repositories.Interfaces;

namespace RaiseMyVoice.Library.Repositories.MockImplementation
{
    public class MockModuleRepository :
        BaseRepository<Module>, IModuleRepository
    {
        public MockModuleRepository(ILogger<MockModuleRepository> logger)
            : base(logger)
        {
            Logger.LogWarning("MockModuleRepository was newed");
        }

        public override IQueryable<Module> EntityCollection
        {
            get
            {
                #region 5 Module random

                var p1 = new Module()
                {
                    Id = 1,
                    Location = "ici"
                };
                var p2 = new Module()
                {
                    Id = 2,
                    Location = "la-bas"
                };
                var p3 = new Module()
                {
                    Id = 3,
                    Location = "ici et la-bas"
                };
                var p4 = new Module()
                {
                    Id = 4,
                    Location = "coucou"
                };
                var p5 = new Module()
                {
                    Id = 5,
                    Location = "coucou"
                };
                #endregion
                return (new[] { p1, p2, p3, p4, p5 })
                    .AsQueryable();
            }
        }

        public override void Update(Module entity)
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