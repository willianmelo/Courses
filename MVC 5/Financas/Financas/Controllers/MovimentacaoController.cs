using Financas.DAO;
using Financas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Financas.Controllers
{
    public class MovimentacaoController : Controller
    {
        MovimentacaoDAO movDAO;
        UsuarioDAO usuDAO;
        public MovimentacaoController(MovimentacaoDAO movDAO, UsuarioDAO usuDAO)
        {
            this.movDAO = movDAO;
            this.usuDAO = usuDAO;
        }
        // GET: Movimentacao
        public ActionResult Form()
        {
            ViewBag.Usuarios = usuDAO.Lista();
            return View();
        }

        public ActionResult Adiciona(Movimentacao movimentacao)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Usuarios = usuDAO.Lista();
                return View("Form", movimentacao);
            }

            movDAO.Adiciona(movimentacao);
            return RedirectToAction("Index");
        }

        public ActionResult Index()
        {
            IList<Movimentacao> movimentacoes = movDAO.Lista();
            return View(movimentacoes);
        }
    }
}