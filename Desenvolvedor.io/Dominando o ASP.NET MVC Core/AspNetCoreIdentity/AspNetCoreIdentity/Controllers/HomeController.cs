using AspNetCoreIdentity.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspNetCoreIdentity.Controllers
{
    [Authorize] // Para acessar esse controlado, tem que está logado.
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [AllowAnonymous] // Qualquer 1 pode entrar
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Authorize(Roles = "Admin, Gestor")] // Essa forma, configuramos a autorização.
        public IActionResult Secret()
        {
            return View();
        }

        [Authorize(Policy = "PodeExcluir")] // Essa forma, configuramos a autorização de forma básica da claim.
        public IActionResult SecretClaim()
        {
            return View("Secret");
        }

        [Authorize(Policy = "PodeEscrever")] // Essa forma, configuramos a autorização de forma que dê para colocar mais autorizações na tabela do Identity
        public IActionResult SecretClaimGravar()
        {
            return View("Secret");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}