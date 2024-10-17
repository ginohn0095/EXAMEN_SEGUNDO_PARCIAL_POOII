using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EXAMEN_SEGUNDO_PARCIAL_POOII.Controller.DSTableAdapters;

namespace EXAMEN_SEGUNDO_PARCIAL_POOII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNMOSTRAR_Click(object sender, EventArgs e)
        {
            PersonaController controller = new PersonaController();
            List<Persona> personas = controller.GetPersonas();
            dataGridView1.DataSource = personas;
        }

        private void BTNACTUALIZAR_Click(object sender, EventArgs e)
        {
            PersonaController controller = new PersonaController();
             if (string.IsNullOrWhiteSpace(TXBID.Text) || !int.TryParse(TXBID.Text, out int id))
            {
                MessageBox.Show("Por favor, introduce un ID.");
                return;
            }
            if (TXBNOMBRE.Text.Length < 3) ; 
            
        }

        private void BTNELIMINAR_Click(object sender, EventArgs e)
        {
            PersonaController controller = new PersonaController();
            if (string.IsNullOrWhiteSpace(TXBID.Text) || !int.TryParse(TXBID.Text, out int id))
            {
                MessageBox.Show("Por favor, introduce un ID válido para eliminar.");
                return;
            }
            bool resultado = controller.Eliminar(id);

            if (resultado)
            {
                MessageBox.Show("Alumno eliminado exitosamente.");
               
            }
            else
            {
                MessageBox.Show("Error al eliminar el alumno. Verifica que el ID exista.");
            }
        }
    }
}
