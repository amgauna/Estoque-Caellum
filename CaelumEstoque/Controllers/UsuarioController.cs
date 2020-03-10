﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CaelumEstoque.Models;
using CaelumEstoque.DAO;

namespace CaelumEstoque.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult adicionaUsuario(Usuario usuario)
        {
            UsuariosDAO dao = new UsuariosDAO();
            dao.Adiciona(usuario);

         //   return RedirectToAction("Index");
            return RedirectToAction(Url.Action("", "Home", "Index"));

        }

        public ActionResult listaUsuario(Usuario usuario)
        {
            UsuariosDAO dao = new UsuariosDAO();
            IList<Usuario> usuarios = dao.Lista();

            return RedirectToAction("Form");
        }

    }
}