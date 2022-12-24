using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app_mvc.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public char Genero { get; set; }
        public string? Curso { get; set; }
    }
}