using Clinica.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    public partial class FormMedicos : Form
    {
       MedicosBL _medicos;
       EspecialidadesBL _especialidades;
       JornadasBL _jornadas;

        public FormMedicos()
        {
            InitializeComponent();

            _medicos = new MedicosBL();
            listaMedicosBindingSource.DataSource = _medicos.ObtenerMedicos(); 

           _especialidades = new EspecialidadesBL();
           listaEspecialidadesBindingSource.DataSource = _especialidades.ObtenerEspecialidades();

            _jornadas = new JornadasBL();
            listaJornadasBindingSource.DataSource = _jornadas.ObtenerJornadas();
        }

       // private void FormMedicos_Load(object sender, EventArgs e)
      //  {

       // }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _medicos.AgregarMedico();
            listaMedicosBindingSource.MoveLast();

            nombreTextBox.Focus();

            DesabilitarHabilitarBotones(false);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("¿Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text); //Convertir el entero de Id para leerlo en el textbox
                    Eliminar(id); //objeto de Metodo para eliminar regirstros
                }
            }
        }

        private void Eliminar(int id) //Metodo para Eliminar registros
        {

            var resultado = _medicos.ElimiarMedicos(id);

            if (resultado == true)
            {
                listaMedicosBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al elimiar Paciente");
            }
        }

        private void listaMedicosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            var medico = (Medico)listaMedicosBindingSource.Current;

            var resultado = _medicos.GuardarMedico(medico);

            if (resultado.Exitoso == true)
            {
                listaMedicosBindingSource.ResetBindings(false);
                DesabilitarHabilitarBotones(true);
                MessageBox.Show("Medico Guardado");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje); //Enviamos el mensaje respectivo a cada error posible
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            _medicos.CancelarCambios();
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

        private void listaJornadasBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void listaEspecialidadesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

   
    }
}
