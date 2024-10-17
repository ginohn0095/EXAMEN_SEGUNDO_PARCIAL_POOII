using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_SEGUNDO_PARCIAL_POOII
{
    class Persona
    {
        public Persona() { }
        public Persona(int iD, string nombre, int edad, DateTime fechaDeNacimiento, string correoElectronico)
        {
            ID = iD;
            Nombre = nombre;
            Edad = edad;
            FechaDeNacimiento = fechaDeNacimiento;
            CorreoElectronico = correoElectronico;
        }

        public int ID { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public string CorreoElectronico { get; set; }

    }
}
