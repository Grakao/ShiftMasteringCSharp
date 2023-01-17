 using AutoMapper;
using Fiap.Web.AspNet4.Controllers.Filters;
using Fiap.Web.AspNet4.Data;
using Fiap.Web.AspNet4.Models;
using Fiap.Web.AspNet4.Repository;
using Fiap.Web.AspNet4.Repository.Interface;
using Fiap.Web.AspNet4.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Fiap.Web.AspNet4.Controllers
{
	[FiapAuthFilter]
	public class ClienteController : Controller
	{
		private readonly IClienteRepository clienteRepository;
		private readonly IRepresentanteRepository representanteRepository;
		private readonly IMapper mapper;

		public ClienteController(IClienteRepository _clienteRepository, IRepresentanteRepository _representanteRepository, IMapper _mapper)
		{
			clienteRepository = _clienteRepository;
			representanteRepository = _representanteRepository;
			mapper = _mapper;
        }

		[HttpGet]
		public IActionResult Index()
		{
            //var listaClientes = clienteRepository.FindAllOrderByNomeDesc();
            //var listaClientes = clienteRepository.FindByNome("na");
            //var listaClientes = clienteRepository.FindByNomeAndEmail("na","@gmail.com");
            //var listaClientes = clienteRepository.FindByNomeAndEmailAndRep("na", "@gmail.com",0);
            //var listaClientes = clienteRepository.FindByNomeAndEmailAndRep("", null ,0);

            //ComboRepresentantes();

			// Controle de Acesso
            //if (String.IsNullOrEmpty(HttpContext.Session.GetString("usuarioLogado")))
            //{
            //    return RedirectToAction("Index", "Login");
            //}

            var vModel = new ClientePesquisaViewModel();
			vModel.Representantes = LoadRepresentantes();
			
			//return View(new List<ClienteModel>());
			return View(vModel);
		}

		[HttpPost]
		public IActionResult Pesquisar(ClientePesquisaViewModel vm)
		{
			//ComboRepresentantes();
			List<ClienteModel> listaClientes = clienteRepository.FindByNomeAndEmailAndRep(	vm.ClienteNome, 
																							vm.ClienteEmail,
																							vm.RepresentanteId);

			var listaClienteVM = mapper.Map<IList<ClienteViewModel>>(listaClientes);
			
			vm.Representantes = LoadRepresentantes();
			vm.Clientes = listaClienteVM;
			return View("Index", vm);           
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

		private SelectList LoadRepresentantes()
        {
            var listaRepresentantes = representanteRepository.FindAll();
            return new SelectList(listaRepresentantes, "RepresentanteId", "NomeRepresentante");
            
        }
    }
}
