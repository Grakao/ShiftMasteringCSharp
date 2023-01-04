using Fiap.Web.AspNet4.Data;
using Fiap.Web.AspNet4.Models;
using Fiap.Web.AspNet4.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Fiap.Web.AspNet4.Controllers
{
	public class ClienteController : Controller
	{
		private readonly ClienteRepository clienteRepository;
		private readonly RepresentanteRepository representanteRepository;

		public ClienteController(DataContext dataContext)
		{
			clienteRepository = new ClienteRepository(dataContext);
			representanteRepository = new RepresentanteRepository(dataContext);
        }

		[HttpGet]
		public IActionResult Index()
		{
			//var listaClientes = clienteRepository.FindAllOrderByNomeDesc();
			//var listaClientes = clienteRepository.FindByNome("na");
			//var listaClientes = clienteRepository.FindByNomeAndEmail("na","@gmail.com");
			//var listaClientes = clienteRepository.FindByNomeAndEmailAndRep("na", "@gmail.com",0);
			//var listaClientes = clienteRepository.FindByNomeAndEmailAndRep("", null ,0);

			ComboRepresentantes();

			return View(new List<ClienteModel>());
		}

		[HttpPost]
		public IActionResult Pesquisar(string NomePesquisa, string EmailPesquisa, int RepresentanteId)
		{
			var listaClientes = clienteRepository.FindByNomeAndEmailAndRep(NomePesquisa, EmailPesquisa, RepresentanteId);
			return View("Index", listaClientes);
		}

		[HttpGet]
		public IActionResult Novo()
		{
			ComboRepresentantes();

			return View(new ClienteModel());
			//return Content("Fiap ASP.NET 4");
			//return RedirectToAction("Index");
		}

		[HttpPost]
		public IActionResult Novo(ClienteModel clienteModel)
		{	
			if (ModelState.IsValid)
			{
				clienteRepository.Insert(clienteModel);
				TempData["Mensagem"] = "Cliente cadastrado com sucesso!";

				//return View("Sucesso");
				return RedirectToAction("Index");
			}
			else
			{
				ComboRepresentantes();

				return View(clienteModel);
			}
		}

		[HttpGet]
		public IActionResult Editar(int id)
		{
            ComboRepresentantes();
            //Forma 1
            //var listaRepresentantes = representanteRepository.FindAll();
            //var selectListRepresentantes = new SelectList(listaRepresentantes, "RepresentanteId", "NomeRepresentante");
            //ViewBag.Representantes = selectListRepresentantes;

            //Forma 2
            //ViewBag.Representantes = new SelectList(representanteRepository.FindAll(), "RepresentanteId", "NomeRepresentante");

            var clienteModel = clienteRepository.FindById(id);

            //var listaRepresentantes = representanteRepository.FindAll();
            //ViewBag.Representantes = listaRepresentantes;

            return View(clienteModel);
		}

		[HttpPost]
		public IActionResult Editar(ClienteModel clienteModel)
		{
			if (ModelState.IsValid)
			{
				clienteRepository.Update(clienteModel);

				TempData["Mensagem"] = "Cliente alterado com sucesso!";
				return RedirectToAction("Index");
			}
			else
			{
                ComboRepresentantes();

                // Forma 1
                //var listaRepresentantes = representanteRepository.FindAll();
                //var selectListRepresentantes = new SelectList(listaRepresentantes, "RepresentanteId", "NomeRepresentante");
                //ViewBag.Representantes = selectListRepresentantes;

                // Forma 2
                //ViewBag.Representantes = new SelectList(representanteRepository.FindAll(), "RepresentanteId", "NomeRepresentante");

                return View(clienteModel);
			}
		}

		[HttpGet]
		public IActionResult Remover(int id)
		{
			TempData["Mensagem"] = "Cliente removido com sucesso!";

			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult Detalhe(int id)
		{
			var clienteModel = clienteRepository.FindById(id);
			return View(clienteModel);
		}

        private void ComboRepresentantes()
        {
            var listaRepresentantes = representanteRepository.FindAll();
            var selectListRepresentantes = new SelectList(listaRepresentantes, "RepresentanteId", "NomeRepresentante");
            ViewBag.representantes = selectListRepresentantes;
        }
    }
}
