using Financas.DAO;
using Financas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Financas.Controllers
{
    public class UsuarioController : Controller
    {
        private UsuarioDAO dao;
        public UsuarioController(UsuarioDAO dao)
        {
            this.dao = dao;
        }
        // GET: Usuario
        public ActionResult Form()
        {
            return View();
        }

        public ActionResult Adiciona(Usuario usuario)
        {
            if (!ModelState.IsValid)
                return View("Form", usuario);

            dao.Adiciona(usuario);
            return RedirectToAction("Index");
        }

        public ActionResult Index()
        {
            IList<Usuario> usuarios = dao.Lista();
            return View(usuarios);
        }
    }
}