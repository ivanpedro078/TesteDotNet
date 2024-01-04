using Microsoft.AspNetCore.Mvc;
using TesteDotNet.Business.DTOs;
using TesteDotNet.Business.Services;
using TesteDotNet.Repository.Entities;

namespace TesteDotNet.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly UsuarioService _usuarioService;

        public HomeController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        public IActionResult Index()
        {
            var result = BuscarUsuarios();
            var result2 = BuscarUsuarioPorCpf("08690943510");
            return View();
        }
        public ActionResult BuscarUsuarios()
        {
            List<UsuarioDTO>? usuarios = new();
            bool is_action = false;
            string error = string.Empty;
            try
            {
                usuarios = _usuarioService.BuscarUsuarios();
                is_action = true;
            }
            catch (Exception e)
            {
                error = e.Message;
            }
            return Json(new { usuarios, is_action, error });
        }
        public ActionResult BuscarUsuarioPorCpf(string cpf)
        {
            bool is_action = false;
            string error = string.Empty;
            UsuarioDTO? usuarios = null;
            try
            {
                usuarios = _usuarioService.BuscarUsuarioPorCpf(cpf);
                is_action = true;
            }
            catch (Exception e)
            {
                error = e.Message;
            }
            return Json(new { usuarios, is_action, error });
        }
    }
}