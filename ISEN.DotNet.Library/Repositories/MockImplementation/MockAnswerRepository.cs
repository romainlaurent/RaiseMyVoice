using System;
using System.Linq;
using Microsoft.Extensions.Logging;
using RaiseMyVoice.Library.Models;
using RaiseMyVoice.Library.Repositories.Interfaces;

namespace RaiseMyVoice.Library.Repositories.MockImplementation
{
    public class MockAnswerRepository :
        BaseRepository<Answer>, IAnswerRepository
    {
        public MockAnswerRepository(ILogger<MockAnswerRepository> logger)
            : base(logger)
        {
            Logger.LogWarning("MockAnswerRepository was newed");
        }

        public override IQueryable<Answer> EntityCollection
        {
            get
            {
                #region 5 Answers random
                var a1 = new Answer()
                {
                    Id = 1,
                    Value = true
                };
                var a2 = new Answer()
                {
                    Id = 2,
                    Value = true
                };
                var a3 = new Answer()
                {
                    Id = 3,
                    Value = false
                };
                var a4 = new Answer()
                {
                    Id = 4,
                    Value = false
                };
                var a5 = new Answer()
                {
                    Id = 5,
                    Value = true
                };
                #endregion
                return (new[] { a1, a2, a3, a4, a5 })
                    .AsQueryable();
            }
        }

        public override void Update(Answer entity)
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