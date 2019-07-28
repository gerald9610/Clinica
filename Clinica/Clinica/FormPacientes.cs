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
    public partial class FormPacientes : Form
    {
        PacientesBL _pacientes;

        public FormPacientes()
        {
            InitializeComponent();

            _pacientes = new PacientesBL();
            listaPacientesBindingSource.DataSource = _pacientes.ObtenerPacientes(); //Para llevar la informacion de nuestra lista de Pacientes al formulario pacientes
        }

        private void FormPacientes_Load(object sender, EventArgs e)
        {

        }
    }
}
