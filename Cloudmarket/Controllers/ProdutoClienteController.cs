﻿using Cloudmarket.Domain.Entities;
using Cloudmarket.Infra.Data.Contexto;
using Cloudmarket.Service;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace Cloudmarket.Web.Controllers
{
    [AllowAnonymous]
    public class ProdutoClienteController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private ProdutoService ps = new ProdutoService();

        // GET: ProdutoCliente
        public ActionResult Index()
        {
            return View(db.Produtos.ToList());
        }

        // GET: ProdutoCliente/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto produto = db.Produtos.Find(id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }

        // GET: Produto/GetProdutoByCodigo/
        public string GetProdutoByCodigo(string codigo)
        {
            var produto = ps.getProdutoByCodigo(codigo);
            var json = new JavaScriptSerializer().Serialize(produto);
            return json;
        }
    }
}