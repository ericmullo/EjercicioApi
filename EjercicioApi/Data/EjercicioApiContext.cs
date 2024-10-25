using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EjercicioApi.Models;

namespace EjercicioApi.Data
{
    public class EjercicioApiContext : DbContext
    {
        public EjercicioApiContext (DbContextOptions<EjercicioApiContext> options)
            : base(options)
        {
        }

        public DbSet<EjercicioApi.Models.Estudiante> Estudiante { get; set; } = default!;
    }
}
