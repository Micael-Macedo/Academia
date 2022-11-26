using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Academia.Models;

namespace Academia.Models
{
    public class ProjetoAcademiaContext : DbContext
    {
        public ProjetoAcademiaContext(DbContextOptions<ProjetoAcademiaContext> options) : base(options){}
        public DbSet<Academia.Models.Instrutor> Instrutor { get; set; }
        public DbSet<Academia.Models.Aula> Aula { get; set; }
        public DbSet<Academia.Models.Aluno> Aluno { get; set; }
        public DbSet<Academia.Models.Equipamento> Equipamento { get; set; }
    }
}