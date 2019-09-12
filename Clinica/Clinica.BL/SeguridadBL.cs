using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Clinica.BL
{
    public class SeguridadBL
    {
        Contexto _contexto;

        public SeguridadBL()
        {
            _contexto = new Contexto();
        }
        public bool Autorizar(string usuario, string contrasena)
        {
            var usuarios = _contexto.Usuarios.ToList();

            foreach (var usuarioBD in usuarios)
            {
            
                if (usuario == usuarioBD.Nombre && contrasena == usuarioBD.Contrasena)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
