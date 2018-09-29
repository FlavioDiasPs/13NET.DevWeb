using Aula01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula01.Data
{
    public class PerguntaContext : DbContext
    {
        public PerguntaContext(DbContextOptions<PerguntaContext> options) : base(options)
        {

        }

        public DbSet<Pergunta> Pergunta { get; set; }
    }
}
