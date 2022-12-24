using app_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace app_mvc.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            Aluno _aluno = new Aluno();
            _aluno.CriarAluno();

            return View(_aluno.BuscarAluno());
        }
    }
}