using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.BL
{
    public class RecetasBL
    {
        Contexto _contexto;

        public BindingList<Receta> ListaRecetas { get; set; }

        public RecetasBL()
        {
            _contexto = new Contexto();
            ListaRecetas = new BindingList<Receta>();
        }

        public BindingList<Receta> ObtenerRecetas()
        {
            _contexto.Recetas.Load();
            ListaRecetas = _contexto.Recetas.Local.ToBindingList();

            return ListaRecetas;
        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        public Resultado GuardarReceta(Receta receta)
        {
            var resultado = Validar(receta);

            if (resultado.Exitoso == false)
            {
                return resultado;
            }
            _contexto.Recetas.Add(receta);
            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarReceta()
        {
            var nuevaReceta = new Receta();

            ListaRecetas.Add(nuevaReceta);
        }

        public bool ElimiarRecetas(int id)
        {
            foreach (var receta in ListaRecetas)
            {
                if (receta.Id == id)
                {
                    ListaRecetas.Remove(receta);
                    _contexto.SaveChanges();
                    return true;
                }
            }

            return false;
        }


        private Resultado Validar(Receta receta)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;


            if (string.IsNullOrEmpty(receta.Descripcion) == true)
            {
               resultado.Mensaje = "Ingrese Descripcion de Medicamento o Suministro Medico";
               resultado.Exitoso = false;
            }

            return resultado;
        }


    }

    public class Receta
    {
        public int Id { get; set; }
        public String Descripcion { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public bool Activo { get; set; }
    }
}
