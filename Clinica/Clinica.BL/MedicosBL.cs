using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.BL
{
    public class MedicosBL
    {
        Contexto _contexto;
        public BindingList<Medico> ListaMedicos { get; set; } 

        public MedicosBL() 
        {
            _contexto = new Contexto();
            ListaMedicos = new BindingList<Medico>();
        }

        public BindingList<Medico> ObtenerMedicos()
        {
            _contexto.Medicos.Load(); //Carga los datos desde la Lista de Pacientes
            ListaMedicos = _contexto.Medicos.Local.ToBindingList(); //Pasa todos los datos cargados al bindignList

            return ListaMedicos;
        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        public Resultado GuardarMedico(Medico medico) //para guardar paciente como parametro
        {
            var resultado = Validar(medico); //Validacion desde la Funcion Resultado / Validar

            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges(); //Funcion del EntityFrameworks para almacenar Datos.

            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarMedico() //Funcion para agregar pacientes a la lista
        {
        var nuevoMedico = new Medico(); //Intancia de variable

            ListaMedicos.Add(nuevoMedico); //Agregar a la lista
        }

        public bool ElimiarMedicos(int id) //Funcion para Eliminar Pacientes de la lista
        {
            foreach (var medico in ListaMedicos) //forech -  para recorrer listas de objetos
            {
                if (medico.Id == id) //definir si es el ID que deseamos eliminar
                {
                    ListaMedicos.Remove(medico);
                    _contexto.SaveChanges(); //Guarda los cambios de eliminacion en el EntityFrameworks
                    return true;
                }
            }

            return false;
        }


         private Resultado Validar(Medico medico)
          {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (medico == null)
            {
                resultado.Mensaje = "Agregue un Medico";
                resultado.Exitoso = false;

                return resultado;
            }

            if (string.IsNullOrEmpty(medico.Nombre) == true)//********
            {
                resultado.Mensaje = "Ingrese Nombre del Medico";
                resultado.Exitoso = false;
            }
            else
            {
                if (string.IsNullOrEmpty(medico.Codigo) == true)
                {
                    resultado.Mensaje = "Ingrese un Codigo del Colegio Medico";
                    resultado.Exitoso = false;
                }
              
            }

            if (medico.EspecialidadId == 0)
            {
                resultado.Mensaje = "Selecciones una Especialidad";
                resultado.Exitoso = false;
            }

            if (medico.JornadaId == 0)
            {
                resultado.Mensaje = "Seleccione una Jornada";
                resultado.Exitoso = false;
            }

            return resultado;
        }
    }

    public class Medico 
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Codigo { get; set; }
        public int EspecialidadId { get; set; } 
        public Especialidad Especialidad { get; set; }
        public int JornadaId { get; set; }
        public Jornada Jornada { get; set; }
        public double Costo { get; set; }
        public bool Activo { get; set; }

    }

}