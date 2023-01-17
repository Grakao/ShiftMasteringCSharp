using AutoMapper;
using Fiap.Web.AspNet4.Controllers.Filters;
using Fiap.Web.AspNet4.Models;
using Fiap.Web.AspNet4.Repository.Interface;
using Fiap.Web.AspNet4.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Web.AspNet4.Controllers
{
    [FiapLogFilter]
    public class LoginController : Controller
	{
		private readonly IUsuarioRepository usuarioRepository;
		private readonly IMapper mapper;

		public LoginController(IUsuarioRepository _usuarioRepository, IMapper _mapper)
		{
			usuarioRepository = _usuarioRepository;
			mapper = _mapper;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Login(LoginViewModel loginViewModel)
		{
			//var usuarioModel = new UsuarioModel();
			//usuarioModel.UsuarioEmail = loginViewModel.UsuarioEmail;
			//usuarioModel.UsuarioSenha = loginViewModel.UsuarioSenha;

			UsuarioModel usuarioModel = mapper.Map<UsuarioModel>(loginViewModel);

			var usuarioRetorno = usuarioRepository.Login(usuarioModel);

			if (usuarioRetorno != null && usuarioRetorno .UsuarioId != 0)
			{
				loginViewModel = mapper.Map<LoginViewModel>(usuarioRetorno);
				var loginViewModelJson = Newtonsoft.Json.JsonConvert.SerializeObject(loginViewModel);

				HttpContext.Session.SetString("usuarioLogado", loginViewModelJson);

				return RedirectToAction("Index", "Home");
			}
			else
			{
				ViewBag.ErrorMessage = "Usuário ou senha inválido(s).";
				return View("Index");
			}		
		}

		public IActionResult Logout()
		{
			HttpContext.Session.Clear();

            return View("Index");
        }
	}
}
