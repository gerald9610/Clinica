using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.BL
{
   public class PacientesBL
    {
        public BindingList<Paciente> ListaPacientes { get; set; } //BindingList nos permite crear una lista de pacientes
                                                // entre <> se puede poner el tipo de clase
        public PacientesBL() //ctor + 2 tab = creacion de construnctor //El () es el constructor
        {
            ListaPacientes = new BindingList<Paciente>();

            var paciente1 = new Paciente();
            paciente1.Id = 1;
            paciente1.Nombre = "Fidelio";
            paciente1.Sexo = "Masculino";
            paciente1.Edad = 30;
            paciente1.Peso = 150.00;
            paciente1.Talla = 180.00;
            paciente1.Activo = true;

            ListaPacientes.Add(paciente1);

            var paciente2 = new Paciente();
            paciente2.Id = 2;
            paciente2.Nombre = "Anastasia";
            paciente2.Sexo = "Femenino";
            paciente2.Edad = 25;
            paciente2.Peso = 90.00;
            paciente2.Talla = 160.00;
            paciente2.Activo = true;

            ListaPacientes.Add(paciente2);

            var paciente3 = new Paciente();
            paciente3.Id = 2;
            paciente3.Nombre = "Marcos";
            paciente3.Sexo = "Masculino";
            paciente3.Edad = 60;
            paciente3.Peso = 160.00;
            paciente3.Talla = 190.00;
            paciente3.Activo = true;

            ListaPacientes.Add(paciente3);


        }

        public BindingList<Paciente> ObtenerPacientes()
        {
            return ListaPacientes;
        } 
    }
    public class Paciente //Propiedades de Paciente
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public int Edad { get; set; }
        public String Sexo { get; set; }
        public double Talla { get; set; }
        public double Peso { get; set; }
        public bool Activo { get; set; }

    }

}
