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
    public partial class FormPacientes : Form
    {
        PacientesBL _pacientes;
        EstadosBL _estados;
        TiposBL _tipos;

        public FormPacientes()
        {
            InitializeComponent();

            _pacientes = new PacientesBL();
            listaPacientesBindingSource.DataSource = _pacientes.ObtenerPacientes(); //Para llevar la informacion de nuestra lista de Pacientes al formulario pacientes

            _estados = new EstadosBL();
            listaEstadosBindingSource.DataSource = _estados.ObtenerEstados();

            _tipos = new TiposBL();
            listaTiposBindingSource.DataSource = _tipos.ObtenerTipos();
        }

        private void FormPacientes_Load(object sender, EventArgs e)
        {

        }

        private void listaPacientesBindingNavigatorSaveItem_Click(object sender, EventArgs e) //Boton de Guardar
        {
            listaPacientesBindingSource.EndEdit(); //EndEdit - Esta instruccion debe decirle a formulario que ya dejamos de escribir

            var paciente = (Paciente)listaPacientesBindingSource.Current; //Current nos servira para definir el Paciente Actual en registro

            if (fotoPictureBox.Image != null)
            {
                paciente.Foto = Program.imagetoByteArray(fotoPictureBox.Image); //Program es la Clase base donde creamo imagetoByte
            }
            else
            {
                paciente.Foto = null; //Si la foto es nula es por la remosion
            }

            var resultado = _pacientes.GuardarPaciente(paciente);

            if (resultado.Exitoso == true) //Validamos los datos recibidos desde Resultado
            {
                listaPacientesBindingSource.ResetBindings(false); //Reset resetea los cambios para la lista
                DesabilitarHabilitarBotones(true);
                MessageBox.Show("Paciente Guardado");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje); //Enviamos el mensaje respectivo a cada error posible
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e) //
        {
            _pacientes.AgregarPaciente();
            listaPacientesBindingSource.MoveLast(); //MoveLast lleva nos lleva a lo ultimo de la lista

            nombreTextBox.Focus();

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
            toolStripButtonCancelar.Visible = !valor; //! cambia el valor contrario al Bool o negacion del Bool
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e) //Boton de Eliminar
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
            
            var resultado = _pacientes.ElimiarPaciente(id);

            if (resultado == true)
            {
                listaPacientesBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al elimiar Paciente");
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e) //Funciones para cancelar operaciones y eliminar Id = 0
        {
            _pacientes.CancelarCambios();
            DesabilitarHabilitarBotones(true);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var paciente = (Paciente)listaPacientesBindingSource.Current; 

            if (paciente != null)
            {
                openFileDialog1.ShowDialog(); //Funsion para buscar en una ventana de Dialogo la fotografia que subieremos
                var archivo = openFileDialog1.FileName;

                if (archivo != "") //Determinar que el archivo no esta vacio
                {
                    var fileInfo = new FileInfo(archivo); //Obtener el archivo desde la ruta asignada y agregarlo a la clase FileInfo
                    var fileStream = fileInfo.OpenRead(); //Almacenamiento por Bites de los archivos de imagen en fileStream

                    fotoPictureBox.Image = Image.FromStream(fileStream); //Asignar el archivo de imagen a PictureBox

                }
            }
            else
            {
                MessageBox.Show("Ingrese el nuevo pacientes antes de asignar una imagen");
            }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fotoPictureBox.Image = null;

        }

        private void listaEstadosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void listaTiposBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

    }
}
