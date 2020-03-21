using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PosInfnetCidadesInteligentesDDD.Aplicacao.Interfaces;
using PosInfnetCidadesInteligentesDDD.Dominio.Entidades;

namespace PosInfnetCidadesInteligentesDDD.Controllers
{
    public class EstacaoRecargaMVCController : Controller
    {
        private readonly IEstacaoRecargaApp _estacaoRecargaApp;

        public EstacaoRecargaMVCController(IEstacaoRecargaApp estacaoRecargaApp)
        {
            _estacaoRecargaApp = estacaoRecargaApp;
        }

        // GET: EstacaoRecargaMVC
        public ActionResult Index()
        {
            return View(_estacaoRecargaApp.Listar());
        }

        // GET: EstacaoRecargaMVC/Details/5
        public ActionResult Details(Guid id)
        {
            return View(_estacaoRecargaApp.RecuperarPorId(id));
        }

        // GET: EstacaoRecargaMVC/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EstacaoRecargaMVC/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EstacaoRecarga estacaoRecarga)
        {
            try
            {
                estacaoRecarga.Id = Guid.NewGuid();
                _estacaoRecargaApp.Adicionar(estacaoRecarga);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return View();
            }
        }

        // GET: EstacaoRecargaMVC/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View(_estacaoRecargaApp.RecuperarPorId(id));
        }

        // POST: EstacaoRecargaMVC/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EstacaoRecarga estacaoRecarga)
        {
            try
            {
                // TODO: Add update logic here
                _estacaoRecargaApp.Atualizar(estacaoRecarga);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EstacaoRecargaMVC/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View(_estacaoRecargaApp.RecuperarPorId(id));
        }

        // POST: EstacaoRecargaMVC/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(EstacaoRecarga estacaoRecarga)
        {
            try
            {
                // TODO: Add delete logic here
                _estacaoRecargaApp.Excluir(estacaoRecarga);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}