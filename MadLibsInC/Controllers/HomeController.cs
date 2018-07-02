using Microsoft.AspNetCore.Mvc;
using MadLibsInC.Models;

namespace MadLibsInC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Form()
        {
          return View();
        }

        [HttpGet("/madlib")]
        public ActionResult MadLib()
        {
            MadLibWords newMadLibWords = new MadLibWords();
            newMadLibWords.SetNameOne(Request.Query["first-name"]);
            newMadLibWords.SetLocationOne(Request.Query["first-location"]);
            newMadLibWords.SetAnimalOne(Request.Query["first-animal"]);
            newMadLibWords.SetVerbOne(Request.Query["first-verb"]);
            newMadLibWords.SetVerbTwo(Request.Query["second-verb"]);
            return View("MadLib", newMadLibWords);
        }
    }
}
