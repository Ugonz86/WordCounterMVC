using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Home() { return View(); }

        [Route("/form")]
        public ActionResult Form() { return View(); }

        [Route("/result")]
        public ActionResult Result(string word, string sentence)
        {
            RepeatCounter myCounter = new RepeatCounter(word, sentence);
            return View(myCounter);

        } 
       


        
    }
}