using Microsoft.AspNetCore.Mvc;
using LeetSpeak.Models;

namespace LeetSpeak.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Route("/result")]
        public ActionResult Result()
        {
            Translator newPhrase = new Translator(Request.Query["phrase"]);
            newPhrase.ArrayReplace();
            return View(newPhrase);
        }
    }
}
