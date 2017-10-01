using Fiap.Exemplo03.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo03.Web.MVC.Controllers
{
    public class ApostaController : Controller
    {
        private LoteriaContext _context = new LoteriaContext();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Aposta aposta)
        {
            _context.Apostas.Add(aposta);
            _context.SaveChanges();
            TempData["msg"] = "Cadastrado!";
            return RedirectToAction("Cadastrar");
        }
    }
}