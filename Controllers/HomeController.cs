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
                    QuestionText = "Which EF Core component is primarily responsible for communicating with the database?",
                    Answer = "DbContext."
                },

                new Question
                {
                    Number = 5,
                    QuestionText = "What does the following command primarily do? dotnet ef dbcontext scaffold \"ConnectionString\" Microsoft.EntityFrameworkCore.SqlServer -o Models",
                    Answer = "Generates EF Core models and a DbContext from an existing database."
                },

                new Question
                {
                    Number = 6,
                    QuestionText = "Where is a database connection string commonly stored in an ASP.NET Core MVC application?",
                    Answer = "appsettings.json."
                },

                new Question
                {
                    Number = 7,
                    QuestionText = "A Student belongs to exactly one Section, while a Section can contain many students. What type of relationship is this?",
                    Answer = "One-to-Many."
                },

                new Question
                {
                    Number = 8,
                    QuestionText = "In the following example, what is SectionId? public int SectionId { get; set; } public Section Section { get; set; }",
                    Answer = "Foreign key referencing Section."
                },

                new Question
                {
                    Number = 9,
                    QuestionText = "What is the purpose of a navigation property such as public Section Section { get; set; }?",
                    Answer = "It represents a relationship to another entity."
                },

                new Question
                {
                    Number = 10,
                    QuestionText = "What does .Include() generally allow Entity Framework Core to do?",
                    Answer = "Load related Section data together with Students."
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