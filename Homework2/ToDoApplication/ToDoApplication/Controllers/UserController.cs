using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoApplication.Models.DomainModels;
using Type = ToDoApplication.Models.DomainModels.Type;

namespace ToDoApplication.Controllers
{
    [Route("User/[action]")]
    public class UserController : Controller
    {
        private List<User> _usersDb;
        private List<Tasks> _tasksDb;


        public UserController()
        {
            _usersDb = new List<User>()
            {
                new User()
                {
                FirstName = "Katerina",
                LastName = "Jangelovska",
                Age = 25,
                AverageFreeTime = 6,
                ToDoTasks = _tasksDb
                },
                new User()
                {
                FirstName = "Petko",
                LastName = "Petkovski",
                Age = 30,
                AverageFreeTime = 8,
                ToDoTasks = _tasksDb
                },

            };

            _tasksDb = new List<Tasks>()
            {
                new Tasks
                {
                    Title = "Fitness",
                    Descripton = "Leg day",
                    Importance = Importance.mediumImportance,
                    Status = Status.NotDone,
                    Type = Type.Hobby,

                },

                new Tasks
                {
                    Title = "sedcHomewrok",
                    Descripton = "ToDoApp",
                    Importance = Importance.Important,
                    Status = Status.Done,
                    Type = Type.Personal,

                }
            };
        }


        public IActionResult Index()
        {
            return View();
        }
        public IActionResult InProgress()
        {
            return View();
        }

        public IActionResult NotDone()
        {
            User katerina = _usersDb[0];
            return View(katerina);
        }

        public IActionResult Done()
        {
            return View();
        }
        public IActionResult Statistics()
        {
            return View();
        }
    }
}