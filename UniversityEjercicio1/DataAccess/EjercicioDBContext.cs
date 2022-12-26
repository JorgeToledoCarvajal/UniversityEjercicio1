using Microsoft.EntityFrameworkCore;
using UniversityEjercicio1.Models.DataModels;

namespace UniversityEjercicio1.DataAccess
{
    public class EjercicioDBContext : DbContext
    {
        public EjercicioDBContext(DbContextOptions<EjercicioDBContext>options): base(options)
        {
        }

        public DbSet<Curso>? cursos { get; set; }


    }

    
}
