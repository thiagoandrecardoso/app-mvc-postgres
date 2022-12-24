using app_mvc.Models;
using app_mvc.Models.conn;
using Microsoft.AspNetCore.Mvc;

namespace app_mvc.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            Aluno _aluno = new Aluno();
            AlunoConnection alunoConnection = new AlunoConnection(new ConnectionPostgres());

            List<Aluno> alunoList = new List<Aluno>();

            alunoList = alunoConnection.getStudentyList();

            return View(alunoList);
        }
    }
}