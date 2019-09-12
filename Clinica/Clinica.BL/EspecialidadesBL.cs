using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.BL
{
    public class EspecialidadesBL
    {
        Contexto _contexto;

        public BindingList<Especialidad> ListaEspecialidades { get; set; }

        public EspecialidadesBL()
        {

            _contexto = new Contexto();
            ListaEspecialidades = new BindingList<Especialidad>();
        }

        public BindingList<Especialidad> ObtenerEspecialidades()
        {
            _contexto.Especialidades.Load();
            ListaEspecialidades = _contexto.Especialidades.Local.ToBindingList();

            return ListaEspecialidades;
        }
    }

    public class Especialidad
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}
