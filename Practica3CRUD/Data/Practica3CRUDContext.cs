using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Practica3CRUD.Models
{
    public class Practica3CRUDContext : DbContext
    {
        public Practica3CRUDContext (DbContextOptions<Practica3CRUDContext> options)
            : base(options)
        {
        }

        public DbSet<Practica3CRUD.Models.Personas> Personas { get; set; }
    }
}
