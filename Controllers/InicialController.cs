using System;
using System.Collections.Generic;
using ExemploSCM.Models;
using ExemploSCM.Util;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


namespace ExemploSCM.Controllers
{
    public class InicialController : Controller
    {
        // GET: /
        public ActionResult Index()
        {
            //ViewBag.Mercadorias = getMercadorias();
            //ViewBag.PontosGrafico = JsonConvert.SerializeObject(getPontos());
            ViewData["Mercadorias"] = new List<Mercadoria>();
            return View();
        }

        [HttpPost]
        public ActionResult gerarGrafico(int mercadoria, int mes, int ano)
        {
            return RedirectToAction("Index", "Inicial");
        }

        public List<PontosGrafico> agruparEntrardas(List<Entrada> entradas)
        {
            List<PontosGrafico> pontos = new List<PontosGrafico>();

            return pontos;
        }
    }
}