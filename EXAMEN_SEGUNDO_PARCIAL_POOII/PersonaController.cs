using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EXAMEN_SEGUNDO_PARCIAL_POOII.Controller.DSTableAdapters;
using System.Data;

namespace EXAMEN_SEGUNDO_PARCIAL_POOII
{
    class PersonaController : Interface
    {
        List<Persona> listaPersona = new List<Persona>();
        Persona p = new Persona();

        public bool Actualizar(int iD, string nombre, int edad, DateTime fechaDeNacimiento, string correoElectronico)
        {
            try
            {
                using (personasTableAdapter personas = new personasTableAdapter())
                {
                    using (var adapter = new personasTableAdapter())
                    {
                        int filasAfectadas = adapter.Actualizar(nombre, edad, fechaDeNacimiento, correoElectronico, iD);

                        return filasAfectadas > 0;
                    }
                }

            }
            catch (Exception ex )
            {
                Console.WriteLine("hubo un problema bobo"+ex );

                throw;
            }

            throw new NotImplementedException();
        }

        public bool Eliminar(int iD)
        {
            var eliminarobjeto = listaPersona.FirstOrDefault(x => x.ID == iD);
            if (eliminarobjeto != null)
            {
                listaPersona.Remove(eliminarobjeto);
                return true;
            }
            else
            {
                return false;
            }
            throw new NotImplementedException();
        }

        internal List<Persona> GetPersonas()
        {
            throw new NotImplementedException();
        }

        public List<Persona> GetPersonas(int iD, string nombre, int edad, DateTime fechaDeNacimiento, string correoElectronico)
        {
            using (personasTableAdapter personas = new personasTableAdapter())
                try
                {
                    var datos = personas.GetData();
                    foreach (DataRow row in datos)
                    {
                        p.ID = Convert.ToInt32(row["ID"]);
                        p.Nombre = Convert.ToString(row["Nombre"]);
                        p.Edad = Convert.ToInt32(row["Edad"]);
                        p.FechaDeNacimiento = Convert.ToDateTime(row["Fecha de Nacimiento"]);
                        p.CorreoElectronico = Convert.ToString(row["Correo Electronico"]);
                        listaPersona.Add(new Persona(p.ID, p.Nombre, p.Edad, p.FechaDeNacimiento, p.CorreoElectronico));

                    }

                }
                catch (Exception ex )
                {
                    Console.WriteLine("algo salio mal bobo"+ ex);

                    throw;
                }
          
            throw new NotImplementedException();
        }

        internal bool Actualizar(int v, string text1, int edad, string text2)
        {
            throw new NotImplementedException();
        }

        public bool InsertarPersona(int iD, string nombre, int edad, DateTime fechaDeNacimiento, string correoElectronico)
        {
            try
            {
                p.ID = iD;
                p.Nombre = nombre;
                p.Edad = edad;
                p.FechaDeNacimiento = fechaDeNacimiento;
                p.CorreoElectronico = correoElectronico;
                listaPersona.Add(new Persona(p.ID, p.Nombre, p.Edad, p.FechaDeNacimiento, p.CorreoElectronico));
                return true;

            }
            catch (Exception ex)
            {

                return false;
            }
            throw new NotImplementedException();
        }
    }
}
