using ApiConection.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ApiConection.Data
{
    public class VitalPetsDbContext : DbContext
    {
        public VitalPetsDbContext(DbContextOptions<VitalPetsDbContext> options)
            : base(options)
        {
        }
        public DbSet<Mascota> Mascotas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Veterinarios> Veterinarios { get; set; }
        public DbSet<Cita> Citas { get; set; }

    }
}
