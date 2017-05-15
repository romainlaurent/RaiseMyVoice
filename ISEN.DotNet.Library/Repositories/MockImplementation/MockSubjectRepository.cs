using System;
using System.Linq;
using Microsoft.Extensions.Logging;
using RaiseMyVoice.Library.Models;
using RaiseMyVoice.Library.Repositories.Interfaces;

namespace RaiseMyVoice.Library.Repositories.MockImplementation
{
    public class MockSubjectRepository :
        BaseRepository<Subject>, ISubjectRepository
    {
        public MockSubjectRepository(ILogger<MockSubjectRepository> logger)
            : base(logger)
        {
            Logger.LogWarning("MockSubjectRepository was newed");
        }

        public override IQueryable<Subject> EntityCollection
        {
            get
            {
                #region 5 Subjectnes random
                var p1 = new Subject()
                {
                    Id = 1,
                    Name = "Politique"
                };
                var p2 = new Subject()
                {
                    Id = 2,
                    Name = "Danse"
                };
                var p3 = new Subject()
                {
                    Id = 3,
                    Name = "Art"
                };
                var p4 = new Subject()
                {
                    Id = 4,
                    Name = "Loisir"
                };
                var p5 = new Subject()
                {
                    Id = 5,
                    Name = "Concert"
                };
                #endregion
                return (new[] { p1, p2, p3, p4, p5 })
                    .AsQueryable();
            }
        }

        public override void Update(Subject entity)
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