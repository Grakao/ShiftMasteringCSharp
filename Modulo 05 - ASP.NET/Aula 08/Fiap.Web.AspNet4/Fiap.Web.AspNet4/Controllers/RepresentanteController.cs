using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Fiap.Web.AspNet4.Data;
using Fiap.Web.AspNet4.Models;
using Fiap.Web.AspNet4.Repository.Interface;

namespace Fiap.Web.AspNet4.Controllers
{
	public class RepresentanteController : Controller
	{
        private readonly IRepresentanteRepository representanteRepository;

        public RepresentanteController(IRepresentanteRepository _representanteRepository)
        {
            representanteRepository = _representanteRepository;
        }

        // GET: RepresentanteModel
        public IActionResult Index()
		{
			return View(representanteRepository.FindAll());
		}

		// GET: RepresentanteModel/Details/5
		public IActionResult Details(int id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var representanteModel = representanteRepository.FindById(id);

			if (representanteModel == null)
			{
				return NotFound();
			}

			return View(representanteModel);
		}

		// GET: RepresentanteModel/Create
		public IActionResult Create()
		{
			return View();
		}

		// POST: RepresentanteModel/Create
		// To protect from overposting attacks, enable the specific properties you want to bind to.
		// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create([Bind("RepresentanteId,NomeRepresentante")] RepresentanteModel representanteModel)
		{
			if (ModelState.IsValid)
			{
				representanteRepository.Insert(representanteModel);
				return RedirectToAction(nameof(Index));
			}
			return View(representanteModel);
		}

		// GET: RepresentanteModel/Edit/5
		public IActionResult Edit(int id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var representanteModel = representanteRepository.FindById(id);
			representanteRepository.Update(representanteModel);

			if (representanteModel == null)
			{
				return NotFound();
			}
			return View(representanteModel);
		}

		// POST: RepresentanteModel/Edit/5
		// To protect from overposting attacks, enable the specific properties you want to bind to.
		// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Edit(int id, [Bind("RepresentanteId,NomeRepresentante")] RepresentanteModel representanteModel)
		{
			if (id != representanteModel.RepresentanteId)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
                    representanteRepository.Update(representanteModel);
                }
				catch (DbUpdateConcurrencyException)
				{
					throw;
				}
				return RedirectToAction(nameof(Index));
			}
			return View(representanteModel);
		}

		// GET: RepresentanteModel/Delete/5
		public IActionResult Delete(int id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var representanteModel = representanteRepository.FindById(id);

			if (representanteModel == null)
			{
				return NotFound();
			}

			return View(representanteModel);
		}

		// POST: RepresentanteModel/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public IActionResult DeleteConfirmed(int id)
		{
			representanteRepository.Delete(id);
			return RedirectToAction(nameof(Index));
		}	
	}
}
