using Clinica.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    public partial class FormRecetarios : Form
    {
        RecetasBL _recetas;
        CategoriasBL _categoria;


        public FormRecetarios()
        {
            InitializeComponent();

            _recetas = new RecetasBL();
               listaRecetasBindingSource.DataSource = _recetas.ObtenerRecetas();

            _categoria = new CategoriasBL();
               listaCategoriaBindingSource.DataSource = _categoria.ObtenerCategoria();

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _recetas.AgregarReceta();
            listaRecetasBindingSource.MoveLast();

            descripcionTextBox.Focus();

            DesabilitarHabilitarBotones(false);
        }


        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("¿Desea eliminar este Medicamento o Suministro?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);
                }
            }
        }

     
        private void Eliminar(int id)
        {

            var resultado = _recetas.ElimiarRecetas(id);

            if (resultado == true)
            {
                     listaRecetasBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al elimiar Medicamento o Suministro");
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            _recetas.CancelarCambios();
            DesabilitarHabilitarBotones(true);
        }

      

        private void DesabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButtonCancelar.Visible = !valor;
        }

        private void listaRecetasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            var receta = (Receta)listaRecetasBindingSource.Current;

            var resultado = _recetas.GuardarReceta(receta);

            if (resultado.Exitoso == true)
            {
                listaRecetasBindingSource.ResetBindings(false);
                DesabilitarHabilitarBotones(true);
                MessageBox.Show("Medicamento o Suministro Guardado");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void listaCategoriaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }

}

