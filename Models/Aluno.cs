using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Academia.Models
{
    public class Aluno
    {
        public int AlunoId { get; set; }
        public string Nome { get; set; }
        public string Objetivo { get; set; }
        public virtual ICollection<Aula> Aulas { get; set; }

    }
}