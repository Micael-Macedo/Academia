using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Academia.Models
{
    public class EquipamentoAula
    {
        public int EquipamentoAulaId { get; set; }
        public int EquipamentoId { get; set; }
        public Equipamento Equipamento { get; set; }
        public int AulaId { get; set; }
        public Aula Aula { get; set; }
    }
}