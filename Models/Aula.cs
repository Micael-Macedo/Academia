using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Academia.Models
{
    public class Aula
    {
        public int AulaId { get; set; }
        public string Dia { get; set; }
        public int InstrutorId { get; set; }
        public Instrutor Instrutor { get; set; }
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
        
    }
}