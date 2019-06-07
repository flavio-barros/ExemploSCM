using ExemploSCM.Dao;
using ExemploSCM.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExemploSCM.Controllers
{
    public class EntradaController : Controller
    {

        private IRepository<Entrada> entradaRepository = new EntradaRepository<Entrada>();
        private IRepository<Mercadoria> mercadoriaRepository = new MercadoriaRepository<Mercadoria>();

        // GET: Entrada
        public ActionResult Index()
        {
            ViewBag.Mercadorias = mercadoriaRepository.Listar();
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Entrada entrada)
        {
            Mercadoria mercadoriaRecuperada = mercadoriaRepository.Recuperar(entrada.Mercadoria.Id);
            entrada.Mercadoria = mercadoriaRecuperada;
            entradaRepository.Salvar(entrada);
            
            return RedirectToAction("Index", "Inicial");
        }
    }
}