using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using RaiseMyVoice.Library.Models;

namespace RaiseMyVoice.Library.Data
{
    public class ApplicationDbContext : IdentityDbContext<AccountUser, AccountRole, int>
    {
        public DbSet<AccountUser> AccountUserCollection { get; set; }
        public DbSet<AccountRole> AccoutRoleCollection { get; set; }
        public DbSet<Module> ModuleCollection { get; set; }
        public DbSet<Question> QuestionCollection { get; set; }
        public DbSet<Subject> SubjectCollection { get; set; }
        public DbSet<Answer> AnswerCollection { get; set; }
        public DbSet<Person> PersonCollection { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("DataSource=.\\RaiseMyVoice.db");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
         
        }
    }

    public class TempDbContextFactory :
        IDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext Create(DbContextFactoryOptions options)
        {
            var dbContextBuilder = 
                new DbContextOptionsBuilder<ApplicationDbContext>();
            dbContextBuilder.UseSqlite("DataSource=.\\RaiseMyVoice.db");
            return new ApplicationDbContext(dbContextBuilder.Options);
        }
    }
}
