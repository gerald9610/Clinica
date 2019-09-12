using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Maestro Detalle de Citas

namespace Clinica.BL
{
    public class CitasBL
    {
        Contexto _contexto;
        public BindingList<Cita> ListaCitas { get; set; }

        public CitasBL()
        {
            _contexto = new Contexto();
            ListaCitas = new BindingList<Cita>();
        }

        public BindingList<Cita> ObtenerCitas()
        {
            _contexto.Citas.Include("CitaDetalle").Load();
            ListaCitas = _contexto.Citas.Local.ToBindingList();

            return ListaCitas;
        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        public Resultado GuardarCita(Cita cita)
        {
            var resultado = Validar(cita);

            if (resultado.Exitoso == false)
            {
                return resultado;
            }
            _contexto.Citas.Add(cita);
            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarCita()
        {
            var nuevaCita = new Cita();

            ListaCitas.Add(nuevaCita);
        }

        //Data Grid de los Medicos
        public void AgregarCitaDetalle(Cita cita)
        {
            if (cita != null)
            {
                var nuevoDetalle = new CitaDetalle();
                cita.CitaDetalle.Add(nuevoDetalle);
            }
        }

        public void RemoverCitaDetalle(Cita cita, CitaDetalle citaDetalle)
        {
            if (cita != null && citaDetalle != null)
            {
                cita.CitaDetalle.Remove(citaDetalle);
            }
        }

        //public bool ElimiarCitas(int id)
        //{
        //    foreach (var cita in ListaCitas)
        //    {
        //        if (cita.Id == id)
        //        {
        //            ListaCitas.Remove(cita);
        //            _contexto.SaveChanges();
        //            return true;
        //        }
        //    }

        //    return false;
        //}

       

        private Resultado Validar(Cita cita)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (cita == null)
            {
                resultado.Mensaje = "Agregue una cita para poder salvar";
                resultado.Exitoso = false;

                return resultado;
            }

            if (cita.Id != 0 && cita.Activo == false)
            {
                resultado.Mensaje = "La cita ya fue emitida y no puede realizar cambios en ella";
                resultado.Exitoso = false;
            }

            if (cita.PacienteId == 0)
            {
                resultado.Mensaje = "Seleccione un Paciente";
                resultado.Exitoso = false;
            }

            if (cita.CitaDetalle.Count == 0)
            {
                resultado.Mensaje = "Agregue un medico a la Cita";
                resultado.Exitoso = false;
            }

            foreach (var detalle in cita.CitaDetalle)
            {
                if (detalle.MedicoId == 0)
                {
                    resultado.Mensaje = "Seleccione Medicos Validos";
                    resultado.Exitoso = false;
                }
            }

            return resultado;
        }

        public void calcularCita(Cita cita)
        {
            if (cita != null)
            {
                double subtotal = 0;

                foreach (var detalle in cita.CitaDetalle)
                {
                    var medico = _contexto.Medicos.Find(detalle.MedicoId);
                    if (medico != null)
                    {
                        detalle.Costo = medico.Costo;
                        subtotal += detalle.Costo;
                    }
                }

                cita.Total = subtotal;
            }
        }

        public bool AnularCita(int id)
        {
            foreach (var cita in ListaCitas)
            {
                if (cita.Id == id)
                {
                    cita.Activo = false;
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }
    }


    public class Cita
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaCita { get; set; }
        public int PacienteId { get; set; } //Llave foranea para relacion de Paciente/Cita
        public Paciente Paciente { get; set; }
        public BindingList<CitaDetalle> CitaDetalle { get; set; } //Para relacionar CitaDetalle
        public string Historial { get; set; }
        public double Total { get; set; }
        public bool Activo { get; set; }

        public Cita()
        {
            Fecha = DateTime.Now;
            FechaCita = DateTime.Now;
            CitaDetalle = new BindingList<CitaDetalle>();
            Activo = true;
        }

    }

    public class CitaDetalle
    {
        public int Id { get; set; }
        public int MedicoId { get; set; }
        public Medico Medico { get; set; }
        public double Costo { get; set; }

        public CitaDetalle()
        {

        }
    }

}
