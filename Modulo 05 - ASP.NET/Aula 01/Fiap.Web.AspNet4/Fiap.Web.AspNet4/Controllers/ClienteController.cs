using Fiap.Web.AspNet4.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Web.AspNet4.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Novo()
        {
            return View();
            //return Content("Fiap ASP.NET 4");
            //return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Novo(ClienteModel clienteModel)
        {
            Console.WriteLine(clienteModel.Nome);
            Console.WriteLine(clienteModel.Sobrenome);

            // ClasseBancoDeDados.Insert (nome, sobrenome);
            return View("Sucesso");
        }
    }
}
