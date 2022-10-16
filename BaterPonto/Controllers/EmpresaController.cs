using BaterPonto.Models;
using BaterPonto.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace BaterPonto.Controllers
{
    public class EmpresaController : Controller
    {
        private readonly IEmpresaRepositorio _empresaRepositorio;
        public EmpresaController(IEmpresaRepositorio empresaRepositorio)
        {
            _empresaRepositorio = empresaRepositorio;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult ApagarConfirmacao()
        {
            return View();
        }

        public IActionResult Apagar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(EmpresModel Empresa)
        {
            _empresaRepositorio.Adicioar(Empresa);
            return RedirectToAction("Index");
        }
    }
}
