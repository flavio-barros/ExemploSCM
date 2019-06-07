using ExemploSCM.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExemploSCM.Controllers
{
    public class SaidaController : Controller
    {
        // GET: Saida
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Saida saida)
        { 
            return RedirectToAction("Index", saida);
        }
    }
}