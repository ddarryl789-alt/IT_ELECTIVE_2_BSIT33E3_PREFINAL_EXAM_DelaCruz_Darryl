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