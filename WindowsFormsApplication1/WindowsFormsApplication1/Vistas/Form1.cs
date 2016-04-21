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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void estudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estudiante est = new Estudiante();
            est.MdiParent = this.MdiParent;
            est.WindowState = FormWindowState.Maximized;
            est.Show();
        }

        private void materiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Materia mat = new Materia();
            mat.MdiParent = this.MdiParent;
            mat.WindowState = FormWindowState.Maximized;
            mat.Show();
        }

        private void profesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profesor profe = new Profesor();
            profe.MdiParent = this.MdiParent;
            profe.WindowState = FormWindowState.Maximized;
            profe.Show();
        }
    }
}
