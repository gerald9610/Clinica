using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.BL
{
    public class EstadosBL
    {
        Contexto _contexto;

        public BindingList<Estado> ListaEstados { get; set; }

        public EstadosBL()
        {

            _contexto = new Contexto();
            ListaEstados = new BindingList<Estado>();
        }

        public BindingList<Estado> ObtenerEstados()
        {
            _contexto.Estados.Load();
            ListaEstados = _contexto.Estados.Local.ToBindingList();

            return ListaEstados;
        }
    }

        public class Estado
        {
            public int Id { get; set; }
            public String Descripcion { get; set; }
        }
    }

