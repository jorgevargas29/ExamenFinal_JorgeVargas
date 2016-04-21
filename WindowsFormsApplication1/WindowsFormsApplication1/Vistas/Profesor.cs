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
    public partial class Profesor : Form
    {
        ControladorProfesor controladorprofesor = new ControladorProfesor();
        EntidadProfesor entidadprofesor = new EntidadProfesor();
        
        public Profesor()
        {
            InitializeComponent();
        }

        private void Profesor_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }
        private void limpiarCampos()
        {
            txt_idProfesor.Text = "";
            txt_nombre.Text = "";
            txt_apellido.Text = "";
        }
        private void cargarEntidad()
        {
            entidadprofesor.Id_profesor = Convert.ToInt16(txt_idProfesor.Text);
            entidadprofesor.Nombre = txt_nombre.Text;
            entidadprofesor.Apellido = txt_apellido.Text;   
        }
        private void cargarGrid()
        {
            dataGridView1.DataSource = controladorprofesor.leer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = controladorprofesor.buscar(Convert.ToInt16(txt_idProfesor.Text));
            txt_nombre.Text = dt.Rows[0][1].ToString();
            txt_apellido.Text = dt.Rows[0][2].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cargarEntidad();
            controladorprofesor.insertar(entidadprofesor);
            cargarGrid();
            limpiarCampos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cargarEntidad();
            controladorprofesor.modificar(entidadprofesor);
            cargarGrid();
            limpiarCampos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            controladorprofesor.eliminar(Convert.ToInt16(txt_idProfesor.Text));
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
