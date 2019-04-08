using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebCoreDDD.Controllers
{
    public class ProdutoWebController : Controller
    {
        private readonly InterfaceAppProduto AppProduto;

        public ProdutoWebController(InterfaceAppProduto _AppProduto)
        {
            AppProduto = _AppProduto;
        }
        // GET: ProdutoWeb
        public ActionResult Index()
        {
            return View(AppProduto.Listar());
        }

        // GET: ProdutoWeb/Details/5
        public ActionResult Details(int id)
        {
            return View(AppProduto.ObterPorId(id));
        }

        // GET: ProdutoWeb/Create
        public ActionResult Create()
        {
            return View(new Produto());
        }

        // POST: ProdutoWeb/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Produto collection)
        {
            try
            {
                // TODO: Add insert logic here
                AppProduto.Adcionar(collection);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProdutoWeb/Edit/5
        public ActionResult Edit(int id)
        {
            return View(AppProduto.ObterPorId(id));
        }

        // POST: ProdutoWeb/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Produto collection)
        {
            try
            {
                // TODO: Add update logic here
                AppProduto.Atualizar(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProdutoWeb/Delete/5
        public ActionResult Delete(int id)
        {
            return View(AppProduto.ObterPorId(id));
        }

        // POST: ProdutoWeb/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Produto collection)
        {
            try
            {
                // TODO: Add delete logic here
                AppProduto.Excluir(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}