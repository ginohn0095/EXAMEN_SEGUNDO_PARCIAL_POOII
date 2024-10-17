using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_SEGUNDO_PARCIAL_POOII
{
    interface Interface 
    {
        List<Persona> GetPersonas(int iD, string nombre, int edad, DateTime fechaDeNacimiento, string correoElectronico);
        bool InsertarPersona(int iD, string nombre, int edad, DateTime fechaDeNacimiento, string correoElectronico);
        bool Eliminar(int iD);
        bool Actualizar(int iD, string nombre, int edad, DateTime fechaDeNacimiento, string correoElectronico);


    }
}
