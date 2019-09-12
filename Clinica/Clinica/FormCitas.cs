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
    public partial class FormCitas : Form
    {
        PacientesBL _pacientesBL;
        MedicosBL _medicosBL;
        
        CitasBL _citasBL;
   

        public FormCitas()
        {
            InitializeComponent();

            _pacientesBL = new PacientesBL();
            listaPacientesBindingSource.DataSource = _pacientesBL.ObtenerPacientes();

            _medicosBL = new MedicosBL();
            listaMedicosBindingSource.DataSource = _medicosBL.ObtenerMedicos();

            _citasBL = new CitasBL();
            listaCitasBindingSource.DataSource = _citasBL.ObtenerCitas();

            
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _citasBL.AgregarCita();
            listaCitasBindingSource.MoveLast();

            DesabilitarHabilitarBotones(false);
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

        private void listaCitasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaCitasBindingSource.EndEdit();

            var cita = (Cita)listaCitasBindingSource.Current;

            var resultado = _citasBL.GuardarCita(cita);

            if(resultado.Exitoso == true)
            {
                listaCitasBindingSource.ResetBindings(false);
                DesabilitarHabilitarBotones(true);
                MessageBox.Show("Cita de Paciente Guardada");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarHabilitarBotones(true);
            _citasBL.CancelarCambios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cita = (Cita)listaCitasBindingSource.Current;

            _citasBL.AgregarCitaDetalle(cita);

            DesabilitarHabilitarBotones(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var cita = (Cita)listaCitasBindingSource.Current;

            var citaDetalle = (CitaDetalle)citaDetalleBindingSource.Current;

           _citasBL.RemoverCitaDetalle(cita, citaDetalle);

            DesabilitarHabilitarBotones(false);
        }

        private void FormCitas_Load(object sender, EventArgs e)
        {

        }

         private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("¿Desea anular esta cita?", "ANULAR", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Anular(id);
                }
            }
        }

        private void Anular(int id)
        {
            var resultado = _citasBL.AnularCita(id);
            if (resultado == true)
            {
                listaCitasBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al anular cita");
            }
        }

        private void listaCitasBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var cita = (Cita)listaCitasBindingSource.Current;
            if (cita != null && cita.Id != 0 && cita.Activo == false)
            {
                label3.Visible = true;
            }
            else
            {
                label3.Visible = false;
            }
        }



        private void citaDetalleDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var cita = (Cita)listaCitasBindingSource.Current;

            _citasBL.calcularCita(cita);

            listaCitasBindingSource.ResetBindings(false);
        }

        private void citaDetalleDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }


    }
}
