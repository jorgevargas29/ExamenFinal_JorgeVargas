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
    public partial class Estudiante : Form
    {
        ControladorEstudiante controladorestudiante = new ControladorEstudiante();
        EntidadEstudiante entidadeestudiante = new EntidadEstudiante();
        ControladorMateria conmat = new ControladorMateria();

        public Estudiante()
        {
            InitializeComponent();
        }
        private void cargarGrid()
        {
            dataGridView1.DataSource = controladorestudiante.leer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = controladorestudiante.buscar(Convert.ToInt16(txt_idEstudiante.Text));
            txt_nombre.Text = dt.Rows[0][1].ToString();
            txt_apellido.Text = dt.Rows[0][2].ToString();
            txt_direccion.Text = dt.Rows[0][3].ToString();
            txt_edad.Text = dt.Rows[0][4].ToString();
            cbx_idCurso.SelectedItem = dt.Rows[0][5].ToString();
        }

        private void Estudiante_Load(object sender, EventArgs e)
        {
            cargarGrid();
            cbx_idCurso.DataSource = conmat.leer();
            cbx_idCurso.DisplayMember = "nombre";
            cbx_idCurso.ValueMember = "id_materia";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cargarEntidad();
            controladorestudiante.insertar(entidadeestudiante);
            cargarGrid();
            limpiarCampos();
        }
        private void limpiarCampos()
        {
            txt_idEstudiante.Text = "";
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_direccion.Text = "";
            txt_edad.Text = "";
        }
        private void cargarEntidad()
        {
            entidadeestudiante.Id_estudiante = Convert.ToInt16(txt_idEstudiante.Text);
            entidadeestudiante.Nombre = txt_nombre.Text;
            entidadeestudiante.Apellido = txt_apellido.Text;
            entidadeestudiante.Direccion = txt_direccion.Text;
            entidadeestudiante.Edad = Convert.ToInt16(txt_edad.Text);
            entidadeestudiante.Id_curso = Convert.ToInt16(cbx_idCurso.SelectedValue);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cargarEntidad();
            controladorestudiante.modificar(entidadeestudiante);
            cargarGrid();
            limpiarCampos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            controladorestudiante.eliminar(Convert.ToInt16(txt_idEstudiante.Text));
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
