using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.BL
{
    public class JornadasBL
    {
        Contexto _contexto;

        public BindingList<Jornada> ListaJornadas { get; set; }

        public JornadasBL()
        {

            _contexto = new Contexto();
            ListaJornadas = new BindingList<Jornada>();
        }

        public BindingList<Jornada> ObtenerJornadas()
        {
            _contexto.Jornadas.Load();
            ListaJornadas = _contexto.Jornadas.Local.ToBindingList();

            return ListaJornadas;
        }
    }

    public class Jornada
    {
        public int Id { get; set; }
        public String Descripcion { get; set; }
    }
}
