using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app_mvc.Models.conn
{
    public interface IAlunoConnection
    {
        List<Aluno> getStudentyList();
    }
}