using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Materia : Form
    {
        ControladorMateria controladormateria = new ControladorMateria();
        EntidadMateria entidadmateria = new EntidadMateria();

        public Materia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = controladormateria.buscar(Convert.ToInt16(txt_idMateria.Text));
            txt_nombre.Text = dt.Rows[0][1].ToString();
            txt_idProfesor.Text = dt.Rows[0][2].ToString();
        }

        private void Materia_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }
        private void limpiarCampos()
        {
            txt_idMateria.Text = "";
            txt_nombre.Text = "";
            txt_idProfesor.Text = "";
        }
        private void cargarEntidad()
        {
            entidadmateria.Id_materia = Convert.ToInt16(txt_idMateria.Text);
            entidadmateria.Nombre = txt_nombre.Text;
            entidadmateria.Id_profesor = Convert.ToInt16(txt_idProfesor.Text);
        }
        private void cargarGrid()
        {
            dataGridView1.DataSource = controladormateria.leer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cargarEntidad();
            controladormateria.insertar(entidadmateria);
            cargarGrid();
            limpiarCampos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cargarEntidad();
            controladormateria.modificar(entidadmateria);
            cargarGrid();
            limpiarCampos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            controladormateria.eliminar(Convert.ToInt16(txt_idMateria.Text));
            cargarGrid();
            limpiarCampos();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cargarGrid();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
    }
}
