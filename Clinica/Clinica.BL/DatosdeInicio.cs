using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Clinica.BL.Contexto;

namespace Clinica.BL
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto> // Esta funcion nos sirve para crear una base de datos de prueba si no existe.
    {
        protected override void Seed(Contexto contexto) //Metodo Seed (Semilla) para los primeros registros de nuestra base de datos.
        {
            //Datos de Inicio para Usuarios y Contraseñas
            var usuarioAdmin = new Usuario();
            usuarioAdmin.Nombre = "admin";
            usuarioAdmin.Contrasena = "123";
            contexto.Usuarios.Add(usuarioAdmin);


            //Datos de inicio de Estado Civil
            var estado1 = new Estado();
            estado1.Descripcion = "Soltero";
            contexto.Estados.Add(estado1);

            var estado2 = new Estado();
            estado2.Descripcion = "Casado";
            contexto.Estados.Add(estado2);

            var estado3 = new Estado();
            estado3.Descripcion = "Union Libre";
            contexto.Estados.Add(estado3);
        
            //Datos de Inicio de Tipo de Seguro
            var tipo1 = new Tipo();
            tipo1.Descripcion = "Asegurado Directo";
            contexto.Tipos.Add(tipo1);

            var tipo2 = new Tipo();
            tipo2.Descripcion = "Asegurado Indirecto";
            contexto.Tipos.Add(tipo2);


            var tipo3 = new Tipo();
            tipo3.Descripcion = "Sin Seguro";
            contexto.Tipos.Add(tipo3);

            //Especialidades Medicas
            var especialidad1 = new Especialidad();
            especialidad1.Descripcion = "Medicina General";
            contexto.Especialidades.Add(especialidad1);

            var especialidad2 = new Especialidad();
            especialidad2.Descripcion = "Medicina Interna";
            contexto.Especialidades.Add(especialidad2);

            var especialidad3 = new Especialidad();
            especialidad3.Descripcion = "Pediatria";
            contexto.Especialidades.Add(especialidad3);

            var especialidad4 = new Especialidad();
            especialidad4.Descripcion = "Ginecologia";
            contexto.Especialidades.Add(especialidad4);

            //Jornadas
            var jornada1 = new Jornada();
            jornada1.Descripcion = "Matutina";
            contexto.Jornadas.Add(jornada1);

            var jornada2 = new Jornada();
            jornada2.Descripcion = "Vespertina";
            contexto.Jornadas.Add(jornada2);

            var jornada3 = new Jornada();
            jornada3.Descripcion = "Nocturna";
            contexto.Jornadas.Add(jornada3);

            //Tipo de Suministro o Medicamento
            var categoria1 = new Categoria();
            categoria1.Descripcion = "Medicamento";
            contexto.Categorias.Add(categoria1);

            var categoria2 = new Categoria();
            categoria2.Descripcion = "Suministro";
            contexto.Categorias.Add(categoria2);


            base.Seed(contexto);
        }
    }
}
