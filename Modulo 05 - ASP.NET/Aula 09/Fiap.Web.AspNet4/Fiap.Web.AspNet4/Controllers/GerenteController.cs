using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Fiap.Web.AspNet4.Data;
using Fiap.Web.AspNet4.Models;
using Fiap.Web.AspNet4.Repository;
using Fiap.Web.AspNet4.Repository.Interface;

namespace Fiap.Web.AspNet4.Controllers
{
    public class GerenteController : Controller
    {
        private readonly IGerenteRepository gerenteRepository;

        public GerenteController(IGerenteRepository _gerenteRepository)
        {
            gerenteRepository = _gerenteRepository;
        }

        // GET: Gerente
        public IActionResult Index()
        {
              return View(gerenteRepository.FindAll());
        }

        // GET: Gerente/Details/5
        public IActionResult Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gerenteModel = gerenteRepository.FindById(id);

            if (gerenteModel == null)
            {
                return NotFound();
            }

            return View(gerenteModel);
        }

        // GET: Gerente/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Gerente/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("GerenteId,Nome,Sobrenome")] GerenteModel gerenteModel)
        {
            if (ModelState.IsValid)
            {
                gerenteRepository.Insert(gerenteModel);
                return RedirectToAction(nameof(Index));
            }
            return View(gerenteModel);
        }

        // GET: Gerente/Edit/5
        public IActionResult Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gerenteModel = gerenteRepository.FindById(id);
            gerenteRepository.Update(gerenteModel);

            if (gerenteModel == null)
            {
                return NotFound();
            }
            return View(gerenteModel);
        }

        // POST: Gerente/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("GerenteId,Nome,Sobrenome")] GerenteModel gerenteModel)
        {
            if (id != gerenteModel.GerenteId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    gerenteRepository.Update(gerenteModel);
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(gerenteModel);
        }

        // GET: Gerente/Delete/5
        public IActionResult Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gerenteModel = gerenteRepository.FindById(id);

            if (gerenteModel == null)
            {
                return NotFound();
            }

            return View(gerenteModel);
        }

        // POST: Gerente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            gerenteRepository.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
