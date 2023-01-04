using app_mvc.Models;
using app_mvc.Models.conn;
using Microsoft.AspNetCore.Mvc;

namespace app_mvc.Controllers
{
    public class AlunoController : Controller
    {
        private readonly IAlunoConnection _alunoConnection;

        public AlunoController(IAlunoConnection alunoConnection)
        {
            _alunoConnection = alunoConnection;
        }

        [ActivatorUtilitiesConstructor]
        public AlunoController()
        {
            _alunoConnection = new AlunoConnection(new ConnectionPostgres());
        }

        public IActionResult Index()
        {
            Aluno _aluno = new Aluno();
            List<Aluno> alunoList = new List<Aluno>();

            alunoList = _alunoConnection.getStudentyList();

            return View(alunoList);
        }
    }
}