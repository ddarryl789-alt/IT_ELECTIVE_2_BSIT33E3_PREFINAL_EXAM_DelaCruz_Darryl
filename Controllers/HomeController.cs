using IT_ELECTIVE_2_BSIT33E3_PREFINAL_EXAM_DelaCruz_Darryl.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_2_BSIT33E3_PREFINAL_EXAM_DelaCruz_Darryl.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var questions = new List<Question>
            {
                new Question
                {
                    Number = 1,
                    QuestionText = "What is the main problem solved by using a database instead of an in-memory collection?",
                    Answer = "It allows data to persist after the application stops."
                },

                new Question
                {
                    Number = 2,
                    QuestionText = "Which approach is being used when an existing database is used to generate EF Core entity classes?",
                    Answer = "Database-First."
                },

                new Question
                {
                    Number = 3,
                    QuestionText = "What is the primary purpose of Entity Framework Core?",
                    Answer = "To map objects in code to relational database data."
                },

                new Question
                {
                    Number = 4,
                    QuestionText = "What component in Entity Framework Core communicates with the database?",
                    Answer = "DbContext."
                },

                new Question
                {
                    Number = 5,
                    QuestionText = "What command generates EF Core models and DbContext from an existing database?",
                    Answer = "dotnet ef dbcontext scaffold \"ConnectionString\" Microsoft.EntityFrameworkCore.SqlServer -o Models"
                }
            };

            return View(questions);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}