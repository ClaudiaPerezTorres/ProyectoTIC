using Microsoft.EntityFrameworkCore;
using AsigOficinas.App.Dominio;

namespace AsigOficinas.App.Persistencia
{
    public class appContext:DbContext
    {
        public DbSet<Persona> Persona {get;set;}
        public DbSet<Gobernacion> Gobernacion {get;set;}
        public DbSet<GobernadorYAsesor> GobernadorYAsesor {get;set;}
        public DbSet<Oficina> Oficina {get;set;}
        public DbSet<PersonalDeAseo> PersonalDeAseo {get;set;}
        public DbSet<Registro> Registro {get;set;}
        public DbSet<SecretarioDeDespacho> SecretarioDeDespacho {get;set;}
        public DbSet<Sede> Sede {get;set;}
        public DbSet<Sistema> Sistema {get;set;}
        public DbSet<Diagnostico> Diagnostico {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = AsigOficina.Data");
            }
        }
    }
}