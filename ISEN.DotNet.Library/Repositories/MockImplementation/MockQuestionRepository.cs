using System;
using System.Linq;
using Microsoft.Extensions.Logging;
using RaiseMyVoice.Library.Models;
using RaiseMyVoice.Library.Repositories.Interfaces;

namespace RaiseMyVoice.Library.Repositories.MockImplementation
{
    public class MockQuestionRepository :
        BaseRepository<Question>, IQuestionRepository
    {
        public MockQuestionRepository(ILogger<MockQuestionRepository> logger)
            : base(logger)
        {
            Logger.LogWarning("MockQuestionRepository was newed");
        }

        public override IQueryable<Question> EntityCollection
        {
            get
            {
                #region 5 Questions random
                var q1 = new Question()
                {
                    Id = 1,
                    Name = "Commant va?"
                };
                var q2 = new Question()
                {
                    Id = 2,
                    Name = "Es-ce qu'il fait beau?"
                };
                var q3 = new Question()
                {
                    Id = 3,
                    Name = "Rouge ou vert?"
                };
                var q4 = new Question()
                {
                    Id = 4,
                    Name = "0 ou 1?"
                };
                var q5 = new Question()
                {
                    Id = 5,
                    Name = "T'as vu ça?"
                };
                #endregion
                return (new[] { q1, q2, q3, q4, q5 })
                    .AsQueryable();
            }
        }

        public override void Update(Question entity)
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