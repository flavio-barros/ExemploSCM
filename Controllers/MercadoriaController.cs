using ExemploSCM.Dao;
using ExemploSCM.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ExemploSCM.Controllers
{
    public class MercadoriaController : Controller
    {

        IRepository<Mercadoria> mercadoriaRepository = new MercadoriaRepository<Mercadoria>();

        // GET: Mercadoria
        public ActionResult Index()
        {
            List<Mercadoria> mercadorias = mercadoriaRepository.Listar();

            return View(mercadorias);
        }

        // GET: Mercadoria/Cadastrar
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Mercadoria mercadoria)
        {
            mercadoriaRepository.Salvar(mercadoria);
            return RedirectToAction("Index");
        }

        // GET: Mercadoria/Editar/5
        public ActionResult Editar(int id)
        {
            Mercadoria mercadoria = mercadoriaRepository.Recuperar(id);
            return View(mercadoria);
        }

        [HttpPost]
        public ActionResult Editar(Mercadoria mercadoria)
        {
            mercadoriaRepository.Editar(mercadoria);
            return RedirectToAction("Index");
        }


        // GET: Mercadoria/Remover/5
        public ActionResult Remover(int id)
        {
            Mercadoria mercadoria = mercadoriaRepository.Recuperar(id);
            mercadoriaRepository.Remover(mercadoria);
            return RedirectToAction("Index");
        }
    }
}
