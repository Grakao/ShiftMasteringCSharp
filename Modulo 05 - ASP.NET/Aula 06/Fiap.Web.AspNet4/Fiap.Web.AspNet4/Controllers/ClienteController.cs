using Fiap.Web.AspNet4.Data;
using Fiap.Web.AspNet4.Models;
using Fiap.Web.AspNet4.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Web.AspNet4.Controllers
{
	public class ClienteController : Controller
	{
		private readonly ClienteRepository clienteRepository;

		public ClienteController(DataContext dataContext)
		{
			clienteRepository = new ClienteRepository(dataContext);
		}

		[HttpGet]
		public IActionResult Index()
		{
			var listaClientes = clienteRepository.FindAll();
			return View(listaClientes);
		}

		[HttpGet]
		public IActionResult Novo()
		{
			var clienteModel = new ClienteModel();
			return View(clienteModel);
			//return Content("Fiap ASP.NET 4");
			//return RedirectToAction("Index");
		}

		[HttpPost]
		public IActionResult Novo(ClienteModel clienteModel)
		{
			Console.WriteLine(clienteModel.Nome);
			Console.WriteLine(clienteModel.Sobrenome);

			// ClasseBancoDeDados.Insert (nome, sobrenome);		
			if (ModelState.IsValid)
			{
				TempData["Mensagem"] = "Cliente cadastrado com sucesso!";

				//return View("Sucesso");
				return RedirectToAction("Index");
			}
			else
			{
				return View(clienteModel);
			}
		}

		[HttpGet]
		public IActionResult Editar(int id)
		{
			// var cliente = SELECT ... FROM CLIENTE WHERE ID = {id}; 

			var clienteModel = new ClienteModel();
			if (id == 1)
			{
				clienteModel = new ClienteModel
				{
					ClienteId = 1,
					Nome = "Flavio",
					Email = "fmoreni@gmail.com",
					DataNascimento = DateTime.Now,
					Observacao = "OBS1"
				};
			}
			else if (id == 2)
			{
				clienteModel = new ClienteModel
				{
					ClienteId = 2,
					Nome = "Eduardo",
					Email = "eduardo@gmail.com",
					DataNascimento = DateTime.Now,
					Observacao = "OBS3"
				};
			}
			else
			{
				clienteModel = new ClienteModel
				{
					ClienteId = 3,
					Nome = "Moreni",
					Email = "moreni@gmail.com",
					DataNascimento = DateTime.Now,
					Observacao = "OBS3"
				};
			}
			return View(clienteModel);
		}

		[HttpPost]
		public IActionResult Editar(ClienteModel clienteModel)
		{
			// Validação de campos no Controller usando if/else recuperando dados da model
			//if (String.IsNullOrEmpty(clienteModel.Nome) || String.IsNullOrEmpty(clienteModel.Email))
			//{
			//    TempData["Mensagem"] = "O nome do cliente ou o e-mail não pode ser nulo!";
			//    return View(clienteModel);
			//    //return RedirectToAction("Editar", new { id = clienteModel.ClienteId });
			//}
			//else
			//{
			//    // UPDATE TABELA ... VALUES ...
			//    TempData["Mensagem"] = "Cliente alterado com sucesso!";
			//    return RedirectToAction("Index");
			//}

			if (ModelState.IsValid)
			{
				// UPDATE TABELA ... VALUES ...
				TempData["Mensagem"] = "Cliente alterado com sucesso!";
				return RedirectToAction("Index");
			}
			else
			{
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
	}
}
