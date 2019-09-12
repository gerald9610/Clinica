using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.BL
{
    public class Contexto: DbContext // : para heredar clases en C#
    {
        public Contexto(): base("Consultorio") //base = DbContext y los () es instancia.
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) //Remover las opciones de Pluralizacion de nombres de tablas
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            Database.SetInitializer(new DatosdeInicio());
        }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Tipo> Tipos { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<Receta> Recetas { get; set; }
        public DbSet<Especialidad> Especialidades { get; set; }
        public DbSet<Jornada> Jornadas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

    }

 
}
