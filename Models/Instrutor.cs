using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Academia.Models
{
    public class Instrutor
    {
        public int InstrutorId { get; set; }
        public string Nome { get; set; }
        public int Matricula { get; set; }
        public virtual ICollection<Aula> Aulas { get; set; }
    }
}