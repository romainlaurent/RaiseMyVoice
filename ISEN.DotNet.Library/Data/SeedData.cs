using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RaiseMyVoice.Library.Models;
using RaiseMyVoice.Library.Repositories.Interfaces;

namespace RaiseMyVoice.Library.Data
{
    public class SeedData
    {
        private readonly UserManager<AccountUser> _userManager;
        private readonly RoleManager<AccountRole> _roleManager;
        private readonly ApplicationDbContext _context;
        private readonly IPersonRepository _personRepository;
        private readonly IModuleRepository _moduleRepository;
        private readonly IQuestionRepository _questionRepository;
        private readonly IAnswerRepository _answerRepository;
        private readonly ISubjectRepository _subjectRepository;
        private readonly ILogger<SeedData> _logger;

        public SeedData(
            ApplicationDbContext context,
            UserManager<AccountUser> userManager,
            IPersonRepository personRepository,
            IModuleRepository moduleRepository,
            IQuestionRepository questionRepository,
            IAnswerRepository answerRepository,
            ISubjectRepository subjectRepository,
            ILogger<SeedData> logger, RoleManager<AccountRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _personRepository = personRepository;
            _moduleRepository = moduleRepository;
            _questionRepository = questionRepository;
            _answerRepository = answerRepository;
            _subjectRepository = subjectRepository;
            _logger = logger;
            _roleManager = roleManager;
        }

        public void DropCreateDatabase()
        {
            var deleted = _context.Database.EnsureDeleted();
            var deletedString = deleted ? "dropped" : "not dropped";
            _logger.LogWarning($"Database was {deletedString}");

            var created = _context.Database.EnsureCreated();
            var createdString = deleted ? "created" : "not created";
            _logger.LogWarning($"Database was {createdString}");
        }

        public async void AddAdminAndRole()
        {
            var roleExist = await _roleManager.RoleExistsAsync("Admin");            
            if (!roleExist)
            {                
                var r1 = await _roleManager.CreateAsync(new AccountRole { Name = "Admin" });
                var r2 = await _roleManager.CreateAsync(new AccountRole { Name = "User" });
                var r3 = await _roleManager.CreateAsync(new AccountRole { Name = "Module" });
                const string mail = "admin@admin.fr";
                var user = new AccountUser {UserName = mail, Email = mail};
                var result = await _userManager.CreateAsync(user,
                    "Admin123!");
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "Admin");
                    _logger.LogWarning("Admin user has been created");
                }
            }
        }

        public void AddSubjects()
        {
            if (_subjectRepository.GetAll().Any()) return;
            _logger.LogWarning("Adding subjects");
            var s1 = new Subject()
            {
                Name = "Politique"
            };
            var s2 = new Subject()
            {
                Name = "Sport"
            };
            var s3 = new Subject()
            {
                Name = "Concert"
            };
            var s4 = new Subject()
            {
                Name = "Art"
            };
            _subjectRepository.UpdateRange(s1, s2, s3, s4);
            _subjectRepository.Save();
            _logger.LogWarning("Added subjects");
        }

//        public void AddUsers()
//        {
//            if (_userRepository.GetAll().Any()) return;
//
//            var marseille = _cityRepository.Single("Marseille");
//            var toulon = _cityRepository.Single("Toulon");
//            var lyon = _cityRepository.Single("Lyon");
//            var torino = _cityRepository.Single("Torino");
//
//            _logger.LogWarning("Adding Users");
//
//#region 5 Usernes random
//            var p1 = new User()
//            {
//                LastName = "GUQUET",
//                FirstName = "Calendau",
//                BirthDate = new DateTime(1980,2,28),
//                City = toulon
//            };    
//            var p2 = new User()
//            {
//                LastName = "SNOW",
//                FirstName = "Jon"
//            };
//            var p3 = new User()
//            {
//                LastName = "REAL",
//                FirstName = "Jon"
//            };
//            var p4 = new User()
//            {
//                BirthDate = new DateTime(1950,7,8),
//                LastName = "FOO",
//                FirstName = "Jack"
//            };
//            var p5 = new User()
//            {
//                BirthDate = new DateTime(1950,9,12),
//                LastName = "BAR",
//                FirstName = "James"
//            };
//#endregion
//
//            _userRepository.UpdateRange(p1, p2, p3, p4, p5);
//            _userRepository.Save();
//
//            _logger.LogWarning("Added Users");
//        }
    }
}