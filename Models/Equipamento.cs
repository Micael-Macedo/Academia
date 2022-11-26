using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Academia.Models
{
    public class Equipamento
    {
        public int EquipamentoId { get; set; }
        public string Nome { get; set; }
        public bool EstaQuebrado { get; set; }
        public string Tipo { get; set; }
        public ICollection<EquipamentoAula> EquipamentoAulas { get; set; }
    }
}