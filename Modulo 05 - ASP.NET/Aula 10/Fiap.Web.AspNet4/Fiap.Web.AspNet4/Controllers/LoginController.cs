using Fiap.Web.AspNet4.Repository.Interface;
using Fiap.Web.AspNet4.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Web.AspNet4.Controllers
{
	public class LoginController : Controller
	{
		private readonly IUsuarioRepository usuarioRepository;

		public LoginController()
		{

		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Login(LoginViewModel loginViewModel)
		{



			return RedirectToAction("Index", "Home");
		}
	}
}
